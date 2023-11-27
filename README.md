# Automated Web Testing with C#, Playwright, and SpecFlow 🤖🅲#🎭

This project provides a structure and tools for automated web testing using C#, Playwright, and SpecFlow, following Behavior-Driven Development (BDD) best practices and employing the Page Object Model design pattern.

## Testing demoblaze.com Features 🧪

This suite of tests is specifically designed to validate and test features on the [demoblaze.com](https://www.demoblaze.com) website. You'll find feature files under the `Features` directory related to signup, login and adding products to the cart.

![csharp2](https://github.com/carlosvagnoni/CSharpPlaywrightSpecFlow/assets/106275103/d08b936f-0700-4e3d-8c54-b4815d910489)

## Table of Contents 📑
- [Requirements](#requirements-)
- [Folder Structure](#folder-structure-)
- [Installation](#installation-)
- [Configuration](#configuration-)
- [Test Execution](#test-execution-)
- [Contact](#contact-)

## Requirements 📋

- .NET SDK 6.0.417
- SpecFlow.NUnit: 3.9.22
- Microsoft.Playwright: 1.40.0
- SpecFlow.Allure: 3.5.0.73

## Folder Structure 📂

- **CSharpPlaywrightSpecFlow.sln:** Solution file for the C# project.
- **run.bat:** Script file specifically designed for execution in Windows environments.

### Directory "CSharpPlaywrightSpecFlow"

- **config.json:** Configuration file for variable data.
- **CSharpPlaywrightSpecFlow.csproj:** C# project file.
- **specflow.json:** Configuration file for SpecFlow.

- **Drivers:** Directory for driver-related code.
  - **Driver.cs:** Driver implementation.

- **Features:** Directory for feature files.

- **Hooks:** Directory for SpecFlow hooks.

- **Pages:** Directory for Page Object Model classes.

- **Steps:** Directory for SpecFlow step definitions.

- **Utils:** Directory for utility classes.
  - **Config.cs:** Utility class for configuration settings.
  - **PageObject.cs:** Class acting as a wrapper for Playwright actions.

## Installation 🛠️

1. Clone this repository:

    ```bash
    git clone https://github.com/carlosvagnoni/CSharpPlaywrightSpecFlow.git
    cd CSharpPlaywrightSpecFlow
    ```

2. Install dependencies:

    ```bash
    dotnet restore
    ```

## Configuration ⚙️

- Make sure you have a browser installed and configured in the script (Chrome, Firefox, or Safari).
- You can configure the config.json file to adjust parameters such as the base URL(url) and browser.

## Test Execution ▶️

Run all the tests:

```bash
dotnet test
```

Open report:

```bash
allure serve CSharpPlaywrightSpecFlow\bin\Debug\net6.0\allure-results
```

**NOTE:**

- Set up the respective environment variables beforehand.
- On Windows environments, you can directly execute the `run.bat` file.

## Contact 📧

If you have any questions or suggestions, feel free to contact me through my social media accounts.

Thank you for your interest in this project!
