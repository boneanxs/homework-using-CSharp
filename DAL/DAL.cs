using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;
using System.Collections;
using System.Data;
namespace DAL
{
    public class class1
    {
        public static int StaffLogin(Staff s)
        {
            String sql = "select distinct * from staff_table where Username ='" + s.ID + "'";
            DataSet a = Datameans.getDataSet(sql);
            if (a.Tables[0].Rows.Count == 0)
            {
                return -1;
            }
            else
            {
                string pwd = a.Tables[0].Rows[0][2].ToString();
                if (pwd == s.pd)
                {
                    return 1;
                }
                else return 0;
            }
            //在员工、管理员表中通过ID查找密码
            //if不存在
            //return -1;
            //if存在但数据库无
            //return 0;
            //if存在且数据库中有
        }

        public static string StaffAuthority(string staffID)
        {
            String sql = "select distinct Postname from staffpost_table where Username ='" + staffID + "'"; //通过ID返回员工类型
            DataSet a = Datameans.getDataSet(sql);
            string post = a.Tables[0].Rows[0][0].ToString();
            System.Console.WriteLine("y");
            //string post = "信息员";
            return post;
        }

        public static void InputMember(Member m)
        {   // id card 改为 phone number 
            String sql = "insert into member_table(MemberID,Name,Sex,Password,email,identitycard,balance,enrolldate,operateStaff) values('"
                  + m.MemCardID
                  + "','"
                  + m.MemName
                  + "','"
                  + m.MemSex
                  + "','"
                  + m.MemPd
                  + "','"
                  + m.Memtel
                  + "','"
                  + m.IDCard
                  + "','"
                  + m.Memacount
                  + "','"
                  + m.Registtime
                  + "','"
                  + m.operateStaff + "')";
            Datameans.getsqlcom(sql);
            //插入m的八项内容
            //m.MemCardID;
            //m.MemName
            //  m.Memtel
            //m.MemSex
            //m.Memacount
            //m.IDCard
            //m.Registtime
            //m.operateStaff
        }

        public static DataSet QueryMembyName(String s)
        {
            DataSet a = new DataSet();
            //"//依据姓名（即String s）查找顾客的会员卡号、姓名、电话号、性别、账户余额、身份证号、注册时间和注册人员");
            String sql = "select distinct * from member_table where Name ='" + s + "'";
            a = Datameans.getDataSet(sql);
            return a;
        }
        public static DataSet QueryMembyMemId(String s)
        {
            DataSet a = new DataSet();
            String sql = "select distinct * from member_table where MemberID ='" + s + "'";
            //依据会员卡号查找信息
            a = Datameans.getDataSet(sql);
            return a;
        }
        public static DataSet QueryMembyDate(String s)
        {
            DataSet a = new DataSet();
            String sql = "select distinct * from member_table where enrolldate ='" + s + "'";
            //依据日期查找会员信息  
            a = Datameans.getDataSet(sql);
            return a;
        }
        public static DataSet QueryMembyTel(String s)
        {
            DataSet a = new DataSet();
            String sql = "select distinct * from member_table where email ='" + s + "'";
            //依据电话号查找会员信息
            a = Datameans.getDataSet(sql);
            return a;
        }
        public static DataSet QueryMembyId(String s)
        {
            DataSet a = new DataSet();
            String sql = "select distinct * from member_table where identitycard ='" + s + "'";
            //依据身份证号查找会员信息
            a = Datameans.getDataSet(sql);
            return a;
        }
        public static void DeleteMem(String MemId)
        {
            String sql = "update member_table set is_use='停用' where MemberID='" + MemId + "'";
            Datameans.getsqlcom(sql);
            //依据MemId在数据库中删除会员信息
        }
        public static void UpdateMem(MODEL.Member m)
        {
            String sql = "update member_table set Name = '" + m.MemName + "',Sex='" + m.MemSex + "', Password='"
                  + m.MemPd + "',email='"
                  + m.Memtel + "',Identitycard='"
                  + m.IDCard + "',balance='"
                  + m.Memacount + "', enrolldate='"
                  + m.Registtime + "', operateStaff='"
                  + m.operateStaff + "' where MemberID='"
                  + m.MemCardID + "'";
            //依据m.MemCardID修改所有内容
            Datameans.getsqlcom(sql);
        }
        //充值记录系列
        public static DataSet QueryRechargebyID(string MemID)
        {
            DataSet a = new DataSet();
            String sql = "select distinct payrecord_table.MemberID, member_table.Name, Payrecord_table.amount, Payrecord_table.Paydate, Payrecord_table.operateStaff from payrecord_table ,member_table where payrecord_table.MemberID ='" + MemID + "' and payrecord_table.MemberID = member_table.MemberID";
            //在充值记录表中通过会员卡号查找会员卡号、姓名、充值金额、充值前后金额、充值时间、操作员信息
            a = Datameans.getDataSet(sql);
            return a;
        }
        public static DataSet QueryRechargebydate(string Date)
        {
            DataSet a = new DataSet();
            String sql = "select distinct Payrecord_table.MemberID, member_table.Name, Payrecord_table.amount, Payrecord_table.Paydate, Payrecord_table.operateStaff from payrecord_table ,member_table where Payrecord_table.Paydate ='" + Date + "' and Payrecord_table.MemberID = member_table.MemberID"; ;
            //在充值记录表中通过日期查找会员卡号、姓名、充值金额、充值前后金额、充值时间、操作员信息
            a = Datameans.getDataSet(sql);
            return a;
        }

