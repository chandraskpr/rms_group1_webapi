using RmsWebApi.Data;
using RmsWebApi.RMS_DB;
namespace RmsWebApi.Repository.Interfaces
{
    public interface ITechStackValue:IBaseRepository<TechStackValue>
    {
        public List<TechStackValueDomain> GetAll();

        public int Create(TechStackValueDomain TValue);

        public void Delete(int TechId);

        public void Update(int TechId, TechStackValueDomain TValue);
    }
}
