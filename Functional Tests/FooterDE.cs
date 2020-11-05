using NUnit.Framework;
using OpenQA.Selenium;

namespace Wordpress
{
    [TestFixture]
    public class FooterDE : Base
    {
        [Test]
        [TestCase(PageMainLink.link_DE, "#menu-item-24852 > a", "Datenschutzrichtlinie")]
        [TestCase(PageMainLink.link_DE, "#menu-item-24851 > a", "Benutzervereinbarung")]
        [TestCase(PageMainLink.link_DE, "#menu-item-24853 > a", "Politik von KYC")]
        [TestCase(PageMainLink.link_DE, "#menu-item-24855 > a", "Rückerstattung Richtlinie")]
        [TestCase(PageMainLink.link_DE, "#menu-item-24854 > a", "Risiko Warnung")]
        [TestCase(PageMainLink.link_DE, "#menu-item-24850 > a", "Anti-Geldwäsche-Richtlinie")]
        [TestCase(PageMainLink.link_DE, "#menu-item-3260 > a", "Über TradeAllCrypto")]
        [TestCase(PageMainLink.link_DE, "#menu-item-22757 > a", "Kontakte")]
        [TestCase(PageMainLink.link_DE, "#menu-item-3261 > a", "Arten von Konten")]
        [TestCase(PageMainLink.link_DE, "#menu-item-3262 > a", "MT4 web-terminal")]

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

