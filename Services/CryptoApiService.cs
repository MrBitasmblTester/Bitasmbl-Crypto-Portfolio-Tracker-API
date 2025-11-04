// Services/CryptoApiService.cs
public class CryptoApiService : ICryptoApiService {
  private readonly HttpClient _http;
  public CryptoApiService(HttpClient http){ _http = http; }
  public async Task<decimal> GetPriceAsync(string symbol){
    // Call CoinGecko API
    var res = await _http.GetStringAsync($"https://api.coingecko.com/api/v3/simple/price?ids={symbol}&vs_currencies=usd");
    // Parse JSON and return price
    return 0m;
  }
}