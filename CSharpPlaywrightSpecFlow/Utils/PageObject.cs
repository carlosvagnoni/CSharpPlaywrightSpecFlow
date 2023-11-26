using Microsoft.Playwright;
using NUnit.Framework;

namespace CSharpPlaywrightSpecFlow.Utils;

/*
Class acting as a wrapper for Playwright actions.
It encapsulates common actions performed on a Page object.
Each method represents a specific action such as clicking elements, waiting for elements,
verifying text, handling alerts, and interacting with elements on a web page.
*/
public class PageObject
{
    private readonly IPage _page;

    public PageObject(IPage page)
    {
        _page = page;
    }

    public async Task ClickElement(string elementLocator)
    {
        await _page.Locator(elementLocator).ClickAsync();
    }

    public async Task WaitForElementBeVisible(string elementLocator)
    {
        await _page.Locator(elementLocator).WaitForAsync(new LocatorWaitForOptions
        {
            State = WaitForSelectorState.Visible
        });
    }
    
    public async Task WaitForElementPresent(string elementLocator)
    {
        await _page.Locator(elementLocator).WaitForAsync(new LocatorWaitForOptions
        {
            State = WaitForSelectorState.Attached
        });
    }

    public async Task WaitForElementToDisappear(string elementLocator)
    {
        await _page.Locator(elementLocator).WaitForAsync(new LocatorWaitForOptions
        {
            State = WaitForSelectorState.Hidden
        });
    }

    public async Task WaitForElementInnerTextToBe(string elementLocator, string expectedText)
    {
        int attempts = 0;
        string currentText = "";
        while (attempts < 10 && currentText != expectedText)
        {
            currentText = await _page.Locator(elementLocator).InnerTextAsync();

            if (currentText != expectedText)
            {
                await _page.WaitForTimeoutAsync(500);
                attempts++;
            }
        }

        if (currentText != expectedText)
        {
            throw new TimeoutException();
        }
    }
    
    public async Task VerifyElementInnerText(string elementLocator, string expectedText)
    {
        await Assertions.Expect(_page.Locator(elementLocator)).ToHaveTextAsync(expectedText);
    }
    
    public async Task VerifyElementTextValue(string elementLocator, string expectedText)
    {
        await Assertions.Expect(_page.Locator(elementLocator)).ToHaveValueAsync(expectedText);
    }

    public void VerifyTextAlert(string msg, string expectedText)
    {
        Assert.AreEqual(msg, expectedText);
    }

    public async Task EnterText(string elementLocator, string text)
    {
        await _page.Locator(elementLocator).FillAsync(text);
    }

    public async Task VerifyCurrentUrl(string expectedUrl)
    {
        await Assertions.Expect(_page).ToHaveURLAsync(expectedUrl);
    }
}
