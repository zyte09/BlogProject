# BlogProject

## Overview
BlogProject is a web application built with ASP.NET Core and Entity Framework Core. It allows users to create, manage, and view blog posts.

## Features
- User management
- CRUD operations for blog posts
- API endpoints for posts
- Swagger integration for API documentation

## Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/zyte09/BlogProject.git

## Project Structure
```BlogProject/
├── Program.cs                 # Application entry point
├── Data/
│   └── BlogDbContext.cs      # Database context and models
├── SampleManager/
│   └── UserManager.cs        # User operations management
├── Controllers/
│   └── PostController.cs     # Blog post endpoints
└── BlogProject.csproj        # Project configuration 
```
## Prerequisites
- .NET 6.0 SDK or later
- SQL Server (LocalDB or higher)
- Visual Studio 2022 or VS Code
