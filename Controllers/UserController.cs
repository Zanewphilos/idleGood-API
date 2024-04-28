using idleGood_WebAPI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http; // 引入命名空间
using System.Threading.Tasks;
using idleGood_WebAPI.Dtos;
using DtosResponse = idleGood_WebAPI.Dtos.Response;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Diagnostics;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace idleGood_WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly IConfiguration _configuration;
        private readonly ILogger<UserController> _logger;

        public UserController(UserManager<User> userManager, IConfiguration configuration, ILogger<UserController> logger)
        {
            _userManager = userManager;
            _configuration = configuration;
            _logger = logger;
        }



        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> RegisterUser(UserRegistrationDto model)
        {
            var userExists = await _userManager.FindByEmailAsync(model.Email);
            if (userExists != null)
                return StatusCode(StatusCodes.Status500InternalServerError, new DtosResponse { Status = "Error", Message = "User already exists!" });

            User user = new User()
            {
                Email = model.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = model.Username
            };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
                return StatusCode(StatusCodes.Status500InternalServerError, new DtosResponse { Status = "Error", Message = "User creation failed! Please check user details and try again." });

            return Ok(new DtosResponse { Status = "Success", Message = "User created successfully!" });
        }


        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> LoginUser(UserLoginDto model)
        {
            _logger.LogInformation($"User attempted to log in: {model.Email}");
            var user = await _userManager.FindByEmailAsync(model.Email);



            if (user != null)
            {
                if (await _userManager.CheckPasswordAsync(user, model.Password))
                {
                    var token = GenerateJwtToken(user);
                    _logger.LogInformation($"Token generated for user: {user.Email}");
                    return Ok(new { Token = token, UserId = user.Id });
                }
                else
                {
                    _logger.LogWarning($"Login failed: Password incorrect for user {model.Email}{model.Password}");
                    return Unauthorized(new { Message = "Authentication failed. Incorrect password." });
                }
            }
            else
            {
                _logger.LogWarning($"Login failed: No user found with email {model.Email}");
                return Unauthorized(new { Message = "Authentication failed. No such user." });
            }
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet("UserInfo")]
        public async Task<IActionResult> GetUserProfile()
        {
            // 从JWT中获取用户ID
            foreach (var claim in User.Claims)
            {
                _logger.LogInformation($"Claim Type: {claim.Type} - Claim Value: {claim.Value}");
            }
            var nameIdentifierClaim = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier);

            if (nameIdentifierClaim == null)
            {
                // Handle the absence of the claim, perhaps by returning an error response.
                return Unauthorized(new { Message = "Invalid token: Name identifier claim is missing." });
            }

            string userId = nameIdentifierClaim.Value;
            // 使用userId从数据库中获取用户信息
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound(new { Message = "User not found " });
            }

            var userDto = new UserDto
            {
                Id = user.Id, 
                UserName = user.UserName,
                UserIconUrl = user.UserIconUrl, // 假设这是User模型中的一个属性
                Email = user.Email,
                Address = user.Address, // 假设这是User模型中的一个属性
                SelfIntro = user.SelfIntro // 假设这是User模型中的一个属性
            };

            return Ok(userDto);
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPut("Update")]
        public async Task<IActionResult> UpdateUser(UserUpdateDto model)
        {
            string userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound(new { Message = "User not found." });
            }

            user.UserName = model.UserName ?? user.UserName;
            user.Email = model.Email ?? user.Email;
            user.Address = model.Address ?? user.Address;
            user.SelfIntro = model.SelfIntro ?? user.SelfIntro;
            

            var result = await _userManager.UpdateAsync(user);
            if (!result.Succeeded)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { Status = "Error", Message = "User update failed." });
            }

            return Ok(new { Status = "Success", Message = "User updated successfully." });
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpDelete("delete")]
        public async Task<IActionResult> DeleteUser()
        {
            
            // Retrieve user ID from the claims
            string userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrEmpty(userId))
            {
                // If the userId could not be retrieved, return an appropriate response
                return BadRequest(new { Message = "User ID is missing from the token." });
            }

            if (_userManager == null)
            {
               
                return StatusCode(StatusCodes.Status500InternalServerError, new { Status = "Error", Message = "_userManager is not initialized." });
            }

            // Attempt to find the user by ID
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound(new { Message = "User not found." });
            }

            var result = await _userManager.DeleteAsync(user);
            var errorMessages = result.Errors.Select(e => e.Description);
            if (!result.Succeeded)
            {
                
                return StatusCode(StatusCodes.Status500InternalServerError, new { Status = "Error", Message = $"User deletion failed. Errors: {string.Join(", ", errorMessages)}" });
            }

            return Ok(new { Status = "Success", Message = "User deleted successfully." });
        }

        private string GenerateJwtToken(User user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            
            var userIdClaim = new Claim(ClaimTypes.NameIdentifier, user.Id.ToString());

            var claims = new List<Claim>
            {
                userIdClaim,
        
            };
            //generate token that is valid for 2 hours
            var token = new JwtSecurityToken(
                issuer: null, 
                audience: null, 
                claims: claims,
                expires: DateTime.UtcNow.AddHours(2), // Use UTC to avoid timezone issues
                signingCredentials: credentials
            );
            var writtenToken = new JwtSecurityTokenHandler().WriteToken(token);
            _logger.LogInformation($"Generated token for user {user.Id}: {writtenToken}");
            foreach (var claim in token.Claims)
            {
                _logger.LogInformation($"Claim Type: {claim.Type} - Claim Value: {claim.Value}");
            }
            return writtenToken;
        }


    }


}
