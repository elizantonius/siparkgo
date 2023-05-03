using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace siparkgo.Controllers
{
    public class BerandaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
