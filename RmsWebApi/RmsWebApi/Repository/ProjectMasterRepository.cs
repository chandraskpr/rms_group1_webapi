using Microsoft.EntityFrameworkCore;
using RmsWebApi.Data;
using RmsWebApi.Repository.Interfaces;
using RmsWebApi.RMS_DB;
namespace RmsWebApi.Repository
{
    public class ProjectMasterRepository : BaseRepository<ProjectMaster>, IProjectMaster
    {
        public ProjectMasterRepository(RMSContext context) : base(context)
        {
        }


        public List<ProjectMasterDomain> GetAll()
        {
            var project = base.SelectAll().Select(x => new ProjectMasterDomain()
            {
                ProjectId = x.ProjectId,
                ProjectName = x.ProjectName,
                ProjectDescription = x.ProjectDescription,
            }).ToList();
            return project;

        }
        public List<ProjectMasterDomain> GetActiveRole()
        {
            var result = base.SelectAll().Select(x => new ProjectMasterDomain()
            {
                ProjectId = x.ProjectId,
                ProjectName = x.ProjectName,
                ProjectDescription = x.ProjectDescription,
                IsDeleted = x.IsDeleted,
            }).ToList();
            return result;
        }
        public int Create(ProjectMasterDomain project)
        {
            var res = new ProjectMaster()
            {
                ProjectId = project.ProjectId,
                ProjectName = project.ProjectName,
                ProjectDescription = project.ProjectDescription,

            };
            var response = base.Create(res);
            return response.ProjectId;

        }

        public void Delete(int projId)
        {
            var res = this.entitySet.FirstOrDefault(x => x.ProjectId == projId);
            if (res != null)
                base.Delete(res);
        }



        public void Update(int projId, ProjectMasterDomain project)
        {
            var res = base.SelectAll().FirstOrDefault(x => x.ProjectId == projId);
            if (res != null)
            {
                //res.ProjectId = project.ProjectId;
                res.ProjectName = project.ProjectName;
                res.ProjectDescription = project.ProjectDescription;
                res.IsDeleted = project.IsDeleted;
            }
            base.Update(res);
        }
    }
}