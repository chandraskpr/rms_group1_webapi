using Microsoft.AspNetCore.Mvc;
using RmsWebApi.Data;
using RmsWebApi.Repository.Interfaces;



namespace RmsWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserNotificationController : ControllerBase
    {
        private readonly IUserRepository userRepository;


        public UserNotificationController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
       
        [HttpGet]
        public IEnumerable<UserNotificationsDomain> Get()
        {
            return this.userRepository.GetNotifications();
        }



        
        [HttpGet("{status}")]
        public IEnumerable<UserNotificationsDomain> Get(string status)
        {
            return this.userRepository.GetActiveNotification();
        }

        
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

       
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}