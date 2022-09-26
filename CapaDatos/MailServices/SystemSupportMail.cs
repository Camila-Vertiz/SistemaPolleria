using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.MailServices
{
    class SystemSupportMail:MasterMailServer
    {
        public SystemSupportMail()
        {
            senderMail = "soporterokys@outlook.com";
            password = "simequieromorir22";
            host = "smtp-mail.outlook.com";
            port = 587;
            ssl = true;
            initializeSmtpClient();
        }
    }
}
