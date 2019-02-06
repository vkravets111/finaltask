using Atata;
namespace PhpTravels.UITests.Components
{

    using _ = LoginPage;
    public class LoginPage: Page<_>
    {
        [FindByName("username")]
        public EmailInput<_> Email { get; private set; }

        [FindByName("password")]
        public PasswordInput<_> Password { get; private set; }

        [FindById("login")]
        public Button<_> Login { get; private set; }

        [FindByXPath("//div[@class='alert alert-danger text-center']")]
        public Text<_> Failure { get; private set; }

        
    }
}
