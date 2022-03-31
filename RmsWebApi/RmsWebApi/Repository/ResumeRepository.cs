using RmsWebApi.Data;
using RmsWebApi.Repository.Interfaces;
using RmsWebApi.RMS_DB;

namespace RmsWebApi.Repository
{
    public class ResumeRepository : BaseRepository<ResumeDomain>, IResumeRepository
    {
        private readonly RMSContext context;
        public ResumeRepository(RMSContext context)
        {

            this.context = context;
        }

        public List<ResumeDomain> SelectAll()
        {
            var records = context.Resume.Select(x => new ResumeDomain()
            {
                ResumeId = x.ResumeId,
                ResumeTitle = x.ResumeTitle,
                ResumeStatus = x.ResumeStatus,
                UpdationDate = x.UpdationDate,
                CreationDate = x.CreationDate,

            }).ToList();
            return records;
        }

        public void Create(ResumeDomain resume)
        {
            var res = new Resume()
            {
                ResumeTitle = resume.ResumeTitle,
                ResumeStatus = resume.ResumeStatus,
                UpdationDate = resume.UpdationDate,
                CreationDate = resume.CreationDate,

            };
            context.Resume.Add(res);
            context.SaveChanges();
        }


        public void Delete(int ResumeId)
        {
            var res = context.Resume.Find(ResumeId);
            context.Resume.Remove(res);
            context.SaveChanges();
        }

        public void Update(int ResumeId, ResumeDomain resume)
        {
            var res = context.Resume.Find(ResumeId);
            if (res != null)
            {
                res.ResumeTitle = resume.ResumeTitle;
                res.ResumeStatus = resume.ResumeStatus;
                res.UpdationDate = resume.UpdationDate;
                res.CreationDate = resume.CreationDate;


                context.SaveChanges();
            }

        }
    }
}
