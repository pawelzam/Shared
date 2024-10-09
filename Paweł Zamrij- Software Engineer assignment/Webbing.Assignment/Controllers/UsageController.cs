namespace Webbing.Assignment.Controllers;

[ApiController]
[Route("api")]
public class UsageController : ControllerBase
{
    private readonly ILogger<UsageController> _logger;

    public UsageController(ILogger<UsageController> logger)
    {
        _logger = logger;
    }

    [HttpGet("usages-group-by-sim")]
    [ProducesResponseType(typeof(object), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetUsagesGroupBySim(
        Guid customerId,
        DateTime FromDate,
        DateTime ToDate)
    {
        // TODO: implement me


        throw new NotImplementedException();
    }

    [HttpGet("usages-group-by-customer")]
    [ProducesResponseType(typeof(object), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetUsagesGroupByCustomer(
        DateTime FromDate,
        DateTime ToDate)
    {
        // TODO: implement me


        throw new NotImplementedException();
    }
}
