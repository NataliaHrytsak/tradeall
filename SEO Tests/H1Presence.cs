using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Wordpress
{
    public class H1Presence:Base
    {
        [Test]
        public void GetH1(string link)
        {           
            IList<IWebElement> selectH1 = driver.FindElements(By.TagName("h1"));
            bool present;
            if (selectH1.Count > 0)
            {
                try
                {
                    Assert.AreEqual(1, selectH1.Count);
                }

                catch (Exception)
                {
                    Console.WriteLine(link + " страница содержит " + selectH1.Count + " H1" );
                }

            }
            else
            {
                present = false;
                Console.WriteLine(link + " на странице отсутствует H1");
                Assert.AreEqual(true, present);
                
            }
        }
    }
}