        //会员消费记录系列
        public static DataSet QueryCustomRecordbyId(string MemID)
        {
            DataSet a = new DataSet();
            String sql = "select distinct selldetail_table.MemberID, member_table.Name, selldetail_table.Goodsname, selldetail_table.Goodsnum, selldetail_table.Sellprice, selldetail_table.Totalprice, selldetail_table.Selltime from selldetail_table, member_table where selldetail_table.GoodsName ='" + MemID + "'and selldetail_table.MemberID = member_table.MemberID";
            //通过会员卡号查找会员卡号、姓名、商品类型、商品数量、单价、总金额、购买日期
            a = Datameans.getDataSet(sql);
            return a;
        }
        public static DataSet QueryCustomRecordbyDate(string Date)
        {
            DataSet a = new DataSet();
            Date = Date + "%";
            String sql = "select distinct selldetail_table.MemberID, member_table.Name, selldetail_table.Goodsname, selldetail_table.Goodsnum, selldetail_table.Sellprice, selldetail_table.Totalprice, selldetail_table.Selltime from selldetail_table, member_table where selldetail_table.Selltime like'" + Date + "'and selldetail_table.MemberID = member_table.MemberID";
            //通过购买日期查找会员卡号、姓名、商品类型、商品数量、单价、总金额、购买日期
            a = Datameans.getDataSet(sql);
            return a;
        }

