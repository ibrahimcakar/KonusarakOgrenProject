using KonusarakOgrenProject.DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgrenProject.DataAccess.Repositories
{
    public class BaseRepository<T>:IBaseManager<T> where T : class, new()
    {
        public T Create(T entity)
        {
            using (ProjectContext context = new ProjectContext())
            {
                var addEntity = context.Set<T>();
                addEntity.Add(entity);
                context.SaveChanges();
            }
            return entity;
        }

        public void Delete(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            using (var ctx = new ProjectContext())
            {
                var deleteEntity = ctx.Set<T>();
                deleteEntity.Remove(entity);
                ctx.SaveChanges();
            }
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            using (ProjectContext context = new ProjectContext())
            {
                return context.Set<T>().FirstOrDefault(filter);
            }
        }

        public List<T> ListAll(Expression<Func<T, bool>> filter = null)
        {
            using (ProjectContext context = new ProjectContext())
            {
                return filter == null
                   ? context.Set<T>().ToList()
                   : context.Set<T>().Where(filter).ToList();

            }
        }

        public T Update(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            using (var ctx = new ProjectContext())
            {
                var updateEntity = ctx.Entry(entity);
                updateEntity.State = EntityState.Modified;
                ctx.SaveChanges();
            }
            return entity;
        }

    }
}
