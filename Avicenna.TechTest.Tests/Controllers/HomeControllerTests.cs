using System.Collections.Generic;
using System.Threading.Tasks;
using Avicenna.TechTest.Controllers;
using Avicenna.TechTest.Models;
using Avicenna.TechTest.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;

namespace Avicenna.TechTest.Tests.Controllers
{
    public class HomeControllerTests
    {
        [Test]
        public async Task Index_ReturnsAllPharmacies()
        {
            // Arrange
            var pharmacyList = new List<PharmacyViewModel>()
            {
                new PharmacyViewModel()
                {
                    Id = "abc",
                    BusinessName = "Test Pharmacy 1"
                },
                new PharmacyViewModel()
                {
                    Id = "def",
                    BusinessName = "Test Pharmacy 2"
                }
            };

            // Act
            var apiClient = new Mock<IAvicennaApiClient>();
            apiClient.Setup(c => c.GetPharmacies()).ReturnsAsync(pharmacyList);
            var controller = new HomeController(apiClient.Object);

            // Assert
            var result = await controller.Index() as ViewResult;
            Assert.IsInstanceOf<ViewResult>(result);
            IEnumerable<PharmacyViewModel> model = result.ViewData.Model as IEnumerable<PharmacyViewModel>;
            // Replace with test for API client being called and checking results
            Assert.AreEqual(true, false);
        }
    }
}
