using Atata;

namespace PhpTravels.UITests.Components
{
    using _ = PricingPage;

  
    public class PricingPage : Page<_>
    {
        [FindByXPath("//*[@class='wow fadeIn btn btn-primary btn-block animated']")]
        public Button<_> OrderNow { get; private set; }
    }
}
