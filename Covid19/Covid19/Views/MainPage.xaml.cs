using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Covid19.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}