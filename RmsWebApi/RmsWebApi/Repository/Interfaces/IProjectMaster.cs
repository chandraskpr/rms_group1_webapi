using RmsWebApi.Data;
using RmsWebApi.RMS_DB;

namespace RmsWebApi.Repository.Interfaces
{
    public interface IProjectMaster :IBaseRepository<ProjectMaster>
    {
        public List<ProjectMasterDomain> GetAll();

        public int Create(ProjectMasterDomain projct);

        public void Delete(int projectId);

        public void Update(int projectId, ProjectMasterDomain project);
    }
}
