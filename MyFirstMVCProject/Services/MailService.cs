using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstMVCProject.Services
{
    public class MailService : IMailService
    {
        public bool sendEmail()
        {
            return true;
        }
    }
}