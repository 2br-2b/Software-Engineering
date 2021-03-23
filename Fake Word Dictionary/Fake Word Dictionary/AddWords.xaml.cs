using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Fictionary
{
    public partial class AddWords : ContentPage
    {
        public AddWords()
        {
            InitializeComponent();
        }

        async void AddWord_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        async void Cancel_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}
