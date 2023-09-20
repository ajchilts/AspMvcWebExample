using AspMvcWebExample;
using AspMvcWebExample.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace AspMvcWebExample.Tests.Controllers
{
    [TestClass]
    public class IndexControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            IndexController controller = new IndexController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
