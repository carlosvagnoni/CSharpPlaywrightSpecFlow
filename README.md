# Automated Web Testing with C#, Playwright, and SpecFlow
![Static Badge](https://img.shields.io/badge/C%23-logo?style=for-the-badge&logo=c%23&logoColor=rgb(151%2C%2020%2C%20190)&labelColor=white&color=rgb(22%2C%2027%2C%2034))
![Static Badge](https://img.shields.io/badge/Playwright-logo?style=for-the-badge&logo=playwright&logoColor=rgb(214%2C%2083%2C%2072)&labelColor=rgb(46%2C%20173%2C%2051)&color=rgb(22%2C%2027%2C%2034))
![Static Badge](https://img.shields.io/badge/SpecFlow-logo?style=for-the-badge&logo=cucumber&logoColor=black&labelColor=rgb(35%2C%20217%2C%20108)&color=rgb(22%2C%2027%2C%2034))

This project offers a framework and tools for automated web testing using C#, Playwright, and SpecFlow, following Behavior-Driven Development (BDD) best practices and employing the Page Object Model design pattern.

## Testing demoblaze.com Features 🧪

This suite of tests is specifically designed to validate and test features on the [demoblaze.com](https://www.demoblaze.com) website. You'll find feature files under the `Features` directory related to signup, login and adding products to the cart.

![csharp2](https://github.com/carlosvagnoni/CSharpPlaywrightSpecFlow/assets/106275103/d08b936f-0700-4e3d-8c54-b4815d910489)

## Table of Contents 📑
- [Requirements](#requirements)
- [Folder Structure](#folder-structure)
- [Installation](#installation)
- [Configuration](#configuration)
- [Test Execution](#test-execution)
- [Contact](#contact)

## <a id="requirements">Requirements 📋</a>

- .NET SDK 6.0.417
- SpecFlow.NUnit: 3.9.22
- Microsoft.Playwright: 1.40.0
- SpecFlow.Allure: 3.5.0.73

## <a id="folder-structure">Folder Structure 📂</a>

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

## <a id="installation">Installation 🛠️</a>

1. Clone this repository:

    ```bash
    git clone https://github.com/carlosvagnoni/CSharpPlaywrightSpecFlow.git
    cd CSharpPlaywrightSpecFlow
    ```

2. Install dependencies:

    ```bash
    dotnet restore
    ```

## <a id="configuration">Configuration ⚙️</a>

- Make sure you have a browser installed and configured in the script (Chrome, Firefox, or Safari).
- You can configure the config.json file to adjust parameters such as the base URL(url) and browser.

## <a id="test-execution">Test Execution ▶️</a>

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

## <a id="contact">Contact 📧</a>

If you have any questions or suggestions, feel free to contact me through my social media accounts.

Thank you for your interest in this project!
