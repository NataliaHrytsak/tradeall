using NUnit.Framework;
using OpenQA.Selenium;

namespace Wordpress
{
    [TestFixture]
    public class FooterEN : Base
    {
        [Test]
        [TestCase(PageMainLink.link_EN, "#menu-item-65 > a", "Privacy Policy")]
        [TestCase(PageMainLink.link_EN, "#menu-item-68 > a", "Terms & Conditions")]
        [TestCase(PageMainLink.link_EN, "#menu-item-64 > a", "KYC Policy")]
        [TestCase(PageMainLink.link_EN, "#menu-item-66 > a", "Refund and Return Policy")]
        [TestCase(PageMainLink.link_EN, "#menu-item-67 > a", "Risk Disclosure Policy")]
        [TestCase(PageMainLink.link_EN, "#menu-item-63 > a", "Anti-Money Laundering")]
        [TestCase(PageMainLink.link_EN, "#menu-item-79 > a", "About Company")]
        [TestCase(PageMainLink.link_EN, "#menu-item-78 > a", "Contacts")]
        [TestCase(PageMainLink.link_EN, "#menu-item-24839 > a", "Account types")]
        [TestCase(PageMainLink.link_EN, "#menu-item-24838 > a", "MT4 web-terminal")]
        
        public void CheckSecondLevelTabs(string Local, string MenuSelector, string expectedH1)
        {
            driver.Url = Local;
            driver.FindElement(By.CssSelector(MenuSelector)).Click();
            Hel_per.Timeout();
            string actualH1 = driver.FindElement(By.TagName("h1")).Text;
            Assert.AreEqual(expectedH1, actualH1);
        }
    }
}
