using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace carrousel_page
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            Button btn = new Button
            {
                Text="temperament"
            };
            btn.Clicked += Btn_Clicked;
            StackLayout st = new StackLayout
            {
                Children = {btn}
            };
            Content = st;
        }

        private async void Btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new temperament());
        }
    }
}
