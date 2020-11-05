using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace Wordpress
{
    public class Base
    {       
        public IWebDriver driver;
        public Actions action;
        public MailGenerator Mail_Generator;     
        public Helper Hel_per;
        public Iframe I_frame;

        [OneTimeSetUp]
        public void OnTestStarted()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            action = new Actions(driver);
            Hel_per = new Helper(driver);
            I_frame = new Iframe(driver);              
        }

        [OneTimeTearDown]
        public void OnTestEnded()
        {
            driver.Close();
        }
        public static string Email()
        {
            return MailGenerator.GetLetters(10);

        }   
        public static string a = Email() + "@gmail.com";      
        
    }
}

