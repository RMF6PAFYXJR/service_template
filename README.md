# ⚙️ RKFFSW ASP.NET 9 Web API Template

**Version 1.0**
A clean and modern base template for building microservices using **ASP.NET Core 9**, **PostgreSQL**, **Redis**, and **Docker**.

---

## 🚀 Overview

This template serves as a **foundation for all my web API services**.
It provides a ready-to-use, production-oriented setup with:

* ✅ Preconfigured **Swagger** (with API key support as example middleware)
* ✅ **PostgreSQL** and **Redis** integration
* ✅ Automatic and manual **EF Core migrations**
* ✅ Global **middleware pipeline**
* ✅ Support for **NGINX reverse proxy** via `ForwardedHeaders`
* ✅ Modular **extension-based startup** (clean `Program.cs`)
* ✅ Ready-to-deploy **Docker** configuration

---

## 🧩 Technologies

| Component                   | Description                         |
| --------------------------- | ----------------------------------- |
| **.NET 9**                  | Core framework for the API          |
| **PostgreSQL**              | Primary database                    |
| **Redis**                   | Cache and session storage           |
| **Entity Framework Core**   | ORM with automatic migrations       |
| **Swagger / OpenAPI**       | Built-in API documentation          |
| **Docker & Docker Compose** | Containerized environment           |
| **Nginx-ready setup**       | Works behind a proxy out of the box |

---

## 📦 Usage

### 🛠 Create a new project from this template

```bash
dotnet new install ./
dotnet new service_template -n MyNewService
```

or if the template is published globally(not now):

```bash
dotnet new service_template -n InventoryService
```

### 🧱 Build and run

```bash
docker compose up --build -d
```

Your API will be available at:

```
http://localhost:8080/swagger
```

---

## 🧠 Project Structure

```
📁 service_template/
├─ 🧩 Extensions/
│   ├─ ApplicationBuilderExtensions.cs
│   ├─ ServiceCollectionExtensions.cs
│   └─ SwaggerExtensions.cs ...
│
├─ 🧠 Middleware/
│   ├─ ApiKeyMiddleware.cs
│   └─ ExceptionMiddleware.cs ...
│
├─ 💾 Data/
│   ├─ AppDbContext.cs
│   └─ Migrations/
│
├─ 🧍 Controllers/
│   └─ UserController.cs ...
│
├─ ⚙️ appsettings.json
├─ 🐋 Dockerfile
├─ 🐋 docker-compose.yml
└─ 🏁 Program.cs
```

---

## 🧰 Commands and tools

| Action                   | Command                                    |
| ------------------------ | ------------------------------------------ |
| Add new migration        | `dotnet ef migrations add "MigrationName" or just use .bat file` |
| Apply migrations         | `dotnet ef database update`                |
| Run in Docker            | `docker compose up --build -d`             |
| Regenerate from template | `dotnet new myservice -n ServiceName`      |

---

## 💡 Notes

* The template uses a **modular startup pattern** – all services, middlewares, and mappings are cleanly separated.
* You can safely extend it with additional layers such as **CQRS**, **MediatR**, or **gRPC**.

---

## 🧑‍💻 Author

**RKFFSW**
*“Built once, reused everywhere.”*

---
