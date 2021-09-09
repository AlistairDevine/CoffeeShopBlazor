using CoffeeShopHRM.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopHRM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : Controller
    {
        private readonly ICountryRepository _countryRepository;

        public CountryController(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        //GET: api/Country
        [HttpGet]
        public IActionResult GetCountries()
        {
            return Ok(_countryRepository.GetAllCountries());
        }

        //GET: api/Country/5
        [HttpGet("{id}")]
        public IActionResult GetCountryById(int id)
        {
            return Ok(_countryRepository.GetCountryById(id));
        }
    }
}
