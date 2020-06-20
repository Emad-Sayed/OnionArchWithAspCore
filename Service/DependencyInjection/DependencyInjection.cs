using System;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Text;
using Core.Domain.ViewModels;
using Core.Domain;
using Core.Domain.ViewModels.ItemType;
using Service.Business;
using Core.Service;

namespace Service.DependencyInjection
{
    public static class DependencyInjection
    {
        public static void InjectServiceDependecy(this IServiceCollection services)
    {
            services.AddTransient<IService<ItemType, CreateItemType>, ItemTypeService>();
            services.AddTransient<IService<Item, Item>, ItemService>();
            services.AddTransient<IRequestResult, RequestResult>();
        }
    }
}
