using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace projectCore.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class UserController : ControllerBase
    {
        [HttpGet]
        [Route("/api/v1/teste")]
        public string Get(int id)
        {
            Console.WriteLine(id);

            string teste = "teste";

            return teste;
        }
    }
}
