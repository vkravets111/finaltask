using Atata;

namespace PhpTravels.UITests.Components
{
    using _ = DemoPage;
   public class DemoPage : Page<_>
    {
        public H2<_> SecondaryHeader { get; private set; }

        [FindByClass("brand")]
        public Image<_> Logo { get; private set; }
    }
}
