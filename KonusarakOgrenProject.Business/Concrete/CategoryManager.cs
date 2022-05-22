using KonusarakOgrenProject.Business.Abstract;
using KonusarakOgrenProject.DataAccess.Repositories;
using KonusarakOgrenProject.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgrenProject.Business.Concrete
{
    public class CategoryManager : BaseRepository<Category>, ICategoryService
    {
    }
}
