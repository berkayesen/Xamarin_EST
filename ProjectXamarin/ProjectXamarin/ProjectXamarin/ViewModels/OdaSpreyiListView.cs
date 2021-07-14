using ProjectXamarin.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ProjectXamarin.ViewModels
{
    public class OdaSpreyiListView
    {
        public ObservableCollection<Product> OdaSpreyleri { get; set; }

        public OdaSpreyiListView()
        {
            OdaSpreyleri = new ObservableCollection<Product>
            {
                new Product
                {
                    CategoryId = 1,
                    Description = "Good",
                    Name = "Kolonya1",
                  
                    Price = 14,
                    Rating = "3",
                    ImageUrl = "https://www.eyupsabrituncer.com/Uploads/UrunResimleri/buyuk/Yeni-Nesil-Oda-Spreyi-Bahar-Tazeligi-500-16c0.jpg"

                },
                new Product
                {
                    CategoryId = 1,
                    Description = "Good",
                    Name = "Kolonya1",
                  
                    Price =  25 ,
                    Rating = "3",
                    ImageUrl = "https://productimages.hepsiburada.net/s/9/375/9222160154674.jpg"

                },
                new Product
                {
                    CategoryId = 1,
                    Description = "Good",
                    Name = "Kolonya1",
                    
                    Price = 5,
                    Rating = "3",
                    ImageUrl = "http://www.cossta.com.tr/Uploads/UrunResimleri/buyuk/eyup-sabri-tuncer-gizli-bahce-nar-cicegi-86b1.jpg"

                },
                new Product
                {
                    CategoryId = 1,
                    Description = "Good",
                    Name = "Kolonya1",
                  
                    Price = 14,
                    Rating = "3",
                    ImageUrl = "https://www.dermokozmetika.com.tr/eyup-sabri-tuncer-japon-kiraz-cicegi-oda-spreyi-500-ml-30475-24-O.jpg"

                }
            };
        }
    }
}



