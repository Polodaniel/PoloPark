using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using PoloPark.Server.Data;
using PoloPark.Server.Model;
using PoloPark.Shared.Model.Account;
using PoloPark.Shared.Model.Account.Result;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace PoloPark.Server.Account
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ApplicationDbContext _contexto;
        private readonly UserManager<ApplicationUser> _userManager;

        //private readonly SignInManager<IdentityUser> _signInManager;

        public LoginController(IConfiguration configuration,
                               SignInManager<ApplicationUser> signInManager,
                                ApplicationDbContext contexto,
                                UserManager<ApplicationUser> userManager)
                               //SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _configuration = configuration;
            _signInManager = signInManager;
            _contexto = contexto;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginModel login)
        {
            var result = await _signInManager.PasswordSignInAsync(login.Email, login.Password, false, false);

            if (!result.Succeeded) 
                return BadRequest(new LoginResult { Successful = false, Error = "Username and password are invalid." });

            var User = _signInManager.UserManager.FindByEmailAsync(login.Email)?.Result;

            var claims = new[]
            {
                new Claim(ClaimTypes.Name, login.Email),
                new Claim(nameof(User.Nome), User?.Nome),
                new Claim(nameof(User.UserID), User?.UserID.ToString()),
                new Claim(nameof(User.TipoConta), ((int)User?.TipoConta).ToString())
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSecurityKey"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expiry = DateTime.Now.AddDays(Convert.ToInt32(_configuration["JwtExpiryInDays"]));

            var token = new JwtSecurityToken(
                _configuration["JwtIssuer"],
                _configuration["JwtAudience"],
                claims,
                expires: expiry,
                signingCredentials: creds
            );

            var Jwt = new JwtSecurityTokenHandler();

            var response = new LoginResult();
            response.Successful = true;

            try
            {
                response.Token = Jwt.WriteToken(token);
            }
            catch (Exception ex)
            {
                var msgErro = ex.Message;
                throw;
            }

            return Ok(response);
        }
    }
}
