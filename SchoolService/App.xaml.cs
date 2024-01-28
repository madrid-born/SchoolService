using SchoolService.Pages;

namespace SchoolService
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new InitialPage());
        }
    }
}