using NUnit.Framework;

namespace Wordpress

{
    public class AuthorizationTest : Base
    {
        [Test]
        [TestCase(PageMainLink.link_EN)]
        [TestCase(PageMainLink.link_DE)]
        [TestCase(PageMainLink.link_PL)]
        [TestCase(PageMainLink.link_RU)]
        public void Authorization(string Local)
        {
            driver.Url = Local;
            Hel_per.ActionButtonLogin();
            Hel_per.Timeout();
            Hel_per.FormAuthorization();
            I_frame.GoToFrame();
            I_frame.MyAccount();
            I_frame.AssertAuthorization();
            driver.SwitchTo().DefaultContent();
            Hel_per.Logout();          
        }
    }
}

