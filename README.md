# Bitasmbl-Crypto-Portfolio-Tracker-API — Crypto Portfolio Tracker API

Description
Build a RESTful API that allows users to track their cryptocurrency investments by fetching live prices, calculating portfolio value, and recording transactions. This project focuses on building secure endpoints, data persistence, and integrating third-party APIs.

## Tech Stack
- ASP.NET Core

## Requirements
- Implement secure authentication using JWT or similar mechanism
- Fetch live crypto data from public API (e.g., CoinGecko, Binance)
- Persist user portfolios and transactions using a database

## Installation
Prerequisites:
- .NET 6.0 SDK or later

Steps:
1. Clone the repository:
   bash
   git clone https://github.com/your-username/Bitasmbl-Crypto-Portfolio-Tracker-API.git
   cd Bitasmbl-Crypto-Portfolio-Tracker-API
   
2. Configure environment variables:
   bash
   export ASPNETCORE_ENVIRONMENT=Development
   export JWT_SECRET=\"YourJwtSecretKey\"
   export CRYPTO_API_URL=\"https://api.coingecko.com/api/v3\"
   # If using Binance:
   # export BINANCE_API_KEY=\"YourBinanceApiKey\"
   # export BINANCE_API_SECRET=\"YourBinanceApiSecret\"
   
3. Restore dependencies and apply migrations:
   bash
   dotnet restore
   dotnet ef database update
   
4. Run the application:
   bash
   dotnet run
   

## Usage
1. Register a new user via the authentication endpoint.
2. Obtain a JWT by logging in.
3. Use the JWT in the `Authorization` header for subsequent requests.
4. Add, view, and manage portfolio transactions.
5. Fetch live portfolio valuation.

## Implementation Steps
1. Scaffold an ASP.NET Core Web API project.
2. Integrate EF Core for database context and migrations.
3. Implement user registration and JWT-based authentication.
4. Create models for User, Portfolio, and Transaction entities.
5. Build services to fetch live crypto data from CoinGecko or Binance.
6. Develop controllers for Auth, Portfolio, and Transactions endpoints.
7. Secure endpoints with authentication and authorization policies.
8. Write unit and integration tests.
9. Document API using Swagger.

## API Endpoints
- POST /api/auth/register — Register a new user
- POST /api/auth/login — Authenticate and retrieve JWT
- GET /api/portfolio — Retrieve user portfolio
- GET /api/portfolio/value — Get current portfolio valuation
- POST /api/transactions — Record a new transaction
- GET /api/transactions — List all user transactions