﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppS3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //Navegacion amd
            MainPage = new NavigationPage (new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
