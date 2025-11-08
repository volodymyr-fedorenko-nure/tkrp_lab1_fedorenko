using Web.Controllers;

namespace Tests;

public class WeatherForecastTest
{
    [Fact]
    public void Test()
    {
        var controller = new WeatherForecastController();
        var result = controller.Get();
        Assert.Equal(5, result.Count());
    }
}