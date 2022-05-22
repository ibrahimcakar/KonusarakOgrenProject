using KonusarakOgrenProject.Business.Abstract;
using KonusarakOgrenProject.DataAccess;
using KonusarakOgrenProject.DataAccess.Repositories;
using KonusarakOgrenProject.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgrenProject.Business.Concrete
{
    public class UserManager: BaseRepository<User> ,IUserService
    {
        public User GetUserByUsernamePassword(User entity)
        {
            using (var userDbContext = new ProjectContext())
            {
                return userDbContext.Users.FirstOrDefault(x => x.UserName == entity.UserName && x.PasswordHash == entity.PasswordHash);
            }
        }

    }
}
