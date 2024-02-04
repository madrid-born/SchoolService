using SchoolService.Temp;

namespace SchoolService.Pages.Worker ;

    public partial class WorkerHome : ContentPage
    {
        public WorkerHome()
        {
            InitializeComponent();
            JobData.ItemsSource = RandomDatas.JobGenerator(10);
        }

        private void JobTapped(object sender, TappedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }