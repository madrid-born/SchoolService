using SchoolService.Models;
using SchoolService.Pages.Worker.SingleContentPages;

namespace SchoolService.Pages.Worker.ContentViews ;

    public partial class JobsContentView : ContentView
    {
        public JobsContentView(List<Job> jobs)
        {
            InitializeComponent();
            JobData.ItemsSource = jobs;
        }
        
        private async void JobTapped(object sender, TappedEventArgs e)
        {
            var jobTapped =
                (sender as Grid)?.GestureRecognizers.OfType<TapGestureRecognizer>().FirstOrDefault()?.CommandParameter;

            if (jobTapped is Job job)
            {
                await Navigation.PushAsync(new JobPage(job));
            }
        }
    }