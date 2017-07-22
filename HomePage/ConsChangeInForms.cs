using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIS
{
    class ConsChangeInForms
    {
        public static void ConsChangeInForm(Control Form)
        {
            foreach (Control cons in Form.Controls)
            {
                //调整窗口属性
                if (cons is Form)
                {
                    Form myform = cons as Form;
                  //  myform.MaximizeBox = true;
                    myform.Size = new Size(920, 610);
                    myform.BackColor = ColorTranslator.FromHtml("#CCCCCC");
                }
                //调整button属性
                if (cons is Button)
                {
                    Button mybtn = cons as Button;
                    mybtn.FlatStyle = FlatStyle.Popup;
                    // mybtn.Size = new Size(145, 50);
                }
                //调整textbox属性
                if (cons is TextBox)
                {
                    TextBox mybox = cons as TextBox;
                    mybox.Multiline = true;
                   // mybox.BackColor = Color.OldLace;
                    mybox.Size = new Size(180, 25);
                    mybox.Font = new Font("楷体", 15);
                }
                //调整label属性
                if (cons is Label)
                {
                    Label mylabel = cons as Label;
                    mylabel.Font = new Font("楷体", 15);
                    mylabel.BackColor = Color.LightGray;

                }
                ////调整combobox属性
                //if (cons is ComboBox)
                //{
                //    ComboBox mycombox = cons as ComboBox;
                //    mycombox.DrawMode = DrawMode.OwnerDrawVariable;
                //   // mycombox.BackColor = Color.OldLace;
                //    mycombox.Size = new Size(180, 25);
                //   // mycombox.Font = new Font("宋体", 13);
                //}
                //调整menustrip属性
                if (cons is MenuStrip)
                {
                    MenuStrip myMenu = cons as MenuStrip;
                    myMenu.AutoSize = false;
                    myMenu.Font = new Font("微软雅黑", 12);
                    myMenu.Size = new Size(900, 40);
                    myMenu.BackColor =  ColorTranslator.FromHtml("#CCCCCC");
                }
                //调整datetimepiker属性
                if (cons is DateTimePicker)
                {
                    DateTimePicker mypiker = new DateTimePicker();
                    mypiker.Font = new Font("楷体", 10);
                }
                ////调整datagridview属性
                //if(cons is DataGridView)
                //{
                //    DataGridView d = new DataGridView();
                //    d.Font = new Font("宋体", 12);
                //}
            }
        }
    }
}
