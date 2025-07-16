using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestPage
{
    public class Tests
    {
        // Create the necessary instances
        private IWebDriver driver;
        private Form form;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("C:\\Users\\aandr\\source\\repos\\dotnetautomation\\Practice\\TestPage\\TestPage\\testpage.html");
            driver.Manage().Window.Maximize();
            form = new Form(driver);
        }

        [Test]
        public void FillForm()
        {
            Thread.Sleep(2000);
            form.EnterCredentials("Andre", "Dragu");
            Thread.Sleep(2000);
            form.SelectCountry(true, "ro");
            Thread.Sleep(2000);
            form.SelectLanguagesCheckbox(["English", "German", "Romanian" ]);
            Thread.Sleep(2000);
            form.SelectLanguagesMulti(true, ["english", "german", "romanian"]);
            Thread.Sleep(2000);
            form.SubmitForm();
        }

        [TearDown] 
        public void TearDown()
        {
            driver.Dispose();
        }
    }
}