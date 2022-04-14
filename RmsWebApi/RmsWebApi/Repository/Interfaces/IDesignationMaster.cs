using RmsWebApi.Data;
using RmsWebApi.RMS_DB;
namespace RmsWebApi.Repository.Interfaces
{
    public interface IDesignationMaster : IBaseRepository<DesignationMaster>
    {
        public List<DesignationMasterDomain> GetAll();

        public int Create(DesignationMasterDomain designation);

        public void Delete(int degId);

        public void Update(int degId, DesignationMasterDomain designation);
    }
}
