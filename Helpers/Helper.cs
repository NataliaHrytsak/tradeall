using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Threading.Tasks;


namespace Wordpress
{
    public class Helper : Base
    {
        public Helper(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void Timeout()
        {
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }
        public void ActionButtonLogin()
        {
            driver.FindElement(By.CssSelector("div[class='button-login__ico']")).Click();          
                    
        }
        public void Logout()
        {
            Actions action = new Actions(driver);
            var dropdown2 = driver.FindElement(By.CssSelector("div[class='button-login__ico']"));
            action.MoveToElement(dropdown2).Build().Perform();
            Task.Delay(1000);
            driver.FindElement(By.CssSelector("a[data-user='logout']")).Click();
        }
        public void FormAuthorization()
        {
            driver.FindElement(By.CssSelector("a[data-header-show='login']")).Click();
            driver.FindElement(By.CssSelector("a[class='button-login__submenu-link active']")).Click();
            driver.FindElement(By.CssSelector("input[type='email']")).SendKeys("iqa@wizardsdev.com");
            driver.FindElement(By.CssSelector("input[type='password']")).SendKeys("qwerty12345");
            driver.FindElement(By.CssSelector("button[type='submit']")).Click();
        }

        public void FormRegistration(string a)
        {
            driver.FindElement(By.CssSelector("div.button-login__submenu > div:nth-child(2) > a")).Click();
            driver.FindElement(By.Id("f_name")).SendKeys("Testname");
            driver.FindElement(By.Id("l_name")).SendKeys("Testsurname");
            a = Email() + "@gmail.com";
            Base.a = a;
            driver.FindElement(By.Id("email")).SendKeys(a);
            driver.FindElement(By.ClassName("custom-select__placeholder")).Click(); 
            driver.FindElement(By.CssSelector("img[alt='RU']")).Click();
            driver.FindElement(By.Id("user_phone")).SendKeys("279997895567");
            driver.FindElement(By.Id("user_password")).SendKeys("qwerty12345");
            driver.FindElement(By.ClassName("checkbox__mark")).Click();
            driver.FindElement(By.CssSelector("body > div.wrapper > div.wrapper__content > div > form > div.account__buttons > button")).Click();
        }     
        public void OpenParentTab(string MenuSelector)
        {
            Actions action = new Actions(driver);
            IWebElement Tab = driver.FindElement(By.XPath(MenuSelector));
            action.MoveToElement(Tab).Build().Perform();           
        }      
    }
}