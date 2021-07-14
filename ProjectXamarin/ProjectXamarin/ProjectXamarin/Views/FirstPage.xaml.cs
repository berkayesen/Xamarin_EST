using ProjectXamarin.Models;
using ProjectXamarin.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstPage : ContentPage
    {
        public ObservableCollection<Category> categories { get; set; }
        public ObservableCollection<Product> products { get; set; }

        public FirstPage()
        {
            InitializeComponent();

            categories = new ObservableCollection<Category>()
            {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Kolonyalar",
                    ImageUrl = "image1.png"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Kolonyalı Mendil",
                    ImageUrl = "image1.png"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Ev Bakım",
                    ImageUrl = "image1.png"
                },
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Kişisel Bakım",
                    ImageUrl = "image1.png"
                },
            };

            cvCategory.ItemsSource = categories;

            products = new ObservableCollection<Product>()
            {
                new Product()
                {
                    CategoryId = 1,
                    Description = "Good",
                    Name = "kolonya",
                    Price = 15,
                    ImageUrl = "image1.png",
                    Rating = "3.5"  
                },
                new Product()
                {
                    CategoryId = 1,
                    Description = "Good",
                    Name = "kolonyalımendil",
                    Price = 15,
                    ImageUrl = "r1.png",
                    Rating = "3.5"
                },
                new Product()
                {
                    CategoryId = 1,
                    Description = "Good",
                    Name = "evbakim",
                    Price = 15,
                    ImageUrl = "r2.png",
                    Rating = "3.5"
                },
                new Product()
                {
                    CategoryId = 1,
                    Description = "Good",
                    Name = "kişiselbakım",
                    Price = 15,
                    ImageUrl = "r3.png",
                    Rating = "3.5"
                },
                new Product()
                {
                    CategoryId = 1,
                    Description = "Good",
                    Name = "evbakım",
                    Price = 15,
                    ImageUrl = "r4.png",
                    Rating = "3.5"
                },
               

            };

            cvProduct.ItemsSource = products;


        }

        public async void cvCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var category = (e.CurrentSelection.FirstOrDefault() as Product)?.Name;

            if (category== "Kolonyalar")
            {
                await Navigation.PushModalAsync(new Kolonya());
            }
            if (category == "Kolonyalı Mendil")
            {
                await Navigation.PushModalAsync(new KolonyaliMendil());
            }
        }

        private void cvProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {

        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var searchResult = products.Where(p => p.Name.Contains(search1.Text));

            cvProduct.ItemsSource = searchResult;
        }

        private async  void search1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Filtreleme());
        }
    }
}