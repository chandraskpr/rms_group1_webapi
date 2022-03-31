using RmsWebApi.Data;
using RmsWebApi.Repository.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RmsWebApi.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        public List<T> datacolletion;

        public BaseRepository()
        {
            datacolletion = new List<T>();
        }
        public void Create<T>(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete<T>(T entity)
        {
            throw new NotImplementedException();
        }

        public List<T> SelectAll<T>()
        {
            return null;
        }

        public void Update<T>(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
