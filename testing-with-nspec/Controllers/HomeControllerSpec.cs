using NSpec;
using FluentAssertions;
using AspMvcWebExample.Controllers;
using System.Web.Mvc;

namespace testing_with_nspec
{
    public class HomeContollerSpec : nspec
    {
        void it_asserts_result_is_not_null()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            result.Should().NotBeNull();
        }
    }
}
