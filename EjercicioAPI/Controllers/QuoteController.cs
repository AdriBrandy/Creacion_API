using EjercicioAPI.Model;
using EjercicioAPI.Resource;
using Microsoft.AspNetCore.Mvc;

namespace EjercicioAPI.Controllers
{
    [Route("api/Quote")]
    [ApiController]

    public class QuoteController : Controller
    {
        [HttpGet(Name = "GetQuote")]

        // devuelve la cotizacion del dolar blue (string)
        public string GetQuote()
        {
            // creo un objeto de la clase DolarAPI
            DolarAPI api = new DolarAPI();

            // llama al metodo GetQuote de la clase DolarAPI
            return api.GetQuote().Result;
        }

        [HttpPost(Name = "GetSpecificQuote")]

        public async Task<string> GetSpecificQuote([FromBody] Currency Currency)
        {
            DolarAPI api = new DolarAPI();
            return await api.GetSpecificQuote(Currency);
        }
    }
}
