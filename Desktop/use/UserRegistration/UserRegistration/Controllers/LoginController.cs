
using UserRegistration.Properties.Data;

using Microsoft.AspNetCore.Mvc;
using UserRegistration.Properties.Dto;

namespace UserRegistration.Controllers
{
    [ApiController]
    [Route("api/login")]
    
        
        public sealed class LoginController : Controller
        {
            private readonly RegistrationContext _registrationContext;
            public LoginController(RegistrationContext context)
            {
                _registrationContext = context ?? throw new ArgumentNullException(nameof(context));
            }
            [HttpPost]
            public IActionResult Login([FromBody] LoginRequest model)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var user = _registrationContext.Registration
                    .FirstOrDefault(u => u.Username == model.Username && u.Password == model.Password);
                if (user == null)
                {
                    return Unauthorized("Invalid username or password.");
                }
                return Ok("Login successful");
            }
        }
    }

