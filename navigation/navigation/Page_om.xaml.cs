using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace navigation
{
    public partial class Page_om : ContentPage
    {
        public Page_om()
        {
            InitializeComponent();
        }
        protected override bool OnBackButtonPressed()
        {
            App.Current.MainPage = new MainPage();
            return base.OnBackButtonPressed();
        }
    }
}