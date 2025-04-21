using Microsoft.AspNetCore.Mvc;

namespace UserService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = new[]
            {
                new { Id = 1, Name = "Alice" },
                new { Id = 2, Name = "Bob" }
            };

            return Ok(users);
        }
    }
}
