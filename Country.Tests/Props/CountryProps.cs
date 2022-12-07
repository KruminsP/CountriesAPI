using Countries.Core.Models;

namespace Countries.Tests.Props;

public class CountryProps
{
    public IEnumerable<ApiResponseCountry> GetApiResponse(int amount)
    {
        var response = new List<ApiResponseCountry>();

        for (int i = 1; i <= amount; i++)
        {
            response.Add(
                new ApiResponseCountry
                {
                    Area = i,
                    Capital = new List<string> { $"capital {i}" },
                    name = new Name { Common = $"common {i}", Official = $"official {i}" },
                    Tld = new List<string> { $"tld {i}" },
                    Population = i
                });
        }

        return response;
    }

    public IEnumerable<Country> GetCountries(int amount)
    {
        var countries = new List<Country>();

        for (int i = 1; i <= amount; i++)
        {
            countries.Add(new Country(
                $"official {i}",
                i,
                i,
                new List<string> { $"tld {i}" },
                $"common {i}",
                new List<string> { $"capital {i}" }));
        }

        return countries;
    }

    public IEnumerable<CountryWithDensity> GetCountriesWithDensity(int amount)
    {
        var countries = new List<CountryWithDensity>();

        for (int i = 1; i <= amount; i++)
        {
            countries.Add(new CountryWithDensity(
                $"official {i}",
                i,
                i,
                new List<string> { $"tld {i}" },
                $"common {i}",
                new List<string> { $"capital {i}" }));
        }

        return countries;
    }

    public CountryWithoutName GetCountryWithoutName(int amount)
    {
        return new CountryWithoutName(
            amount, amount, new List<string> { $"tld {amount}" }, new List<string> { $"capital {amount}" }
        );
    }
}