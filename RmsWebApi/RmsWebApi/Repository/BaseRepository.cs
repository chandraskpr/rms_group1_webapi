using Microsoft.EntityFrameworkCore;
using RmsWebApi.Data;
using RmsWebApi.Repository.Interfaces;
using RmsWebApi.RMS_DB;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace RmsWebApi.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T:class
    {

        protected readonly RMSContext context;
        protected readonly DbSet<T> entitySet;

        public BaseRepository(RMSContext context)
        {

            this.context = context;
            
            entitySet = this.context.Set<T>();
        }


        public void Create(T entity)
        {
            entitySet.Add(entity);
            context.SaveChanges();
        }

        public void  Delete(T entity)
        {
            entitySet.Remove(entity);
            context.SaveChanges();
        }

        public List<T> SelectAll()
        {
            return entitySet.ToList();
        }

        public void  Update(T entity)
        {
            entitySet.Update(entity);
            context.SaveChanges();
        }
    }

}
