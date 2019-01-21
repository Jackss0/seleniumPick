using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.Events;

namespace SeleniumPick
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Url = "https://duckduckgo.com/";

            var txtSearch = _driver.FindElement(By.Id("search_form_input_homepage"));
            Console.WriteLine("escribir algo");
            txtSearch.Clear();
            txtSearch.SendKeys("invoker dota 2");

            var btnSearch = _driver.FindElement(By.Id("search_button_homepage"));
            btnSearch.Click();
            Task.Delay(3500).Wait();


            var btnImagenes = _driver.FindElement(By.ClassName("js-zci-link--images"));
            btnImagenes.Click();
            Task.Delay(3500).Wait();

            var primeraImagen = _driver.FindElement(By.ClassName("zci__main"))
                               .FindElements(By.ClassName("tile--img"))[0];
            primeraImagen.Click();
            Task.Delay(3500).Wait();


            Screenshot ss = ((ITakesScreenshot)_driver).GetScreenshot();
            ss.SaveAsFile("D:\\imgs\\xddx2.png", ScreenshotImageFormat.Png);
            
            _driver.Quit();
        }
    }
}
