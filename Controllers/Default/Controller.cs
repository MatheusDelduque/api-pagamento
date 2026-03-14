using Microsoft.AspNetCore.Mvc;
using Serilog;
using System.Diagnostics.CodeAnalysis;

namespace Pagamento.API.Controllers.Default
{
    [ExcludeFromCodeCoverage]
    [ApiController, Route("api/[controller]")]
    public abstract class Controller : ControllerBase
    {
        protected async Task<IActionResult> HandleRequest<T>(Func<Task<T>> action)
        {
            try
            {
                var result = await action();
                return Ok(result);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "An error occurred while processing the request.");
                return StatusCode(500, new { Message = "An error occurred while processing the request.", Details = ex.Message });
            }
        }
    }
}
