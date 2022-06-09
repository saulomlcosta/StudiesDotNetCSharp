using Microsoft.Extensions.DependencyInjection;
using NetCoreAngularApp.Application.Interfaces;
using NetCoreAngularApp.Application.Services;
using NetCoreAngularApp.Data.Repositories;
using NetCoreAngularApp.Domain.Interfaces;
using System;

namespace NetCoreAngularApp.IoC
{
    public static class NativeInjector
    {
        public static void RegisterServices(IServiceCollection services)
        {
            #region Services

                services.AddScoped<IUserService, UserService>();

            #endregion

            #region Repositories

                services.AddScoped<IUserRepository, UserRepository>();

            #endregion
        }
    }
}
