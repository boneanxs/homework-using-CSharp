using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using ModuleTech;
using ModuleLibrary;
using ModuleTech.Gen2;
using DAL;
using MODEL;
namespace Restore_Cmd_Application
{
    class Program
    {
        private static readonly string conAdr = "192.168.0.103";
        private static readonly int antNum = 4;
        private static readonly double dp = 0.9;//antena power percentage
        private static readonly uint userStart = 0;// the start address of read user section
        private static readonly uint userEnd = 2;//read blocks number
        private static readonly int readDur = 500;
        private Reader reader = null;
        private Thread readThr = null;
        private Mutex tagMux = new Mutex();
        private bool isReceive = true;
        private string[] tagInfo = new string[antNum];//readTagsInformation
        private int tagInfCount = 0;
        private void rdrParmSet() {
            try
            {
                int[] ants = new int[antNum];
                AntPower[] apwr = new AntPower[antNum];
                for (int i = 0;i < antNum; i++)
                {
                    ants[i] = i + 1;
                    apwr[0].AntId = (byte)ants[i];
                    apwr[0].WritePower = (ushort)((int)reader.ParamGet("RfPowerMax") * dp);
                    apwr[0].ReadPower = (ushort)((int)reader.ParamGet("RfPowerMax") * dp);
                }
                reader.ParamSet("ReadPlan", new SimpleReadPlan(TagProtocol.GEN2, ants));
                reader.ParamSet("CheckAntConnection", false);
                reader.ParamSet("Gen2Session", (Session)0);
                reader.ParamSet("AntPowerConf", apwr);
            }
            catch(Exception ee)
            {
                throw new Exception("reader parm set error: ", ee);
            }
        }
        private byte[] strCovertToDeciByte(string temp)
        {
            byte[] filterbytes = Encoding.ASCII.GetBytes(temp);

            return filterbytes;
        }
        private void receiveData()
        {
            while (true)
            {
                tagMux.WaitOne();
                if (isReceive)
                {
                    //Console.WriteLine("读取啦!");
                    try
                    {
                        TagReadData[] tagDatas = reader.Read(readDur);
                        tagInfCount = 0;
                        foreach (TagReadData tag in tagDatas)
                        {
                            if (tag.EPCString.IndexOf("A") == 0 && tag.EPCString.Length == 8)
                            {

                                lockerInfo locker = DAL.InStock.getLockInfo(tag.Antenna);
                                if (locker.isLocked)
                                {
                                    if (locker.userID == tag.EPCString)
                                    {
                                        locker.userID = "";
                                        locker.isLocked = false;
                                        DAL.InStock.updateLockInfo(locker);
                                        tagInfo[tagInfCount] = "会员卡号为" + tag.EPCString + ", " + tag.Antenna + "号箱柜解锁成功!\n";
                                    }
                                    else
                                    {
                                        tagInfo[tagInfCount] = "对不起，" + tag.Antenna + "号箱柜不是您的货柜！\n";
                                    }
                                    tagInfCount++;
                                }
                                else
                                {
                                    locker.isLocked = true;
                                    locker.userID = tag.EPCString;
                                    DAL.InStock.updateLockInfo(locker);
                                    tagInfo[tagInfCount] = "会员卡号为" + tag.EPCString + ", " + tag.Antenna + "号箱柜上锁成功!\n";
                                    tagInfCount++;
                                }
                                isReceive = false;
                            }
                        }
                    }
                    catch
                    {
                        
                    }
                    tagMux.ReleaseMutex();
                    Thread.Sleep(500);
                }
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            try
            {
                p.reader = Reader.Create(conAdr,ModuleTech.Region.NA,(ReaderType)1);
            }catch(Exception ee)
            {
                Console.WriteLine("系统创建连接错误,错误代码为: " + ee.ToString());
                Console.Read();
                return;
            }
            try
            {
                p.rdrParmSet();
            }catch(Exception ee)
            {
                Console.WriteLine(ee.ToString());
                Console.Read();
                return;
            }
            Console.WriteLine("开始读取信息：");
            p.readThr = new System.Threading.Thread(p.receiveData);
            p.readThr.Start();
            while (true)
            {
                p.tagMux.WaitOne();
                if (!p.isReceive)
                {
                    for (int i = 0; i < p.tagInfCount; i++)
                         Console.Write(p.tagInfo[i]);
                    p.isReceive = true;
                }
                p.tagMux.ReleaseMutex();
                Thread.Sleep(1000);
            }
        }
    }
}
