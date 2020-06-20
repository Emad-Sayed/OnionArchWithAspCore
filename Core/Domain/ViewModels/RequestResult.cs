using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.ViewModels
{
    public interface IRequestResult
    {
        bool status { get; set; }
        object data { get; set; }
    }
}
