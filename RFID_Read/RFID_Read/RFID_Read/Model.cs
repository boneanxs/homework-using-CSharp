using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFID_Read
{
    class Model
    {
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
            this.number = (string)userDetail[2];//会员邮箱
            this.balance = Convert.ToDouble(userDetail[3]);//会员余额
        }
    }
    public class costInfo
    {
        string memID { get; set; } //会员ID
        string goodID { get; set; } //商品ID
        string date { get; set; } // 该商品销售日期
        double cost { get; set; } //该商品单价
        string billNumer { get; set; } //该商品销售额
        int goodNum { get; set; } //商品销售数量
        double total { get; set; } //商品销售总额
        public costInfo(string memID, string goodID, string date, string billNumber,int goodNum, double cost, double total)
        {
            this.memID = memID;
            this.goodID = goodID;
            this.date = date;
            this.goodNum = goodNum;
            this.cost = cost;
            this.billNumer = billNumer;
            this.total = total;
        }
    }
    public class goodDetail
    {
        public string ID;
        public string name;
        public double cost;
        public goodDetail(string ID, string name, double cost)
        {
            this.ID = ID;//商品ID
            this.name = name;//商品名称
            this.cost = cost;//商品单价
        }
    }
}
