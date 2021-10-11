using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using User.API.Models;
using User.API.Models.Commons;
using User.API.Models.Responses;
using User.API.Models.ViewModels;
using User.API.Tools;

namespace User.API.Services
{
    public class UsersService:IUsersService
    {
        private readonly AppSettings _appSettings;

        public UsersService(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }
        public UsersResponse Auth(AuthViewModel model)
        {
            UsersResponse usersResponse = new UsersResponse();

            using (var db = new CloudAheadContext())
            {
                string xClientePassword = Encrypt.GetSHA256(model.Password);
                var user = db.Users.Where(d => d.Email == model.Email && d.Password == xClientePassword).FirstOrDefault();
                
                if (user == null) return null;
                usersResponse.Email = user.Email;
                usersResponse.Token =GetToken(user) ;
            }
            return usersResponse;
        }

        private string GetToken(Users user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var llave = Encoding.ASCII.GetBytes(_appSettings.Secreto);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(
                    new Claim[]
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Email, user.Email)
                }),

                Expires = DateTime.UtcNow.AddDays(60),
                SigningCredentials = new SigningCredentials(
                                   new SymmetricSecurityKey(llave),
                                   SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

    }
}
