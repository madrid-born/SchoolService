﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolService.Pages.Worker;

namespace SchoolService.Pages.School ;

    public partial class SchoolLogin : ContentPage
    {
        public SchoolLogin()
        {
            InitializeComponent();
        }

        private void LoginButton_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void RegisterButton_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new SchoolRegiter());

        }

        private void WorkerButton_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new WorkerLogin());

        }
    }