using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace TimeSheetBackend.Data.Entities
{
    public class ApplicationUser: IdentityUser
    {
        [Key]
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? UserPhoneNumber { get; set; }
        public string? Organaization { get; set; }
        public string? Password { get; set; }
        public string? RewritePassword { get; set; }
    }
}