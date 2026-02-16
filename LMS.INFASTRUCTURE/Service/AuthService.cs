using LMS.APPLICATION.Auth;
using LMS.APPLICATION.Interfaces;
using LMS.DOMAIN.Entities;


namespace LMS.INFASTRUCTURE.Service
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;
        private readonly ITokenService _tokenService;

        public AuthService(IUserRepository userRepository, ITokenService tokenService)
        {
            _userRepository = userRepository;
            _tokenService = tokenService;
        }
        public async Task<string> RegisterAsync(RegisterRequest request)
        {
            var existingUser = await _userRepository.GetByEmailAsync(request.Email);
            if (existingUser != null)
                throw new Exception("User already exists");

            var user = new User
            {
                Email = request.Email,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(request.Password),
                Role = request.Role
            };

            await _userRepository.AddAsync(user);

            return _tokenService.GenerateToken(user);
        }

        public async Task<string> LoginAsync(LoginRequest request)
        {
            var user = await _userRepository.GetByEmailAsync(request.Email);
            if (user == null ||!BCrypt.Net.BCrypt.Verify(request.Password, user.PasswordHash))
            {
                return "Invalid email or password";
            }

            return _tokenService.GenerateToken(user);
        }



    }
}

