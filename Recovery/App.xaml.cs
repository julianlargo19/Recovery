using System.Globalization;

namespace Recovery
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();


            var culture = new CultureInfo("es-CO");
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;


            MainPage = new TabbedPage

            {

                Children =
            {
                new WelcomePage(),
                new EmailPage(),
                new CreateUserPage(),
                new AddictionsListPage(),
                new AddictionOwnPage(),
                new StartSobrietyDatePage(),
                new TrackStartPage(),
                new DaysTakingPage(),
                new TimesTakingPage(),
                new ReasonSoberPage(),
                new DailyPromisePage(),
                new LobbyPage(),
           
               }
            };

            MainPage = new
            NavigationPage(new WelcomePage())

            {

            };
        }
    }

}