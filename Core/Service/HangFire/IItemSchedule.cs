using Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Service.HangFire
{
    public interface IItemSchedule
    {
        string CreateExpirationSchedule(Item item);
        void DeleteExpirationSchedule(string jobId);
    }
}
