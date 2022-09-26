using index = CoffeeShopHRM.App.Pages.Index;

namespace CoffeShopHRM.Testing.App
{
    public class IndexPageTests : TestContext
    {
        [Fact]
        public void IndexComponentRenders()
        {
            //Arrange
            //using var ctx = new TestContext();

            //Act
            var cut = RenderComponent<index>();

            //Assert
            cut.MarkupMatches("<h1 class=\"page-title\">Welcome to Coffee Shop HRM!</h1><br /><h3>Using this application, you can manage our wonderful staff working for us, bringing people the best coffee!</h3>");
        }
        [Fact]
        public void IndexComponentMarkupRendering()
        {
            //Arrange
            using var ctx = new TestContext();
            //Act
            var cut = ctx.RenderComponent<index>();
            //Assert
            
        }
    }
}
