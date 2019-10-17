using System;

using Xamarin.Forms;

namespace navigation
{
    public class page_2 : ContentPage
    {
        public page_2()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

