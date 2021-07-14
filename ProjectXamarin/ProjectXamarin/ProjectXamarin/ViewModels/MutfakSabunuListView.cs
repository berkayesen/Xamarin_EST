using ProjectXamarin.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ProjectXamarin.ViewModels
{
    public class MutfakSabunuListView
    {
        public ObservableCollection<Product> MutfakSabunulari { get; set; }

        public MutfakSabunuListView()
        {
            MutfakSabunulari = new ObservableCollection<Product>
            {
                new Product
                {
                    CategoryId = 1,
                    Description = "Good",
                    Name = "Kolonya1",

                    Price = 14,
                    Rating = "3",
                    ImageUrl = "https://www.dermokozmetika.com.tr/eyup-sabri-tuncer-mutfak-sabunu-cilek-500ml-40253-30-O.jpg"

                },
                new Product
                {
                    CategoryId = 1,
                    Description = "Good",
                    Name = "Kolonya1",
                    
                    Price =  23 ,
                    Rating = "3",
                    ImageUrl = "https://productimages.hepsiburada.net/s/53/375/11143758053426.jpg"

                },
                new Product
                {
                    CategoryId = 1,
                    Description = "Good",
                    Name = "Kolonya1",

                    Price = 17,
                    Rating = "3",
                    ImageUrl = "https://cdn.dsmcdn.com/mnresize/415/622/ty43/product/media/images/20210101/17/44228012/125647255/1/1_org_zoom.jpg"

                },
                new Product
                {
                    CategoryId = 1,
                    Description = "Good",
                    Name = "Kolonya1",
                   
                    Price = 18,
                    Rating = "3",
                    ImageUrl = "https://cdn.happy.com.tr/image/cache/data/happy-images-new/eyup-sabri-tuncer-kiraz-aromali-mutfak-sabunu-500-ml-sunger-x-2-adet-500-500.jpg"

                }
            };
        }
    }
}




