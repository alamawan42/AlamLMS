using Azure;
using LMS.APPLICATION.Auth;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using LoginRequest = LMS.APPLICATION.Auth.LoginRequest;
using RegisterRequest = LMS.APPLICATION.Auth.RegisterRequest;


namespace LMS.PRESENTATION.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterRequest request)
        {
            var token = await _authService.RegisterAsync(request);
            return Ok(new { Token = token });
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequest request)
        {
            var response = await _authService.LoginAsync(request);
            if (response == "Invalid email or password")
                return Unauthorized(new { message = response });

            return Ok(new { Token = response });
        }

    }
}
