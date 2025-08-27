using System.ComponentModel.DataAnnotations;    
namespace UserRegistration.Properties.Dto
{
    public class LoginRequest
    {
        [StringLength(maximumLength: 200, MinimumLength = 3)]
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
