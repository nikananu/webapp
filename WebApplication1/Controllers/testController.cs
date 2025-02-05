using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class testController : Controller
    {
        public IActionResult Index()
        {
            var per1 = new test
            {
                name = "Nika "
            };
            return View(per1);
        }
        public IActionResult ConfirmationPage()
        {
            return View();
        }
        public IActionResult NoConfirmationPage()
        {
            return View();
        }
    }
}
