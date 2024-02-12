using SchoolService.Pages.Worker.SingleContentPages;

namespace SchoolService.Pages.Worker.MainPages ;

    public partial class WorkerProfile : ContentPage
    {
        public WorkerProfile()
        {
            InitializeComponent();
        }

        private async void ResumeClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ResumePage());
        }

        private async void BookMarksClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BookMarksPage());
        }
    }