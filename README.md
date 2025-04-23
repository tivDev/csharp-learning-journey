# C# Learning Journey

This folder serves as a guide for learning C# from a beginner's perspective. It contains resources, examples, and exercises to help you build a strong foundation in C# programming.

Feel free to explore the content and enhance your skills step by step!

## Modern Way to Create a C# Project

> **Note:** Make sure you have .NET installed on your system.  
> You can download and install it from the official .NET website:  
> [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download)

1. Create a C# project:
   ```bash
   dotnet new console -o MyApp
   cd MyApp
   ```
   This will generate a `Program.cs` file for you.

2. Replace the content of `Program.cs` with your code (or move your `main.cs` there).

3. Build the project:
   ```bash
   dotnet build
   ```

4. Run the project:
   ```bash
   dotnet run
   ```

## Folder and File Structure of a C# Console App Project

When you run:
```bash
dotnet new console -o MyApp
```
It will create a basic folder and file structure for a console app project.

### Structure:
```
MyApp/
├── MyApp.csproj
├── Program.cs
├── obj/
│   └── (build files)
```

### 🗂 Explanation:

| File / Folder         | Purpose                                          |
|-----------------------|--------------------------------------------------|
| `MyApp.csproj`        | The project file — defines project settings, .NET version, dependencies, etc. |
| `Program.cs`          | Your C# source code (by default: Hello, World!). |
| `obj/`                | Build artifacts, intermediate files created by `dotnet build`. |
| `bin/`                | *(Not shown until you build)* — compiled output lives here after `dotnet build`. |

### Example After Build:
After running `dotnet build`, the structure will look like:
```
MyApp/
├── bin/
│   └── Debug/
│       └── net8.0/
│           └── MyApp.dll
├── obj/
│   └── Debug/
│       └── net8.0/
│           └── (build files)
├── MyApp.csproj
└── Program.cs
```

### To Run It:
```bash
cd MyApp
dotnet run
```
And it will output:
```
Hello, World!
```
