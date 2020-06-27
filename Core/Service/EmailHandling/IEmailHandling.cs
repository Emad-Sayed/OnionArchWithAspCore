using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Service.EmailHandling
{
    public interface IEmailHandling
    {
        void SendEmail(string to,string head,string body);
    }
}
