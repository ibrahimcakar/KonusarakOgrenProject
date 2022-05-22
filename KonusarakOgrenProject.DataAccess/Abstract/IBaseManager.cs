using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgrenProject.DataAccess.Abstract
{
    public interface IBaseManager<T>
         where T : class, new()
    {
        public T Create(T entity);
        public T Update(T entity);
        public void Delete(T entity);
        public T Get(Expression<Func<T, bool>> filter);
        public List<T> ListAll(Expression<Func<T, bool>> filter = null);

    }
}
