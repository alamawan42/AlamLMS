using LMS.APPLICATION;
using System;
using System.Collections.Generic;
using System.Text;

namespace LMS.INFASTRUCTURE.Service
{
    public class EmailService : IMailService
    {
      public string SendMail() {
            return "Email sent successfully!";
        }
    }
}
