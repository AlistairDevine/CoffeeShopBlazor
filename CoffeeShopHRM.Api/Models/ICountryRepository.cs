using CoffeeShopHRM.Shared;
using System.Collections.Generic;

namespace CoffeeShopHRM.Api.Models
{
    public interface ICountryRepository
    {
        IEnumerable<Country> GetAllCountries();
        Country GetCountryById(int countryId);
    }
}