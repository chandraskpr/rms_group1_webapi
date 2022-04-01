using RmsWebApi.Data;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace RmsWebApi.Repository.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        List<T> SelectAll() ;
        void Create(T entity);
        void  Update(T entity) ;
        void Delete(T entity) ;
    }
}