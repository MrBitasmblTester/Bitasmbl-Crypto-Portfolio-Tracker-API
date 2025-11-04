// Controllers/PortfolioController.cs
[ApiController]
[Route("api/portfolio")]
public class PortfolioController : ControllerBase {
  private readonly PortfolioContext _ctx;
  private readonly ICryptoApiService _api;
  public PortfolioController(PortfolioContext ctx, ICryptoApiService api){ _ctx = ctx; _api = api; }
  [HttpGet]
  public async Task<IActionResult> GetValue() {
    // Fetch portfolios, get prices, calculate total
    return Ok();
  }
  [HttpPost("transaction")]
  public async Task<IActionResult> AddTransaction([FromBody] Transaction tx) {
    // Save transaction
    return Ok();
  }
}