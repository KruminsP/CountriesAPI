using Countries.Core.Models;

namespace Countries.Core;

public class CountrySelector
{
    public IEnumerable<Country> GetAllOceaniaCountries(ApiResponseCountry[] apiResponse)
    {
        var returnedCountries = apiResponse.Select(country => new Country(
            country.name.Official,
            country.Area,
            country.Population,
            country.Tld,
            country.name.Common,
            country.Capital));

        return returnedCountries;
    }

    public IEnumerable<Country> GetTenPopulousCountries(ApiResponseCountry[] apiResponse)
    {
        var countries = apiResponse
            .Select(country => new Country(
                country.name.Official,
                country.Area,
                country.Population,
                country.Tld,
                country.name.Common,
                country.Capital))
            .OrderByDescending(country => country.Population)
            .Take(10);

        return countries;
    }

    public IEnumerable<CountryWithDensity> GetTenDensestCountries(ApiResponseCountry[] apiResponse)
    {
        var countries = apiResponse
            .Select(country => new CountryWithDensity(
                country.name.Official,
                country.Area,
                country.Population,
                country.Tld,
                country.name.Common,
                country.Capital))
            .OrderByDescending(country => country.Density)
            .Take(10);

        return countries;
    }

    public CountryWithoutName GetCountryByName(string name, ApiResponseCountry[] apiResponse)
    {
        var apiResponseCountry = apiResponse
            .First(item => item.name.Official
                .ToLower()
                .Contains(name.ToLower()));

        var country = new CountryWithoutName(apiResponseCountry.Area,
            apiResponseCountry.Population,
            apiResponseCountry.Tld,
            apiResponseCountry.Capital);

        return country;
    }
}