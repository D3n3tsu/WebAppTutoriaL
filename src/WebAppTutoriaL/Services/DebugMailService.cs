using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAppTutoriaL.Services
{
    public class DebugMailService : IMailService
    {
        public bool SendMail(string to, string from, string subject, string body)
        {
            Debug.WriteLine($"Sending mail: TO: {to}, Subject: {subject}");
            return true;
        }
    }
}
