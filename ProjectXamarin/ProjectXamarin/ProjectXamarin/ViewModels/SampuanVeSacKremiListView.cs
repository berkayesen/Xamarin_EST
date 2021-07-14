using ProjectXamarin.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ProjectXamarin.ViewModels
{
    public class SampuanVeSacKremiListView
    {
        public ObservableCollection<Product> SampuanVeKremler { get; set; }

        public SampuanVeSacKremiListView()
        {
            SampuanVeKremler = new ObservableCollection<Product>
            {
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

                }
            };
        }
    }
}



