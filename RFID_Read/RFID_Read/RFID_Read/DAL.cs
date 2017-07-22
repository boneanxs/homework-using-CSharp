using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFID_Read
{
    class DAL
    {
        public static goodDetail getDetailByID(string ID)
        {
            //通过商品的RFID扫描得到商品详细信息：商品ID（非RFID），商品名称，商品单价，以goodDetail类型返回
            List<string> temp = new List<string>();
            temp.Add("苹果");
            temp.Add("15.2");
            temp.Add("123213");
            temp.Add("0");
            goodDetail temp2 = new goodDetail(temp[2], temp[0],Convert.ToDouble(temp[1]));
            return temp2;
        }
        public static UserInfo getMemDetailByID(string ID)
        {
            //通过会员ID得到会员的详细信息，以UserInfo类型返回
            ArrayList temp = new ArrayList();
            if(ID == "A0000001")
            {
                temp.Add("123");
                temp.Add("anhui");
                temp.Add("anh131@126.com");
            }
            else
            {
                temp.Add("123");
                temp.Add("wangke");
                temp.Add("anh131@126.com");
            }
            temp.Add(300);
            UserInfo temp2 = new UserInfo(temp);
            return temp2;
        }
        public static bool updateMemCostDetail(costInfo cost)
        {
            return true;
        }
        public static bool updateMemBalance(string memID, double bal)
        {
            //更新会员卡内余额，通过memID进行，bal为新会员卡余额，成功返回true，失败返回false
            return true;
        }
        public static string getBillNumber()
        {
            return "01234";
        }
        public static void refreshRFIDInfo(string RFIDID,string goodID, int isSold)
        {
            //更新RFID表
        }
        //**************************new***********************************
        public static string getARFIDInfo(string memID)
        {
            //通过会员ID获取到有源RFID的编号
            return "12345";
        }
    }
}
