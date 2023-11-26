using CSharpPlaywrightSpecFlow.Utils;
using Microsoft.Playwright;

namespace CSharpPlaywrightSpecFlow.Pages;

/**
 * Class representing the header and footer of the application.
 */
public class BasePage : PageObject
{
    public BasePage(IPage page) : base(page)
    {
    }
    
    // Locators for elements on the page
    private readonly string signupButtonLocator = "#signin2";
    private readonly string signupTitleLocator = "#signInModalLabel";
    private readonly string loginButtonLocator = "#login2";
    private readonly string loginTitleLocator = "#logInModalLabel";
    private readonly string signupUsernameInputLocator = "#sign-username";
    private readonly string signupPasswordInputLocator = "#sign-password";
    private readonly string loginUsernameInputLocator = "#loginusername";
    private readonly string loginPasswordInputLocator = "#loginpassword";
    private readonly string submitSignupButtonLocator = "#signInModal > div > div > div.modal-footer > button.btn.btn-primary";
    private readonly string submitLoginButtonLocator = "#logInModal > div > div > div.modal-footer > button.btn.btn-primary";
    private readonly string loggedInUsernameLocator = "#nameofuser";
    private readonly string cartButtonLocator = "#cartur";

    // Methods to interact with page elements
    public async Task ClickSignupButton()
    {
        await ClickElement(this.signupButtonLocator);
    }

    public async Task WaitForSignupTitle()
    {
        await WaitForElementBeVisible(signupTitleLocator);
    }
    
    public async Task VerifySignupTitle()
    {
        await VerifyElementInnerText(this.signupTitleLocator, "Sign up");
    }
    
    public async Task ClickLoginButton()
    {
        await ClickElement(this.loginButtonLocator);
    }
    
    public async Task WaitForLoginTitle()
    {
        await WaitForElementBeVisible(loginTitleLocator);
    }
    
    public async Task VerifyLoginTitle()
    {
        await VerifyElementInnerText(this.loginTitleLocator, "Log in");
    }

    public async Task EnterLoginUsername(string text)
    {
        await EnterText(this.loginUsernameInputLocator, text);
    }
    
    public async Task EnterLoginPassword(string text)
    {
        await EnterText(this.loginPasswordInputLocator, text);
    }
    
    public async Task EnterSignupUsername(string text)
    {
        await EnterText(this.signupUsernameInputLocator, text);
    }
    
    public async Task EnterSignupPassword(string text)
    {
        await EnterText(this.signupPasswordInputLocator, text);
    }

    public async Task VerifyEnteredCredentials(string username, string password)
    {
        await VerifyElementTextValue(this.signupUsernameInputLocator, username);
        await VerifyElementTextValue(this.signupPasswordInputLocator, password);
    }

    public async Task SubmitSignup()
    {
        await ClickElement(this.submitSignupButtonLocator);
    }

    public void VerifyAlertSuccessfulSignup(string msg)
    {
        VerifyTextAlert(msg, "Sign up successful.");
    }
    
    public async Task SubmitLogin()
    {
        await ClickElement(this.submitLoginButtonLocator);
    }

    public async Task WaitForLoggedInUsername(string username)
    {
        await WaitForElementToDisappear(this.loginTitleLocator);
        await WaitForElementInnerTextToBe(this.loggedInUsernameLocator, $@"Welcome {username}");
    }

    public async Task VerifyLoggedInUsername(string username)
    {
        await VerifyElementInnerText(this.loggedInUsernameLocator, $@"Welcome {username}");
    }
    
    public async Task ClickCartButton()
    {
        await ClickElement(this.cartButtonLocator);
    }
    
}