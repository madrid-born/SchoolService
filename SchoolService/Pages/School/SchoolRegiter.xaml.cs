using SchoolService.Pages.Worker;

namespace SchoolService.Pages.School ;

    public partial class SchoolRegiter : ContentPage
    {
        public SchoolRegiter()
        {
            InitializeComponent();
        }

        private void RegisterButton_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoginButton_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new SchoolLogin());

        }

        private void WorkerButton_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new WorkerRegister());

        }
    }