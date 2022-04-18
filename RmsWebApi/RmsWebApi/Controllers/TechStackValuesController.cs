using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RmsWebApi.Repository.Interfaces;
using System.Linq;
using RmsWebApi.Data;
using RmsWebApi.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RmsWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TechStackValuesController : ControllerBase
    {
        private readonly ITechStackValue valueRepository;

        public TechStackValuesController(ITechStackValue valueRepository)
        {
            this.valueRepository = valueRepository;
        }

        [HttpGet]
        public List<TechStackValueDomain> Get()
        {
            return this.valueRepository.GetAll();
        }

        [HttpPost]
        public int Post([FromBody] TechStackValueDomain value)
        {
            return this.valueRepository.Create(value);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            this.valueRepository.Delete(id);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] TechStackValueDomain value)
        {
            this.valueRepository.Update(id, value);
        }
    }
}
