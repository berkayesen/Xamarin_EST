using ProjectXamarin.Models;
using ProjectXamarin.Services;
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
    public partial class CartView : ContentPage
    {
        public CartView()
        {
            InitializeComponent();

            var response = Preferences.Get("lblName", string.Empty);

            lblName.Text = response;

            var price = Preferences.Get("lblPrice", string.Empty);

            lblPrice.Text = price;

            var image = Preferences.Get("lblImageUrl", string.Empty);

            lblImageUrl.Source = image;

            //lblImageUrl.Source = product.ImageUrl;
            //lblName.Text = product.Name;
            //lblPrice.Text = product.Price;
        }

        public async void Button_Clicked(object sender, EventArgs e)
        {
            var product = (Product)BindingContext;
            ProductDatabase database = await ProductDatabase.Instance;
            await database.SaveItemAsync(product);
            await Navigation.PopAsync();
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}