using CSharpPlaywrightSpecFlow.Pages;
using Microsoft.Playwright;

namespace CSharpPlaywrightSpecFlow.Steps;

/**
 * This class contains SpecFlow steps for adding a product to the shopping cart on a demo e-commerce site.
 */
[Binding]
public sealed class AddProductToCartStepDefinitions
{

    private readonly ScenarioContext _scenarioContext;
    private readonly IPage _page;
    private readonly BasePage _basePage;
    private readonly CartPage _cartPage;
    private readonly HomePage _homePage;
    private readonly ProductPage _productPage;
    private string? _msg;

    public AddProductToCartStepDefinitions(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
        _page = Hooks.Hooks.Page!;
        _basePage = new BasePage(_page);
        _cartPage = new CartPage(_page);
        _homePage = new HomePage(_page);
        _productPage = new ProductPage(_page);
    }


    [Given(@"the user is browsing the list of available products.")]
    public async Task GivenTheUserIsBrowsingTheListOfAvailableProducts()
    {
        await _homePage.VerifyCurrentUrl("https://www.demoblaze.com/");
    }

    [When(@"the user selects a product from the laptops category.")]
    public async Task WhenTheUserSelectsAProductFromTheCategory()
    {
        await _homePage.ClickLaptopsCategoryButton();
        await _homePage.WaitForMacbookButton();
        await _homePage.ClickMacbookButton();
    }

    [When(@"the user adds the selected product to the shopping cart.")]
    public async Task WhenTheUserAddsTheSelectedProductToTheShoppingCart()
    {
        var dialogMessage = new TaskCompletionSource<string>();
        _page.Dialog += (_, dialog) =>
        {
            dialog.AcceptAsync();
            dialogMessage.TrySetResult(dialog.Message);
        };
        await _productPage.WaitForMacbookTitle();
        await _productPage.ClickAddToCart();
        _msg = await dialogMessage.Task;
        _productPage.VerifyAlertSuccessfulAddedToCart(_msg);
    }

    [Then(@"the product should be added to the user's shopping cart.")]
    public async Task ThenTheProductShouldBeAddedToTheUsersShoppingCart()
    {
        await _basePage.ClickCartButton();
        await _cartPage.WaitForMacbookTitleInCart();
        await _cartPage.VerifyMacbookTitleInCart();
    }
}