        ///质检单系列
        public static void InputQAmain(MODEL.QAmain qamain)
        {
            String sql = "insert into qualitymain_table(qualityID,Suppliername,StaffID,checkdate) values('"
                  + qamain.QAID
                  + "','"
                  + qamain.Supplier
                  + "','"
                  + qamain.Operator
                  + "','"
                  + qamain.Date + "')";//依据qamain.QAID即质检单号插入质检单号、
                                       //qamain.Supplier供应商
                                       //qamain.Operator操作员号
                                       // qamain.Date日期
            Datameans.getsqlcom(sql);
        }
        public static void InputQAdetail(MODEL.QAdetail qadetail)
        {
            String sql = "insert into qualitydetail_table(qualityID,GoodsID,Goodsname,unit,GoodsNum,is_check) values('"
                 + qadetail.QAID
                 + "','"
                 + qadetail.GoodID
                 + "','"
                 + qadetail.GoodName
                 + "','"
                 + qadetail.Unit
                 + "','"
                 + qadetail.Amount
                 + "','"
                 + qadetail.Check + "')";//依据QAID插入商品号、名、单位、数量、类型、是否合格
            Datameans.getsqlcom(sql);
        }
        //质检单查询系列
        public static DataSet QuerybyQAID(string QAID)
        {
            DataSet a = new DataSet();
            String sql = "select distinct qualitymain_table.qualityID, qualitydetail_table.GoodsID, qualitydetail_table.Goodsname, qualitydetail_table.GoodsNum, qualitymain_table.Suppliername, qualitymain_table.checkdate, qualitymain_table.StaffID from qualitydetail_table ,qualitymain_table where qualitymain_table.qualityID ='" + QAID + "' and qualitymain_table.qualityID= qualitydetail_table.qualityID";
            //依据质检单ID从主、从表查找质检单号、商品号、商品名称、数量、供应商、时间、质检员
            a = Datameans.getDataSet(sql);
            return a;
        }
        public static DataSet QuerybyGoodID(string GoodID)
        {
            DataSet a = new DataSet();
            String sql = "select distinct qualitymain_table.qualityID, qualitydetail_table.GoodsID, qualitydetail_table.Goodsname, qualitydetail_table.GoodsNum, qualitymain_table.Suppliername, qualitymain_table.checkdate, qualitymain_table.StaffID from qualitydetail_table ,qualitymain_table where qualitydetail_table.GoodsID ='" + GoodID + "' and qualitymain_table.qualityID= qualitydetail_table.qualityID";
            //依据货品ID从主、从表查找质检单号、商品号、商品名称、数量、供应商、时间、质检员
            a = Datameans.getDataSet(sql);
            return a;
        }
        public static DataSet QuerybyGoodName(string goodName)
        {
            DataSet a = new DataSet();
            String sql = "select distinct qualitymain_table.qualityID, qualitydetail_table.GoodsID, qualitydetail_table.Goodsname, qualitydetail_table.GoodsNum, qualitymain_table.Suppliername, qualitymain_table.checkdate, qualitymain_table.StaffID from qualitydetail_table ,qualitymain_table where qualitydetail_table.Goodsname ='" + goodName + "' and qualitymain_table.qualityID= qualitydetail_table.qualityID";
            //依据商品名称从主、从表查找质检单号、商品号、商品名称、数量、供应商、时间、质检员
            a = Datameans.getDataSet(sql);
            return a;
        }
        public static DataSet QuerybySupplier(string supplier)
        {
            DataSet a = new DataSet();
            String sql = "select distinct qualitymain_table.qualityID, qualitydetail_table.GoodsID, qualitydetail_table.Goodsname, qualitydetail_table.GoodsNum, qualitymain_table.Suppliername, qualitymain_table.checkdate, qualitymain_table.StaffID from qualitydetail_table ,qualitymain_table where qualitymain_table.Suppliername ='" + supplier + "' and qualitymain_table.qualityID = qualitydetail_table.qualityID";
            //依据供应商从主、从表查找质检单号、商品号、商品名称、数量、供应商、时间、质检员
            a = Datameans.getDataSet(sql);
            return a;
        }
        public static DataSet QuerybyDate(string date)
        {
            String sql = "select distinct qualitymain_table.qualityID, qualitydetail_table.GoodsID, qualitydetail_table.Goodsname, qualitydetail_table.GoodsNum, qualitymain_table.Suppliername, qualitymain_table.checkdate, qualitymain_table.StaffID from qualitydetail_table ,qualitymain_table where qualitymain_table.checkdate='" + date + "' and qualitymain_table.qualityID = qualitydetail_table.qualityID";
            DataSet a = new DataSet();
            //依据日期从主、从表查找质检单号、商品号、商品名称、数量、供应商、时间、质检员
            a = Datameans.getDataSet(sql);
            return a;
        }
        public static DataSet QuerybyOperator(string qaoperator)
        {
            String sql = "select distinct qualitymain_table.qualityID, qualitydetail_table.GoodsID, qualitydetail_table.Goodsname, qualitydetail_table.GoodsNum, qualitymain_table.Suppliername, qualitymain_table.checkdate, qualitymain_table.StaffID from qualitydetail_table ,qualitymain_table where qualitymain_table.StaffID ='" + qaoperator + "' and qualitymain_table.qualityID= qualitydetail_table.qualityID";
            DataSet a = new DataSet();
            //依据质检员ID从主、从表查找质检单号、商品号、商品名称、数量、供应商、时间、质检员
            a = Datameans.getDataSet(sql);
            return a;
        }
    }
    public class InStock
    {
        public static void InPutMain(MODEL.InStockMain instockmain)
        {
            String sql = "insert into stockmain_table(GoodinID,qualityID,Indate,Handlepeople) values('"
                    + instockmain.InID
                    + "','"
                    + instockmain.QAID
                    + "','"
                    + instockmain.Date
                    + "','"
                    + instockmain.Operator + "')";
            Datameans.getsqlcom(sql);
            //插入instockmain.InID入库单号
            //instockmain.QAID质检单号
            //instockmain.Date入库日期
            //instockmain.Operator入库员
        }
        public static void InputDetail(MODEL.InStockdetail instockdetail)
        {
            String sql = "insert into stockdetail_table(GoodinID,GoodsID,Goodsname,Suppliername,Storename,GoodsinNum,Goodsinprice) values('"
                    + instockdetail.InID
                    + "','"
                    + instockdetail.GoodID
                    + "','"
                    + instockdetail.GoodName
                    + "','"
                    + instockdetail.Supplier
                    + "','"
                    + instockdetail.Inventory
                    + "','"
                    + instockdetail.Amount
                    + "','"
                    + instockdetail.goodinprice + "')";
            Datameans.getsqlcom(sql);



            //插入入库单从表
        }
        public static DataSet QuerybyID(string ID)
        {
            DataSet a = new DataSet();
            String sql = "select distinct stockmain_table.GoodinID, stockdetail_table.GoodsID, stockdetail_table.Goodsname, stockdetail_table.GoodsinNum, stockdetail_table.Suppliername, stockmain_table.Indate, stockmain_table.Handlepeople from stockdetail_table,stockmain_table where stockdetail_table.GoodinID ='" + ID + "'and stockdetail_table.GoodinID = stockmain_table.GoodinID";
            //通过入库单号查询入库单号、商品号、商品名称、商品数量、供应商、日期、入库员
            a = Datameans.getDataSet(sql);
            return a;
        }
        public static DataSet QuerybyGoodID(string ID)
        {
            DataSet a = new DataSet();
            String sql = "select distinct stockmain_table.GoodinID, stockdetail_table.GoodsID, stockdetail_table.Goodsname, stockdetail_table.GoodsinNum, stockdetail_table.Suppliername, stockmain_table.Indate, stockmain_table.Handlepeople from stockdetail_table,stockmain_table where stockdetail_table.GoodsID ='" + ID + "'and stockdetail_table.GoodinID = stockmain_table.GoodinID";
            //通过商品号查询入库单号、商品号、商品名称、商品数量、供应商、日期、入库员
            a = Datameans.getDataSet(sql);
            return a;
        }
        public static DataSet QuerybyGoodName(string ID)
        {
            DataSet a = new DataSet();
            String sql = "select distinct stockmain_table.GoodinID, stockdetail_table.GoodsID, stockdetail_table.Goodsname, stockdetail_table.GoodsinNum, stockdetail_table.Suppliername, stockmain_table.Indate, stockmain_table.Handlepeople from stockdetail_table,stockmain_table where stockdetail_table.Goodsname ='" + ID + "'and stockdetail_table.GoodinID = stockmain_table.GoodinID";
            //通过商品名查询入库单号、商品号、商品名称、商品数量、供应商、日期、入库员
            a = Datameans.getDataSet(sql);
            return a;
        }
        public static DataSet QuerybySupplier(string ID)
        {
            DataSet a = new DataSet();
            String sql = "select distinct stockmain_table.GoodinID, stockdetail_table.GoodsID, stockdetail_table.Goodsname, stockdetail_table.GoodsinNum, stockdetail_table.Suppliername, stockmain_table.Indate, stockmain_table.Handlepeople from stockdetail_table,stockmain_table where stockdetail_table.Suppliername ='" + ID + "'and stockdetail_table.GoodinID = stockmain_table.GoodinID";
            //通过供应商查询入库单号、商品号、商品名称、商品数量、供应商、日期、入库员
            a = Datameans.getDataSet(sql);
            return a;
        }
        public static DataSet QuerybyDate(string ID)
        {
            DataSet a = new DataSet();
            String sql = "select distinct stockmain_table.GoodinID, stockdetail_table.GoodsID, stockdetail_table.Goodsname, stockdetail_table.GoodsinNum, stockdetail_table.Suppliername, stockmain_table.Indate, stockmain_table.Handlepeople from stockdetail_table,stockmain_table where stockmain_table.Indate ='" + ID + "'and stockdetail_table.GoodinID = stockmain_table.GoodinID";
            //通过日期查询入库单号、商品号、商品名称、商品数量、供应商、日期、入库员
            a = Datameans.getDataSet(sql);
            return a;
        }
        public static DataSet QuerybyOperator(string ID)
        {
            DataSet a = new DataSet();
            String sql = "select distinct stockmain_table.GoodinID, stockdetail_table.GoodsID, stockdetail_table.Goodsname, stockdetail_table.GoodsinNum, stockdetail_table.Suppliername, stockmain_table.Indate, stockmain_table.Handlepeople from stockdetail_table,stockmain_table where stockmain_table.Handlepeople ='" + ID + "'and stockdetail_table.GoodinID = stockmain_table.GoodinID";
            //通过入库员查询入库单号、商品号、商品名称、商品数量、供应商、日期、入库员
            a = Datameans.getDataSet(sql);
            return a;
        }

