using ProjectXamarin.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ProjectXamarin.ViewModels
{
    public class CesmeLimonuKolonyasiListView
    {
        public ObservableCollection<Product> CesmeLimonuKolonyasi { get; set; }

        public CesmeLimonuKolonyasiListView()
        {
            CesmeLimonuKolonyasi = new ObservableCollection<Product>
            {
                new Product
                {
                    CategoryId = 1,
                    Description = "Good",
                    Name = "Kolonya1",
                   
                    Price = 15,
                    Rating = "3",
                    ImageUrl = "https://productimages.hepsiburada.net/s/33/375/10399111381042.jpg"

                },
                new Product
                {
                    CategoryId = 1,
                    Description = "Good",
                    Name = "Kolonya1",
                    
                    Price =  25 ,
                    Rating = "3",
                    ImageUrl = "https://productimages.hepsiburada.net/s/38/375/10592965263410.jpg"

                },
                new Product
                {
                    CategoryId = 1,
                    Description = "Good",
                    Name = "Kolonya1",
                   
                    Price = 35,
                    Rating = "3",
                    ImageUrl = "https://static.happycenter.com.tr/Uploads/150-cesme-limonu-35635-500x500.png"

                },
                new Product
                {
                    CategoryId = 1,
                    Description = "Good",
                    Name = "Kolonya1",
                   
                    Price = 5,
                    Rating = "3",
                    ImageUrl = "https://besikte.com/Admin/Upload/Urun/38443.jpg"

                }
            };
        }

    }
}



