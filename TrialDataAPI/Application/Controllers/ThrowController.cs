using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace TrialDataAPI.Application.Controllers;

[ApiExplorerSettings(IgnoreApi = true)]
public class ThrowController : ControllerBase
{
    [Route("/error")]
    public IActionResult HandlerError() =>
        Problem();

    [Route("/error-development")]
    public IActionResult HandlerErrorDevelopment([FromServices] IHostEnvironment hostEnvironment)
    {
        if (!hostEnvironment.IsDevelopment())
        {
            return NotFound();
        }

        var exceptionHandlerFeature = HttpContext.Features.Get<IExceptionHandlerFeature>()!;

        return Problem(
            detail: exceptionHandlerFeature.Error.StackTrace,
            title: exceptionHandlerFeature.Error.Message
        );
    }
}