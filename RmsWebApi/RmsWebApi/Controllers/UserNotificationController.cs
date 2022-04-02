using Microsoft.AspNetCore.Mvc;
using RmsWebApi.Data;
using RmsWebApi.Repository.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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
        // GET: api/<UserNotificationController>
        [HttpGet]
        public IEnumerable<UserNotificationsDomain> Get()
        {
            return this.userRepository.GetNotifications();
        }



        // GET api/<UserNotificationController>/5
        [HttpGet("{status}")]
        public IEnumerable<UserNotificationsDomain> Get(string status)
        {
            return this.userRepository.GetActiveNotification();
        }

        // POST api/<UserNotificationController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UserNotificationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserNotificationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}