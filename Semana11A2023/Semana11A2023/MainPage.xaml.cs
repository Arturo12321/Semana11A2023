using Semana11A2023.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Semana11A2023
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


            Item1.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Operacions());
            };

            Item2.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Resta());
            };

            Item3.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Multiplication());
            };

            Item4.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Division());
            };
        }
    }
}
