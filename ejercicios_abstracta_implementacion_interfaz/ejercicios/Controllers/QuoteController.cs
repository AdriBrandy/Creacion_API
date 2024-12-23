using ejercicios.Model;
using ejercicios.Resource;
using Microsoft.AspNetCore.Mvc;

namespace ejercicios.Controllers
{

    [Route("api/Quote")]

    [ApiController]

    public class QuoteController : Controller
    {
       
        [HttpGet(Name = "GetQuote")]

        public string GetQuote()
        {

            DolarAPI api = new DolarAPI();

            return api.GetQuote().Result;
        }

      
        [HttpPost(Name = "GetSpecificQuote")]

        public async Task<string> GetSpecificQuote([FromBody] Currency Currency)
        {
          
            DolarAPI api = new DolarAPI();
            
        }
    }
}
