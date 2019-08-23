using GoogleProject.Pages;
using NUnit.Framework;

namespace GoogleProject.Test
{
    [TestFixture]
    public class GoogleTest
    {
        private Application _application;

        [SetUp]
        public void SetUp()
        {
            _application = new Application();
        }

        [TearDown]
        public void TearDown()
        {
            _application.CloseApplication();
        }

        [TestCase("Java", "Java | Oracle")]
        public void SearchTest(string searchText, string expectedResult)
        {
            //Arrange
            var mainPage = _application.OpenApplication();
            //Act
            string actualResult = mainPage.SetSearchBoxAndClickButton(searchText).GetTitleTextLink(expectedResult);
            //Assert
            Assert.AreEqual(expectedResult, actualResult, "Test Fail");
        }
    }
}
