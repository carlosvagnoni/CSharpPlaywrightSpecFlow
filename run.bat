@echo off

echo Compiling the project...
rmdir /s /q CSharpPlaywrightSpecFlow\bin\Debug
dotnet clean
dotnet build

echo Running Tests...
dotnet test

echo Generating Allure reports...
allure serve CSharpPlaywrightSpecFlow\bin\Debug\net6.0\allure-results

