// Services/JwtService.cs
public class JwtService {
  private readonly IConfiguration _config;
  public JwtService(IConfiguration config){ _config = config; }
  public string GenerateToken(string userId){
    // Build claims and sign token
    return "token";
  }
} 