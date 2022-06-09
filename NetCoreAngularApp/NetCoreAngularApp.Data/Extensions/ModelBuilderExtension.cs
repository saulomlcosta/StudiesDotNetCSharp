using Microsoft.EntityFrameworkCore;
using NetCoreAngularApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata;
using NetCoreAngularApp.Domain.Models;

namespace NetCoreAngularApp.Data.Extensions
{
    public static class ModelBuilderExtension
    {
        public static ModelBuilder ApplyGlobalConfiguration(this ModelBuilder builder)
        {
            foreach(IMutableEntityType entityType in builder.Model.GetEntityTypes())
            {
                foreach(IMutableProperty property in entityType.GetProperties())
                {
                    switch (property.Name)
                    {
                        case nameof(Entity.Id):
                            property.IsKey();
                            break;
                        case nameof(Entity.DateUpdated):
                            property.IsNullable = true;
                            break;
                        case nameof(Entity.DateCreated):
                            property.IsNullable = false;
                            property.SetDefaultValue(DateTime.Now);
                            break;
                        case nameof(Entity.IsDeleted):
                            property.IsNullable = false;
                            property.SetDefaultValue(false);
                            break;
                        default:
                            break;
                    }
                }
            }

            return builder;
        }

        public static ModelBuilder SeedData(this ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasData(
                    new User { Id = Guid.Parse("8687ed78-4518-433b-8d96-1af3348fba5a"), Name = "Default User", Email = "default.user@app.com", DateCreated = new DateTime(2020,2,2), IsDeleted = false, DateUpdated = null }
                );

            return builder;
        }
    }
}
