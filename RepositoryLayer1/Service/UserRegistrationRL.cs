using Microsoft.Extensions.Logging;
using RepositoryLayer1.Context;
using RepositoryLayer1.Entity;
using System;
using System.Linq;
using NLog;
using RepositoryLayer1.Interface;
using ModelLayer1.DTO;

namespace RepositoryLayer1.Service
{
    public class UserRegistrationRL : IUserRegistrationRL
    {
        private readonly UserContext _dbContext;
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public UserRegistrationRL(UserContext dbContext)
        {
            _dbContext = dbContext;
        }

        public UserEntity RegisterUser(RegisterDTO userDTO)
        {
            try
            {
                var existingUser = _dbContext.Users.FirstOrDefault(u => u.Email == userDTO.Email);

                if (existingUser == null)
                {
                    var user = new UserEntity()
                    {
                        FirstName = userDTO.FirstName,
                        LastName = userDTO.LastName,
                        Email = userDTO.Email,
                        Password = userDTO.Password,  // Consider hashing the password!
                    };

                    _dbContext.Users.Add(user);
                    _dbContext.SaveChanges();
                    logger.Info($"User registered successfully: {user.Email}");

                    return user;
                }
                else
                {
                    logger.Warn($"User already exists with email: {userDTO.Email}");

                    return existingUser;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error in RegisterUser");
                throw;
            }
        }
    }
}
