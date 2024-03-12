using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSheetBackend.ViewModel
{
    public class UserViewModel
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? UserPhoneNumber { get; set; }
        public string? Password { get; set; }
        public string? RewritePassword { get; set; }
        public string? Organaization { get; set; }
    }

    public class LoginViewModel
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}