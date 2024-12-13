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
├── SampleModel/
│   └── User.cs               # User data model
│   └── Post.cs               # Post data model
│   └── Comment.cs            # Represents a comment on a post.
├── SampleManager/
│   └── UserManager.cs        # User operations management
│   └── BlogDbContext.cs      # Database context and models
├── Controllers/
│   └── PostController.cs     # Blog post endpoints
└── BlogProject.csproj        # Project configuration 
```
- Program.cs: The main entry point of the application.
- BlogDbContext.cs: This file defines the BlogDbContext class, which is the Entity Framework Core database context.
- SampleModel/Users.cs: User data model.
- SampleManager/UserManager.cs: Contains the UserManager class, which handles operations related to user management, such as creating, updating, and deleting users.
- Controllers/PostController.cs: This file contains the PostController class, which defines the API endpoints for managing blog posts. It includes actions for creating, reading, updating, and deleting posts.
- BlogProject.csproj: The project file for the BlogProject application. It contains metadata about the project, such as the project dependencies, target framework, and other configuration settings.
## Prerequisites
- .NET 6.0 SDK or later
- SQL Server (LocalDB or higher)
- Visual Studio 2022 or VS Code
