using NUnit.Framework;
using OpenQA.Selenium;


namespace Wordpress
{
    [TestFixture]
    public class HeaderEN : Base
    {
        [Test]
        [TestCase(PageMainLink.link_EN, "//a[@class='top-menu__link' and text()='Account Types']", "Account Types", "Account types")]
        [TestCase(PageMainLink.link_EN, "//a[@class='top-menu__link' and text()='Instruments']", "Online-platform", "Online-platform")]
        [TestCase(PageMainLink.link_EN, "//a[@class='top-menu__link' and text()='Instruments']", "Economic calendar", "Economic calendar")]
        [TestCase(PageMainLink.link_EN, "//a[@class='top-menu__link' and text()='Instruments']", "Market news", "Financial news")]
        [TestCase(PageMainLink.link_EN, "//a[@class='top-menu__link' and text()='Instruments']", "Market reviews", "Market reviews and strategies")]
        [TestCase(PageMainLink.link_EN, "//a[@class='top-menu__link' and text()='Instruments']", "Spread table", "Spread table")]
        [TestCase(PageMainLink.link_EN, "//a[@class='top-menu__link' and text()='Instruments']", "Trading hours", "Trading hours")]
        [TestCase(PageMainLink.link_EN, "//a[@class='top-menu__link' and text()='Instruments']", "MT4 web-terminal", "MT4 web-terminal")]
        [TestCase(PageMainLink.link_EN, "//a[@class='top-menu__link' and text()='About Us']", "About Company", "About Company")]
        [TestCase(PageMainLink.link_EN, "//a[@class='top-menu__link' and text()='About Us']", "Contacts", "Contacts")]
        [TestCase(PageMainLink.link_EN, "//a[@class='top-menu__link' and text()='About Us']", "Terms & Conditions", "Terms & Conditions")]
        [TestCase(PageMainLink.link_EN, "//a[@class='top-menu__link' and text()='About Us']", "Risk Disclosure Policy", "Risk Disclosure Policy")]
        [TestCase(PageMainLink.link_EN, "//a[@class='top-menu__link' and text()='About Us']", "Privacy Policy", "Privacy Policy")]
        [TestCase(PageMainLink.link_EN, "//a[@class='top-menu__link' and text()='About Us']", "KYC Policy", "KYC Policy")]
        [TestCase(PageMainLink.link_EN, "//a[@class='top-menu__link' and text()='About Us']", "Refund and Return Policy", "Refund and Return Policy")]
        [TestCase(PageMainLink.link_EN, "//a[@class='top-menu__link' and text()='About Us']", "Anti-Money Laundering", "Anti-Money Laundering")]

        public void CheckTabs(string Local, string MenuSelector, string SubmenuSelector, string expectedH1)
        {
            driver.Url = Local;
            Hel_per.OpenParentTab(MenuSelector);
            driver.FindElement(By.LinkText(SubmenuSelector)).Click();
            Hel_per.Timeout();
            string actualH1 = driver.FindElement(By.TagName("h1")).Text;
            Assert.AreEqual(expectedH1, actualH1);
        }
    }
}
