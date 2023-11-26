using CSharpPlaywrightSpecFlow.Pages;
using CSharpPlaywrightSpecFlow.Utils;
using Microsoft.Playwright;

namespace CSharpPlaywrightSpecFlow.Steps;

/**
 * This class contains SpecFlow steps for user login functionality on the application.
 */
[Binding]
public sealed class LoginStepDefinitions
{

    private readonly ScenarioContext _scenarioContext;
    private readonly IPage _page;
    private readonly BasePage _basePage;
    private string? _username;
    private string? _password;
    private Config? _config;

    public LoginStepDefinitions(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
        _page = Hooks.Hooks.Page!;
        _basePage = new BasePage(_page);
        _config = Hooks.Hooks.Config!;
    }


    [Given(@"the user has signed up with credentials: '(.*)', '(.*)'.")]
    public async Task GivenTheUserHasSignedUpWithCredentials(string user, string pass)
    {
        _username = user;
        _password = pass;
        await _page.GotoAsync(_config!.url!);
    }

    [Given(@"the user is on the Login Page.")]
    public async Task GivenTheUserIsOnTheLoginPage()
    {
        await _basePage.ClickLoginButton();
        await _basePage.WaitForLoginTitle();
        await _basePage.VerifyLoginTitle();
    }

    [When(@"the user inputs their username and password into the form.")]
    public async Task WhenTheUserInputsTheirUsernameAndPasswordIntoTheForm()
    {
        if (_username != null && _password != null)
        {
            await _basePage.EnterLoginUsername(_username);
            await _basePage.EnterLoginPassword(_password);
        }
        else
        {
            throw new NullReferenceException("The _username or password inputs are empty.");
        }

    }

    [When(@"the user clicks on the Submit button.")]
    public async Task WhenTheUserClicksOnTheSubmitButton()
    {
        await _basePage.SubmitLogin();
    }

    [Then(@"the user should be logged in.")]
    public async Task ThenTheUserShouldBeLoggedIn()
    {
        if (_username != null)
        {
            await _basePage.WaitForLoggedInUsername(_username);
            await _basePage.VerifyLoggedInUsername(_username);
        }
        else
        {
            throw new NullReferenceException("The username is null.");
        }
        
    }
}