using NUnit.Framework;
using OpenQA.Selenium;


namespace Wordpress
{
    [TestFixture]
    public class HeaderPL : Base
    {
        [Test]
        [TestCase(PageMainLink.link_PL, "//a[@class='top-menu__link' and text()='Rodzaje kont']", "Rodzaje kont", "Rodzaje kont")]
        [TestCase(PageMainLink.link_PL, "//a[@class='top-menu__link' and text()='Instrumenty']", "MT4 web-terminal", "MT4 web-terminal")]
        [TestCase(PageMainLink.link_PL, "//a[@class='top-menu__link' and text()='Instrumenty']", "Kalendarz ekonomiczny", "Kalendarz ekonomiczny")]
        [TestCase(PageMainLink.link_PL, "//a[@class='top-menu__link' and text()='Instrumenty']", "Wiadomości rynkowe", "Wiadomości finansowe")]
        [TestCase(PageMainLink.link_PL, "//a[@class='top-menu__link' and text()='Instrumenty']", "Badania i strategie rynkowe", "Badania i strategie rynkowe")]
        [TestCase(PageMainLink.link_PL, "//a[@class='top-menu__link' and text()='Instrumenty']", "Tabela spreadów", "Tabela spreadów")]
        [TestCase(PageMainLink.link_PL, "//a[@class='top-menu__link' and text()='Instrumenty']", "Godziny handlu", "Godziny handlu")]
        [TestCase(PageMainLink.link_PL, "//a[@class='top-menu__link' and text()='O nas']", "O firmie", "O firmie TradeAllCrypto")]
        [TestCase(PageMainLink.link_PL, "//a[@class='top-menu__link' and text()='O nas']", "Kontakty", "Kontakty")]
        [TestCase(PageMainLink.link_PL, "//a[@class='top-menu__link' and text()='O nas']", "Regulamin", "Regulamin")]
        [TestCase(PageMainLink.link_PL, "//a[@class='top-menu__link' and text()='O nas']", "Polityka prywatności", "Zawiadomienia o ochronie prywatności")]
        [TestCase(PageMainLink.link_PL, "//a[@class='top-menu__link' and text()='O nas']", "Procedura zwrotu środków", "Procedura zwrotu środków")]
        [TestCase(PageMainLink.link_PL, "//a[@class='top-menu__link' and text()='O nas']", "Polityka KYC", "Polityka KYC")]
        [TestCase(PageMainLink.link_PL, "//a[@class='top-menu__link' and text()='O nas']", "Przeciwdziałanie praniu pieniędzy", "Polityka przeciwdziałania praniu brudnych pieniędzy")]
        [TestCase(PageMainLink.link_PL, "//a[@class='top-menu__link' and text()='O nas']", "Ostrzeżenie o ryzyku", "Ostrzeżenie o ryzyku")]

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
