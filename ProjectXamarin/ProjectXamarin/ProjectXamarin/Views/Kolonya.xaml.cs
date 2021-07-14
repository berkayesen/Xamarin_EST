﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Kolonya : ContentPage
    {
        public Kolonya()
        {
            InitializeComponent();
        }

        public async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HawaiAnanasKolonyasi());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MiniKolonyalar());
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BebekKolonyasi());
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CesmeLimonuKolonyasi());
        }
    }
}