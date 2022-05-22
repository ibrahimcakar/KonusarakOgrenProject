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
    public class ColorMap : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.HasData(
                new Color { Id=1,Name=Faker.Currency.Name(), IsActive=true},
                new Color { Id=2,Name=Faker.Currency.Name(), IsActive=true},
                new Color { Id=3,Name=Faker.Currency.Name(), IsActive=true},
                new Color { Id=4,Name=Faker.Currency.Name(), IsActive=true},
                new Color { Id=5,Name=Faker.Currency.Name(), IsActive=true}
                ) ;
        }
    }
}
