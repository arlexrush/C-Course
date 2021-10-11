using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSVentas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FamiliaController : ControllerBase
    {

        private readonly ILogger<FamiliaController> _logger;
        public FamiliaController(ILogger<FamiliaController> logger)
        {
            _logger = logger;
        }

        [HttpGet]

        public IEnumerable<Familia> Get()
        {
            List<Familia> LasFamilias = new List<Familia>();

            LasFamilias.Add(new Familia() {id=1, Padre="Arlex", Madre= "Maritzabel", Patrimonio_Usd=300 }  );
            LasFamilias.Add(new Familia () { id = 2, Padre = "Wilmer", Madre = "Reina", Patrimonio_Usd = 500 });
            LasFamilias.Add(new Familia () { id = 1, Padre = "Abel", Madre = "Maritza", Patrimonio_Usd = 1300 });
            return LasFamilias;

        }


    }
}
