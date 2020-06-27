using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using Repository;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Repository.DependencyInjection;
using Service.DependencyInjection;
using Microsoft.OpenApi.Models;
using AutoMapper;
using Core.Domain.Mapper;
using Hangfire;

namespace OnionArchitecture.DependecnyInjection
{
    public static class InjectDependecies
    {
        public static void InjectAllDependecies(this IServiceCollection services)
        {
            services.AppRepositoryLibraryInjection();
            services.AppServiceLibraryInjection();
            services.SwaggerInjection();
            services.MapperInjection();
            services.HangFireInjection();
        }

        public static IServiceCollection AppRepositoryLibraryInjection(this IServiceCollection service)
        {
            var IdentityConnection = Startup.Configuration.GetConnectionString("DefaultConnection");
            string assemblyName = typeof(AppDbContext).Namespace;

            service.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(
                   IdentityConnection,
                   optionsBuilder => optionsBuilder.MigrationsAssembly("Repository"))
                );
            service.InjectRepositoryDependecy();
            return service;
        }
        public static IServiceCollection AppServiceLibraryInjection(this IServiceCollection service)
        {
            service.InjectServiceDependecy();
            return service;
        }
        public static IServiceCollection SwaggerInjection(this IServiceCollection service)
        {
            service.AddSwaggerGen(swagger =>
            {
                swagger.SwaggerDoc("v1", new OpenApiInfo { Title = "My API" });
            });
            return service;
        }
        public static IServiceCollection MapperInjection(this IServiceCollection service)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            service.AddSingleton(mapper);
            return service;
        }
        public static IServiceCollection HangFireInjection(this IServiceCollection service)
        {
            service.AddHangfire(x => x.UseSqlServerStorage(Startup.Configuration.GetConnectionString("DefaultConnection")));
            service.AddHangfireServer();
            return service;
        }
    }
}
