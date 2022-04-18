using Microsoft.EntityFrameworkCore;
using RmsWebApi.Data;
using RmsWebApi.Repository.Interfaces;
using RmsWebApi.RMS_DB;



namespace RmsWebApi.Repository
{
    public class DesignationMasterRepository : BaseRepository<DesginationMaster>, IDesignationMaster
    {
        public DesignationMasterRepository(RMSContext context) : base(context)
        {
        }

        public List<DesginationMasterDomain> GetAll()
        {
            var designations = base.SelectAll().Select(x => new DesginationMasterDomain()
            {
                DesginationId = x.DesginationId,
                DesginationName = x.DesginationName,
                DesginationDescription = x.DesginationDescription,
                IsDeleted = x.IsDeleted,
            }).ToList();
            return designations;

        }

        public List<DesginationMasterDomain> GetActiveRole()
        {
            var result = base.SelectAll().Select(x => new DesginationMasterDomain()
            {
                DesginationId = x.DesginationId,
                DesginationName = x.DesginationName,
                DesginationDescription = x.DesginationDescription,
                IsDeleted = x.IsDeleted,
            }).ToList();
            return result;
        }

        public int Create(DesginationMasterDomain designation)
        {
            var res = new DesginationMaster()
            {
                DesginationId = designation.DesginationId,
                DesginationName = designation.DesginationName,
                DesginationDescription = designation.DesginationDescription,
                IsDeleted = designation.IsDeleted,


            };
            var response = base.Create(res);
            return response.DesginationId;

        }

        public void Delete(int desId)
        {
            var res = this.entitySet.FirstOrDefault(x => x.DesginationId == desId);
            if (res != null)
                base.Delete(res);
        }

        public void Update(int desId, DesginationMasterDomain designation)
        {
            var res = base.SelectAll().FirstOrDefault(x => x.DesginationId == desId);
            if (res != null)
            {
                //res.DesginationId = designation.DesginationId;
                res.DesginationName = designation.DesginationName;
                res.DesginationDescription = designation.DesginationDescription;
                res.IsDeleted = designation.IsDeleted;
            }
            base.Update(res);
        }
    }
}