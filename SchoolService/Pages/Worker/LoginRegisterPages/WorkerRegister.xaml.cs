﻿using SchoolService.Pages.School;

namespace SchoolService.Pages.Worker.LoginRegisterPages ;

    public partial class WorkerRegister : ContentPage
    {
        public WorkerRegister()
        {
            InitializeComponent();
        }

        private void RegisterButton_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoginButton_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new WorkerLogin());
        }

        private void SchoolButton_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new SchoolLogin());
        }
    }