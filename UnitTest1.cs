using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace TestWeb
{
    [TestClass]
    public class TestLogin
    {
       // IWebDriver driver1 = new ChromeDriver();

        public bool Is { get; private set; }

        [TestMethod]
        public void Login()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://localhost:5000";

            driver.FindElement(By.Id("Name")).SendKeys("user");
            driver.FindElement(By.Id("Password")).SendKeys("user");
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.LinkText("All Products")).Click();
        }
        [TestMethod]
        public void Create()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://localhost:5000";
            driver.FindElement(By.Id("Name")).SendKeys("user");
            driver.FindElement(By.Id("Password")).SendKeys("user");
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.LinkText("All Products")).Click();
            driver.FindElement(By.Id("Name")).SendKeys("user");
            driver.FindElement(By.Id("Password")).SendKeys("user");
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.LinkText("All Products")).Click();
      
            //driver.FindElement(By.CssSelector(".btn")).Click();
               driver.FindElement(By.LinkText("Back to home page")).Click();
            //   IWebElement createenewButton = driver.FindElement(By.LinkText("Create new"));
            //   createenewButton.Click();
            //  driver.FindElement(By.LinkText("Create new")).Click();
            driver.FindElement(By.Id("ProductName")).Click();
            driver.FindElement(By.Id("ProductName")).SendKeys("fish");
            driver.FindElement(By.Id("CategoryId")).Click();
            {
                var dropdown = driver.FindElement(By.Id("CategoryId"));
                dropdown.FindElement(By.XPath("//option[. = 'Seafood']")).Click();
            }
            driver.FindElement(By.Id("CategoryId")).Click();
            driver.FindElement(By.Id("SupplierId")).Click();
            {
                var dropdown = driver.FindElement(By.Id("SupplierId"));
                dropdown.FindElement(By.XPath("//option[. = 'Leka Trading']")).Click();
            }
            driver.FindElement(By.Id("SupplierId")).Click();
            driver.FindElement(By.Id("UnitPrice")).Click();
            driver.FindElement(By.Id("UnitPrice")).SendKeys("163");
            driver.FindElement(By.Id("QuantityPerUnit")).Click();
            driver.FindElement(By.Id("QuantityPerUnit")).SendKeys("10 in");
            driver.FindElement(By.Id("UnitsInStock")).Click();
            driver.FindElement(By.Id("UnitsInStock")).SendKeys("66");
            driver.FindElement(By.Id("UnitsOnOrder")).Click();
            driver.FindElement(By.Id("UnitsOnOrder")).SendKeys("2");
            driver.FindElement(By.Id("ReorderLevel")).Click();
            driver.FindElement(By.Id("ReorderLevel")).SendKeys("3");
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.LinkText("fish")).Click();
        }

    }


