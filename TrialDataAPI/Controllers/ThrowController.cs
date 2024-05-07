using Microsoft.AspNetCore.Mvc;

namespace TrialDataAPI.Controllers;

[ApiExplorerSettings(IgnoreApi = true)]
public class ThrowController : ControllerBase
{
    [Route("Error")]
    public IActionResult HandlerError() =>
        Problem();
}