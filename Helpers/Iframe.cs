using System;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Wordpress
{   
    public class Iframe : Base
    {       
        public Iframe(OpenQA.Selenium.IWebDriver driver)
        {
            this.driver = driver;
        }     
        public void GoToFrame()
        {
            var ff = ".positions-page__cabinet-iframe"; 
            var iframe_go = driver.FindElement(By.CssSelector(ff));
            driver.SwitchTo().Frame(iframe_go);
        }     
        public void MyAccount()
        {
            Actions action = new Actions(driver);
            IWebElement Tab = driver.FindElement(By.CssSelector("#root > div.scrollbar-root > div > div > div > div > div > div > div > div > section > div > div > a:nth-child(5) > div > div.we1oxv-1.sc-13qb6w2-1.jSywvJ.content__chevron"));
            action.MoveToElement(Tab).Build().Perform();
            Tab.Click();
            IWebElement Tab2 = driver.FindElement(By.CssSelector("#root > div.scrollbar-root > div > div > div > div > div > div > div > div > section > div > div > div.we1oxv-1.sc-13qb6w2-1.bnOTxe.sc-1utd397-0.bxqDWh.collapsible-sub-menu > div > div > a:nth-child(1) > div > div"));
            action.MoveToElement(Tab).Build().Perform();
            Tab2.Click();
            var frame2 = "#personal-data-page";
            var iframe_goto = driver.FindElement(By.CssSelector(frame2));
            driver.SwitchTo().Frame(iframe_goto);
            Task.Delay(500);            
            string name = driver.FindElement(By.CssSelector("#personal-data > div > div:nth-child(1) > div > div > div.col-xs-9.col-sm-8 > label")).Text;
            string surname = driver.FindElement(By.CssSelector("#personal-data > div > div:nth-child(2) > div > div > div.col-xs-9.col-sm-8 > label")).Text;
            string email = driver.FindElement(By.CssSelector("#personal-data > div > div:nth-child(5) > div > div.col-xs-12.col-sm-9 > label")).Text;
            Console.Write(name, surname, email);
        }       
        public void AssertRegistration()
        {
            string email = driver.FindElement(By.CssSelector("#personal-data > div > div:nth-child(5) > div > div.col-xs-12.col-sm-9 > label")).Text;
            Assert.AreEqual(a, email);          
        }     
        public void AssertAuthorization()
        {
            string email = driver.FindElement(By.CssSelector("label[class='ui-line-element ui-field-value text-truncate']")).Text;
            Assert.AreEqual("iqa@wizardsdev.com", email);
        }

    }
}

