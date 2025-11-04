// Models/CryptoPortfolio.cs
public class CryptoPortfolio {
  public int Id { get; set; }
  public string UserId { get; set; }
  public ICollection<Transaction> Transactions { get; set; }
} 