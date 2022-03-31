using RmsWebApi.Data;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace RmsWebApi.Repository.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        List<T> SelectAll<T>() ;
        void Create<T>(T entity);
        void  Update<T>(T entity) ;
        void Delete<T>(T entity) ;
    }
}
