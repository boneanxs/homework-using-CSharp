using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hit.RFID;
using ReaderB;
using System.IO.Ports;
namespace Hit.RFID
{
    class UHFReaderHelper
    {
        int port = -1;
        byte ComAdr = 0xff;
        byte Baud = 5;
        int FrmHandle = -1;
        private int WriteTryMaxCount = 20;
        public int isConnected = -1;
        //reading beginning adress and read length
        string userStart = "0";
        string userEnd = "4";
        //string EPCStart = "0";
        //string EPCLen = "8";
        string accessPassword = "00000000";
        //***********************************
        public void ActiveAllCom()
        {
            try
            {
                string[] portList = SerialPort.GetPortNames();
                foreach(string portName in portList)
                {
                    SerialPort sp = new SerialPort(portName, 57600, Parity.None, 8, StopBits.One);
                    if (!sp.IsOpen)
                    {
                        sp.Open();
                        sp.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public bool Connect()
        {
            if(port > 0)
            {
                StaticClassReaderB.CloseSpecComPort(FrmHandle);
            }
            ActiveAllCom();
            int iRet = StaticClassReaderB.AutoOpenComPort(ref port, ref ComAdr, Baud, ref FrmHandle);
            if(iRet == 0)
            {
                isConnected = 1;
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string ByteArrayToHexString(byte[] data)
        {
            StringBuilder sb = new StringBuilder(data.Length * 3);
            foreach (byte b in data)
                sb.Append(Convert.ToString(b, 16).PadLeft(2, '0'));
            return sb.ToString().ToUpper();

        }
        public string Inventory_G2(byte TIDFlag, byte AdrTID, byte LenTID)
        {
            if (port == 0)
            {
                return "";
            }
            byte[] EPC = new byte[5000];

            // 返回的EPC的实际字节数
            int Totallen = 0;
            // 查询到的标签数量
            int CardNum = 0;
            int iCount = 0;
            string hexEPC = "";

            while (iCount < 100)
            {
                int fCmdRet = StaticClassReaderB.Inventory_G2(ref ComAdr, AdrTID, LenTID, TIDFlag, EPC, ref Totallen, ref CardNum, FrmHandle);
                if ((fCmdRet == 1) | (fCmdRet == 2) | (fCmdRet == 3) | (fCmdRet == 4) | (fCmdRet == 0xFB))//代表已查找结束
                {
                    byte[] daw = new byte[Totallen];
                    Array.Copy(EPC, daw, Totallen);
                    string temps = ByteArrayToHexString(daw);
                    //
                    if (CardNum > 0)
                    {
                        int EPClen = daw[0];
                        hexEPC = temps.Substring(2, EPClen * 2);

                        break;
                    }

                }
                iCount++;
            }
            return hexEPC;
        }
        private byte[] HexStringToByteArray(string s)
        {
            s = s.Replace(" ", "");
            byte[] buffer = new byte[s.Length / 2];
            for (int i = 0; i < s.Length; i += 2)
                buffer[i / 2] = Convert.ToByte(s.Substring(i, 2), 16);
            return buffer;
        }
        public static string ByteArrayToString(byte[] data)
        {
            UnicodeEncoding encoding = new UnicodeEncoding();
            return Encoding.Default.GetString(data);
        }
        private string ReadSpecificBlock(byte mem,string EPCID,string start,string readNum)
        {
            string readedData = "";
            if (port == 0)
            {
                return "";
            }
            byte maskFlag = 0;
            byte maskadr = 0;
            byte maskLen = 0;
            byte[] EPC = new byte[EPCID.Length / 2];
            EPC = HexStringToByteArray(EPCID);
            byte WordPtr = Convert.ToByte(start.Trim(), 10);
            byte Num = Convert.ToByte(readNum);
            byte[] fPassWord = HexStringToByteArray(accessPassword);
            byte[] Data = new byte[1320];
            byte EPClength = (Byte)EPC.Length;
            Int32 ferrorcode = -1;
            //
            Int32 fCmdRet = StaticClassReaderB.ReadCard_G2(ref ComAdr, EPC, mem, WordPtr, Num, fPassWord, maskadr, maskLen, maskFlag, Data, EPClength, ref ferrorcode, FrmHandle);

            if (fCmdRet == 0)
            {
                byte[] daw = new byte[Num * 2];
                Array.Copy(Data, daw, Num * 2);
                readedData = ByteArrayToString(daw);
            }
            return readedData;
        }
        public string ReadEPC()
        {
            string EPCID = Inventory_G2((byte)0, (byte)0, (byte)0);
            return EPCID;
        } 
        public string ReadUser()
        {
            string EPCID = Inventory_G2((byte)0, (byte)0, (byte)0);
            byte mem = 0x03;
            return ReadSpecificBlock(mem, EPCID, userStart, userEnd);
        }
        public bool WriteEPCData(string inputData)
        {
            for(int i = inputData.Length; i <inputData.Length + 4 - (inputData.Length % 4);i++)
            {
                inputData += "F";
            }
            byte[] writeData = HexStringToByteArray(inputData);
            byte writeLen = (byte)writeData.Length;
            if (writeLen % 2 != 0)
            {
                writeLen += 1;
            }
            byte[] fPassword = HexStringToByteArray(accessPassword);
            Int32 ferrorcode = -1;
            int fCmdRet = 0;
            for (int tryCnt = 0; tryCnt < WriteTryMaxCount; tryCnt++)
            {
                fCmdRet = StaticClassReaderB.WriteEPC_G2(ref ComAdr,fPassword,writeData,writeLen,ref ferrorcode,FrmHandle);

                if (fCmdRet == 0)
                {
                    return true;
                }
            }
            return false;
        }
        private byte[] StringToByteArray(String str)
        {
            //UnicodeEncoding converter = new UnicodeEncoding();
            //return converter.GetBytes(str);
            return Encoding.Default.GetBytes(str);
        }
        public string readTIDData()
        {
            string TIDID = Inventory_G2((byte)1, (byte)0, (byte)8);
            return TIDID;
        }
        public bool WriteUserData(string inputData)
        {
            string EPCID = Inventory_G2((byte)0, (byte)0, (byte)0);
            if (inputData.Length != 8)
            {
                for (int i = inputData.Length; i < 8; i++)
                {
                    inputData += "F";
                }
            }
            byte[] writeData = StringToByteArray(inputData);
            byte wordPtr = Convert.ToByte(userStart, 10);
            byte writeLen = (byte)writeData.Length;
            byte maskFlag = 0;
            byte maskadr = 0;
            byte maskLen = 0;
            byte[] EPC = new byte[EPCID.Length / 2];
            EPC = HexStringToByteArray(EPCID);
            byte mem = 0x03;
            byte[] fPassWord = HexStringToByteArray(accessPassword);
            Int32 WrittenDataNum = 0;
            byte EPClength = (Byte)EPC.Length;
            Int32 ferrorcode = -1;
            int fCmdRet = 0;
            for (int tryCnt = 0; tryCnt < WriteTryMaxCount; tryCnt++)
            {
                fCmdRet = StaticClassReaderB.WriteCard_G2(ref ComAdr, EPC, mem, wordPtr, writeLen, writeData, fPassWord, maskadr, maskLen, maskFlag, WrittenDataNum, EPClength, ref ferrorcode, FrmHandle);

                if (fCmdRet == 0)
                {
                    break;
                }
            }

            //
            if (fCmdRet == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DisConnect()
        {
            int iRet = StaticClassReaderB.CloseSpecComPort(port);
            if(iRet == 0)
            {
                port = -1;
                FrmHandle = -1;
                isConnected = -1;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
