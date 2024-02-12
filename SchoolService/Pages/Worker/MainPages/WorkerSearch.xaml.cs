using SchoolService.Models;
using SchoolService.Pages.Worker.ContentViews;
using SchoolService.Temp;

namespace SchoolService.Pages.Worker.MainPages ;

    public partial class WorkerSearch : ContentPage
    {
        private readonly List<Job> _jobs;
        public WorkerSearch()
        {
            InitializeComponent();
            _jobs = RandomDatas.JobGenerator(100);
        }

        private void SearchBar_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (e.NewTextValue == null) return;
            var matchingJobs = _jobs
                .Where(job => job.Title.Contains(e.NewTextValue, StringComparison.OrdinalIgnoreCase))
                .Select(job => job).ToList();
            JobContent.Content = new JobsContentView(matchingJobs);
        }
        
    }