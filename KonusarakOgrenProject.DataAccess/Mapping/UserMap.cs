using KonusarakOgrenProject.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgrenProject.DataAccess.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User { Id = 1, Name = Faker.Name.FullName(Faker.NameFormats.WithPrefix), UserName = Faker.Name.First(), Email = Faker.Internet.Email(), PasswordHash = "1234567", IsActive = true }, 
                new User { Id = 2, Name = Faker.Name.FullName(Faker.NameFormats.WithPrefix), UserName = Faker.Name.First(), Email = Faker.Internet.Email(), PasswordHash = "1234567", IsActive = true }, 
                new User { Id = 3, Name = Faker.Name.FullName(Faker.NameFormats.WithPrefix), UserName = Faker.Name.First(), Email = Faker.Internet.Email(), PasswordHash = "1234567", IsActive = true }, 
                new User { Id = 4, Name = Faker.Name.FullName(Faker.NameFormats.WithPrefix), UserName = Faker.Name.First(), Email = Faker.Internet.Email(), PasswordHash = "1234567", IsActive = true }
                
                );
        }
    }
}
