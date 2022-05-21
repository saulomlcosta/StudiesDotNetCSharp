using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NetCoreAngularApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreAngularApp.Data.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.Id).IsRequired();

            builder.Property(x => x.Id).HasMaxLength(100).IsRequired();
        }
    }
}
