using BusinessLayer.Interface;
using Microsoft.Extensions.Logging;
using ModelLayer.Model;
using RepositoryLayer.Entity;
using RepositoryLayer.Service;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Service
{
    public class UserRegistrationBL : IUserRegistrationBL
    {
        private readonly IUserRegistrationRL _userRl;
        public UserRegistrationBL(IUserRegistrationRL userRl)
        {
            _userRl = userRl;
        }

        public RegisterResponse Register(RegisterRequest userDTO)
        {
            try
            {
                var result = _userRl.RegisterUser(userDTO);

                RegisterResponse registerResponse = null;

                if (result != null)
                {
                    registerResponse = new RegisterResponse();
                    registerResponse.Name = result.Name;
                    registerResponse.Email = result.Email;
                    
                }
                
                return registerResponse;
            }
            catch (Exception ex)
            {
               
                throw;
            }
        }

        public bool UpdatePassword(int Id, string newPassword)
        {
            return _userRl.UpdatePassword(Id, newPassword);
        }

        public string Login(LoginModel login)
        {
            return _userRl.Login(login);
        }
    }
}
