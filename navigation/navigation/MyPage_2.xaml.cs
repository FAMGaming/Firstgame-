using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace navigation
{
    public partial class MyPage_2 : ContentPage
    {
        public MyPage_2()
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
