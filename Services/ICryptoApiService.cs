// Services/ICryptoApiService.cs
public interface ICryptoApiService {
  Task<decimal> GetPriceAsync(string symbol);
} 