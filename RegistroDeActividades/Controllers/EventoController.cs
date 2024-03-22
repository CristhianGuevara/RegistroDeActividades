using Microsoft.AspNetCore.Mvc;

namespace ProyectoEventoAdminLTE.Controllers
{
    public class EventoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
