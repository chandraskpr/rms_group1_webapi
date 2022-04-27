using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RmsWebApi.Repository.Interfaces;
using System.Linq;
using RmsWebApi.Data;
using RmsWebApi.Repository;
using RMS.Domain.ResumeDomain;

namespace RmsWebApi.Controllers.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResumeController : ControllerBase
    {
        private readonly IResumeRepository resumeRepository;

        public ResumeController(IResumeRepository resumeRepository)
        {
            this.resumeRepository = resumeRepository;
        }

        [HttpGet]
        public List<ResumeDomain> Get()
        {
            return this.resumeRepository.GetAll();
        }

        [HttpGet("{id}")]
        public ResumeDomain Get(int id)
        {
            return this.resumeRepository.GetAll().FirstOrDefault(x =>x.ResumeId==id);
        }

        [HttpGet]
        [Route("GetNonDraftResume")]
        public List<ResumeDomain> GetNonDraftResume()
        {
            return this.resumeRepository.GetNonDraftResume();
        }

        [HttpPost]
        public ResumeDomain Post([FromBody] ResumeDomain value)
        {
            return this.resumeRepository.Create(value);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            this.resumeRepository.Delete(id);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ResumeDomain value)
        {
            this.resumeRepository.Update(id, value);
        }

        [HttpGet]
        [Route("GetResumeBySkills/{skillIds}")]
        public List<ResumeDomain> GetResumeBySkills(int skillIds)
        {
            return this.resumeRepository.GetResumeBySkills(skillIds);
            
        }
    }
}