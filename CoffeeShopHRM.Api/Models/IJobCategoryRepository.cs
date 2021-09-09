using CoffeeShopHRM.Shared;
using System.Collections.Generic;

namespace CoffeeShopHRM.Api.Models
{
    public interface IJobCategoryRepository
    {
        IEnumerable<JobCategory> GetAllJobCategories();
        JobCategory GetJobCategoryById(int JobCategoryId);
    }
}