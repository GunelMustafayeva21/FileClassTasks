using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace TASK3
{
    public static class Mail
    {
        public static void Send(string email, string title, string message)
        {
            MailAddress to = new MailAddress(email);
            if(title.Length==0 || title.Length > 100)
            {
                throw new MailTitleNotValidException("Title is not valid");
            }
            if (message.Length == 0 || message.Length > 100)
            {
                throw new MailMessageNotValidException("Message is not valid");
            }

            Console.WriteLine("Mail is sent successfully");
        }
    }
}
