using Microsoft.EntityFrameworkCore;
using RmsWebApi.Data;
using RmsWebApi.Repository.Interfaces;
using RmsWebApi.RMS_DB;

namespace RmsWebApi.Repository
{
    public class SkillsMasterRepository : BaseRepository<SkillsMaster>, ISkillsMaster
    {
        public SkillsMasterRepository(RMSContext context) : base(context)
        {
        }
        public List<SkillsMasterDomain> GetAll()
        {
            var Skills = base.SelectAll().Select(x => new SkillsMasterDomain()
            {
                SkillsId = x.SkillsId,
                SkillName = x.SkillName,
                SkillCategory = x.SkillCategory,
                IsDeleted = x.IsDeleted,
            }).ToList();
            return Skills;
        }

        public List<SkillsMasterDomain> GetActiveSkills()
        {
            var result = base.SelectAll().Where(x => x.IsDeleted.HasValue && !x.IsDeleted.Value).Select(x => new SkillsMasterDomain()
            {
                SkillsId = x.SkillsId,
                SkillName = x.SkillName,
                SkillCategory = x.SkillCategory,
                IsDeleted = x.IsDeleted,
            }).ToList();
            return result;
        }
        public int Create(SkillsMasterDomain Skills)
        {
            var res = new SkillsMaster()
            {
                SkillsId = Skills.SkillsId,
                SkillName = Skills.SkillName,
                SkillCategory = Skills.SkillCategory,
                IsDeleted = Skills.IsDeleted,
            };
            var response = base.Create(res);
            return response.SkillsId;
        }

        public void Delete(int SkillsId)
        {
            var res = this.entitySet.FirstOrDefault(x => x.SkillsId == SkillsId);
            if (res != null)
                base.Delete(res);
        }

        public void Update(int SkillsId, SkillsMasterDomain Skills)
        {
            var res = base.SelectAll().FirstOrDefault(x => x.SkillsId == SkillsId);
            if (res != null)
            {
                //res.SkillsId = Skills.SkillsId;
                res.SkillName = Skills.SkillName;
                res.SkillCategory = Skills.SkillCategory;
                res.IsDeleted = Skills.IsDeleted;
            }
            base.Update(res);
        }
    }
}