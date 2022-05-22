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
    public class BrandMap : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasData(
                new Brand {Id=1,Name=Faker.Company.Name(), IsActive=true},
                new Brand {Id=2,Name=Faker.Company.Name(), IsActive=true},
                new Brand {Id=3,Name=Faker.Company.Name(), IsActive=true},
                new Brand {Id=4,Name=Faker.Company.Name(), IsActive=true},
                new Brand {Id=5,Name=Faker.Company.Name(), IsActive=true}
                ) ;
        }
    }
}
