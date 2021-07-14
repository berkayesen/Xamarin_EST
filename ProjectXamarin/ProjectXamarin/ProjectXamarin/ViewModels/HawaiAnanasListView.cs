using ProjectXamarin.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ProjectXamarin.ViewModels
{
    public class HawaiAnanasListView:BaseViewModel
    {
        public ObservableCollection<Product> HawaiAnanasKolonyasi { get; set; }

        public HawaiAnanasListView()
        {
            HawaiAnanasKolonyasi = new ObservableCollection<Product>
            {
                new Product
                {
                    CategoryId = 1,
                    Description = "150 ml",
                    Name = "Eyüp Sabri Tuncer",                   
                    Price = 15,
                    Rating = "3",
                    ImageUrl = "https://www.dermoeczanem.com/eyup-sabri-tuncer-hawaii-ananas-kolonya-400-ml-pet-sise-eyup-sabri-tuncer-151710-67-B.jpg"

                },
                new Product
                {
                    CategoryId = 1,
                    Description = "200 ml",
                    Name = "Eyüp Sabri Tuncer",                    
                    Price =  20 ,
                    Rating = "3.5",
                    ImageUrl = "https://www.dermoeczanem.com/eyup-sabri-tuncer-hawaii-ananas-kolonya-150-ml-pet-sise-eyup-sabri-tuncer-151718-67-B.jpg"

                },
                new Product
                {
                    CategoryId = 1,
                    Description = "400 ml",
                    Name = "Eyüp Sabri Tuncer",                    
                    Price = 18,
                    Rating = "2.75",
                    ImageUrl = "https://www.eyupsabrituncer.com/Uploads/UrunResimleri/buyuk/japon-kiraz-cicegi-kolonyasi-5-lt-bag-in-a4e7.jpg"

                }
                
            };
        }
    }
}



