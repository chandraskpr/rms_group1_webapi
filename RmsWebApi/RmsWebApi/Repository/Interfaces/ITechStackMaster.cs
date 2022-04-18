using RmsWebApi.Data;
using RmsWebApi.RMS_DB;
namespace RmsWebApi.Repository.Interfaces
{
    public interface ITechStackMaster:IBaseRepository<TechStackMaster>
    {
        public List<TechStackMasterDomain> GetAll();
    }
}
