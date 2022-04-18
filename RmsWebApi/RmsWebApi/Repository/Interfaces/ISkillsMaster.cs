using RmsWebApi.Data;
using RmsWebApi.RMS_DB;

namespace RmsWebApi.Repository.Interfaces
{
    public interface ISkillsMaster : IBaseRepository<SkillsMaster>
    {
        public List<SkillsMasterDomain> GetAll();
        public int Create(SkillsMasterDomain skills);
        public void Delete(int skillsId);

        public List<SkillsMasterDomain> GetActiveSkills();
        public void Update(int skillsId, SkillsMasterDomain skills);
    }
}