using ProjectXamarin.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ProjectXamarin.ViewModels
{
    public class LosyonVeKremListView
    {
        public ObservableCollection<Product> LosyonVeKremler { get; set; }

        public LosyonVeKremListView()
        {
            LosyonVeKremler = new ObservableCollection<Product>
            {
                new Product
                {
                    CategoryId = 1,
                    Description = "Good",
                    Name = "Kolonya1",
                    
                    Price = 18,
                    Rating = "3",
                    ImageUrl = "https://productimages.hepsiburada.net/s/44/375/10820230185010.jpg"

                },
                new Product
                {
                    CategoryId = 1,
                    Description = "Good",
                    Name = "Kolonya1",
                   
                    Price =  5 ,
                    Rating = "3",
                    ImageUrl = "https://productimages.hepsiburada.net/s/7/375/9749984608306.jpg"

                },
                new Product
                {
                    CategoryId = 1,
                    Description = "Good",
                    Name = "Kolonya1",
                  
                    Price = 4,
                    Rating = "3",
                    ImageUrl = "https://img-watsons.mncdn.com/Content/Images/Thumbs/0314751_eyup-sabri-tuncer-dogal-zeytinyagli-dus-jeli-600-ml-41834.png"

                },
                new Product
                {
                    CategoryId = 1,
                    Description = "Good",
                    Name = "Kolonya1",
                  
                    Price = 7,
                    Rating = "3",
                    ImageUrl = "https://www.kozmela.com/UserFiles/Product/big/8691685007907.jpg"

                }
            };
        }
    }
}



