using RmsWebApi.Data;
using RmsWebApi.RMS_DB;

namespace RmsWebApi.Repository.Interfaces
{
    public interface IRoleMaster :IBaseRepository<RoleMaster>
    {
        public List<RoleMasterDomain> GetAll();

        public int Create(RoleMasterDomain role);

        public void Delete(int roleId);

        public void Update(int roleId, RoleMasterDomain role);
    }
}
