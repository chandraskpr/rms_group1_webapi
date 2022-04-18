using Microsoft.EntityFrameworkCore;
using RmsWebApi.Data;
using RmsWebApi.Repository.Interfaces;
using RmsWebApi.RMS_DB;
namespace RmsWebApi.Repository
{
    public class RoleMasterRepository : BaseRepository<RoleMaster>, IRoleMaster
    {
        public RoleMasterRepository(RMSContext context) : base(context)
        {

        }


        public List<RoleMasterDomain> GetAll()
        {
            var role = base.SelectAll().Select(x => new RoleMasterDomain()
            {
                RoleId = x.RoleId,
                RoleName = x.RoleName,
                RoleDesc = x.RoleDesc,
                IsDeleted = x.IsDeleted,
            }).ToList();
            return role;

        }

        public List<RoleMasterDomain> GetActiveRole()
        {
            return base.SelectAll().Select(x => new RoleMasterDomain() 
            { 
                RoleId = x.RoleId,
                RoleName= x.RoleName,
                RoleDesc= x.RoleDesc,
                IsDeleted= x.IsDeleted,
            }).ToList();
   
        }

        public int Create(RoleMasterDomain role)
        {
            var res = new RoleMaster()
            {
                RoleId = role.RoleId,
                RoleName = role.RoleName,
                RoleDesc = role.RoleDesc,
                IsDeleted = role.IsDeleted,

            };
            var response = base.Create(res);
            return response.RoleId;

        }


        public void Delete(int roleId)
        {
            var res = this.entitySet.FirstOrDefault(x => x.RoleId == roleId);
            if (res != null)
                base.Delete(res);
        }

        public void Update(int roleId, RoleMasterDomain role)
        {
            var res = base.SelectAll().FirstOrDefault(x => x.RoleId == roleId);
            if (res != null)
            {
                //res.RoleId = role.RoleId;
                res.RoleName = role.RoleName;
                res.RoleDesc = role.RoleDesc;
                res.IsDeleted = role.IsDeleted;
            }
            base.Update(res);
        }
    }

}