using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestWeb
{
    [TestClass]
    public class TestNwapp
    {
        //test
        IWebDriver driver = new ChromeDriver();

        public bool Is { get; private set; }

        [TestMethod]
        public void Addproduct_app()
        {
           
            driver.Url = "http://localhost:5000";

            driver.FindElement(By.Id("Name")).SendKeys("user");
            driver.FindElement(By.Id("Password")).SendKeys("user");
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.LinkText("All Products")).Click();

            driver.FindElement(By.LinkText("Create new")).Click();
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
       
        }

        [TestMethod]
        public void Productcheck_app()
        {   //proverka
            driver.Url = "http://localhost:5000";
            driver.FindElement(By.Id("Name")).SendKeys("user");
            driver.FindElement(By.Id("Password")).SendKeys("user");
            driver.FindElement(By.CssSelector(".btn")).Click();

       
            driver.FindElement(By.LinkText("All Products")).Click();
            driver.FindElement(By.LinkText("fish")).Click();
            string valueProductName = driver.FindElement(By.Id("ProductName")).GetAttribute("value");
            Assert.AreEqual(valueProductName, "fish", "элемент не найден"); //равны ли два элемента
            string elementCategoryId = driver.FindElement(By.CssSelector("#CategoryId > option:nth-child(9)")).GetAttribute("text"); ;
            Assert.AreEqual(elementCategoryId, "Seafood", "элемент не найден");
            string elementSupplierId = driver.FindElement(By.CssSelector("#SupplierId > option:nth-child(21)")).GetAttribute("text"); ;
            Assert.AreEqual(elementSupplierId, "Leka Trading", "элемент не найден");
            string valueUnitPrice = driver.FindElement(By.Id("UnitPrice")).GetAttribute("value");
            Assert.AreEqual(valueUnitPrice, "163,0000", "элемент не найден");
            string valueQuantityPerUnit = driver.FindElement(By.Id("QuantityPerUnit")).GetAttribute("value");
            Assert.AreEqual(valueQuantityPerUnit, "10 in", "элемент не найден");
            string valueUnitsInStock = driver.FindElement(By.Id("UnitsInStock")).GetAttribute("value");
            Assert.AreEqual(valueUnitsInStock, "66", "элемент не найден");
            string valueUnitsOnOrder = driver.FindElement(By.Id("UnitsOnOrder")).GetAttribute("value");
            Assert.AreEqual(valueUnitsOnOrder, "2", "элемент не найден");
            string valueReorderLevel = driver.FindElement(By.Id("ReorderLevel")).GetAttribute("value");
            Assert.AreEqual(valueReorderLevel, "3", "элемент не найден");
            driver.FindElement(By.LinkText("All Products")).Click();
        }


        [TestMethod]
        public void Deleteproduct_app()
        {
            driver.Url = "http://localhost:5000";
            driver.FindElement(By.Id("Name")).SendKeys("user");
            driver.FindElement(By.Id("Password")).SendKeys("user");
            driver.FindElement(By.CssSelector(".btn")).Click();

            driver.FindElement(By.LinkText("All Products")).Click();
            driver.FindElement(By.CssSelector("tr:nth-child(79) > td:nth-child(12) > a")).Click();
            string DialogWindow = driver.SwitchTo().Alert().Text;
            Assert.AreEqual(DialogWindow, "Are you sure?");
            driver.SwitchTo().Alert().Accept();
        }

        [TestMethod]
        public void Login_logout_app()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://localhost:5000";
            driver.FindElement(By.Id("Name")).SendKeys("user");
            driver.FindElement(By.Id("Password")).SendKeys("user");
            driver.FindElement(By.CssSelector(".btn")).Click();

            driver.FindElement(By.LinkText("Logout")).Click();
            var elements = driver.FindElements(By.Id("Name"));
            Assert.IsTrue(elements.Count > 0, "элемент для ввода логина не найден");
            var element = driver.FindElements(By.Id("Password"));
            Assert.IsTrue(elements.Count > 0, "элемент для ввода пароля не найден");
        }
    }
}


