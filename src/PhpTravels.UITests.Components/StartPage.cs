using Atata;

namespace PhpTravels.UITests.Components
{
    using _ = StartPage;
    [Url("/")]
    public class StartPage : Page<_>
    {
        [FindByXPath("//*[@class='btn btn-hero btn-light-blue']")]
        public Link<DemoPage, _> ExploreDemo { get; private set; }

        [FindByClass("login")]
        public Link<_> Login { get; private set; }

        [FindByClass("text-success")]
        public Link<PricingPage,_> Pricing { get; private set; }
    }
}
