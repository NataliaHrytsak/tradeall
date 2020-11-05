using NUnit.Framework;
using OpenQA.Selenium;

namespace Wordpress
{   
    [TestFixture]
    public class FooterRU:Base
    {
        [Test]
        [TestCase(PageMainLink.link_RU, "#menu-item-24890 > a", "Часы Торговли")]
        [TestCase(PageMainLink.link_RU, "#menu-item-24894 > a", "MT4 web-terminal")]
        [TestCase(PageMainLink.link_RU, "#menu-item-24895 > a", "Торговая платформа XCritical")]
        [TestCase(PageMainLink.link_RU, "#menu-item-24896 > a", "XCritical - мобильное приложение для торговли на рынке Форекс")]
        [TestCase(PageMainLink.link_RU, "#menu-item-24893 > a", "Торговая платформа MetaTrader 4")]
        [TestCase(PageMainLink.link_RU, "#menu-item-24911 > a", "Календарь экономических новостей")]
        [TestCase(PageMainLink.link_RU, "#menu-item-24912 > a", "СЕЗОН ОТЧЕТНОСТИ В США")]
        [TestCase(PageMainLink.link_RU, "#menu-item-24913 > a", "Финансовые новости")]
        [TestCase(PageMainLink.link_RU, "#menu-item-24914 > a", "Обзоры рынков и стратегии")]
        [TestCase(PageMainLink.link_RU, "#menu-item-24869 > a", "Портфель Уоррена Баффета")]
        [TestCase(PageMainLink.link_RU, "#menu-item-24868 > a", "ДАЙТЕ ВАШИМ ДЕНЬГАМ ВОЗМОЖНОСТЬ ВЫРАСТИ!")]
        [TestCase(PageMainLink.link_RU, "#menu-item-24951 > a", "Политика конфиденциальности")]
        [TestCase(PageMainLink.link_RU, "#menu-item-24954 > a", "Предупреждение о риске")]
        [TestCase(PageMainLink.link_RU, "#menu-item-24947 > a", "О компании TradeAllCrypto")]
        [TestCase(PageMainLink.link_RU, "#menu-item-24953 > a", "Пользовательское соглашение")]
        [TestCase(PageMainLink.link_RU, "#menu-item-24949 > a", "Политика KYC")]
        [TestCase(PageMainLink.link_RU, "#menu-item-24952 > a", "Политика по борьбе с отмыванием денег")]
        [TestCase(PageMainLink.link_RU, "#menu-item-24948 > a", "Станьте партнером TradeAllCrypto и получайте высокий доход на индивидуальных условиях!")]
        [TestCase(PageMainLink.link_RU, "#menu-item-24950 > a", "Политика возврата средств")]
        [TestCase(PageMainLink.link_RU, "#menu-item-24955 > a", "Контакты")]
        
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
