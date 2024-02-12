using SchoolService.Pages.Worker.ContentViews;
using SchoolService.Temp;

namespace SchoolService.Pages.Worker.MainPages ;

    public partial class WorkerJobs : ContentPage
    {
        public WorkerJobs()
        {
            InitializeComponent();
            JobContent.Content = new JobsContentView(RandomDatas.JobGenerator(10));
        }
    }