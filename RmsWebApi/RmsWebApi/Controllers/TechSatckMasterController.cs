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
    public class TechSatckMasterController : ControllerBase
    {
        private readonly ITechStackMaster techRepository;

        public TechSatckMasterController(ITechStackMaster techRepository)
        {
            this.techRepository = techRepository;
        }

       

        [HttpGet]
        public List<TechStackMasterDomain> Get()
        {
            return this.techRepository.GetAll();
        }


    }
}
