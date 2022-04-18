using RmsWebApi.Data;
using RmsWebApi.RMS_DB;
namespace RmsWebApi.Repository.Interfaces
{
    public interface IDesignationMaster : IBaseRepository<DesginationMaster>
    {
        public List<DesginationMasterDomain> GetAll();

        public int Create(DesginationMasterDomain designation);

        public void Delete(int degId);

        public void Update(int degId, DesginationMasterDomain designation);
        public List<DesginationMasterDomain> GetActiveRole();
    }
}