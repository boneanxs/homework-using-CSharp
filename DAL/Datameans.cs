using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows;


namespace DAL
{
    public class Datameans
    {
        #region  全局变量
        public static SqlConnection My_con;  //定义一个SqlConnection类型的公共变量，用于判断数据库是否连接成功
        public static string M_str_sqlcon = "Data Source=pc24;User id=sa;PWD=123";
        #endregion

        #region  建立数据库连接
        // 建立数据库连接.
        // 返回SqlConnection对象
        public static SqlConnection getcon()
        {
            My_con = new SqlConnection(@"Data Source=192.168.0.254;Database=futureShop;User id=sa;PWD=abc123@");   //用SqlConnection对象与指定的数据库相连接
            My_con.Open();  //打开数据库连接
            return My_con;  //返回SqlConnection对象的信息
        }
        #endregion

        #region  测试数据库是否连接
        // 测试数据库是否连接
        public static void con_open()
        {
            getcon();
        }
        #endregion

        #region  关闭数据库连接
        // 关闭于数据库的连接.
        public static void con_close()
        {
            if (My_con.State == ConnectionState.Open)   //判断是否打开与数据库的连接
            {
                My_con.Close();   //关闭数据库的连接
                My_con.Dispose();   //释放My_con变量的所有空间
            }
        }
        #endregion

        #region  读取指定表中的信息到内存，返回SqlDataReader
        /// 读取指定表中的信息. 返回SqlDataReader类型的My_read
        public static SqlDataReader getcom(string SQLstr)
        {
            getcon();   //打开与数据库的连接
            SqlCommand My_com = My_con.CreateCommand(); //创建一个SqlCommand对象，用于执行SQL语句
            My_com.CommandText = SQLstr;    //获取指定的SQL语句
            SqlDataReader My_read = My_com.ExecuteReader(); //执行SQL语句，生成一个SqlDataReader对象
            return My_read;
        }
        #endregion

        #region 执行SqlCommand命令改变数据表，不返回信息（用于增，删，改）
        /// 执行SqlCommand
        public static bool getsqlcom(string SQLstr)
        {
            try
            {
                getcon();   //打开与数据库的连接
                SqlCommand SQLcom = new SqlCommand(SQLstr, My_con); //创建一个SqlCommand对象，用于执行SQL语句
                SQLcom.ExecuteNonQuery();   //执行SQL语句
                SQLcom.Dispose();   //释放空间
                con_close();
                return true;
            }
            catch (Exception e) {
                return false;
            }
                                   //调用con_close()方法，关闭与数据库的连接
        }
        #endregion

        #region  执行SQL，返回DataSet对象
        /// 执行SQL语句，返回Dataset对象
        public static DataSet getDataSet(string SQLstr)
        {
            try
            {
                getcon();   //打开与数据库的连接
                SqlDataAdapter SQLda = new SqlDataAdapter(SQLstr, My_con);  //创建一个SqlDataAdapter对象
                DataSet My_DataSet = new DataSet(); //创建DataSet对象
                SQLda.Fill(My_DataSet);  //将数据表信息添加到DataSet对象中
                con_close();    //关闭数据库的连接
                return My_DataSet;
            }
            catch(Exception e)
            {
                DataSet a = new DataSet();
                System.Console.WriteLine("error");
                return a;
            }
            //返回DataSet对象
        }
        #endregion

        #region    执行SQL ，返回Datatable对象
        //执行SQL语句。返回Datatable对象
        public static DataTable GetTable(string SQLstr)
        {
            getcon();   //打开与数据库的连接
            SqlDataAdapter SQLda = new SqlDataAdapter(SQLstr, My_con);  //创建一个SqlDataAdapter对象
            DataTable My_DataTable = new DataTable(); //创建DataTable对象
            SQLda.Fill(My_DataTable);  //将数据表信息添加到DataTable对象中
            con_close();
            return My_DataTable;//关闭数据库的连接
        }
        #endregion
    }
}
