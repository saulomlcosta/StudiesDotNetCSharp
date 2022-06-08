using System;
using System.Collections.Generic;
using System.Text;
using NetCoreAngularApp.Data.Context;
using NetCoreAngularApp.Domain.Entities;
using NetCoreAngularApp.Domain.Interfaces;

namespace NetCoreAngularApp.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(NetCoreAppContext context)
            : base(context) { }

        public IEnumerable<User> GetAll()
        {
            return Query(x => !x.IsDeleted);
        }
    }
}
