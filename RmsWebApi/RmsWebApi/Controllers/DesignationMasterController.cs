using Microsoft.AspNetCore.Mvc;
using RmsWebApi.Data;
using RmsWebApi.Repository.Interfaces;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RmsWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DesignationMasterController : ControllerBase
    {
        private readonly IDesignationMaster designationMasterRepository;
        public DesignationMasterController(IDesignationMaster designationMasterRepository)
        {
            this.designationMasterRepository = designationMasterRepository;
        }
        // GET: api/<DesignationMasterController>
        [HttpGet]
        public List<DesignationMasterDomain> Get()
        {
            return this.designationMasterRepository.GetAll();
        }

        [HttpGet]
        [Route("GetActiveDesignation")]
        public List<DesignationMasterDomain> GetActiveDesignation()
        {
            return this.designationMasterRepository.GetActiveDesignations();
        }

        [HttpGet("{isDeleted}")]
        public DesignationMasterDomain Get(bool isDeleted)
        {
            return this.designationMasterRepository.GetAll().FirstOrDefault(d => d.IsDeleted == isDeleted);
        }


        // POST api/<RoleMasterController>
        [HttpPost]
        public int Post([FromBody] DesignationMasterDomain value)
        {
            return this.designationMasterRepository.Create(value);

        }

        // PUT api/<RoleMasterController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] DesignationMasterDomain value)
        {
            this.designationMasterRepository.Update(id, value);
        }

        // DELETE api/<RoleMasterController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            this.designationMasterRepository.Delete(id);
        }
    }
}
