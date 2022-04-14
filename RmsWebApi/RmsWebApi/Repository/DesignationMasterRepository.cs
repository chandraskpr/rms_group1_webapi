using Microsoft.EntityFrameworkCore;
using RmsWebApi.Data;
using RmsWebApi.Repository.Interfaces;
using RmsWebApi.RMS_DB;

namespace RmsWebApi.Repository
{
    public class DesignationMasterRepository : BaseRepository<DesignationMaster>, IDesignationMaster
    {
        public DesignationMasterRepository(RMSContext context) : base(context)
        {
        }

        public List<DesignationMasterDomain> GetAll()
        {
            var designations = base.SelectAll().Select(x => new DesignationMasterDomain()
            {
                DesignationId = x.DesignationId,
                DesignationName = x.DesignationName,
                DesignationDescription = x.DesignationDescription,
                IsDeleted = x.IsDeleted,
            }).ToList();
            return designations;

        }
        public int Create(DesignationMasterDomain designation)
        {
            var res = new DesignationMaster()
            {
               DesignationId=designation.DesignationId,
               DesignationName=designation.DesignationName,
               DesignationDescription=designation.DesignationDescription,
               IsDeleted=designation.IsDeleted,

            };
            var response = base.Create(res);
            return response.DesignationId;

        }

        public void Delete(int desId)
        {
            var res = this.entitySet.FirstOrDefault(x => x.DesignationId == desId);
            if (res != null)
                base.Delete(res);
        }

        public void Update(int desId, DesignationMasterDomain designation)
        {
            var res = base.SelectAll().FirstOrDefault(x => x.DesignationId == desId);
            if (res != null)
            {
                res.DesignationName = designation.DesignationName;
                res.DesignationDescription = designation.DesignationDescription;
                res.IsDeleted=designation.IsDeleted;
            }
            base.Update(res);
        }
    }
}
