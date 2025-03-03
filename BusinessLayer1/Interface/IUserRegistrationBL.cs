﻿using ModelLayer1.DTO;
using RepositoryLayer1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer1.Interface
{
    public interface IUserRegistrationBL
    {
        RegisterResponse Register(RegisterDTO userDTO);
    }
}
