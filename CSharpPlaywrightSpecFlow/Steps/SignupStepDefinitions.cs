using CSharpPlaywrightSpecFlow.Pages;
using CSharpPlaywrightSpecFlow.Utils;
using Microsoft.Playwright;

namespace CSharpPlaywrightSpecFlow.Steps;

/**
 * This class contains SpecFlow steps for user registration on the application.
 */
[Binding]
public sealed class SignupStepDefinitions
{
    private readonly ScenarioContext _scenarioContext;
    private readonly IPage _page;
    private readonly BasePage _basePage;
    private string? _username;
    private string? _password;
    private string? _msg;
    private readonly Config? _config;

    public SignupStepDefinitions(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
        _page = Hooks.Hooks.Page!;
        _basePage = new BasePage(_page);
        _config = Hooks.Hooks.Config!;
    }

    [Given(@"the user is on the Registration Page.")]
    public async Task GivenTheUserIsOnTheRegistrationPage()
    {
        await _page.GotoAsync(_config!.url!);
        await _basePage.ClickSignupButton();
        await _basePage.WaitForSignupTitle();
        await _basePage.VerifySignupTitle();
    }

    [When(@"the user provides the following registration details: '(.*)', '(.*)'.")]
    public async Task WhenTheUserProvidesTheFollowingRegistrationDetails(string user, string pass)
    {
        _username = user;
        _password = pass;
        await _basePage.EnterSignupUsername(_username);
        await _basePage.EnterSignupPassword(_password);
        await _basePage.VerifyEnteredCredentials(_username, _password);
    }

    [When(@"the user clicks on the Sign Up button.")]
    public async Task WhenTheUserClicksOnTheSignUpButton()
    {
        var dialogMessage = new TaskCompletionSource<string>();
        _page.Dialog += (_, dialog) =>
        {
            dialog.AcceptAsync();
            dialogMessage.TrySetResult(dialog.Message);
        };
        await _basePage.SubmitSignup();
        _msg = await dialogMessage.Task;
    }

    [Then(@"the user should be registered successfully.")]
    public void ThenTheUserShouldBeRegisteredSuccessfully()
    {
        if (_msg != null)
        {
            _basePage.VerifyAlertSuccessfulSignup(_msg);
        }
        else
        {
            throw new NullReferenceException("The msg is null.");
        }
    }
}