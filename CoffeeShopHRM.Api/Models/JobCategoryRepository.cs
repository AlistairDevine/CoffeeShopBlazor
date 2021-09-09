using CoffeeShopHRM.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopHRM.Api.Models
{
    public class JobCategoryRepository : IJobCategoryRepository
    {
        private readonly AppDbContext _appDbContext;

        public JobCategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<JobCategory> GetAllJobCategories()
        {
            return _appDbContext.JobCategories;
        }

        public JobCategory GetJobCategoryById(int JobCategoryId)
        {
            return _appDbContext.JobCategories.FirstOrDefault(j => j.JobCategoryId == JobCategoryId);
        }
    }
}
