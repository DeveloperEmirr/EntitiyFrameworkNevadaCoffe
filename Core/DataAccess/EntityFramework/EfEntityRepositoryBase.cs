using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity,TContext> : IEntityRepository<TEntity>
        where TEntity:class, IEntity, new()
        where TContext:DbContext, new()
    {
        public void Add(TEntity Entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(Entity); //Product entity git burdan eriş demek
                addedEntity.State = EntityState.Added; //ekle
                context.SaveChanges(); // kaydet gerçekleştir demek bu işlem
            }
        }

        public void Delete(TEntity Entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(Entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<TEntity> Get(System.Linq.Expressions.Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().Where(filter).ToList();
                
            }
        }

        public List<TEntity> GetAll(System.Linq.Expressions.Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity Entity)
        {
            throw new NotImplementedException();
        }
    }
}
