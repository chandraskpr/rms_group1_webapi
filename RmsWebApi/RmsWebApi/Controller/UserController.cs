using Microsoft.AspNetCore.Mvc;
using RmsWebApi.Data;
using RmsWebApi.Repository.Interfaces;





namespace RmsWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository userRepository;




        public UserController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }



        
        [HttpGet]
        public List<UserInfoDomain> Get()
        {
            return this.userRepository.GetAll();
        }



        
        [HttpGet("{id}")]
        public UserInfoDomain Get(int id)
        {
            return this.userRepository.GetAll().FirstOrDefault(x => x.UserId == id);
        }



        
        [HttpPost]
        public void Post([FromBody] UserInfoDomain value)
        {
            this.userRepository.Create(value);
        }



        
        [HttpPut("{id}")]
        public void Put( [FromBody] UserInfoDomain value)
        {
            this.userRepository.Update(value.UserId, value);
        }



        
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            this.userRepository.Delete(id);
        }
    }
}
