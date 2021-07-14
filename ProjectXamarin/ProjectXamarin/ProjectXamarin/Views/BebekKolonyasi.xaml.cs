﻿using ProjectXamarin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BebekKolonyasi : ContentPage
    {
        public BebekKolonyasi()
        {
            InitializeComponent();
        }

        private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private async void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var product = e.SelectedItem as Product;

            string price = product.Price.ToString();
            Preferences.Set("lblName", product.Name);
            Preferences.Set("lblPrice", price);
            Preferences.Set("lblImageUrl", product.ImageUrl);

            if (e.SelectedItem != null)
            {
                await DisplayAlert("Selected item", product.Name, "Ok");

                await Navigation.PushAsync(new CartView()
                {
                    BindingContext = product
                });
            }
        }
    }
}