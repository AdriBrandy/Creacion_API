﻿using ejercicios.EjemploDeInterfaz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ejercicios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EjemploInterfazController : ControllerBase
    {
        [HttpGet("GetAnimal")]
        public string GetAnimal()
        {
            Perro perro = new Perro();

            return perro.HacerSonido();
        }

        [HttpGet("EjemploInterfazImplementacion")]
        public string EjemploInterfazImplementacion()
        {
            IAnimal perro = new Perro();

            return perro.Caminar();
        }
    }
}