        public static void InPutGoodsRFID(string goodID, string RFID)
        {
            String sql = "insert into GoodsRFID(RFID_ID,Good_ID,IS_SOLD) values('"
                  + RFID
                  + "','"
                  + goodID + "','" + "0')";
            Datameans.getsqlcom(sql);
            //插入goodsrfid表
        }


        // 下面是RFID 部分用到的DAL  
        public static goodDetail getDetailByID(string ID)
        {
            DataSet a = new DataSet();
            String sql = "select distinct GoodsRFID.Good_ID, stockdetail_table.Goodsname, stockdetail_table.Goodsinprice from GoodsRFID,stockdetail_table where GoodsRFID.RFID_ID ='" + ID + "' and stockdetail_table.GoodsID = GoodsRFID.Good_ID";
            //通过商品的RFID扫描得到商品详细信息：商品ID（非RFID），商品名称，商品单价，以goodDetail类型返回                       
            a = Datameans.getDataSet(sql);
            if (a.Tables[0].Rows.Count != 0) {
                string name = a.Tables[0].Rows[0][1].ToString();
                string GoodID = a.Tables[0].Rows[0][0].ToString();
                string price = a.Tables[0].Rows[0][2].ToString();
                List<string> temp = new List<string>();
                temp.Add(name);
                temp.Add(price);
                temp.Add(GoodID);
                goodDetail temp2 = new goodDetail(temp[2], temp[0], Convert.ToDouble(temp[1]));
                return temp2;
            }
            return null;
        }
        public static UserInfo getMemDetailByID(string ID)
        {
            DataSet a = new DataSet();
            String sql = "select distinct MemberID, Name, email,balance from member_table where member_table.MemberID='" + ID + "'";
            //通过会员ID得到会员的详细信息，以UserInfo类型返回 
            a = Datameans.getDataSet(sql);
            String MemID = a.Tables[0].Rows[0][0].ToString();
            String name = a.Tables[0].Rows[0][1].ToString();
            String phonenum = a.Tables[0].Rows[0][2].ToString();
            String balance = a.Tables[0].Rows[0][3].ToString();
            ArrayList temp = new ArrayList();
            temp.Add(MemID);
            temp.Add(name);
            temp.Add(phonenum);
            temp.Add(balance);
            UserInfo temp2 = new UserInfo(temp);
            return temp2;
        }
        public static bool updateMemCostDetail(costInfo cost)  // 商品销售，添加销售信息 ， 商品销售表
        {
            DataSet a = new DataSet();
            String sql = "select distinct Goodsname,Suppliername from stockdetail_table where GoodsID = '" + cost.goodID + "'";
            a = Datameans.getDataSet(sql);
            String Goodname = a.Tables[0].Rows[0][0].ToString();
            String suppliername = a.Tables[0].Rows[0][1].ToString();
            String sql1 = "insert into selldetail_table(SellId,GoodsName,MemberID,Goodsnum,Sellprice,Totalprice,Selltime) values('"
                      + cost.billNumber
                      + "','"
                      + Goodname
                      + "','"
                      + cost.memID
                      + "','"
                      + cost.goodNum
                      + "','"
                      + cost.cost
                      + "','"
                      + cost.total
                      + "','"
                      + cost.date + "')";
            Datameans.getsqlcom(sql1);
            //更新销售汇总表
            string sql2 = "select distinct GoodsID from selltotal_table where GoodsID='"
               + cost.goodID + "' and Date = '" + cost.date.Split(' ')[0] + "'";
            DataSet b = Datameans.getDataSet(sql2);
            if (b.Tables[0].Rows.Count == 0)
            {
                string sql3 = "insert into selltotal_table(GoodsID,Goodname,suppliername,amount,Date) values('"
                       + cost.goodID
                       + "','"
                       + Goodname
                       + "','"
                       + suppliername
                       + "','"
                       + cost.goodNum
                       + "','"
                       + cost.date.Split(' ')[0] + "')";
                Datameans.getsqlcom(sql3);
            }
            //如果表中有ID，根据入库单商品ID在库存表里增加相应数量Amount
            else
            {
                string sql4 = "update selltotal_table set amount = amount + '" + cost.goodNum + "' where GoodsID='"
              + cost.goodID + "'";
                Datameans.getsqlcom(sql4);
            }

            return true;
        }
        public static int isSold(string RFIDID)
        {
            DataSet a = new DataSet();
            string sql = "select distinct IS_SOLD from GoodsRFID where RFID_ID = '" + RFIDID + "'";
            a = Datameans.getDataSet(sql);
            int issold = System.Convert.ToInt32(a.Tables[0].Rows[0][0].ToString());
            return issold;
        }
        public static void refreshRFIDInfo(string RFIDID, string goodID, int isSold) // 更新RFID表
        {
            string sql = "update GoodsRFID set IS_SOLD = 1 where RFID_ID ='" + RFIDID + "'";
            Datameans.getsqlcom(sql);
            string sql1 = "update stockgoods set GoodNum = GoodNum -1";
            Datameans.getsqlcom(sql1);
            //更新RFID表
        }
        public static bool updateMemBalance(string memID, double bal)
        {
            String sql = "update member_table set balance = '" + bal + "' where MemberID='" + memID + "'";
            Datameans.getsqlcom(sql);
            return true;
            //更新会员卡内余额，通过memID进行，bal为新会员卡余额，成功返回true，失败返回false
        }
        public static string getSoldBillNumber()             //获取小票代号
        {
            DataSet a = new DataSet();
            String sql = "select distinct SellId from selldetail_table ";
            a = Datameans.getDataSet(sql);
            string sellID = "0";
            if (a.Tables[0].Rows.Count != 0)
                sellID = a.Tables[0].Rows[a.Tables[0].Rows.Count - 1][0].ToString();
            return sellID;
        }
        public static string getARFIDInfo(string memID)
        {
            DataSet a = new DataSet();
            String sql = "select distinct RFIDID from MemberRFID_table where MemberID = '" + memID + "'";
            a = Datameans.getDataSet(sql);
            if (a.Tables[0].Rows.Count > 0)
            {
                string RFIDID = a.Tables[0].Rows[0][0].ToString();
                return RFIDID;
            }
            return "";
            //通过会员ID获取到有源RFID的编号
        }
        public static lockerInfo getLockInfo(int LockNumber)
        {
            DataSet a = new DataSet();
            string sql = "select distinct * from LockBox_table where LockNumber = '" + LockNumber + "'";
            a = Datameans.getDataSet(sql);
            int Locknumber = System.Convert.ToInt32(a.Tables[0].Rows[0][0].ToString());
            string memberID = a.Tables[0].Rows[0][1].ToString();
            int islock = System.Convert.ToInt32(a.Tables[0].Rows[0][2].ToString());
            //查看相应箱柜号使用者，返回memID
            if (islock == 0)
            {
                lockerInfo temp = new lockerInfo();
                temp.isLocked = false;
                temp.LockNumber = Locknumber;
                temp.userID = memberID;
                return temp;

            }
            else
            {
                lockerInfo temp = new lockerInfo();
                temp.isLocked = true;
                temp.LockNumber = Locknumber;
                temp.userID = memberID;
                return temp;

            }
        }
        public static bool updateLockInfo(lockerInfo locker)
        {
            string sql = "update LockBox_table set MemberID = '" + locker.userID + "', is_locked='"
                  + (locker.isLocked == true ? 1 : 0) + "' where LockNumber='"
                  + locker.LockNumber + "'";
            Datameans.getsqlcom(sql);
            //更新箱柜信息
            return true;
        }
    }
    public class Inventory
    {
        public static void ChangeNum(MODEL.InStockdetail instockdetail)
        {
            string sql = "select distinct GoodsID from stockgoods_table where GoodsID='"
               + instockdetail.GoodID + "'";
            DataSet a = Datameans.getDataSet(sql);
            if (a.Tables[0].Rows.Count == 0)
            {
                string sql1 = "insert into stockgoods_table(GoodsID,Storename,GoodNum) values('"
                       + instockdetail.GoodID
                       + "','"
                       + instockdetail.Inventory
                       + "','"
                       + instockdetail.Amount + "')";
                Datameans.getsqlcom(sql1);
            }
            //如果表中有ID，根据入库单商品ID在库存表里增加相应数量Amount
            else
            {
                string sql2 = "update stockgoods_table set GoodNum = GoodNum + '" + instockdetail.Amount + "' where GoodsID='"
              + instockdetail.GoodID + "'";
                Datameans.getsqlcom(sql2);
            }
            //如果表中没有该商品ID插入以下信息                                                       


            //Datameans.getsqlcom(sql1);
        }
        public static DataSet QuerybyGoodName(string name)
        {
            DataSet d = new DataSet();
            string sql = "select distinct stockdetail_table.GoodsID, stockdetail_table.Goodsname, stockgoods_table.GoodNum from stockgoods_table, stockdetail_table where stockdetail_table.Goodsname = '" + name + "' and stockdetail_table.GoodsID = stockgoods_table.GoodsID";
            //依据商品名称查找商品的ID、名称和库存数量
            d = Datameans.getDataSet(sql);
            return d;
        }
        public static DataSet QuerybyGoodID(string ID)
        {
            DataSet d = new DataSet();
            string sql = "select distinct stockdetail_table.GoodsID, stockdetail_table.Goodsname, stockgoods_table.GoodNum from stockgoods_table, stockdetail_table where  stockdetail_table.GoodsID = '" + ID + "' and stockdetail_table.GoodsID = stockgoods_table.GoodsID";
            //依据商品编号查找商品的ID、名称和库存数量
            d = Datameans.getDataSet(sql);
            return d;
        }
        public static void PanDian(MODEL.Inventory inventory)
        {
            string sql = "update stockgoods_table set GoodNum = '" + inventory.Amount + "' where GoodsID = '" + inventory.GoodID + "'";
            Datameans.getsqlcom(sql);
            //根据inventory.GoodID改变inventory.Amount
        }

    }
    //***********************new******************************






