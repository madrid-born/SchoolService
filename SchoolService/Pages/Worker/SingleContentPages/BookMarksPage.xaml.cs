using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolService.Pages.Worker.ContentViews;
using SchoolService.Temp;

namespace SchoolService.Pages.Worker.SingleContentPages ;

    public partial class BookMarksPage : ContentPage
    {
        public BookMarksPage()
        {
            InitializeComponent();
            JobContent.Content = new JobsContentView(RandomDatas.JobGenerator(5));
        }
    }