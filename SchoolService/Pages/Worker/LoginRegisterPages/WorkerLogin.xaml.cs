using SchoolService.Pages.School;
using SchoolService.Pages.Worker.MainPages;

namespace SchoolService.Pages.Worker.LoginRegisterPages ;

    public partial class WorkerLogin : ContentPage
    {
        public WorkerLogin()
        {
            InitializeComponent();
        }

        private void LoginButton_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new WorkerHome());
        }

        private void RegisterButton_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new WorkerRegister());
        }

        private void SchoolButton_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new SchoolLogin());
        }
    }