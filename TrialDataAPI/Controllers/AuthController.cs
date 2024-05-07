using Microsoft.AspNetCore.Mvc;

namespace TrialDataAPI.Controllers;

public class AuthController : Controller
{
    [HttpPost]
    public IActionResult Auth()
    {
        return View();
    }
}