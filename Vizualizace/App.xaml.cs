﻿using System;
using Vizualizace.Services;
using Vizualizace.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Vizualizace
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
