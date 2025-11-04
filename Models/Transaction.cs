// Models/Transaction.cs
public class Transaction {
  public int Id { get; set; }
  public int PortfolioId { get; set; }
  public string Symbol { get; set; }
  public decimal Amount { get; set; }
  public DateTime Timestamp { get; set; }
} 