using ejercicios.EjemploDeHerencia;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ejercicios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EjemploHerenciaController : ControllerBase
    {
        [HttpGet("GetAnimal")]
        public string GetAnimal()
        {
            Animal animal = new Animal();
            animal.Edad = 10;

            Lobo lobo = new Lobo();
            lobo.Edad = 5;
            lobo.Raza = "Ibérico";

            return lobo.HacerSonido();
        }
    }
}
