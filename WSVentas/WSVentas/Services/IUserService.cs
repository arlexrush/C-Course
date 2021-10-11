
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSVentas.Models.Response;
using WSVentas.Models.Viewmodels;
using WSVentas.Services;

namespace WSVentas.Services
{
    public interface IUserService
    {
        UserResponse Auth(AuthViewModels model);
        
    }
}
