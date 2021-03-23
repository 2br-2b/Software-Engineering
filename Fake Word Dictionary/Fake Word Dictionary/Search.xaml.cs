using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Fictionary
{
    public partial class Search : ContentPage
    {
        public Search()
        {
            InitializeComponent();
        }

        
        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            // Push this on top of the search page
            await Navigation.PopAsync();
        }
    }
}
