// using BookedBackend.Data.Entities;
// using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
// using Microsoft.EntityFrameworkCore;

// namespace BookedBackend.Data
// {
//     public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
//     {
//         private readonly IConfiguration _configuration;
//         private readonly IHttpContextAccessor _httpContextAccessor;

//         public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IConfiguration configuration, IHttpContextAccessor httpContextAccessor)
//             : base(options)
//         {
//             _configuration = configuration;
//             _httpContextAccessor = httpContextAccessor;
//         }

//         // Configuring the DataBase Connection
//         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//            => optionsBuilder.UseNpgsql(_configuration["ConnectionStrings:DefaultConnection"]);

//         public DbSet<Specialization> Specialization { get; set; }
//         public DbSet<AvailableLanguages> AvailableLanguage { get; set; }
//         public DbSet<SlotBooking> SlotBooking { get; set; }
//         public DbSet<TimeSlot> TimeSlot { get; set; }
//         public DbSet<ValidPhoneNumber> UserPhoneNumber { get; set; }
//         public DbSet<BoardCertification> BoardCertification { get; set; }
//         public DbSet<MedicalDegree> MedicalDegree { get; set; }
//         public DbSet<UploadedFile> UploadedFile { get; set; }
//         public DbSet<SpecializationUser> SpecializationUser { get; set; }
//         public DbSet<ComFortableLanguageUser> LanguageUser { get; set; }
//         public DbSet<CategoryUser> CategoryUser { get; set; }
//         public DbSet<SlotsBookByPatient> SlotsBookByPatient { get; set; }
//         public DbSet<Address> Address { get; set; }
//         public DbSet<PaymentDetails> PaymentDetails { get; set; }
//         public DbSet<Notifications> Notifications { get; set; }
//     }

// }
