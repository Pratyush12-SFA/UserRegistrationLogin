using Microsoft.Identity.Client;

namespace UserRegistration.Properties.Dto
{
    public class RegistrationDto
    {
        public int Id { get; set; }

        public string Username { get; set; } = string.Empty;

        public string Email { get; set; }=  string.Empty;

        public string Password { get; set; } = string.Empty;


        public RegistrationDto(int id, string username, string email, string password)
        {
            Id = id;
            
            Username = username;

            Email = email;

            Password = password;


        }

       
    }
}
