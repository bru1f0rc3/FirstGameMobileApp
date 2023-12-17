using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App8
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Version", "Game Version 0.1.1", "OK");
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new MainPage());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}