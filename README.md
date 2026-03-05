# JwtImplementation

![.NET](https://img.shields.io/badge/-.NET-blue?logo=.net&logoColor=white)

## 📝 Description

JwtImplementation is a comprehensive demonstration of secure authentication using JSON Web Tokens (JWT) within the .NET ecosystem. This project features a full-stack approach, providing a robust backend to handle user registration, login, and logout processes, alongside a functional UI for user interaction. It serves as a practical reference for implementing stateless authentication, secure token management, and identity integration, making it an excellent resource for developers building modern and secure web applications.

## 🛠️ Tech Stack

- 🔷 .NET


## 📦 Key Dependencies

```
Microsoft.AspNetCore.Authentication.JwtBearer: 8.0.0
Microsoft.AspNetCore.Identity.EntityFrameworkCore: 8.0.0
Microsoft.EntityFrameworkCore.SqlServer: 8.0.0
Swashbuckle.AspNetCore: 6.6.2
System.IdentityModel.Tokens.Jwt: 8.12.1
```

## 📁 Project Structure

```
.
├── AuthenticationApi
│   ├── AuthenticationApi.csproj
│   ├── AuthenticationApi.csproj.user
│   ├── AuthenticationApi.http
│   ├── Controllers
│   │   ├── AuthController.cs
│   │   └── WeatherForecastController.cs
│   ├── Data
│   │   ├── ApplicationDbContext.cs
│   │   └── ApplicationUser.cs
│   ├── Migrations
│   │   ├── 20250719111804_AddIdentityTable.Designer.cs
│   │   ├── 20250719111804_AddIdentityTable.cs
│   │   └── ApplicationDbContextModelSnapshot.cs
│   ├── Model
│   │   ├── Login.cs
│   │   └── Register.cs
│   ├── Program.cs
│   ├── Properties
│   │   └── launchSettings.json
│   ├── appsettings.Development.json
│   └── appsettings.json
├── AuthenticationApi.sln
├── AuthenticationApi.slnLaunch.user
└── AuthenticationUi
    ├── AuthenticationUi.csproj
    ├── AuthenticationUi.csproj.user
    ├── Controllers
    │   └── HomeController.cs
    ├── Models
    │   ├── ErrorViewModel.cs
    │   ├── LoginView.cs
    │   └── RegisterView.cs
    ├── Program.cs
    ├── Properties
    │   └── launchSettings.json
    ├── Views
    │   ├── Home
    │   │   ├── Index.cshtml
    │   │   ├── Login.cshtml
    │   │   ├── Privacy.cshtml
    │   │   └── Register.cshtml
    │   ├── Shared
    │   │   ├── Error.cshtml
    │   │   ├── _Layout.cshtml
    │   │   ├── _Layout.cshtml.css
    │   │   └── _ValidationScriptsPartial.cshtml
    │   ├── _ViewImports.cshtml
    │   └── _ViewStart.cshtml
    ├── appsettings.Development.json
    ├── appsettings.json
    └── wwwroot
        ├── css
        │   └── site.css
        ├── favicon.ico
        ├── js
        │   └── site.js
        └── lib
            ├── bootstrap
            │   └── LICENSE
            ├── jquery
            │   └── LICENSE.txt
            ├── jquery-validation
            │   └── LICENSE.md
            └── jquery-validation-unobtrusive
                ├── LICENSE.txt
                └── jquery.validate.unobtrusive.js
```

## 🛠️ Development Setup

### .NET Setup
1. Install [.NET SDK](https://dotnet.microsoft.com/)
2. Restore dependencies: `dotnet restore`
3. Build the project: `dotnet build`
4. Run the project: `dotnet run`


## 👥 Contributing

Contributions are welcome! Here's how you can help:

1. **Fork** the repository
2. **Clone** your fork: `git clone https://github.com/Sehar-1207/JwtImplementation/new/main?filename=README.md.git`
3. **Create** a new branch: `git checkout -b feature/your-feature`
4. **Commit** your changes: `git commit -am 'Add some feature'`
5. **Push** to your branch: `git push origin feature/your-feature`
6. **Open** a pull request

Please ensure your code follows the project's style guidelines and includes tests where applicable.

---
*This README was generated with ❤️ by Sehar Ajmal*
