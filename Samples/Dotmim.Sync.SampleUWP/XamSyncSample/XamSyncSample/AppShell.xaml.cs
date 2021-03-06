﻿using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XamSyncSample.ViewModels;
using XamSyncSample.Views;

namespace XamSyncSample
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(EmployeeDetailPage), typeof(EmployeeDetailPage));
            Routing.RegisterRoute(nameof(NewEmployeePage), typeof(NewEmployeePage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
