using NUnit.Framework;

namespace Wordpress
{
    [TestFixture]
    public class RegistrationTest : Base
    {
        [Test]
        [TestCase(PageMainLink.link_EN)]      
        [TestCase(PageMainLink.link_PL)]
        [TestCase(PageMainLink.link_RU)]
        [TestCase(PageMainLink.link_DE)]
        public void Registration(string Local)
        {
            driver.Navigate().GoToUrl(Local);
            Hel_per.ActionButtonLogin();
            Hel_per.Timeout();
            Hel_per.FormRegistration(a);
            I_frame.GoToFrame();
            I_frame.MyAccount();          
            I_frame.AssertRegistration();
            driver.SwitchTo().DefaultContent();
            Hel_per.Logout();           
        }
    }
}
