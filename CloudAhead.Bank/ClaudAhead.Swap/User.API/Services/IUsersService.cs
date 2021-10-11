using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using User.API.Models;
using User.API.Models.Responses;
using User.API.Models.ViewModels;

namespace User.API.Services
{
    public interface IUsersService
    {
        UsersResponse Auth(AuthViewModel model);
       
    }
}
