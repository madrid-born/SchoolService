using SchoolService.Pages.Worker.ContentViews;
using SchoolService.Temp;

namespace SchoolService.Pages.Worker.MainPages ;

    public partial class WorkerOffers : ContentPage
    {
        public WorkerOffers()
        {
            InitializeComponent();
            JobContent.Content = new JobsContentView(RandomDatas.JobGenerator(10));
        }
    }