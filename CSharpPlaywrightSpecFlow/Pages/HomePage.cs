using CSharpPlaywrightSpecFlow.Utils;
using Microsoft.Playwright;

namespace CSharpPlaywrightSpecFlow.Pages;

/**
 * HomePage class represents the home page functionalities and elements for the application.
 */
public class HomePage : PageObject
{
    public HomePage(IPage page) : base(page)
    {
    }
    
    // Locators for elements on the page
    private readonly string laptopsCategoryButtonLocator = "div:nth-of-type(1) > a#itemc.list-group-item:nth-of-type(3)";
    private readonly string macbookButtonLocator = "#tbodyid > div:nth-child(3) > div > div > h4 > a";

    // Methods to interact with page elements
    public async Task ClickLaptopsCategoryButton()
    {
        await ClickElement(this.laptopsCategoryButtonLocator);
    }

    public async Task WaitForMacbookButton()
    {
        await WaitForElementInnerTextToBe(this.macbookButtonLocator, "MacBook air");
    }
    
    public async Task ClickMacbookButton()
    {
        await ClickElement(this.macbookButtonLocator);
    }
}