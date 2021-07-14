using ProjectXamarin.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ProjectXamarin.ViewModels
{
    public class DisMacunlariListView
    {
        public ObservableCollection<Product> DisMacunlari { get; set; }

        public DisMacunlariListView()
        {
            DisMacunlari = new ObservableCollection<Product>
            {
                new Product
                {
                    CategoryId = 1,
                    Description = "Good",
                    Name = "Kolonya1",
                    
                    Price = 30,
                    Rating = "3",
                    ImageUrl = "https://www.civilim.com/productimages/384591/big/8691685012413.jpg"

                },
                new Product
                {
                    CategoryId = 1,
                    Description = "Good",
                    Name = "Kolonya1",
                   
                    Price =  14 ,
                    Rating = "3",
                    ImageUrl = "http://www.dermoailem.com/Uploads/UrunResimleri/buyuk/dogal-bambu-aktif-karbonlu-dis-macunu-75-a0a8.jpg"

                },
                new Product
                {
                    CategoryId = 1,
                    Description = "Good",
                    Name = "Kolonya1",
                   
                    Price = 13,
                    Rating = "3",
                    ImageUrl = "https://www.kozmela.com/UserFiles/Product/big/KARANFIL-DIS-MACUNU.jpg"

                },
                new Product
                {
                    CategoryId = 1,
                    Description = "Good",
                    Name = "Kolonya1",
                    
                    Price = 16,
                    Rating = "3",
                    ImageUrl = "https://www.toptantr.com/content/images/thumbs/003/0039401_eyup-sabri-tuncer-dis-macunu-propolis-ozlu-75-ml-dis-fircasi-hediye-outlet_550.jpeg"

                }
            };
        }
    }
}



