# CodeAssistant.Web

CodeAssistant.Web is a C# web application that utilizes OpenAI's GPT to generate responses to user prompts. This project is built with ASP.NET Core and uses Entity Framework Core for object-relational mapping.

## Prerequisites

Before running the application, ensure you have the following installed:
- [.NET 7.0 SDK](https://dotnet.microsoft.com/download/dotnet/7.0)
- An appropriate IDE such as [Visual Studio](https://visualstudio.microsoft.com/), [Visual Studio Code](https://code.visualstudio.com/) with the C# extension, or [JetBrains Rider](https://www.jetbrains.com/rider/).

## Installation

First, clone the repository to your local machine:

```sh
git clone https://github.com/your-username/CodeAssistant.Web.git
cd CodeAssistant.Web
```

## Configuration

### Environment Variables

Set your OpenAI API key as an environment variable:

For Unix-based systems:
```sh
export OPENAI_API_KEY='your_api_key_here'
```

For Windows CMD:
```cmd
set OPENAI_API_KEY=your_api_key_here
```

For Windows PowerShell:
```ps
$Env:OPENAI_API_KEY='your_api_key_here'
```

Replace `'your_api_key_here'` with your actual OpenAI API key.

### Database Setup

This application uses SQLite. Make sure the connection string in `appsettings.json` is correct.

Run the following command to create your database schema with Entity Framework migrations:

```sh
dotnet ef database update
```

## Running the Application

Once configuration and database setup are complete, start the application:

```sh
dotnet run
```

See the link the app is running through in the command prompt. By default, the application will be hosted at `http://localhost:5078`.