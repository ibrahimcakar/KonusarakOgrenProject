using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgrenProject.Entities.Models
{
    public class Product:BaseModel
    {
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }
        public int? ColorId { get; set; }
        public int SizeId { get; set; } 
        public int BrandId { get; set; } 
        public Category Category { get; set; }
        public Size Size { get; set; }  
        public Color Color { get; set; }
        public Brand Brand { get; set; }
    }
}
