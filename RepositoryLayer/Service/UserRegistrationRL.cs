
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using ModelLayer.Model;
using RepositoryLayer.Context;
using RepositoryLayer.Entity;
using RepositoryLayer.Interface;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;


namespace RepositoryLayer.Service
{
    public class UserRegistrationRL : IUserRegistrationRL
    {
        private readonly UserContext _dbContext;
        private readonly IConfiguration _configuration;
        private readonly IRedisCacheService _cache;

        private const string CacheKey = "Users";

        // Constructor
        public UserRegistrationRL(UserContext dbContext, IConfiguration configuration, IRedisCacheService cache)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
            _cache = cache ?? throw new ArgumentNullException(nameof(cache));
        }


        public UserEntity RegisterUser(RegisterRequest userDTO)
        {
            try
            {
                var users = _cache.Get<List<UserEntity>>(CacheKey) ?? new List<UserEntity>();
                var existingUser = users.FirstOrDefault(u => u.Email == userDTO.Email) ?? _dbContext.Users.FirstOrDefault(u => u.Email == userDTO.Email);

                if (existingUser == null)
                {
                    var user = new UserEntity()
                    {
                        Name = userDTO.Name,
                        Email = userDTO.Email,
                        PhoneNum= userDTO.Phone,
                        Password = userDTO.Password,  
                    };

                    _dbContext.Users.Add(user);
                    _dbContext.SaveChanges();
                    _cache.Set(CacheKey, users, TimeSpan.FromMinutes(60));
                    return user;
                }
                else
                {
                   
                    return existingUser;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool UpdatePassword(int Id, string newPassword)
        {
            var user = _dbContext.Users.Find(Id);
            if (user == null)
                return false;

            user.Password = newPassword; 
            _dbContext.Users.Update(user);
            _dbContext.SaveChanges();
            return true;
        }


        public string Login(LoginModel login)
        {
            try
            {
                var user = _dbContext.Users.FirstOrDefault(u => u.Email == login.Email && u.Password == login.Password);

                if (user == null)
                    return null; // Return null if the user is not found

                var claims = new[]
                {
            new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim("UserId", user.UserId.ToString()),
            new Claim("Email", user.Email.ToString()),
        };

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
                var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var token = new JwtSecurityToken(
                    _configuration["Jwt:Issuer"],
                    _configuration["Jwt:Audience"],
                    claims,
                    expires: DateTime.UtcNow.AddMinutes(60),
                    signingCredentials: signIn
                );

                return new JwtSecurityTokenHandler().WriteToken(token); // Return the token
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }

    }
}
