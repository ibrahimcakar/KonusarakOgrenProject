using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgrenProject.Entities.Models
{
    public class UserRole:IdentityRole<int>
    {
        public bool IsSysAdmin { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsCustomer { get; set; }
    }
}
