using HerryWijayaPortfolio2026API.Data;
using HerryWijayaPortfolio2026API.Project2JwtAuthentication.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace HerryWijayaPortfolio2026API.Project2JwtAuthentication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Project2JwtAuthenticationController : ControllerBase
    {

        private readonly IConfiguration _config;
        private readonly ApplicationDbContext _context;

        public Project2JwtAuthenticationController(IConfiguration config,ApplicationDbContext context)
        {
            _config = config;
            _context = context;
        }
        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterRequest request)
        {
            if (_context.Users.Any(u => u.Email == request.Email))
            {
                return BadRequest("Email already exists");
            }
            var user = new User
            {
                Email = request.Email,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(request.Password)
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return Ok("User registered");
        }
        [AllowAnonymous]
        [HttpPost("login")]
        public IActionResult Login(RegisterRequestDto request)
        {
            var user = _context.Users.FirstOrDefault(x => x.Email == request.Email);

            if (user == null || !BCrypt.Net.BCrypt.Verify(request.Password, user.PasswordHash))
                return Unauthorized();

            var token = GenerateJwtToken(user);
            return Ok(new
            {
                token,
                email = user.Email
            });
        }
        [Authorize]
        [HttpGet("profile")]
        public IActionResult Profile()
        {
            return Ok("You are authenticated");
        }
        private string GenerateJwtToken(User user)
        {
            var claims = new[]
            {
        new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
        new Claim(ClaimTypes.Email, user.Email)
    };

            var key = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(_config["Jwt:Key"])
            );

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"],
    audience: _config["Jwt:Audience"],
                claims: claims,
                expires: DateTime.Now.AddHours(1),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
