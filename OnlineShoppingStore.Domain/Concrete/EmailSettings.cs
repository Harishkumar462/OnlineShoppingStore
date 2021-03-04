using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingStore.Domain.Concrete
{
    public class EmailSettings
    {
        public string MailToAddress = "harishkumarskv@gmail.com";
        public string MailFromAddress = "harishkumarskv@gmail.com";
        public bool UseSsl = true;
        public string Username = "harishkumarskv@gmail.com";
        public string Password = ""; // Create your own google app password, In the video I have shown you how to create app password.
        public string ServerName = "smtp.gmail.com";
        public int ServerPort = 587;
    }
}
