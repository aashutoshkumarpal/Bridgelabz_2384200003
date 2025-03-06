using ModelLayer.Model;
using RepositoryLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Interface
{
    public interface IUserRegistrationRL
    {
        UserEntity RegisterUser(RegisterRequest userDTO);

        bool UpdatePassword(int Id, string newPassword);

        string Login(LoginModel login);
    }
}
