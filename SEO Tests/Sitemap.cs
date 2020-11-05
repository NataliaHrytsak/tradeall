using System.Collections.Generic;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using System.Linq;
using System;

namespace Wordpress
{

    [TestFixture]
    public class Sitemap : Base
    {
     
        StatusCode respose_code = new StatusCode();      
        
        [Test]
        [TestCase(SitemapsLinks.PostSitemap1)]
        [TestCase(SitemapsLinks.PostSitemap2)]
        [TestCase(SitemapsLinks.PostSitemap3)]
        [TestCase(SitemapsLinks.PostSitemap4)]
        [TestCase(SitemapsLinks.PostSitemap5)]
        [TestCase(SitemapsLinks.PostSitemap6)]
        [TestCase(SitemapsLinks.PostSitemap7)]
        [TestCase(SitemapsLinks.PostSitemap8)]
        [TestCase(SitemapsLinks.PostSitemap9)]
        [TestCase(SitemapsLinks.PageSitemap)]
        [TestCase(SitemapsLinks.SpreadsSitemap)]
        [TestCase(SitemapsLinks.CategorySitemap)]
        [TestCase(SitemapsLinks.AuthorSitemap)]

        public void Links(string Local)
        {           
            driver.Navigate().GoToUrl(Local);
            IList<IWebElement> elementList = driver.FindElements(By.PartialLinkText("https://tradeallcryp"));
            List<string> links = new List<string>();
            int numberOfListElements = elementList.Count();
            foreach (IWebElement element in elementList)
            {
                string link = element.GetAttribute("href").ToString();
                links.Add(link);
            }
            for (int i = 0; i < numberOfListElements; i++)
            {
                {
                    driver.Url = links[i];
                    respose_code.GetResponse(links[i]);
                   // title_presence.GetTitle(links[i]);
                    
                }
                continue;            
            }      
        }    
    }  
}


       

                        

   

 
   