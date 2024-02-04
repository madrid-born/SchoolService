using SchoolService.Pages.School;
using SchoolService.Pages.Worker;

namespace SchoolService.Pages ;

    public partial class InitialPage : ContentPage
    {
        public InitialPage()
        {
            InitializeComponent();
        }

        private void WorkerButton_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new WorkerLogin());
        }

        private void SchoolButton_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new SchoolLogin());
        }
    }