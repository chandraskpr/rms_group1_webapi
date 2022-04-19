using Microsoft.AspNetCore.Mvc;
using RmsWebApi.Data;
using RmsWebApi.Repository.Interfaces;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RmsWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   
        public class SkillsMasterController : ControllerBase
        {
            private readonly ISkillsMaster skillMasterRepository;

            public SkillsMasterController(ISkillsMaster skillMasterRepository)
            {
                this.skillMasterRepository = skillMasterRepository;
            }

            // GET: api/<RoleMasterController>
            [HttpGet]
            public List<SkillsMasterDomain> Get()
            {
                return this.skillMasterRepository.GetAll();
            }


        [HttpGet]
        [Route("GetActiveSkill")]
        public List<SkillsMasterDomain> GetActiveSkill()
        {
            return this.skillMasterRepository.GetActiveSkills();
        }

        [HttpGet("{isDeleted}")]
        public SkillsMasterDomain Get(bool isDeleted)
        {
            return this.skillMasterRepository.GetAll().FirstOrDefault(x => x.IsDeleted == isDeleted);
        }

        // POST api/<RoleMasterController>
        [HttpPost]
            public int Post([FromBody] SkillsMasterDomain value)
            {
                return this.skillMasterRepository.Create(value);

            }

            // PUT api/<RoleMasterController>/5
            [HttpPut("{id}")]
            public void Put(int id, [FromBody] SkillsMasterDomain value)
            {
                this.skillMasterRepository.Update(id, value);
            }

            // DELETE api/<RoleMasterController>/5
            [HttpDelete("{id}")]
            public void Delete(int id)
            {
                this.skillMasterRepository.Delete(id);
            }
        }
    }

