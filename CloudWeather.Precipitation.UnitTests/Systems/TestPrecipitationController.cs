using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudWeather.Precipitation;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace CloudWeather.Precipitation.UnitTests.Systems
{
    public class TestPrecipitationController
    {
        [Fact]
        public void Get_ReturnsSuccessful_StatusCodeIs200()
        {
            // Arrange
            // Act
            var result = (Ok<string>)PrecipitationApi.Get("12345");

            //Assert
            result.StatusCode.Should().Be(200);

        }

        [Fact]
        public void Get_ReturnsSuccessful_ReturnsPassedInZipcode()
        {
            // Arrange
            string zip = "12345";
            // Act
            var result = (Ok<string>)PrecipitationApi.Get(zip);

            //Assert
            result.Value.Should().Be(zip);
        }
    }
}