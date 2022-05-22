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
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { Id= 1,Name= Faker.Lorem.GetFirstWord(), IsActive=true  },
                new Category { Id= 2,Name= Faker.Lorem.GetFirstWord(), IsActive=true  },
                new Category { Id= 3,Name= Faker.Lorem.GetFirstWord(), IsActive=true  },
                new Category { Id= 4,Name= Faker.Lorem.GetFirstWord(), IsActive=true  },
                new Category { Id= 5,Name= Faker.Lorem.GetFirstWord(), IsActive=true  }
                
                ) ;
        }
    }
}
