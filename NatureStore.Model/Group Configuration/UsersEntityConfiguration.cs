﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NatureStore.Model.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatureStore.Model.Group_Configuration
{
    internal class UsersEntityConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            // User properties can't be null
            builder.HasData(
                new User
                {
                    Id = 25,
                    UserName = "admin567",
                    Password = "admin567!",
                    Address = "",
                    City = "",
                    Country = "",
                    UserType = UserType.Admin
                });
        }
    }
}