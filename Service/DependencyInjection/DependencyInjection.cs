using System;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Text;
using Core.Domain.ViewModels;
using Core.Domain;
using Core.Domain.ViewModels.ItemType;
using Service.Business;
using Core.Service;
using Core.Domain.ViewModels.Item;
using Core.Service.EmailHandling;
using Service.EmailHandling_;
using Service.HangFireService;
using Core.Service.HangFire;

namespace Service.DependencyInjection
{
    public static class DependencyInjection
    {
        public static void InjectServiceDependecy(this IServiceCollection services)
    {
            services.AddTransient<IService<ItemType, CreateItemType>, ItemTypeService>();
            services.AddTransient<IService<Item, CreateItem>, ItemService>();
            services.AddTransient<IRequestResult, RequestResult>();
            services.AddTransient<IEmailHandling, EmailHandling>();
            services.AddTransient<IItemSchedule, ItemSchedule>();
        }
    }
}
