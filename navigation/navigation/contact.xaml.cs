using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace navigation
{
    public partial class contact : ContentPage
    {
        public contact()
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
