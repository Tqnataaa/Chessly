# Chessly

Chessly is an ASP.NET Core MVC chess web application.

## Main Features

- **Play vs. Bots:** Compete against AI opponents across three difficulty tiers: PawnBot, KnightBot, and QueenBot.
- **Live Elo & Stats:** Automatic Elo rating updates and win/loss/draw tracking displayed in the navbar and user profile.
- **Match History:** View PGN move notations, edit match titles and personal notes, or delete saved games.
- **Global Top 50 Leaderboard:** Scrollable player rankings sorted by Elo rating and wins, with win-rate calculations.
- **Account Management:** Register, log in, update profile settings, and download or delete personal account data.

## Technologies

- ASP.NET Core 8
- ASP.NET Core MVC
- Entity Framework Core
- SQL Server / LocalDB
- Razor Views
- Bootstrap
- ASP.NET Core Identity

## Requirements

- .NET 8 SDK
- SQL Server LocalDB
- Entity Framework Core CLI

## Setup

1. Clone the repository.

2. Open a terminal in the project directory.

3. Restore the project dependencies:

```bash
dotnet restore
```

4. Apply the Entity Framework Core migrations:

```bash
dotnet ef database update
```

5. Run the application:

```bash
dotnet run
```

## Database Configuration

The application uses SQL Server LocalDB for local development.

The default connection is:

```text
Server=(localdb)\MSSQLLocalDB;Database=Chessly.WebApp;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True
```

No external credentials or environment variables are required for local development.

## Database

The database is created and updated by applying the included Entity Framework Core migrations:

```bash
dotnet ef database update
```

## Test Account

A seeded test account is included for testing the application:

- **Email:** `tester@acc.test`
- **Password:** `123`

## Running the Application

After running:

```bash
dotnet run
```

open the HTTPS URL displayed in the terminal.

## Project Structure

- `Controllers` - MVC controllers
- `Models` - Entity models
- `ViewModels` - View-specific models
- `Views` - Razor views
- `Data` - Entity Framework Core database context and migrations
- `Areas/Identity` - ASP.NET Core Identity pages