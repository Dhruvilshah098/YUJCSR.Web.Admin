using Microsoft.AspNetCore.Mvc;

namespace YUJCSR.Web.Admin.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
