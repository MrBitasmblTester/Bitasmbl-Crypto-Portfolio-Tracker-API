// Program.cs
var builder = WebApplication.CreateBuilder(args);
// Add EF Core DbContext
builder.Services.AddDbContext<PortfolioContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
// Add JWT Authentication
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options => { /* configure JWT options */ });
var app = builder.Build();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();