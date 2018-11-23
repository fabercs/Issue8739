using Issue8739.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Issue8739.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HomeViewModel model = new HomeViewModel { Id = 2, Name = "Test" };
            return View(model);
        }
    }
}