using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace WebApplication1.Controllers
{
    public class OiMundiController : Controller
    {
        //public IActionResult Index()
        public string Index()
        {
            //return View();
            return "Apresenta esta mesnagem" ;
        }

        public string Welcome(string nome, int vezes =1)
        {
            return HtmlEncoder.Default.Encode($"Oi {nome}, vezes: {vezes}");
        }

        public string Oi()
        {
            return "Oi";
        }
    }
}
