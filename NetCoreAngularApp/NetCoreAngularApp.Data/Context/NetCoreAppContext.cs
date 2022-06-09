using Microsoft.EntityFrameworkCore;
using NetCoreAngularApp.Data.Extensions;
using NetCoreAngularApp.Data.Mapping;
using NetCoreAngularApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreAngularApp.Data.Context
{
    public class NetCoreAppContext : DbContext
    {
        public NetCoreAppContext(DbContextOptions<NetCoreAppContext> options)
            : base(options) { }

        #region "DBSets"

        DbSet<User> Users { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());

            modelBuilder.ApplyGlobalConfiguration();

            modelBuilder.SeedData();

            base.OnModelCreating(modelBuilder);
        }
    }
}
