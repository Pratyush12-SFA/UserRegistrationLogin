using Microsoft.EntityFrameworkCore;
using UserRegistration.Properties.models;
using UserRegistration.models;
using UserRegistration.Properties.Dto;



namespace UserRegistration.Properties.Data
{
    public class RegistrationContext(DbContextOptions options) : DbContext (options)
    {
        

        public DbSet<Registration> Registration { get; set; }

        //public DbSet<Login> Login{ get; set; }
    }
}
