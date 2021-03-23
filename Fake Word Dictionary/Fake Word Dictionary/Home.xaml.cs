using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Fictionary
{
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            // Just push this on top of the home page
           await Navigation.PushModalAsync(new AddWords());
        }

        async void Search_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Search());
        }
    }
}
