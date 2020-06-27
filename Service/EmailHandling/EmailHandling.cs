using Core.Service.EmailHandling;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.EmailHandling_
{
    public class EmailHandling : IEmailHandling
    {
        public void SendEmail(string to, string head, string body)
        {
            System.Diagnostics.Debug.WriteLine("Email Sent Successfully!!");
        }
    }
}
