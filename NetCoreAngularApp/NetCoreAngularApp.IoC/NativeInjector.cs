using Microsoft.Extensions.DependencyInjection;
using NetCoreAngularApp.Application.Interfaces;
using NetCoreAngularApp.Application.Services;
using System;

namespace NetCoreAngularApp.IoC
{
    public static class NativeInjector
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
        }
    }
}
