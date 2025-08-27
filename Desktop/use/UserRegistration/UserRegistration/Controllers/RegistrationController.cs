using Microsoft.EntityFrameworkCore;
using UserRegistration.Properties.Data;
using UserRegistration.models;
using Microsoft.AspNetCore.Mvc;
using UserRegistration.Properties.Dto;

namespace UserRegistration.Controllers
{
    [Route("/api/Registration")]
    public sealed class RegistrationController : Controller
    {
        private readonly RegistrationContext _registrationContext;

        public RegistrationController(RegistrationContext context) 
        {
            _registrationContext = context ?? throw new ArgumentNullException(nameof(context));
        }

        [HttpPost]

        public IActionResult Register([FromBody] RegistrationRequestDto model)
        {

            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Registration reg = new Registration() {
                Username = model.Username,
                Email = model.Email,
                Password = model.Password

            };

            _registrationContext.Registration.Add(reg);
            _registrationContext.SaveChanges();



            return Ok("Reg is success");
        }



    }
}
