using BusinessLayer.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ModelLayer.Model;

namespace UserRegitrationReview.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class UserRegistrationController : ControllerBase
    {
        private readonly IUserRegistrationBL _userBl;
        public UserRegistrationController(IUserRegistrationBL userBl)
        {
            _userBl = userBl;
        }

        [HttpPost("register")]
        public IActionResult Register(RegisterRequest userDTO)
        {
            ResponseBody<RegisterResponse> responseBody = new ResponseBody<RegisterResponse>();
            try
            {
                
                var response = _userBl.Register(userDTO);

                if (response != null)
                {
                    responseBody.Success = true;
                    responseBody.Message = "register sucess";
                    responseBody.Data = response;
                    return Ok(responseBody); 
                }
                else
                {

                    return BadRequest(responseBody); 
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseBody<RegisterResponse>
                {
                    Success = false,
                    Message = "Internal Server Error",
                    Data = null
                });
            }
        }

        [HttpPatch("update-password/{id}")]
        public IActionResult UpdatePassword(int id,  string newpassword)
        {
            if (string.IsNullOrEmpty(newpassword))
                return BadRequest("Password cannot be empty");

            bool isUpdated = _userBl.UpdatePassword(id, newpassword);
            if (!isUpdated)
                return NotFound("User not found");

            return Ok("Password updated successfully");
        }

        [HttpPost("login")]
        public IActionResult Login(LoginModel login)
        {
            var token = _userBl.Login(login);
            if (string.IsNullOrEmpty(token))
            {
                return Unauthorized(new { message = "Invalid email or password" });
            }
            return Ok(new { message = "Login successful", token = token });
        }

        [Authorize]
        [HttpGet("protected")]
        public IActionResult ProtectedMethod()
        {
            return Ok("This is a protected API endpoint.");
        }

    }
}
