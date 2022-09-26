using CoffeeShopHRM.Api.Controllers;
using CoffeeShopHRM.App.Services;

namespace CoffeShopHRM.Testing.Api
{
    public class EmployeeControllerTests
    {
        private readonly IEmployeeDataService _employeeDataService;
        public EmployeeControllerTests()
        {
        }

        [Fact]
        public void GetAllEmployees_ReturnNotNull()
        {
            //Arrange
            //Act
            //Assert
            Assert.True(_employeeDataService.GetAllEmployees() is not null);
        }
    }
}
