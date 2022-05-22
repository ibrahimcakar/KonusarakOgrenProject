using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgrenProject.Entities.Models
{
    public class User:IdentityUser<int>
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public bool IsActive { get; set; }

    }
}
