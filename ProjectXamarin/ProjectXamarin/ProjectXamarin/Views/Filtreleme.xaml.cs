using ProjectXamarin.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Filtreleme : ContentPage
    {
        public ObservableCollection<Product> products { get; set; }

        public Filtreleme()
        {
            InitializeComponent();

            products = new ObservableCollection<Product>()
            {
                 new Product
                {
                    CategoryId = 1,
                    Description = "Bodrum Mandalinası",
                    Name = "Eyüp Sabri Tuncer",

                    Price = 18,
                    Rating = "3",
                    ImageUrl = "https://productimages.hepsiburada.net/s/33/375/10416260677682.jpg"

                },
                new Product
                {
                    CategoryId = 1,
                    Description = "Çeşme Limonlu",
                    Name = "Eyüp Sabri Tuncer",

                    Price =  20 ,
                    Rating = "3",
                    ImageUrl = "https://www.eczane.com.tr/Uploads/UrunResimleri/buyuk/eyup-sabri-tuncer-sprey-kolonya-beyaz-ca-8580.jpg"

                },
                new Product
                {
                    CategoryId = 1,
                    Description = "Hatıralar Kolonyası",
                    Name = "Eyüp Sabri Tuncer",

                    Price = 5,
                    Rating = "3",
                    ImageUrl = "https://www.eczane.com.tr/Uploads/UrunResimleri/buyuk/eyup-sabri-tuncer-sprey-kolonya-amber-16-da1d.jpg"

                },
                new Product
                {
                    CategoryId = 1,
                    Description = "Japon Kiraz Çiçeği",
                    Name = "Eyüp Sabri Tuncer",

                    Price = 6,
                    Rating = "3",
                    ImageUrl = "https://cdn.dsmcdn.com/ty4/product/media/images/20200514/18/1291410/71122495/1/1_org_zoom.jpg"
                },
                new Product
                {
                    CategoryId = 2,
                    Description = "Good",
                    Name = "Kolonya1",

                    Price = 23,
                    Rating = "3",
                    ImageUrl = "https://www.kozmela.com/UserFiles/Product/big/8691685020289.jpg"

                },
                new Product
                {
                    CategoryId = 2,
                    Description = "Good",
                    Name = "Kolonya1",

                    Price =  15 ,
                    Rating = "3",
                    ImageUrl = "https://cdn03.ciceksepeti.com/cicek/kc781560-1/XL/eyup-sabri-tuncer-kolonyali-mendil-klasik-limon-100-lu-kc781560-1-7c5b3a23c966405c84f3600089b0d663.jpg"

                },
                new Product
                {
                    CategoryId = 2,
                    Description = "Good",
                    Name = "Kolonya1",

                    Price = 18,
                    Rating = "3",
                    ImageUrl = "https://cdn.akakce.com/eyup-sabri-tuncer/eyup-sabri-tuncer-karma-100-lu-kolonyali-mendil-z.jpg"

                },
                new Product
                {
                    CategoryId = 2,
                    Description = "Good",
                    Name = "Kolonya1",

                    Price = 7,
                    Rating = "3",
                    ImageUrl = "https://assets.mmsrg.com/isr/166325/c1/-/pixelboxx-mss-80081778/mobile_786_587_png/EYUP-SABRI-TUNCER-Bodrum-Mandalinas%C4%B1-Kolonyal%C4%B1-Mendil-Paket-X50"

                },
                new Product
                {
                    CategoryId = 3,
                    Description = "Good",
                    Name = "Kolonya1",

                    Price = 10,
                    Rating = "3",
                    ImageUrl = "https://productimages.hepsiburada.net/s/7/375/9749723578418.jpg"

                },
                new Product
                {
                    CategoryId = 3,
                    Description = "Good",
                    Name = "Kolonya1",

                    Price =  9 ,
                    Rating = "3",
                    ImageUrl = "https://reyonnet.com/1444-large_default/zeytinyagli-sampuan-700-ml-eyup-sabri-tuncer.jpg"

                },
                new Product
                {
                    CategoryId = 3,
                    Description = "Good",
                    Name = "Kolonya1",

                    Price = 15,
                    Rating = "3",
                    ImageUrl = "https://cdn.dsmcdn.com/mnresize/415/622/ty72/product/media/images/20210318/0/73184859/13309133/1/1_org_zoom.jpg"

                },
                new Product
                {
                    CategoryId = 3,
                    Description = "Good",
                    Name = "Kolonya1",

                    Price = 5,
                    Rating = "3",
                    ImageUrl = "https://img-morhipo.mncdn.com/mnresize/1200/1645/productimages/ii/8691685003916/[img][5][1].jpg?2153"

                },
                new Product
                {
                    CategoryId = 4,
                    Description = "Good",
                    Name = "Kolonya1",

                    Price = 17,
                    Rating = "3",
                    ImageUrl = "https://cdn.dsmcdn.com/mnresize/415/622/ty29/product/media/images/20201202/12/34400517/115170453/1/1_org_zoom.jpg"

                },
                new Product
                {
                    CategoryId = 4,
                    Description = "Good",
                    Name = "Kolonya1",

                    Price =  12 ,
                    Rating = "3",
                    ImageUrl = "https://n11scdn.akamaized.net/a1/640/ev-yasam/yuzey-temizleyiciler/eyup-sabri-tuncer-pine-est-dogal-cam-yagli-yuzey-temizleyici-1-l__0319452774734055.jpg"

                },
                new Product
                {
                    CategoryId = 4,
                    Description = "Good",
                    Name = "Kolonya1",

                    Price = 15,
                    Rating = "3",
                    ImageUrl = "https://www.hijyenland.com/img/products/small/5lt_11.09.2020_0853e4f.jpg"

                },
                new Product
                {
                    CategoryId = 4,
                    Description = "Good",
                    Name = "Kolonya1",

                    Price = 13,
                    Rating = "3",
                    ImageUrl = "https://cdn.dsmcdn.com//ty111/product/media/images/20210504/18/85688330/170816024/0/0_org.jpg"

                }
            };

            listViewProduct.ItemsSource = products;
        }

        private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            //var searchResult = products.Where(p => p.Price.Contains(slider.Value));

            //collectionView.ItemsSource = searchResult;



            IEnumerable<Product> Products = from product in products
                                            where product.Price == slider.Value
                                            select product; 

            listViewProduct.ItemsSource = Products;
        }

       

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var searchResult = products.Where(p => p.Name.Contains(searchBar2.Text));

            listViewProduct.ItemsSource = searchResult;
        }

        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            
            if (e.Value)
            {
                IEnumerable<Product> Products = from product in products
                                                where product.CategoryId == 1
                                                select product;

                listViewProduct.ItemsSource = Products;
            }
            else
            {
                listViewProduct.ItemsSource = products;
            }
            
        }

        private void CheckBox_CheckedChanged_1(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value)
            {
                IEnumerable<Product> Products = from product in products
                                                where product.CategoryId == 2
                                                select product;

                listViewProduct.ItemsSource = Products;
            }
            else
            {
                listViewProduct.ItemsSource = products;
            }
        }

        private void CheckBox_CheckedChanged_2(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value)
            {
                IEnumerable<Product> Products = from product in products
                                                where product.CategoryId == 3
                                                select product;

                listViewProduct.ItemsSource = Products;
            }
            else
            {
                listViewProduct.ItemsSource = products;
            }
        }

        private void CheckBox_CheckedChanged_3(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value)
            {
                IEnumerable<Product> Products = from product in products
                                                where product.CategoryId == 4
                                                select product;

                listViewProduct.ItemsSource = Products;
            }
            else
            {
                listViewProduct.ItemsSource = products;
            }
        }
        private async void listViewProduct_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var product = e.SelectedItem as Product;

            string price = product.Price.ToString();
            Preferences.Set("lblName", product.Name);
            Preferences.Set("lblPrice", price);
            Preferences.Set("lblImageUrl", product.ImageUrl);

            if (e.SelectedItem != null)
            {
                await DisplayAlert("Selected Item", product.Name, "Ok");

                await Navigation.PushAsync(new CartView()
                {
                    BindingContext = product
                });
            }
        }
    }
}