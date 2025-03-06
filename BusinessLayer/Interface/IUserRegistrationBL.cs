using ModelLayer.Model;
using RepositoryLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interface
{
    public interface IUserRegistrationBL
    {
        RegisterResponse Register(RegisterRequest userDTO);

        public bool UpdatePassword(int Id, string newPassword);

        string Login(LoginModel login);
    }
}
