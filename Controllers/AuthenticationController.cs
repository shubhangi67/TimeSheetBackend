using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TimeSheetBackend.ViewModel;

namespace TimeSheetBackend.Controllers
{
    [Route("[controller]")]
    public class AuthenticationController : Controller
    {
        private readonly ILogger<AuthenticationController> _logger;
        private readonly AuthenticationService _authenticationService;
        public AuthenticationController(ILogger<AuthenticationController> logger, AuthenticationService authenticationService)
        {
            _logger = logger;
            _authenticationService = authenticationService;
        }

        [HttpPost("SignUp")]
        
        public async Task<IActionResult> SignUp(UserViewModel userViewModel)
        {
            // await _authenticationService.SignUp(userViewModel);
            return Ok();
        }
        [HttpPost("SignIn")]
        
        public async Task<IActionResult> SignIn(UserViewModel userViewModel)
        {
            // await _authenticationService.SignUp(userViewModel);
            return Ok();
        }
    }
}