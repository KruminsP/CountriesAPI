using Countries.Services;
using FluentAssertions;
using Refit;

namespace Countries.Tests
{
    [TestClass]
    public class ApiResponseTests
    {
        private ICountriesApi _apiResponse;
        
        [TestInitialize]
        public void Setup()
        {
            //Arrange
            _apiResponse = RestService.For<ICountriesApi>("https://restcountries.com");
        }

        [TestMethod]
        public async Task GetAllOceaniaCountries_ResponseNotNull()
        {
            //Act
            var countries = await _apiResponse.GetFullOceaniaCountriesData();

            //Assert
            countries.Should().NotBeNull();
        }

        [TestMethod]
        public async Task GetAllOceaniaCountries_CountryListReturned()
        {
            //Act
            var countries = await _apiResponse.GetFullOceaniaCountriesData();

            //Assert
            countries.Length.Should().Be(27);
        }
    }
}