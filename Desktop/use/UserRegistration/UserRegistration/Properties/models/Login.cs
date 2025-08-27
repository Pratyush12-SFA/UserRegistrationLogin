using System.ComponentModel.DataAnnotations;   


namespace UserRegistration.Properties.models
{
    public sealed class Login
    {
        public string Username { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;
    }
}
