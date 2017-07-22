using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MODEL
{
    public class class1
    {
        public static string s;
        public static Staff staff;
    }
    public class Staff
    {
        public string ID;
        public string pd;
        public string authority;
        public Staff(string ID,string pd)
        {
            this.ID = ID;
            this.pd = pd;
        }
    }

    public class Member
    {
        public string MemCardID { get; set; }
        public string MemName { get; set; }
        public string MemSex { get; set; }
        public string MemPd { get; set; }
        public string Memtel { get; set; }
        public string IDCard { get; set; }
        public double Memacount { get; set; }
        public string Registtime { get; set; }
        public string operateStaff { get; set; }
    }

    public class RechargeRecord
    {
        public string MemCardID { get; set; }
        public string MemName { get; set; }
        public double RechargeAmount { get; set; }
        public double AmountBefore { get; set; }
        public double AmountAfter { get; set; }
        public string RechargeTime { get; set; }
        public string Operator { get; set; }
    }

    public class QAmain//质检单主表
    {
        public string QAID { get; set; }
        public string Supplier { get; set; }
        public string Operator { get; set; }
        public string Date { get; set; }
    }
    public class QAdetail//质检从表
    {
        public string QAID { get; set; }
        public string GoodID { get; set; }
        public string GoodName { get; set; }
        public string Unit { get; set; }
        public double Amount { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public double Money { get; set; }
        public string Check { get; set; }
    }
    //入库单类
    public class InStockMain
    {
        public string InID { get; set; }
        public string Date { get; set; }
        public string QAID { get; set; }
        public string Operator { get; set; }
    }
    public class InStockdetail
    {
        public string InID { get; set; }
        public string GoodID { get; set; }
        public string GoodName { get; set; }
        public double Amount { get; set; }
        public string Type { get; set; }
        public string Supplier { get; set; }
        public string Inventory { get; set; }
        public double goodinprice { get; set; }
        
    }

    //下面是RFID的Model  
    public class BillHelper
    {
        public static string getNextBillNumber(string billNumber)
        {
            string billNumber1 = "";
            billNumber1 += System.DateTime.Now.Year.ToString();
            if (System.DateTime.Now.Month.ToString().Length == 1)
            {
                billNumber1 += "0";
            }
            billNumber1 += System.DateTime.Now.Month.ToString();
            if (System.DateTime.Now.Day.ToString().Length == 1)
            {
                billNumber1 += "0";
            }
            billNumber1 += System.DateTime.Now.Day.ToString();
            int curNum;
            if (billNumber == "0")
            {
                curNum = 0;
            }
            else if (billNumber.Substring(0, 8) == billNumber1)
                curNum = Convert.ToInt32(billNumber.Substring(8));
            else curNum = 0;
            curNum += 1;
            string tempNum = curNum.ToString();
            for (int i = tempNum.Length; i < 3; i++)
            {
                tempNum = "0" + tempNum;
            }
            billNumber1 = billNumber1 + tempNum;
            return billNumber1;
        }

    }
    public class UserInfo
    {
        public string ID;
        public string name;
        public string number;
        public double balance;
        public string EPCStr;
        public UserInfo(ArrayList userDetail)
        {
            this.ID = (string)userDetail[0];//会员ID
            this.name = (string)userDetail[1];//会员姓名
            this.number = (string)userDetail[2];//会员电话号码
            this.balance = Convert.ToDouble(userDetail[3]);//会员余额
        }
    }
    public class costInfo
    {
        public string memID { get; set; } //会员ID
        public string goodID { get; set; } //商品ID
        public string date { get; set; } // 该商品销售日期
        public double cost { get; set; } //该商品单价
        public string billNumber { get; set; } //该商品小票代号
        public int goodNum { get; set; } //商品销售数量
        public double total { get; set; } //商品销售总额
        public costInfo(string memID, string goodID, string date, string billNumber, int goodNum, double cost, double total)
        {
            this.memID = memID;
            this.goodID = goodID;
            this.date = date;
            this.goodNum = goodNum;
            this.cost = cost;
            this.billNumber = billNumber;
            this.total = total;
        }
    }
    public class goodDetail
    {
        public string ID { get; set; }
        public string name { get; set; }
        public double cost { get; set; }
        public goodDetail(string ID, string name, double cost)
        {
            this.ID = ID;//商品ID
            this.name = name;//商品名称
            this.cost = cost;//商品单价
        }
    }

    public class Inventory
    {
        public string GoodID { get; set; }
        public string GoodName { get; set; }
        public double Amount { get; set; }
    }
    //******************new*****************************
    public class lockerInfo
    {
        public int LockNumber;//箱柜代号
        public bool isLocked;//是否上锁
        public string userID;//使用者ID
    }

    public class AddID
    {
        public static string Getid(int former)
        {
            string temp = former.ToString();
            for (int i = temp.Length; i < 7; i++)
            {
                temp = "0" + temp;
            }
            return temp;
        }

        public static string Change(string s)
        {
            string code, year, month, day, num;

            code = s.Substring(0, 1);
            year = s.Substring(1, 4);
            month = s.Substring(5, 2);
            day = s.Substring(7, 2);
            num = s.Substring(9, 3);
            int n = Convert.ToInt32(num);
            string newNUm = System.Convert.ToString(++n);
            string output = "";
            if (System.DateTime.Now.Year == Convert.ToInt32(year) && DateTime.Now.Month == Convert.ToInt32(month) && DateTime.Now.Day == Convert.ToInt32(day))
            {
                switch (newNUm.Length)
                {
                    case 1:
                        {
                            output = code + year + month + day + "00" + newNUm;
                            break;
                        }
                    case 2:
                        {
                            output = code + year + month + day + "0" + newNUm;
                            break;
                        }
                    case 3:
                        {
                            output = code + year + month + day + newNUm;
                            break;
                        }
                }

            }
            else
            {
                if (DateTime.Now.Month.ToString().Length == 1)
                {
                    month = "0" + DateTime.Now.Month.ToString();
                }
                else month = DateTime.Now.Month.ToString();
                if (DateTime.Now.Day.ToString().Length == 1)
                {
                    day = "0" + DateTime.Now.Day.ToString();
                }
                else day = DateTime.Now.Day.ToString();
                output = code + year + month + day + "001";
            }
            return output;
        }

    }

  
}
