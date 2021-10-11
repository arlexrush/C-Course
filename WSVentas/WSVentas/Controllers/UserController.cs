﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSVentas.Models.Response;
using WSVentas.Models.Viewmodels;
using WSVentas.Services;

namespace WSVentas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase

    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        
        [HttpPost("login")]
        public IActionResult Authentify ([FromBody] AuthViewModels model)
        {
            Respuesta respuesta = new Respuesta();
            var userresponse = _userService.Auth(model);
            if (userresponse == null)
            {
                respuesta.Exito = 0;
                respuesta.Mensaje = "User or password INCORRECT";
                return BadRequest(respuesta);
            }

            respuesta.Exito = 1;
            respuesta.Mensaje = "Successful!!!, Wellcome to our Platform";
            respuesta.Data = userresponse;
            return Ok(respuesta);
        } 
    }
}