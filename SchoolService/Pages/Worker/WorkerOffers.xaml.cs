﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolService.Models;
using SchoolService.Temp;

namespace SchoolService.Pages.Worker ;

    public partial class WorkerOffers : ContentPage
    {
        public WorkerOffers()
        {
            InitializeComponent();
            JobData.ItemsSource = RandomDatas.JobGenerator(10);
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