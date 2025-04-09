using Microsoft.AspNetCore.Mvc;

namespace FFCE.Controllers
{
    [Route("/")] // Define a rota para o caminho raiz
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("My Homepage :) ");
        }
    }
}