    //  the latest change 
    public class getnewest
    {
        public static string MemID()
        {
            DataSet a = new DataSet();
            string sql = "select distinct MemberID from member_table ";
            a = Datameans.getDataSet(sql);
            string newestMemID = a.Tables[0].Rows[a.Tables[0].Rows.Count - 1][0].ToString();
            //获取最近的会员卡号
            return newestMemID;
        }
        public static string QAID()
        {
            DataSet a = new DataSet();
            string sql = "select distinct qualityID from qualitydetail_table ";
            a = Datameans.getDataSet(sql);
            string newestQAID = a.Tables[0].Rows[a.Tables[0].Rows.Count - 1][0].ToString();
            //获取最近的质检单号
            return newestQAID;
        }
        public static DataSet allQAID()
        {
            DataSet a = new DataSet();
            string sql = "select distinct qualityID from qualitydetail_table ";
            a = Datameans.getDataSet(sql);
            //获取最近的质检单号
            return a;
        }
        public static string InID()
        {
            DataSet a = new DataSet();
            string sql = "select distinct GoodinID from stockdetail_table ";
            a = Datameans.getDataSet(sql);
            string newestInID = a.Tables[0].Rows[a.Tables[0].Rows.Count - 1][0].ToString();
            //获取最近的入库单号
            return newestInID;
        }
    }
    public class SellInfo
    {
        public static DataSet QuerybyGoodName(string GoodName)
        {
            DataSet a = new DataSet();
            String sql = "select distinct Goodname , GoodsID , amount ,Date from selltotal_table where Goodname = '" + GoodName + "'";
            a = Datameans.getDataSet(sql);
            //根据商品名称查找售出产品的名称、数量、编号和日期；
            return a;
        }
        public static DataSet QuerybyDate(string Date)
        {
            DataSet a = new DataSet();
            String sql = "select distinct Goodname , GoodsID , amount ,Date from selltotal_table where Date = '" + Date + "'";
            a = Datameans.getDataSet(sql);
            return a;
        }
        public static DataSet QuerybuSupplier(string supplier, string date)
        {
            DataSet a = new DataSet();
            String sql = "select distinct Goodname , GoodsID , amount ,Date from selltotal_table where suppliername = '" + supplier + "' and Date = '" + date + "'";
            a = Datameans.getDataSet(sql);
            //根据supplier和date查找当天售出产品的编号、名称、日期和数量
            return a;
        }

    }

