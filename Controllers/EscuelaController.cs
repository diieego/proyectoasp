using Microsoft.AspNetCore.Mvc;

namespace proyectomv.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult index()
        {
            return View();
        }
    }
}