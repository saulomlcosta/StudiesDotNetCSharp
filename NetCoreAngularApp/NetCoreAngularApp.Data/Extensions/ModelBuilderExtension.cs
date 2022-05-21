using Microsoft.EntityFrameworkCore;
using NetCoreAngularApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreAngularApp.Data.Extensions
{
    public static class ModelBuilderExtension
    {
        public static ModelBuilder SeedData(this ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasData(
                    new User { Id = Guid.Parse("8687ed78-4518-433b-8d96-1af3348fba5a"), Name = "Default User", Email = "default.user@app.com"}
                );

            return builder;
        }
    }
}