    public class recharge
    {
        public static void InputRecord(MODEL.RechargeRecord record)
        {
            string sql1 = "insert into payrecord_table(PayId,MemberID,amount,Paydate,OperateStaff) values('"  + "','"
                       + record.MemCardID
                       + "','"
                       + record.RechargeAmount
                       + "','"
                        + record.RechargeTime
                       + "','"
                       + record.Operator + "')";
            Datameans.getsqlcom(sql1);
            //插入ID、姓名、充值金额、操作员、时间
            //record.MemCardID;
            //record.RechargeAmount;        
            //record.Operator;
            //record.RechargeTime;

        }
    }


    public class ConvertQAtoStock
    {
        public static DataSet Convert(string QAID)
        {
            DataSet a = new DataSet();
            String sql = "select distinct qualitydetail_table.GoodsID , qualitydetail_table.Goodsname, qualitydetail_table.GoodsNum, qualitymain_table.Suppliername from qualitydetail_table,qualitymain_table where qualitydetail_table.qualityID = '" + QAID + "' and qualitydetail_table.qualityID = qualitymain_table.qualityID";
            a = Datameans.getDataSet(sql);
            return a;

            //根据QAID选择商品ID、商品名、商品数量、供应商
        }
    }

    public class ActiveRFID
    {
        public static void Input(string MemID,string RFID)
        {
            string sql = "update MemberRFID_table set MemberID = '" + MemID + "' where RFIDID = '" + RFID + "'";
            Datameans.getsqlcom(sql);
            //在RFID表中输入会员号和rfid号
        }
    }
}