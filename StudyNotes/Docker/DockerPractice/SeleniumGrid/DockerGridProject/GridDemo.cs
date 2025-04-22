using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium;

namespace DockerGridProject
{
    [TestFixture]
    public class SeleniumGridPractice
    {
        IWebDriver driver;
        ChromeOptions options;
        FirefoxOptions firefoxOptions;

        [SetUp]
        public void Setup()
        {
            options = new ChromeOptions();
            firefoxOptions = new FirefoxOptions();
            options.AddAdditionalOption("selenoid:options", new Dictionary<string, object>
            {
                ["enableVNC"] = true,
                ["enableVideo"] = true
            });
        }

        [Test]
        public void Test1()
        {
            driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), options);
            Thread.Sleep(3000);
            driver.Navigate().GoToUrl("https://www.youtube.com/");
            Thread.Sleep(5000);
            Console.WriteLine(driver.Url);
            Console.WriteLine(driver.Title);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Dispose();
        }
    }
}