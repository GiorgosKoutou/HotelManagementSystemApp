Hotel Management System App

A simple Hotel Property Management System (PMS) desktop application built with C#, WinForms, and Entity Framework Core.
The goal of this project was to apply modern .NET development techniques while keeping the structure understandable and approachable for entry-level development.

Technologies Used
✅ C# (.NET 8)

✅ WinForms (UI Layer)

✅ Entity Framework Core (ORM)

✅ MySQL (Database)

✅ Layered Architecture (UI Layer / Data Access Layer separation)

✅ LINQ

✅ Generics

✅ Reflection

Entity Framework Core (EF Core)
The project uses Entity Framework Core (EF Core) as the Object-Relational Mapper (ORM) to manage communication with a MySQL database.

EF Core Features Used:
✅ Database-first approach:
The database was created externally, and then the models were generated using EF Core tools.

✅ DbContext & DbSets:
A dedicated HotelDbContext class is used to handle all interactions with the database.

✅ LINQ Queries:
LINQ is used extensively for querying data, making the code more readable and maintainable.

✅ Migrations Support:
Although the project started with a pre-existing database, EF Core Migrations can be easily enabled for future schema changes.

✅ Provider:
The application uses the Pomelo.EntityFrameworkCore.MySql provider to connect EF Core with MySQL.

Use of Reflection
A small but meaningful use of Reflection is present inside the BaseService class.

Specifically:

✅ Dynamic Property Access:
Reflection is used to dynamically retrieve the value of a given property from an object at runtime. This helps reduce boilerplate code when performing generic operations across different entities.

✅ Example scenario:
This technique is applied in a generic filtering method that dynamically inspects filter form properties (marked with custom attributes) and builds LINQ queries to filter any entity type.

This was mainly implemented to experiment with Reflection and understand its use in real-world scenarios.

Layered Architecture
The project follows a basic layered architecture with a clear separation between:

✅ UI Layer (WinForms):
Contains all the forms, user interface logic, and the service classes that handle business logic and data manipulation.
(For simplicity and learning purposes, the service classes are placed inside the UI Layer rather than having a dedicated Business Logic Layer.)

✅ Data Access Layer:
Contains the EF Core DbContext and the entity models.

Requirements
Before running the project, make sure you have the following installed:

✅ .NET 8 SDK

✅ Visual Studio 2022 or later
(Make sure to include the .NET desktop development workload)

✅ A supported Relational Database Management System (RDBMS)
The project currently uses MySQL, but thanks to EF Core's flexibility, it can work with others (like SQL Server, PostgreSQL)
(You’ll need to adjust the connection string and provider packages if you switch.)

✅ MySQL Server
Example: MySQL Community Server (or tools like MySQL Workbench for managing your DB)

✅ Entity Framework Core Tools (with MySQL support)

You need the following EF Core NuGet packages:

Package Name	Installation via NuGet Package Manager	Installation via CLI
Microsoft.EntityFrameworkCore	Search: Microsoft.EntityFrameworkCore	
Pomelo.EntityFrameworkCore.MySql	Search: Pomelo.EntityFrameworkCore.MySql	
Microsoft.EntityFrameworkCore.Tools	Search: Microsoft.EntityFrameworkCore.Tools	
Microsoft.EntityFrameworkCore.Design	Search: Microsoft.EntityFrameworkCore.Design	

Alternatively, install via CLI:

bash
Copy
Edit
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Pomelo.EntityFrameworkCore.MySql
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.EntityFrameworkCore.Design
✅ EF Core CLI tools (optional but recommended for database commands like migrations):

bash
Copy
Edit
dotnet tool install --global dotnet-ef

Author
Georgios Koutourinis
IVT AKMI – Semester D
Department: Software Engineer
Academic Year: 2024–2025

✅ Final Notes
This project was built as part of my personal learning journey into .NET development, desktop app design, and database-driven applications.
It focuses on clean code, separation of concerns, and trying out advanced features like EF Core, LINQ, and Reflection, even at an entry level.

Feel free to explore, clone, and give feedback! 😊
