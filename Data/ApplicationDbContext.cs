using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TimeSheetBackend.Data.Entities;

namespace TimeSheetBackend.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IConfiguration configuration, IHttpContextAccessor httpContextAccessor)
            : base(options)
        {
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
        }

        // Configuring the DataBase Connection
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
           => optionsBuilder.UseNpgsql(_configuration["ConnectionStrings:DefaultConnection"]);

        // public DbSet<Specialization> Specialization { get; set; }
    }

}
