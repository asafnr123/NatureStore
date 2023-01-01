using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NatureStore.Model.Entitys;


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
                    Id = 1,
                    UserName = "admin",
                    Password = "Admin1213!",
                    Address = "",
                    City = "",
                    Country = "",
                    UserType = UserType.Admin
                });
        }
    }
}
