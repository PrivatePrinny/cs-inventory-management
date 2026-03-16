# Inventory Management

A simple inventory management web application built as a Rapid Application Development (RAD) exercise to
evaluate how quickly a basic, functional web app can be created using ASP.NET Core and Entity Framework Core.

## Overview

This project implements a minimal inventory system that allows creating, reading, updating and deleting
inventory items. It uses ASP.NET Core (controllers with views) and Entity Framework Core for data access.

Key characteristics:
- Target: .NET 8
- Web framework: ASP.NET Core (Controllers with Views)
- Data access: Entity Framework Core

## Features

- CRUD operations for inventory items
- EF Core `DbContext` and basic model configuration
- Simple database initializer that seeds sample data on first run

## Requirements

- .NET 8 SDK
- A database provider supported by EF Core (SQL Server is commonly used). The project expects a
  connection string in `appsettings.json`.

## Getting Started

1. Clone the repository:

   ```bash
   git clone <repository-url>
   cd InventoryManagement
   ```

2. Update the connection string in `appsettings.json` to point to your database (for example, LocalDB/SQL Server).

3. Restore and build the project:

   ```bash
   dotnet restore
   dotnet build
   ```

4. Run the application:

   ```bash
   dotnet run --project InventoryManagement
   ```

On first run the application will attempt to initialize and seed the database using the included
`DBInitializer` (see `Program.cs`).

## Important Files

- `Program.cs` — application startup and service registration (including EF Core `DbContext` registration).
- `Data/InventoryContext.cs` — EF Core `DbContext` and model configuration.
- `Data/DBInitializer.cs` — database initialization and seed logic.
- `Models/Inventory.cs` — inventory entity model.
- `Controllers/InventoriesController.cs` — controller providing CRUD endpoints and views.
- `Views/Shared/_Layout.cshtml` — shared layout for the UI.

## Configuration

Set the database connection string in `appsettings.json` under `ConnectionStrings`. Example for LocalDB/SQL Server:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=InventoryDB;Trusted_Connection=True;MultipleActiveResultSets=true"
}
```

Also ensure the following NuGet packages are installed and compatible with .NET 8:
- `Microsoft.EntityFrameworkCore`
- `Microsoft.EntityFrameworkCore.SqlServer` (or another provider you intend to use)
