// Controllers/AuthController.cs
[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase {
  private readonly JwtService _jwt;
  public AuthController(JwtService jwt){ _jwt = jwt; }
  [HttpPost("login")]
  public IActionResult Login([FromBody] UserCred cred) {
    // Validate user credentials
    var token = _jwt.GenerateToken(cred.UserId);
    return Ok(new { token });
  }
}