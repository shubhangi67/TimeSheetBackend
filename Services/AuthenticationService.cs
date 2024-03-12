
using TimeSheetBackend.Data;
using TimeSheetBackend.Data.Entities;
using TimeSheetBackend.ViewModel;

namespace TimeSheetBackend.Services
{
    public class AuthenticationService
    {
        private readonly ILogger<AuthenticationService> _logger;
        private readonly ApplicationDbContext _dbContext;
        public AuthenticationService(ILogger<AuthenticationService> logger, ApplicationDbContext dbContext)
        {
           _logger = logger;
           _dbContext = dbContext;
        }
        public async Task SignUp(UserViewModel userViewModel)
        {
            ApplicationUser user = new ApplicationUser()
            {
                FirstName = userViewModel.FirstName,
                LastName = userViewModel.LastName,
                Email = userViewModel.Email,
                UserPhoneNumber = userViewModel.UserPhoneNumber,
                Organaization = userViewModel.Organaization,
            };
            _dbContext.Add(user);
            await _dbContext.SaveChangesAsync();
        }
        // public async Task<string> SignIn(LoginViewModel loginViewModel)
        // {
        //     var login = await _dbContext.Users.Where(x => x.Email == loginViewModel.Email && x.Passw).FirstOrDefaultAsync();
        // }
    }
}