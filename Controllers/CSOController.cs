using Microsoft.AspNetCore.Mvc;

namespace YUJCSR.Web.Admin.Controllers
{
    public class CSOController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
