using BusinessLayer1.Interface;
using RepositoryLayer1.Interface;
using System;
using NLog;
using ModelLayer1.DTO;

namespace BusinessLayer1.Service
{
    public class UserRegistrationBL : IUserRegistrationBL
    {
        private readonly IUserRegistrationRL _userRl;
        private static Logger logger = LogManager.GetCurrentClassLogger();

        
        public UserRegistrationBL(IUserRegistrationRL userRl)
        {
            _userRl = userRl;
        }

        public RegisterResponse Register(RegisterDTO userDTO)
        {
            try
            {
                var result = _userRl.RegisterUser(userDTO);

                RegisterResponse registerResponse = new RegisterResponse();

                if (result != null) {
                    registerResponse = new RegisterResponse();
                    registerResponse.FirstName= result.FirstName;
                    registerResponse.Email = result.Email;
                    logger.Info($"User registered successfully in Business Layer: {userDTO.Email}");
                }
                else
                {
                    logger.Warn($"User registration failed in Business Layer:");
                }

                return registerResponse;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error in Register method of Business Layer");
                throw;
            }
        }
    }
}
