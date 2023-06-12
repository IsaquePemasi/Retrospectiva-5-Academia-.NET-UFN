using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ExerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
