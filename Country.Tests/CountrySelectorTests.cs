using Countries.Core;
using Countries.Tests.Props;
using FluentAssertions;

namespace Countries.Tests;

public class CountrySelectorTests
{
    [TestClass]
    public class ApiResponseTests
    {
        private CountrySelector _countrySelector;
        private CountryProps _props;

        [TestInitialize]
        public void Setup()
        {
            _props = new CountryProps();
            _countrySelector = new CountrySelector();
        }

        [TestMethod]
        public void GetAllOceaniaCountries_ProvideApiResponse_ReturnsCountries()
        {
            //Arrange
            var countries = _props.GetCountries(20);
            var response = _props.GetApiResponse(20).ToArray();

            //Act
            var selectedCounties = _countrySelector.GetAllOceaniaCountries(response);

            //Assert
            selectedCounties.Should().BeEquivalentTo(countries);
        }

        [TestMethod]
        public void GetTenPopulousCountries_ProvideApiResponse_ReturnsCountries()
        {
            //Arrange
            var response = _props.GetApiResponse(20).ToArray();

            //Act
            var selectedCounties = _countrySelector.GetTenPopulousCountries(response);

            //Assert
            selectedCounties.Count().Should().Be(10);
            selectedCounties.First().Population.Should().Be(20);
            selectedCounties.Last().Population.Should().Be(11);
        }

        [TestMethod]
        public void GetTenDensestCountries_ProvideApiResponse_ReturnsCountries()
        {
            //Arrange
            var countries = _props.GetCountriesWithDensity(10);
            var response = _props.GetApiResponse(10).ToArray();

            //Act
            var selectedCounties = _countrySelector.GetTenDensestCountries(response);

            //Assert
            selectedCounties.Should().BeEquivalentTo(countries);
        }

        [TestMethod]
        public void GetCountryByName_ProvideApiResponse_ReturnsCountry()
        {
            //Arrange
            var country = _props.GetCountryWithoutName(1);
            var response = _props.GetApiResponse(10).ToArray();

            //Act
            var selectedCountry = _countrySelector.GetCountryByName("official 1", response);

            //Assert
            selectedCountry.Should().BeEquivalentTo(country);
        }
    }
}
