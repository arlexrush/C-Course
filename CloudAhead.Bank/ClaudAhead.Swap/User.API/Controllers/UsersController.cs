using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using User.API.Models.Responses;
using User.API.Models.ViewModels;
using User.API.Services;

namespace User.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUsersService _usersService;

        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
            
        }
        
        [HttpPost("login")]

        public IActionResult Authentify([FromBody] AuthViewModel model)
        {
            ResponseType response = new ResponseType();
            
            var userResponse=_usersService.Auth(model);

            if (userResponse == null)
            {
                response.Exito = 0;
                response.Mensaje = "User or Password Incorrect";
                return BadRequest(response);
            }

            response.Exito = 1;
            response.Mensaje = "Successful, wellcome to our Platform";
            response.Data = userResponse;
            return Ok(response);

            
        }


    }
}
