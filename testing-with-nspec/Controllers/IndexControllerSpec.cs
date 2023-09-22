using NSpec;
using FluentAssertions;
using AspMvcWebExample.Controllers;
using System.Web.Mvc;

namespace testing_with_nspec
{
    public class IndexContollerSpec : nspec
    {
        void it_asserts_result_is_not_null()
        {
            // Arrange
            IndexController controller = new IndexController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            result.Should().NotBeNull();
        }
    }
}
