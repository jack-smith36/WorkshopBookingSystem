# WorkshopBookingSystem

## Database setup

This solution is configured to use **PostgreSQL** through EF Core.

### Local development

1. Start only the database with Docker Compose.
2. Run the API from your machine with `dotnet run`.
3. Keep the local connection string in `WorkshopBookingSystem.API/appsettings.Development.json` pointed at `localhost`.

### Full Docker run

The compose file also includes the API service. In that mode the API gets its connection string from environment variables and talks to the database on the Docker network using host `db`.

## EF Core commands

Create a migration:

```powershell
dotnet ef migrations add InitialCreate --project "WorkshopBookingSystem.Infrastructure" --startup-project "WorkshopBookingSystem.API" --output-dir "Persistence/Migrations"
```

Apply migrations:

```powershell
dotnet ef database update --project "WorkshopBookingSystem.Infrastructure" --startup-project "WorkshopBookingSystem.API"
```

## Run locally

Start PostgreSQL:

```powershell
docker compose up -d db
```

Run the API:

```powershell
dotnet run --project "WorkshopBookingSystem.API"
```

## Run with Docker Compose

```powershell
docker compose up --build
```

