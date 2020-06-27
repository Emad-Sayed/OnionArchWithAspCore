using Core.Domain;
using Core.Service.EmailHandling;
using Core.Service.HangFire;
using Hangfire;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.HangFireService
{
    public class ItemSchedule : IItemSchedule
    {
        IEmailHandling emailHandling;
        public ItemSchedule(IEmailHandling emailHandling_)
        {
            emailHandling = emailHandling_;
        }
        public string CreateExpirationSchedule(Item item)
        {
            var DifferenceDays = (item.ExpirationDate - DateTime.Now).TotalDays;
            var jobId = BackgroundJob.Schedule(
                () => emailHandling.SendEmail("manager@email.com","Expired Item",item.Name+" Expired"),
                TimeSpan.FromDays(DifferenceDays));
            return jobId;
        }

        public void DeleteExpirationSchedule(string jobId)
        {
            BackgroundJob.Delete(jobId);
        }
    }
}
