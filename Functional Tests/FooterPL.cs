using NUnit.Framework;
using OpenQA.Selenium;

namespace Wordpress
{
    [TestFixture]
    public class FooterPL : Base
    {
        [Test]
        [TestCase(PageMainLink.link_PL, "#menu-item-3263 > a", "Zawiadomienia o ochronie prywatności")]
        [TestCase(PageMainLink.link_PL, "#menu-item-3264 > a", "Regulamin")]
        [TestCase(PageMainLink.link_PL, "#menu-item-3265 > a", "Polityka KYC")]
        [TestCase(PageMainLink.link_PL, "#menu-item-3406 > a", "Polityka przeciwdziałania praniu brudnych pieniędzy")]
        [TestCase(PageMainLink.link_PL, "#menu-item-3272 > a", "Ostrzeżenie o ryzyku")]
        [TestCase(PageMainLink.link_PL, "#menu-item-3273 > a", "Procedura zwrotu środków")]
        [TestCase(PageMainLink.link_PL, "#menu-item-3485 > a", "O firmie TradeAllCrypto")]
        [TestCase(PageMainLink.link_PL, "#menu-item-22758 > a", "Kontakty")]
        [TestCase(PageMainLink.link_PL, "#menu-item-3500 > a", "Rodzaje kont")]
        [TestCase(PageMainLink.link_PL, "#menu-item-3501 > a", "MT4 web-terminal")]   

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

