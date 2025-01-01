using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SampleNUnitTestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.google.in");
            Console.WriteLine("Sample code 1");
            Console.WriteLine("Sample code 2");
        }
    }
}