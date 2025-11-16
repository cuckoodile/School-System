# Student Portal

A Windows Forms application built with VB.NET that provides a student portal interface with navigation capabilities similar to React Router.

## Features

- **Navigation System**: Radio button-based navigation with an "Outlet" panel that displays different content based on the selected navigation item
- **Dashboard Page**: Overview of student information and academic progress
- **Employees Management**: Employee records and management interface
- **Students Management**: Student records and enrollment information
- **Courses Management**: Course offerings and scheduling interface
- **Settings Page**: Configuration options for the application

## Architecture

The application implements a React Router-like navigation pattern with:

- **BasePage**: A base UserControl class that all pages inherit from
- **Outlet Panel**: Panel3 serves as the content area that displays different pages
- **Radio Navigation**: Five radio buttons that control which page is displayed
- **Page Lifecycle**: Each page has `OnPageShown()` and `OnPageHidden()` methods for proper initialization and cleanup

## Project Structure

```
Student_Portal/
├── Form1.vb              # Main form with navigation logic
├── Form1.Designer.vb     # Form designer code
├── Pages/
│   ├── BasePage.vb       # Base page class
│   ├── DashboardPage.vb  # Dashboard page implementation
│   ├── EmployeesPage.vb  # Employees management page
│   ├── StudentsPage.vb   # Students management page
│   ├── CoursesPage.vb    # Courses management page
│   └── SettingsPage.vb   # Settings page
└── Components/           # Reusable components
```

## Navigation System

The navigation system works similar to React Router:
- Radio buttons act as navigation links
- Panel3 serves as the Outlet component
- Each radio button corresponds to a different page
- Pages are efficiently managed by showing/hiding them as needed

## Getting Started

1. Clone the repository
2. Open the solution in Visual Studio or use the .NET CLI
3. Build the project: `dotnet build`
4. Run the application: `dotnet run`

## Requirements

- .NET 8.0 or later
- Windows OS (for Windows Forms)

## Technologies Used

- VB.NET
- Windows Forms
- .NET 8.0

## License

[No license specified - project is for educational purposes]