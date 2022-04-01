using Microsoft.AspNetCore.Mvc;
using RmsWebApi.Data;
using RmsWebApi.Repository.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RmsWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository userRepository;

       
        public  UserController(IUserRepository userRepository)
        {
                this.userRepository = userRepository;
        }

        // GET: api/<UserController>
        [HttpGet]
        public List<UserInfoDomain> Get()
        {
            return this.userRepository.GetAll();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public UserInfoDomain Get(int id)
        {
            return this.userRepository.GetAll().FirstOrDefault(x => x.UserId == id);
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] UserInfoDomain value)
        {
            this.userRepository.Create(value);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] UserInfoDomain value)
        {
            this.userRepository.Update(id, value);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            this.userRepository.Delete(id);
        }
    }
}
