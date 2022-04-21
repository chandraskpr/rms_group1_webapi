using Microsoft.AspNetCore.Mvc;
using RmsWebApi.Data;
using RmsWebApi.Repository.Interfaces;
using RmsWebApi.RMS_DB;



// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860



namespace RmsWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleMasterController : ControllerBase
    {
        private readonly IRoleMaster roleMasterRepository;



        public RoleMasterController(IRoleMaster roleMasterRepository)
        {
            this.roleMasterRepository = roleMasterRepository;
        }



        // GET: api/<RoleMasterController>
        [HttpGet]
        public List<RoleMasterDomain> Get()
        {
            return this.roleMasterRepository.GetAll();
        }

        [HttpGet]
        [Route("GetActiveRoles")]
        public List<RoleMasterDomain> GetActiveRoles()
        {
            return this.roleMasterRepository.GetActiveRole();
        }

        [HttpGet("{isDeleted}")]
        public RoleMasterDomain Get(bool isDeleted)
        {
            return this.roleMasterRepository.GetAll().FirstOrDefault(x => x.IsDeleted == isDeleted);
        }


        // POST api/<RoleMasterController>
        [HttpPost]
        public int Post([FromBody] RoleMasterDomain value)
        {
            return this.roleMasterRepository.Create(value);
        }



        // PUT api/<RoleMasterController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] RoleMasterDomain value)
        {
            this.roleMasterRepository.Update(id, value);
        }



        // DELETE api/<RoleMasterController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            this.roleMasterRepository.Delete(id);
        }
    }
}