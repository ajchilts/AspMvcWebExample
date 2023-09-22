using NSpec;
using FluentAssertions;
using AspMvcWebExample.Controllers;
using System.Web.Mvc;

namespace testing_with_nspec
{
    public class ContactContollerSpec : nspec
    {
        void it_asserts_result_is_not_null()
        {
            // Arrange
            ContactController controller = new ContactController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            result.Should().NotBeNull();
        }
    }
}
