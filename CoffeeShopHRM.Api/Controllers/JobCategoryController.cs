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
    public class JobCategoryController : Controller
    {
        private readonly JobCategoryRepository _jobCategoryRepository;

        public JobCategoryController(JobCategoryRepository jobCategoryRepository)
        {
            _jobCategoryRepository = jobCategoryRepository;
        }

        //GET: api/JobCategory
        [HttpGet]
        public IActionResult GetJobCategories()
        {
            return Ok(_jobCategoryRepository.GetAllJobCategories());
        }

        //GET: api/JobCategory/5
        [HttpGet("{id}")]
        public IActionResult GetJobCategoryById(int id)
        {
            return Ok(_jobCategoryRepository.GetJobCategoryById(id));
        }
    }
}
