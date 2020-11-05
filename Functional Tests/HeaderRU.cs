using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;


namespace Wordpress
{
    [TestFixture]
    public class HeaderRU : Base
    {
        [Test]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='Типы счетов']", "Типы счетов", "Типы счетов")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='Инструменты']", "Часы торговли", "Часы Торговли")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='Инструменты']", "Таблица спредов", "Таблица спредов")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='Платформы']", "MT4web-terminal", "MT4 web-terminal")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='Платформы']", "Онлайн платформа", "Торговая платформа XCritical")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='Платформы']", "Xcritical", "XCritical - мобильное приложение для торговли на рынке Форекс")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='Платформы']", "MetaTrader4", "Торговая платформа MetaTrader 4")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='Аналитика']", "Экономический календарь", "Календарь экономических новостей")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='Аналитика']", "Сезон отчетности", "СЕЗОН ОТЧЕТНОСТИ В США")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='Аналитика']", "Новости на рынке Форекс", "Финансовые новости")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='Аналитика']", "Обзоры рынков и стратегии", "Обзоры рынков и стратегии")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='Аналитика']", "Внешнеэкономическая деятельность", "Внешнеэкономическая деятельность организаций")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='Акции и бонусы']", "Инвестируй, как сам Баффет!", "Портфель Уоррена Баффета")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='Акции и бонусы']", "Инвест портфель", "ДАЙТЕ ВАШИМ ДЕНЬГАМ ВОЗМОЖНОСТЬ ВЫРАСТИ!")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='Акции и бонусы']", "Зарабатывай не выходя из дома!", "Как спасти бюджет\r\nот эпидемии и кризиса?")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='Акции и бонусы']", "Гонка по сезону отчетности!", "Rally по сезону отчетности!")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='О компании']", "Политика конфиденциальности", "Политика конфиденциальности")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='О компании']", "Предупреждение о риске", "Предупреждение о риске")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='О компании']", "О нас", "О компании TradeAllCrypto")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='О компании']", "Пользовательское соглашение", "Пользовательское соглашение")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='О компании']", "Политика KYC", "Политика KYC")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='О компании']", "Политика по борьбе с отмыванием денег", "Политика по борьбе с отмыванием денег")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='О компании']", "Партнерская программа", "Станьте партнером TradeAllCrypto и получайте высокий доход на индивидуальных условиях!")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='О компании']", "Политика возврата средств", "Политика возврата средств")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='О компании']", "Контакты", "Контакты")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='О компании']", "Отзывы о TradeAllCrypto", "Отзывы о Форекс брокере TradeAllCrypto")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='Обучение']", "Вебинары", "Торговые и обучающие вебинары")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='Обучение']", "Школа трейдинга", "Пришло время научиться зарабатывать на финансовых рынках и перестать сомневаться в своих силах!")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='Обучение']", "Форекс обучение", "Обучение Форекс: как стать профи в торговле на бирже")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='Обучение']", "Форекс стратегии", "Стратегии Форекс: их суть и, что советуют профессионалы")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='Обучение']", "Торговые сигналы", "Торговые сигналы это решение для трейдера или ящик Пандоры, который не стоит открывать?")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='Обучение']", "Инвестиции", "Инвестиции – какими они бывают, варианты инвестиций и их возврат")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='Обучение']", "Управление активами", "Управление активами: нужно ли доверить свои деньги третьим лицам, и что вам это даст")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='Обучение']", "Торговые платформы", "Торговая платформа Форекс: инструкция для начинающих")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='Обучение']", "Торговые боты", "Торговые боты: что это такое, и как они помогают зарабатывать на криптовалютах?")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='Онлайн ТВ']", "Онлайн ТВ", "Online-TV: Смотрите ежедневные прогнозы от экспертов рынка!")]

        public void CheckSecondLevelTabs(string Local, string MenuSelector, string SubmenuSelector, string expectedH1)
        {
            driver.Url = Local;
            Hel_per.OpenParentTab(MenuSelector);
            driver.FindElement(By.LinkText(SubmenuSelector)).Click();
            Hel_per.Timeout();
            string actualH1 = driver.FindElement(By.TagName("h1")).Text;
            Assert.AreEqual(expectedH1, actualH1);
        }
        [Test]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='Обучение']", "Форекс стратегии", "Прибыльные стратегии форекс", "Стратегии форекс прибыльные")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='Обучение']", "Форекс стратегии", "Стратегии форекс для начинающих", "Стратегии форекс для начинающих спекулянтов: подробная инструкция для трейдеров")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='Обучение']", "Форекс стратегии", "Стратегия Price Action", "Что такое Price Action")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='Обучение']", "Форекс стратегии", "Стратегия Снайпер", "Торговая стратегия Снайпер")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='Обучение']", "Форекс стратегии", "Скальпинг стратегии", "Скальпинг стратегии")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='Обучение']", "Форекс стратегии", "Стратегии Свинг-трейдинг", "Свинг-трейдинг")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='Обучение']", "Форекс стратегии", "Торговые графики", "Как работать с графиками: подробная инструкция")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='Обучение']", "Торговые сигналы", "Торговые сигналы криптовалют", "Торговые сигналы криптовалют: где искать и как применять")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='Обучение']", "Торговые сигналы", "Торговые сигналы Форекс", "Торговые сигналы Форекс: где брать и как применять?")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='Обучение']", "Торговые сигналы", "Торговые сигналы онлайн", "Торговые сигналы онлайн помогут трейдеру заработать")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='Обучение']", "Торговые сигналы", "Торговые сигналы акций", "Торговые сигналы акций: особенности и преимущества применения")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='Обучение']", "Управление активами", "Доверительное управление", "Доверительное управление — финансовый выбор современного инвестора")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='Обучение']", "Рынки", "Торговля на бирже", "Торговля на бирже представляет трейдеру настоящую возможность заработать и разбогатеть")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='Обучение']", "Рынки", "Торговля акциями", "Торговля акциями на фондовом рынке для начинающих трейдеров")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='Обучение']", "Рынки", "Купить облигации", "Как купить облигации: подробный мануал для новичков")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='Обучение']", "Рынки", "Торговля на Форекс", "Торговля на Форекс позволит быстро увеличить доход трейдера")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='Обучение']", "Рынки", "Торговля на фьючерсах", "Торговля на фьючерсах является одним из наиболее интересных видов трейдинга")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='Обучение']", "Рынки", "Торговля на фондовом рынке", "Торговля на фондовом рынке — возможность стабильного заработка")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='Обучение']", "Рынки", "Торговля биткоинами", "Торговля биткоинами: ключевые понятия")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='Обучение']", "Торговые боты", "Торговые боты криптовалют", "Боты для торговли криптовалютой: какой выбрать")]
        [TestCase(PageMainLink.link_RU, "//a[@class='top-menu__link' and text()='Обучение']", "Торговые боты", "Торговые роботы", "Что такое торговые роботы Форекс")]

        public void CheckThirdLevelTabs(string Local, string MenuSelector, string SubmenuSelector, string ThirdLevelTabSelector, string expectedH1)
        {
            driver.Url = Local;
            Hel_per.OpenParentTab(MenuSelector);
            Actions action = new Actions(driver);
            IWebElement Tab = driver.FindElement(By.LinkText(SubmenuSelector));
            action.MoveToElement(Tab).Build().Perform();
            driver.FindElement(By.LinkText(ThirdLevelTabSelector)).Click();
            Hel_per.Timeout();
            string actualH1 = driver.FindElement(By.TagName("h1")).Text;
            Assert.AreEqual(expectedH1, actualH1);
        }       
    }
}
