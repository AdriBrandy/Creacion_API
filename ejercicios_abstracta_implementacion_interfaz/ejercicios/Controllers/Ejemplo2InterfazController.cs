using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ejercicios.EjemploDeInterfaz;

namespace ejercicios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ejemplo2InterfazController : ControllerBase
    {
        [HttpGet("GetAnimal")]
        public string GetAnimal()
        {

            EjemploDeInterfaz.BaseEjemploInterfaz _base = new BaseEjemploInterfaz();
      
            Lobo lobo = new Lobo();
            // el metodo se ejecutará dependiendo del objeto que se mande
            return _base.HacerSonido(lobo);
        }
    }
}
