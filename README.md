# ⚙️ RKFFSW ASP.NET 10 Web API Template

**Version 2.0**
This is an updated, modern template for an **ASP.NET 10 Web API**, built with Clean Architecture principles — a ready base for services and microservices.

---

## 🚀 Overview

The template provides a scalable, modular, and testable foundation for backend services and includes a set of ready integrations and patterns to accelerate development.

Includes:

* ✅ Preconfigured Swagger / OpenAPI
* ✅ PostgreSQL and Redis integration
* ✅ Entity Framework Core (migrations included)
* ✅ Global middleware pipeline
* ✅ Clean configuration in `Program.cs`
* ✅ Docker + nginx-ready configuration
* ✅ Domain-driven structure and Use Case patterns

---

## 🧩 Technologies

| Component                        | Description                        |
|----------------------------------|------------------------------------|
| **.NET 10**                      | Target platform                    |
| **PostgreSQL**                   | Primary DBMS                       |
| **Redis**                        | Caching                            |
| **Entity Framework Core 10**     | ORM and migrations                 |
| **Swagger / OpenAPI**            | API documentation and testing      |
| **Docker & Compose**             | Containerization                   |

---

## 🧠 Project structure (brief)

The `src/` folder contains the layered projects:

```
src/
├─ ServiceTemplate.Domain/        # Core (entities, interfaces)
├─ ServiceTemplate.Application/   # UseCases, DTOs, application logic
├─ ServiceTemplate.Infrastructure/# Implementations, DbContext, repos
└─ ServiceTemplate.Web/           # API, controllers, Swagger, middleware
```

---

## 🚀 Quick start

1) Restore packages and run the API locally (Windows cmd):

```bat
dotnet restore
dotnet build
dotnet run --project src\ServiceTemplate.Web\ServiceTemplate.Web.csproj
```

2) Run with Docker:

```bat
docker compose up --build -d
```

By default Swagger is available at:

```
http://localhost:8080/swagger
```

3) Working with EF Core migrations:

```bat
dotnet ef migrations add "MigrationName" --project src\ServiceTemplate.Infrastructure\ServiceTemplate.Infrastructure.csproj --startup-project src\ServiceTemplate.Web\ServiceTemplate.Web.csproj
dotnet ef database update --project src\ServiceTemplate.Infrastructure\ServiceTemplate.Infrastructure.csproj --startup-project src\ServiceTemplate.Web\ServiceTemplate.Web.csproj
```

---

## ✅ Recommended upgrade steps

1. Ensure every project in the solution targets `net10.0` (Web, Infrastructure, Application, Domain, Tests).
2. Update the Npgsql provider to a version compatible with EF Core 10, or downgrade EF Core to 9.x if required (not recommended when moving to .NET 10).
3. Install/upgrade `Swashbuckle.AspNetCore` to get `Microsoft.OpenApi.Models`.
4. Run:

```bat
dotnet restore
dotnet build
dotnet test
```

---

## 🧑‍💻 Author

RKFFSW — "Built once, reused everywhere."
