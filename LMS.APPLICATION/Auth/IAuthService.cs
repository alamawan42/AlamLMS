
using System;
using System.Collections.Generic;
using System.Text;

namespace LMS.APPLICATION.Auth
{
    public interface IAuthService
    {
        Task<string> LoginAsync(LoginRequest request);
        Task<string> RegisterAsync(RegisterRequest request);
    }
}
