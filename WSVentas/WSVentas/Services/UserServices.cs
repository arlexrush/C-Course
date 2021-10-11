using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using WSVentas.Models;
using WSVentas.Models.Commons;
using WSVentas.Models.Response;
using WSVentas.Models.Viewmodels;
using WSVentas.Tools;

namespace WSVentas.Services
{
    public class UserServices : IUserService
    {
        private readonly AppSettings _appSettings;

       
        
        public UserServices(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }
        
       
        
        


        UserResponse userresponse= new UserResponse();
        public UserResponse Auth(AuthViewModels model)
        {

            using (var db = new VentasRealContext())
            {
                string spassword = Encrypt.GetSHA256(model.Password);
                var user = db.Usuarios.Where(d => d.Password == spassword && d.Email == model.Email).FirstOrDefault();
                if (user == null) return null;
                userresponse.Email = user.Email;
                userresponse.Token = GetToken(user);
            }

            return userresponse;


                
        }

        private string GetToken(Usuario user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();

            var llave= Encoding.ASCII.GetBytes(_appSettings.Secreto);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(
                    new Claim[]
                    {
                        new Claim(ClaimTypes.NameIdentifier,user.Id.ToString()),
                        new Claim(ClaimTypes.Email,user.Email)
                    }
                    ),
                Expires = DateTime.UtcNow.AddDays(60),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(llave), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);

        }
                
    }
}
