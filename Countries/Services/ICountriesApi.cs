using Countries.Core.Models;
using Refit;

namespace Countries.Services;

public interface ICountriesApi
{
    [Get("/v3.1/region/oceania")]
    Task<ApiResponseCountry[]> GetFullOceaniaCountriesData();
}