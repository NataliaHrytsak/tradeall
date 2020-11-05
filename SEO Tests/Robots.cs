
using NUnit.Framework;
using OpenQA.Selenium;
namespace Wordpress
{
    class Robots:Base
    {
        [Test]
        public void GetRobotstext()
        {
            string exp_robots = "User-agent: *" +
                "\r\nDisallow: /cgi-bin" +
                "\r\nDisallow: /wp-" +
                "\r\nDisallow: /*?*" +
                "\r\nDisallow: */articles/*/" +
                "\r\nDisallow: /en/news/*/" +
                "\r\nDisallow: /de/news/*/" +
                "\r\nDisallow: /pl/news/*/" +
                "\r\nDisallow: */registration" +
                "\r\nAllow: /news/" +
                "\r\nAllow: */uploads" +
                "\r\nAllow: /images" +
                "\r\nAllow: /wp-*/*.js" +
                "\r\nAllow: /wp-content/*.css" +
                "\r\nAllow: /wp-*/*.jpg" +
                "\r\nAllow: /wp-*/*.png" +
                "\r\nAllow: /wp-*/*.svg" +
                "\r\nAllow: /wp-*/*.ttf" +
                "\r\n\r\nSitemap: https://tradeallcrypto.com/sitemap_index.xml";
            driver.Url = "https://tradeallcrypto.com/robots.txt";
            string act_robots = driver.FindElement(By.TagName("pre")).Text;
            Assert.AreEqual(exp_robots, act_robots);
        }
    }
}
