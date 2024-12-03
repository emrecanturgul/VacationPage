using Microsoft.AspNetCore.Mvc;

namespace VacationPage.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
