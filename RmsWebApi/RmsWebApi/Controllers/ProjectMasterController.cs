using Microsoft.AspNetCore.Mvc;
using RmsWebApi.Data;
using RmsWebApi.Repository.Interfaces;
using RmsWebApi.RMS_DB;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860



namespace RmsWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectMasterController : ControllerBase
    {
        private readonly IProjectMaster projectMasterRepository;
        public ProjectMasterController(IProjectMaster projectMasterRepository)
        {
            this.projectMasterRepository = projectMasterRepository;
        }
        // GET: api/<ProjectMasterController>
        [HttpGet]
        public List<ProjectMasterDomain> Get()
        {
            return this.projectMasterRepository.GetAll();
        }

        [HttpGet("{isDeleted}")]
        public ProjectMasterDomain GetActiveRoll(bool isDeleted)
        {
            return this.projectMasterRepository.GetAll().FirstOrDefault(x => x.IsDeleted == isDeleted);
        }


        // POST api/<RoleMasterController>
        [HttpPost]
        public int Post([FromBody] ProjectMasterDomain value)
        {
            return this.projectMasterRepository.Create(value);



        }



        // PUT api/<RoleMasterController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ProjectMasterDomain value)
        {
            this.projectMasterRepository.Update(id, value);
        }



        // DELETE api/<RoleMasterController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            this.projectMasterRepository.Delete(id);
        }
    }
}