using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace navigation
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            DisplayAlert("Hello", "this is mainpage", "ok");
            base.OnAppearing();

        }
     
        private void bntsecond_clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new MyPage_2();

        }

        private void omthird_clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new Page_om();



        }
    }
}
