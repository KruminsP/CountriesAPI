using Countries.Core;
using Countries.Services;
using Microsoft.AspNetCore.Mvc;
using Refit;

namespace Countries.Controllers
{
    [Route("countries")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly CountrySelector _countrySelector;
        private readonly ICountriesApi _apiResponse;

        public CountryController(CountrySelector countrySelector, ICountriesApi countriesApi)
        {
            _countrySelector = countrySelector;
            _apiResponse = countriesApi;
        }

        [Route("oceania")]
        [HttpGet]
        public async Task<IActionResult> GetAllOceaniaCountries()
        {
            var apiResponse = await _apiResponse.GetFullOceaniaCountriesData();
            var countries = _countrySelector.GetAllOceaniaCountries(apiResponse);

            return Ok(countries);
        }

        [Route("top10populated")]
        [HttpGet]
        public async Task<IActionResult> GetTenPopulousCountries()
        {
            var apiResponse = await _apiResponse.GetFullOceaniaCountriesData();
            var countries = _countrySelector.GetTenPopulousCountries(apiResponse);

            return Ok(countries);
        }

        [Route("top10dense")]
        [HttpGet]
        public async Task<IActionResult> GetTenDensestCountries()
        {
            var apiResponse = await _apiResponse.GetFullOceaniaCountriesData();
            var countries = _countrySelector.GetTenDensestCountries(apiResponse);

            return Ok(countries);
        }

        [Route("{name}")]
        [HttpGet]
        public async Task<IActionResult> GetCountryByName(string name)
        {
            var apiResponseCountry = await _apiResponse
                .GetFullOceaniaCountriesData();
            var country = _countrySelector.GetCountryByName(name, apiResponseCountry);

            return Ok(country);
        }
    }
}
