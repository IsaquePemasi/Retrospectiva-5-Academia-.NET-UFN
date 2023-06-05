using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class OiMundiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
