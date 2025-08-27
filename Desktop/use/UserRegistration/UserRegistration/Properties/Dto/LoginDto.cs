using Microsoft.Identity.Client;


namespace UserRegistration.Properties.Dto
{
    public class LoginDto
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public LoginDto(string username, string password)
        {
            Username = username;

            Password = password;
        }
    }
}
