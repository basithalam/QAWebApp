# Q&A Web Application (ASP.NET Core .NET 8)

A minimal Q&A web app built with Razor Pages + Web API. It implements Questions, Answers, Comments, Tags, and Votes. Data is stored in SQL Server via EF Core. Authentication uses JWT, and data access is abstracted via a Generic Repository pattern.

## Tech Stack
- .NET 8 (ASP.NET Core Razor Pages + Web API)
- EF Core + SQL Server
- JWT Authentication
- N-tier Architecture + Repository Pattern

## Features
- Questions: List, Create, Edit, Delete, Detail
- Answers: Create, Edit, Delete, Accept
- Comments: Create, Edit, Delete (for Question and Answer)
- Tags: Create/Get, assign tags to questions, filter by tag
- Votes: Upvote/Downvote (Question and Answer), supports toggle/change
- Owner-only operations: Edit/Delete own question/answer/comment; accept answers on own questions

## Getting Started
1. Prerequisites:
   - .NET 8 SDK
   - SQL Server (LocalDB/SQLEXPRESS/any instance)
2. Configure connection string:
   - Update `ConnectionStrings:DefaultConnection` in `appsettings.json` to match your SQL Server.
3. Restore + Build:
   ```bash
   dotnet restore
   dotnet build
   ```
4. Database migrate/update:
   - After changing server name or on first run:
   ```bash
   dotnet ef database update
   ```
   - The app also calls `context.Database.Migrate()` at startup (see Program.cs), so migrations apply at runtime.
5. Run the app:
   ```bash
   dotnet run
   ```
   - Open the URL shown in console (e.g., http://localhost:5000/ or the Kestrel port).

## Configuration
- Connection string: `appsettings.json` → `ConnectionStrings.DefaultConnection`
- JWT:
  - Configure `Jwt:Key`, `Jwt:Issuer`, `Jwt:Audience`. Change the key for production.

## User Flow
- Register: `/Register` page or API `POST /api/auth/register`
- Login: `/Login` page or API `POST /api/auth/login`
- On success, the frontend stores `jwtToken`, `userId`, `username` in `localStorage`; protected APIs require `Authorization: Bearer <token>`.

## Key API Endpoints (summary)
- Auth:
  - `POST /api/auth/register` → register + return JWT token
  - `POST /api/auth/login` → login + return JWT token
- Questions:
  - `POST /api/questions` (Authorized)
  - `PUT /api/questions/{id}` (Authorized, owner-only)
  - `DELETE /api/questions/{id}` (Authorized, owner-only)
- Answers:
  - `POST /api/answers` (Authorized)
  - `PUT /api/answers/{id}` (Authorized, owner-only)
  - `DELETE /api/answers/{id}` (Authorized, owner-only)
  - `POST /api/answers/{id}/accept` (Authorized, question owner-only)
- Comments:
  - `POST /api/comments` (Authorized)
  - `PUT /api/comments/{id}` (Authorized, owner-only)
  - `DELETE /api/comments/{id}` (Authorized, owner-only)
- Votes:
  - `POST /api/vote` (Authorized) → upvote/downvote + toggle/change

## Architecture (N-tier + Repository)
- UI: Razor Pages (Pages/*)
- API: Controllers (Controllers/*)
- Application/Services: business logic (Services/Interfaces & Services/Implementations)
- Domain: Models, DTOs (Models/*, DTOs/*)
- Data: EF Core DbContext, migrations (Data/ApplicationDbContext.cs, Migrations/*)
- Repository: Generic Repository (Repositories/*)

## Tests
- xUnit + EF Core InMemory are used.
```bash
dotnet build Tests/QAWebApp.Tests/QAWebApp.Tests.csproj
dotnet test  Tests/QAWebApp.Tests/QAWebApp.Tests.csproj
```

## Seed Data
- Demo user: `demo / Demo@123`
- One demo question and answer are seeded; they insert on first run/migration.

## Notes
- For production, change `Jwt:Key` and enforce HTTPS.
- `TrustServerCertificate=True` may be helpful for local development to avoid certificate issues.

