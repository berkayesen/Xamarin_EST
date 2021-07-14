using ProjectXamarin.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ProjectXamarin.ViewModels
{
    public class KolonyaliMendilListView
    {
        public ObservableCollection<Product> KolonyaliMendil { get; set; }

        public KolonyaliMendilListView()
        {
            KolonyaliMendil = new ObservableCollection<Product>
            {
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

                }
            };
        }
    }
}



