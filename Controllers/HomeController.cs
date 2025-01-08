using Microsoft.AspNetCore.Mvc;

namespace GestaoPedidos.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
