using NUnit.Framework;
using OpenQA.Selenium;

namespace Wordpress
{
    [TestFixture]
    public class HeaderDE : Base
    {
        [Test]
        [TestCase(PageMainLink.link_DE, "//a[@class='top-menu__link' and text()='Arten von Konten']", "Arten von Konten", "Arten von Konten")]
        [TestCase(PageMainLink.link_DE, "//a[@class='top-menu__link' and text()='Instrumente']", "MT4 veb-terminal", "MT4 web-terminal")]
        [TestCase(PageMainLink.link_DE, "//a[@class='top-menu__link' and text()='Instrumente']", "Wirtschaftskalender", "Wirtschaftskalender")]
        [TestCase(PageMainLink.link_DE, "//a[@class='top-menu__link' and text()='Instrumente']", "Finanznachrichten", "Finanznachrichten")]
        [TestCase(PageMainLink.link_DE, "//a[@class='top-menu__link' and text()='Instrumente']", "Spread Tabelle", "Spread Tabelle")]
        [TestCase(PageMainLink.link_DE, "//a[@class='top-menu__link' and text()='Instrumente']", "Handelszeiten", "Handelszeiten")]
        [TestCase(PageMainLink.link_DE, "//a[@class='top-menu__link' and text()='Über uns']", "Über TradeAllCrypto", "Über TradeAllCrypto")]
        [TestCase(PageMainLink.link_DE, "//a[@class='top-menu__link' and text()='Über uns']", "Kontakte", "Kontakte")]
        [TestCase(PageMainLink.link_DE, "//a[@class='top-menu__link' and text()='Über uns']", "Benutzervereinbarung", "Benutzervereinbarung")]
        [TestCase(PageMainLink.link_DE, "//a[@class='top-menu__link' and text()='Über uns']", "Risiko Warnung", "Risiko Warnung")]
        [TestCase(PageMainLink.link_DE, "//a[@class='top-menu__link' and text()='Über uns']", "Datenschutzrichtlinie", "Datenschutzrichtlinie")]
        [TestCase(PageMainLink.link_DE, "//a[@class='top-menu__link' and text()='Über uns']", "Politik von KYC", "Politik von KYC")]
        [TestCase(PageMainLink.link_DE, "//a[@class='top-menu__link' and text()='Über uns']", "Rückerstattung Richtlinie", "Rückerstattung Richtlinie")]
        [TestCase(PageMainLink.link_DE, "//a[@class='top-menu__link' and text()='Über uns']", "Anti-Geldwäsche-Richtlinie", "Anti-Geldwäsche-Richtlinie")]      

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

