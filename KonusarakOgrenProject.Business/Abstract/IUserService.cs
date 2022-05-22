using KonusarakOgrenProject.DataAccess;
using KonusarakOgrenProject.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgrenProject.Business.Abstract
{
    public interface IUserService
    {
        User GetUserByUsernamePassword(User entity);
   
    }
}
