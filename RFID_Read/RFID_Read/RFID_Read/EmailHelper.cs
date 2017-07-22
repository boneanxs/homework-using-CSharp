using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace RFID_Read
{
    class EmailHelper
    {
        public static bool sendEmail(string adr, string subject, string data)
        {
            var emailAcount = "anh131@sina.com";
            var emailPassword = "anhui996329";
            var reciver = adr;
            var content = data;
            MailMessage message = new MailMessage();
            //设置发件人信息
            MailAddress fromAddr = new MailAddress("anh131@sina.com");
            message.From = fromAddr;
            //设置收件人
            message.To.Add(reciver);
            //设置邮件标题
            message.Subject = subject;
            //设置邮件内容
            message.Body = content;
            //设置邮件发送服务器
            SmtpClient client = new SmtpClient("smtp.sina.com", 25);
            //设置发送人的邮箱账号和密码
            client.Credentials = new NetworkCredential(emailAcount, emailPassword);
            //启用ssl
            client.EnableSsl = true;
            //发送邮件
            try
            {
                client.Send(message);
                return true;
            }catch(Exception ee)
            {
                return false;
            }

        }
    }
}
