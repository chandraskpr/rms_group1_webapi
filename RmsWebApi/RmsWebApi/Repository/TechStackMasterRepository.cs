using Microsoft.EntityFrameworkCore;
using RmsWebApi.Data;
using RmsWebApi.Repository.Interfaces;
using RmsWebApi.RMS_DB;

namespace RmsWebApi.Repository
{
    public class TechStackMasterRepository:BaseRepository<TechStackMaster>,ITechStackMaster
    {
        public TechStackMasterRepository(RMSContext context):base(context)
        { }

        public List<TechStackMasterDomain> GetAll()
        {
            var records = base.SelectAll().Select(x => new TechStackMasterDomain()
            {
                TechStackId = x.TechStackId,
                Category=x.Category,
            }).ToList();
            return records;
        }
    }
}
