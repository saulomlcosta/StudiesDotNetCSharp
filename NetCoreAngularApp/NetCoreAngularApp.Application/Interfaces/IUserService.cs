using System;
using System.Collections.Generic;
using System.Text;
using NetCoreAngularApp.Application.ViewModels;

namespace NetCoreAngularApp.Application.Interfaces
{
    public interface IUserService
    {
        List<UserViewModel> Get();
    }
}
