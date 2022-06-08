using System;
using System.Collections.Generic;
using System.Text;
using NetCoreAngularApp.Domain.Entities;

namespace NetCoreAngularApp.Domain.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
    }
}
