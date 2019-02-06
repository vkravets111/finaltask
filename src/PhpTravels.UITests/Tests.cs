using Atata;
using NUnit.Framework;
using PhpTravels.UITests.Components;

namespace PhpTravels.UITests
{
    public class Tests : UITestFixture
    {
        [Test, Order(1)]
        public void HeaderVerificationOnDemoPage()
        {
            Go.To<StartPage>().
                ExploreDemo.ClickAndGo().
                SecondaryHeader.Should.Contain("APPLICATION TEST DRIVE");

        }

        [Test, Order(2)]
        public void InvalidLoginAttempt()
        {
            Go.To<StartPage>().
                Login.Click();
            Go.ToNextWindow<LoginPage>().
                Email.Set("abrakadabra@gmail.com").
                Password.Set("akfgskfgsdgfsjddfg").
                Login.Click().
                Failure.Should.Contain("Please complete the captcha and try again").
            CloseWindow(); 
            Go.To<StartPage>(navigate: false);
        }

        [Test, Order(3)]
        public void PricingPageVerification()
        {
            Go.To<StartPage>().
                Pricing.ClickAndGo().
                OrderNow.Should.BeVisible();

        }
    }
}
