using System.ComponentModel.DataAnnotations;

namespace UserRegistration.models
{
    public sealed class Registration
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;


    }
}
