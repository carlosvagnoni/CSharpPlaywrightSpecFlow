using CSharpPlaywrightSpecFlow.Utils;
using Microsoft.Playwright;

namespace CSharpPlaywrightSpecFlow.Pages;

/**
 * CartPage class represents the cart page functionalities and elements for the application.
 */
public class CartPage : PageObject
{
    public CartPage(IPage page) : base(page)
    {
    }
    
    // Locators for elements on the page
    private readonly string macbookTitleInCartLocator = "table > tbody > tr:first-child > td:nth-child(2)";

    // Methods to interact with page elements
    public async Task WaitForMacbookTitleInCart()
    {
        await WaitForElementInnerTextToBe(this.macbookTitleInCartLocator, "MacBook air");
    }
    
    public async Task VerifyMacbookTitleInCart()
    {
        await VerifyElementInnerText(this.macbookTitleInCartLocator, "MacBook air");
    }
}