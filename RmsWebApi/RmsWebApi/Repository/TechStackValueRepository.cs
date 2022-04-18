using Microsoft.EntityFrameworkCore;
using RmsWebApi.Data;
using RmsWebApi.Repository.Interfaces;
using RmsWebApi.RMS_DB;

namespace RmsWebApi.Repository
{
    public class TechStackValueRepository : BaseRepository<TechStackValue>, ITechStackValue
    {
        public TechStackValueRepository(RMSContext context) : base(context)
        {

        }
        public List<TechStackValueDomain> GetAll()
        {
            var project = base.SelectAll().Select(x => new TechStackValueDomain()
            {
                ValueId = x.ValueId,
                ValueName = x.ValueName,
                TechStackId = x.TechStackId,
                IsDeleted = x.IsDeleted,
            }).ToList();
            return project;

        }
        public int Create(TechStackValueDomain TValue)
        {
            var res = new TechStackValue()
            {
                ValueId = TValue.ValueId,
                ValueName = TValue.ValueName,
                TechStackId = TValue.TechStackId,
                IsDeleted = TValue.IsDeleted,

            };
            var response = base.Create(res);
            return response.ValueId;

        }

        public void Delete(int TechId)
        {
            var res = this.entitySet.FirstOrDefault(x => x.ValueId == TechId);
            if (res != null)
                base.Delete(res);
        }

        public void Update(int TechId, TechStackValueDomain TValue)
        {
            var res = base.SelectAll().FirstOrDefault(x => x.ValueId == TechId);
            if (res != null)
            {

                res.ValueName = TValue.ValueName;
                res.TechStackId = TValue.TechStackId;
                res.IsDeleted = TValue.IsDeleted;
            }
            base.Update(res);
        }
    }
}