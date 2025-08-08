# C# Projects

These are small projects I built while learning C# and .NET. They cover console apps, OOP basics, and Entity Framework Code‑First.

## Projects

- **[Package Express Quote](https://github.com/xxHeeBeexx/PackageExpressQuote)**  
  Console app that calculates a shipping quote based on weight and dimensions with input validation and early exits.

- **[Employee Comparison App](https://github.com/xxHeeBeexx/EmployeeComparisonApp)**  
  Console app that asks for two employees’ hourly rates and hours, calculates weekly pay, formats currency, validates input, and reports who earns more.

- **[EF Code First Student App](https://github.com/xxHeeBeexx/EFCodeFirstStudentApp)**  
  EF6 Code‑First console app that creates a `Student` table and performs full CRUD (add, list, update, delete). Uses LocalDB and an App.config connection string.

---

## What I practiced

- Console I/O, branching, and validation  
- OOP: classes, properties, basic encapsulation  
- .NET formatting (currency/locale)  
- Entity Framework 6 Code‑First, `DbContext`, `DbSet<T>`, initializers  
- LINQ queries and CRUD patterns

---

## How to run locally

> Prereqs: Windows + Visual Studio 2022 Community (or VS Code + .NET SDK for console apps)

### Package Express Quote
1. Clone: `git clone https://github.com/xxHeeBeexx/PackageExpressQuote`
2. Open the solution in Visual Studio.
3. Run (**Ctrl+F5**).  
   You’ll be prompted for weight/width/height/length; the app prints a dollar quote or exits if invalid.

### Employee Comparison App
1. Clone: `git clone https://github.com/xxHeeBeexx/EmployeeComparisonApp`
2. Open in Visual Studio.
3. Run (**Ctrl+F5**).  
   Enter rates/hours for two employees; the app prints weekly salaries and who earns more.

### EF Code First Student App
1. Clone: `git clone https://github.com/xxHeeBeexx/EFCodeFirstStudentApp`
2. Open in Visual Studio.
3. Run (**Ctrl+F5**).  
   First run creates the database and inserts one student; output lists all students and totals.

**Database notes:** Uses **(LocalDb)\MSSQLLocalDB** with a `SchoolDb` database (managed by LocalDB).  
Check data via **View → SQL Server Object Explorer** in Visual Studio.

---

## Screenshots (optional)
_Add 1–2 screenshots per project (console output or SQL Server Object Explorer view)._

---

## Next steps
- Add unit tests (xUnit/MSTest) for core logic  
- Convert the EF app to an ASP.NET MVC or Razor Pages UI  
- Enable EF Migrations and seed sample data

---

## Contact
**GitHub:** [@xxHeeBeexx](https://github.com/xxHeeBeexx)
