using BusinessLayer1.Interface;
using Microsoft.AspNetCore.Mvc;
using NLog;
using ModelLayer1.DTO;

namespace UserResgistration1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserRegistrationController : ControllerBase
    {
        private readonly IUserRegistrationBL _userBl;
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public UserRegistrationController(IUserRegistrationBL userBl)
        {
            _userBl = userBl;
        }

        [HttpPost("register")]
        public IActionResult Register(RegisterDTO userDTO)
        {
            ResponseBody<RegisterResponse> responseBody = new ResponseBody<RegisterResponse>();
            try
            {
                // ✅ Get the ResponseDTO<RegisterResponse> from Business Layer
                var response = _userBl.Register(userDTO);

                if (response != null)
                {
                    responseBody.Success = true;
                    responseBody.Message = "register sucess";
                    responseBody.Data = response;
                    return Ok(response); // Return success response
                }
                else
                {
                    return BadRequest(response); // Return failure response
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error in Register method of Controller");
                return StatusCode(500, new ResponseBody<RegisterResponse>
                {
                    Success = false,
                    Message = "Internal Server Error",
                    Data = null
                });
            }
        }
    }
}
