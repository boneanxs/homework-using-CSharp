using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Forms;

namespace DAL
{
    class Publicmeans
    {

        #region  公共变量
        public Datameans datameans = new Datameans();   //声明MyMeans类的一个对象，以调用其方法
        #endregion

        #region  将日期转换成指定的格式
        // 将日期转换成yyyy-mm-dd格式.返回String对象
        public string Date_Format(string NDate)
        {
            string sm, sd;
            int y, m, d;
            try
            {
                y = Convert.ToDateTime(NDate).Year;
                m = Convert.ToDateTime(NDate).Month;
                d = Convert.ToDateTime(NDate).Day;
            }
            catch
            {
                return "";
            }
            if (m < 10)
                sm = "0" + Convert.ToString(m);
            else
                sm = Convert.ToString(m);
            if (d < 10)
                sd = "0" + Convert.ToString(d);
            else
                sd = Convert.ToString(d);
            return Convert.ToString(y) + "-" + sm + "-" + sd;
        }
        #endregion

        #region  将时间转换成指定的格式    
        //将时间转换成yyyy-mm-dd格式.
        public string Time_Format(string NDate)
        {
            string sh, sm, se;
            int hh, mm, ss;
            try
            {
                hh = Convert.ToDateTime(NDate).Hour;
                mm = Convert.ToDateTime(NDate).Minute;
                ss = Convert.ToDateTime(NDate).Second;

            }
            catch
            {
                return "";
            }
            sh = Convert.ToString(hh);
            if (sh.Length < 2)
                sh = "0" + sh;
            sm = Convert.ToString(mm);
            if (sm.Length < 2)
                sm = "0" + sm;
            se = Convert.ToString(ss);
            if (se.Length < 2)
                se = "0" + se;
            return sh + sm + se;
        }
        #endregion

        #region  绑定ComboBox控件
        // 对ComboBox控件进行数据绑定
        public void cboxBind(string M_str_sqlstr, string M_str_table, string M_str_tbMember, ComboBox cbox)
        {
            DataSet myds = Datameans.getDataSet(M_str_sqlstr); // 根据SQL语句与表，获取Dataset对象
            cbox.DataSource = myds.Tables[M_str_table];  // 动态的绑定数据
            cbox.DisplayMember = M_str_tbMember;  // 设置要显示的列
        }
        #endregion
    }
}
