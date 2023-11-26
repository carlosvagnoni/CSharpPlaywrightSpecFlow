using CSharpPlaywrightSpecFlow.Utils;
using Microsoft.Playwright;

namespace CSharpPlaywrightSpecFlow.Pages;

/**
* ProductPage class represents the product page functionalities and elements for the application.
*/
public class ProductPage : PageObject
{
    public ProductPage(IPage page) : base(page)
    {
    }
    
    // Locators for elements on the page
    private readonly string macbookTitleLocator = "#tbodyid > h2";
    private readonly string addToCartButtonLocator = "#tbodyid > div.row > div > a";

    // Methods to interact with page elements
    public async Task WaitForMacbookTitle()
    {
        await WaitForElementPresent(this.macbookTitleLocator);
    }
    
    public async Task ClickAddToCart()
    {
        await ClickElement(this.addToCartButtonLocator);
    }

    public void VerifyAlertSuccessfulAddedToCart(string msg)
    {
        VerifyTextAlert(msg, "Product added.");
    }
}