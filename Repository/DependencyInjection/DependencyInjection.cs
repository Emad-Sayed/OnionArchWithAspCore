using Core.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.DependencyInjection
{
    public static class DependencyInjection
    {
        public static void InjectRepositoryDependecy(this IServiceCollection services)
        {
            services.AddTransient<IUOW, UOW>();
        }
    }
}
