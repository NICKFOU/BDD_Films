﻿using BDD_Films.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BDD_Films
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new Index());
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