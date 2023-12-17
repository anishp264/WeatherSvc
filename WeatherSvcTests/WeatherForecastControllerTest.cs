using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherSvcApi.Controllers;

namespace WeatherSvcTests
{
    public class WeatherForecastControllerTest
    {
        [Fact]
        public void WeatherForecastEndpoint_exists()
        {
            var controller = new WeatherForecastController();
            var weatherForecasts = controller.Get();
            if (weatherForecasts is not null)
            {
                Assert.True(weatherForecasts.Any());
            }
            //Assert.IsType<OkResult>(weatherForecasts);
            Assert.False(false);
        }
    }
}
