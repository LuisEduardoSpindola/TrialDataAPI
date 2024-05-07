using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TrialDataAPI.Models;
using TrialDataAPI.Services.Auth;

namespace TrialDataAPI.Controllers;

[ApiController]
[Route("api/v1/Auth")]
public class AuthController : Controller
{
    [HttpPost]
    public IActionResult Auth(string userName, string password)
    {
        if (userName == "Luis" && password=="123")
        {
            var token = TokenServices.GenerateToken(new Employee());
            return Ok(token);
        }
        else
        {
            return BadRequest("Erro ao tentar logar com o usuário");
        }
    }
}