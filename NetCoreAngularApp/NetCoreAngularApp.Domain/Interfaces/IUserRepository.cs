using System;
using System.Collections.Generic;
using System.Text;
using NetCoreAngularApp.Domain.Entities;

namespace NetCoreAngularApp.Domain.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        IEnumerable<User> GetAll();
    }
}
