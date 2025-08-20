# ASP.NET Core Web API with PostgreSQL

This project is a sample **ASP.NET Core Web API** using **Entity Framework Core** with **PostgreSQL** as the database. It includes database configuration, migrations setup, and dependency injection for `DbContext`.

---

## Table of Contents

* [Prerequisites](#prerequisites)
* [Project Structure](#project-structure)
* [Configuration](#configuration)
* [Running the Application](#running-the-application)
* [Database Migrations](#database-migrations)
* [Docker Setup (Optional)](#docker-setup-optional)
* [Swagger UI](#swagger-ui)

---

## Prerequisites

* [.NET SDK 9](https://dotnet.microsoft.com/download)
* [PostgreSQL](https://www.postgresql.org/download/)
* (Optional) [Docker](https://www.docker.com/get-started) for containerized database

---

## Project Structure

```
api/
│-- Controllers/       # Web API controllers
│-- Data/              # EF DbContext and models
│-- Configurations/    # Database configuration extension
│-- Models/            # Entity models (Customer, Order, etc.)
│-- Program.cs         # ASP.NET Core startup
│-- appsettings.json   # Configuration file with connection strings
│-- DBContextFactory.cs# EF CLI design-time factory
```

---

## Configuration

1. Open `appsettings.json`:

```json
{
  "AppSettings": {
    "Area": "T"
  },
  "ConnectionStrings": {
    "T_DefaultConnection": "Host=localhost;Port=5432;Database=mydb;Username=postgres;Password=123456"
  }
}
```

2. Update the **connection string** to match your PostgreSQL setup.

> Make sure the database exists or will be created by EF migrations.

---

## Running the Application

1. Restore dependencies:

```bash
dotnet restore
```

2. Build the project:

```bash
dotnet build
```

3. Run the application:

```bash
dotnet run
```

4. By default, the API will be available at:

```
https://localhost:5001
http://localhost:5000
```

---

## Database Migrations

### Install EF CLI (if not installed)

```bash
dotnet tool install --global dotnet-ef
```

### Add a new migration

```bash
dotnet ef migrations add InitialCreate
```

### Update database

```bash
dotnet ef database update
```

> **Note:** Make sure `DBContextFactory.cs` exists so EF CLI can resolve your `DbContext`.

---

## Docker Setup (Optional)

1. Run PostgreSQL container:

```bash
docker run --name pg -e POSTGRES_PASSWORD=123456 -p 5432:5432 -d postgres
```

2. Update `appsettings.json` with:

```json
"T_DefaultConnection": "Host=localhost;Port=5432;Database=mydb;Username=postgres;Password=123456"
```

3. Run migrations and start the API as usual.

---

## Swagger UI

Swagger is enabled in development mode. After running the app, open:

```
https://localhost:5001/swagger
```

* Use it to test API endpoints (GET `/customers`, POST `/orders`, etc.).

---
