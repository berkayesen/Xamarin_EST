using ProjectXamarin.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ProjectXamarin.ViewModels
{
    public class MiniKolonyalarListView
    {
        public ObservableCollection<Product> MiniKolonyalar { get; set; }

        public MiniKolonyalarListView()
        {
            MiniKolonyalar = new ObservableCollection<Product>
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

                }
            };
        }
    }
}


