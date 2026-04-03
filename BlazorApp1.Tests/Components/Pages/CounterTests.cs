using BlazorApp1.Components.Pages;
using Bunit;

namespace BlazorApp1.Tests.Components.Pages;

public class CounterTests : BunitContext
{
    [Fact]
    public void WhenButtonIsClicked_ThenCounterShouldIncrement()
    {
        var cut = Render<Counter>();
        cut.Find("button").Click();
        cut.Find("p").MarkupMatches("<p role=\"status\">Current count: 1</p>");
    }
}