using Countries.Controllers;
using Countries.Core;
using Countries.Services;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Refit;

namespace Countries.Tests;

[TestClass]
public class ControllerTests
{
    private CountryController _countryController;
    private ICountriesApi _countriesApi;

    [TestInitialize]
    public void Setup()
    {
        //Arrange
        _countriesApi = RestService.For<ICountriesApi>("https://restcountries.com");
        _countryController = new CountryController(new CountrySelector(), _countriesApi);
    }

    [TestMethod]
    public async Task GetAllOceaniaCountries_ResponseNotNull()
    {
        //Act
        var result = await _countryController.GetAllOceaniaCountries();
        var okResult = result as OkObjectResult;

        //Assert
        okResult.StatusCode.Should().Be(200);
        okResult.Value.Should().NotBeNull();
    }

    [TestMethod]
    public async Task GetTenPopulousCountries_ResponseNotNull()
    {
        //Act
        var result = await _countryController.GetTenPopulousCountries();
        var okResult = result as OkObjectResult;

        //Assert
        okResult.StatusCode.Should().Be(200);
        okResult.Value.Should().NotBeNull();
    }

    [TestMethod]
    public async Task GetTenDensestCountries_ResponseNotNull()
    {
        //Act
        var result = await _countryController.GetTenDensestCountries();
        var okResult = result as OkObjectResult;

        //Assert
        okResult.StatusCode.Should().Be(200);
        okResult.Value.Should().NotBeNull();
    }

    [TestMethod]
    public async Task GetCountryByName_ResponseNotNull()
    {
        //Act
        var result = await _countryController.GetCountryByName("tuvalu");
        var okResult = result as OkObjectResult;

        //Assert
        okResult.StatusCode.Should().Be(200);
        okResult.Value.Should().NotBeNull();
    }
}