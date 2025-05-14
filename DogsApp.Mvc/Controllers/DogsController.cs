using Microsoft.AspNetCore.Mvc;

namespace DogsApp.Mvc.Controllers
{
    public class DogsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
