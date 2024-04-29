using Microsoft.AspNetCore.Mvc;

namespace TrialDataAPI.Controllers
{
    public class UserAuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
