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
    public class SizeMap : IEntityTypeConfiguration<Size>
    {
        public void Configure(EntityTypeBuilder<Size> builder)
        {
            builder.HasData(
                new Size {Name="XXS",IsActive=true },
                new Size {Name="XS",IsActive=true },
                new Size {Name="S",IsActive=true },
                new Size {Name="M",IsActive=true },
                new Size {Name="L",IsActive=true },
                new Size {Name="XL",IsActive=true },
                new Size {Name="XXL",IsActive=true },
                new Size {Name="XXXL",IsActive=true }
                
                ) ;
        }
    }
}
