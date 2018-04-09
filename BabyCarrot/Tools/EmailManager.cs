﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace BabyCarrot.Tools
{
    public class EmailManager
    {
        public static void Send(string to, string subject, string contents)
        {
            string sender = "do_not_reply@test.com";

            string smtpHost = "smtp.com";
            int smtpPort = 2525;

            string smtpId = "id;";
            string smtpPwd = "password";

            MailMessage mailMsg = new MailMessage();    //using System.Net.Mail; 해줘야 함
            mailMsg.From = new MailAddress(sender);     //보내는 사람
            mailMsg.To.Add(new MailAddress(to));        //받는사람 (컬렉션 객체임으로 여러개 지정 가능)

            mailMsg.Subject = subject;
            mailMsg.IsBodyHtml = true;
            mailMsg.Body = contents;

            mailMsg.Priority = MailPriority.Normal;

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential(smtpId, smtpPwd);
            smtpClient.Host = smtpHost;
            smtpClient.Port = smtpPort;
            smtpClient.Send(mailMsg);

        }
    }
}
