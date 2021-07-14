using ProjectXamarin.Models;
using ProjectXamarin.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Sepetim : ContentPage
    {
        
        public Sepetim()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            ProductDatabase database = await ProductDatabase.Instance;
            listView3.ItemsSource = await database.GetItemAsync();
           
        }

        public async void listView3_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var product = e.SelectedItem as Product;
            ProductDatabase database = await ProductDatabase.Instance;
            if (product != null)
            {
                await DisplayAlert("Sepetten silindi", product.Name, "Ok");
                await database.DeleteItemAsync(product);
                OnAppearing();
            }

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //foreach (var item in listView3.ItemsSource)
            //{
            //    var total = item. as Product
            //}

            await Navigation.PushAsync(new Odeme());

        }
    }
}