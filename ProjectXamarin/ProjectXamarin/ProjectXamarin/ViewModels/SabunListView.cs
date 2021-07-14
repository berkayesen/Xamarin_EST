using ProjectXamarin.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ProjectXamarin.ViewModels
{
    public class SabunListView
    {
        public ObservableCollection<Product> Sabunlar { get; set; }

        public SabunListView()
        {
            Sabunlar = new ObservableCollection<Product>
            {
                new Product
                {
                    CategoryId = 1,
                    Description = "Good",
                    Name = "Kolonya1",
                    
                    Price = 15,
                    Rating = "3",
                    ImageUrl = "https://st2.myideasoft.com/idea/el/24/myassets/products/142/eyup-sabri-tunceri-sivi-sabun-cesitleri-500-ml.png?revision=1615470243"

                },
                new Product
                {
                    CategoryId = 1,
                    Description = "Good",
                    Name = "Kolonya1",
                    
                    Price =  15 ,
                    Rating = "3",
                    ImageUrl = "https://cdn.dsmcdn.com/mnresize/415/622/ty14/product/media/images/20200927/17/12207273/70282894/1/1_org_zoom.jpg"

                },
                new Product
                {
                    CategoryId = 1,
                    Description = "Good",
                    Name = "Kolonya1",
                   
                    Price = 15,
                    Rating = "3",
                    ImageUrl = "https://img-morhipo.mncdn.com/mnresize/1200/1645/productimages/i/8691685014837/[img][5][1].jpg?1427"

                },
                new Product
                {
                    CategoryId = 1,
                    Description = "Good",
                    Name = "Kolonya1",
                    
                    Price = 15,
                    Rating = "3",
                    ImageUrl = "https://img-morhipo.mncdn.com/mnresize/1200/1645/productimages/i/8691685020692/[img][5][1].jpg?1513"

                }
            };
        }
    }
}




