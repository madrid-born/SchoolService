using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolService.Models;

namespace SchoolService.Pages.Worker ;

    public partial class JobPage : ContentPage
    {
        public JobPage(Job job)
        {
            InitializeComponent();
            Picture.Source = job.ImagePath;
            Name.Text = job.Title;
            Wage.Text = job.Wage.ToString();
            Abilities.ItemsSource = job.NeededAbilities;
        }
    }