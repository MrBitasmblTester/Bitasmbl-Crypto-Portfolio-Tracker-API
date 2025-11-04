// Data/PortfolioContext.cs
public class PortfolioContext : DbContext {
  public PortfolioContext(DbContextOptions<PortfolioContext> opts): base(opts){}
  public DbSet<CryptoPortfolio> Portfolios { get; set; }
  public DbSet<Transaction> Transactions { get; set; }
}