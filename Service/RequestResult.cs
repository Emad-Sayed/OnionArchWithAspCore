using Core.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class RequestResult : IRequestResult
    {
        public bool status { get; set; } = true;
        public object data { get; set; }
    }
}
