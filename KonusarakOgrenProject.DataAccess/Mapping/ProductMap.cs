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
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                    new Product { Id = 1,Name=Faker.Lorem.GetFirstWord(),CategoryId=1,Price=Faker.RandomNumber.Next(999,15), BrandId=1,ColorId=1,SizeId=1,Stock= Faker.RandomNumber.Next(999, 15) ,Description=Faker.Lorem.Sentence(10),IsActive=true},
                    new Product { Id = 2,Name=Faker.Lorem.GetFirstWord(),CategoryId=2,Price=Faker.RandomNumber.Next(999,15), BrandId=2,ColorId=2,SizeId=2,Stock= Faker.RandomNumber.Next(999, 15) ,Description=Faker.Lorem.Sentence(10),IsActive=true},
                    new Product { Id = 3,Name=Faker.Lorem.GetFirstWord(),CategoryId=3,Price=Faker.RandomNumber.Next(999,15), BrandId=3,ColorId=3,SizeId=3,Stock= Faker.RandomNumber.Next(999, 15) ,Description=Faker.Lorem.Sentence(10),IsActive=true},
                    new Product { Id = 4,Name=Faker.Lorem.GetFirstWord(),CategoryId=4,Price=Faker.RandomNumber.Next(999,15), BrandId=4,ColorId=4,SizeId=4,Stock= Faker.RandomNumber.Next(999, 15) ,Description=Faker.Lorem.Sentence(10),IsActive=true},
                    new Product { Id = 5,Name=Faker.Lorem.GetFirstWord(),CategoryId=5,Price=Faker.RandomNumber.Next(999,15), BrandId=5,ColorId=5,SizeId=5,Stock= Faker.RandomNumber.Next(999, 15) ,Description=Faker.Lorem.Sentence(10),IsActive=true}
                ) ;
        }
    }
}
