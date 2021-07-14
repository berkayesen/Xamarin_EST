using ProjectXamarin.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ProjectXamarin.ViewModels
{
    public class YuzeyTemizleyiciListView
    {
        public ObservableCollection<Product> YuzeyTemizleyiciler { get; set; }

        public YuzeyTemizleyiciListView()
        {
            YuzeyTemizleyiciler = new ObservableCollection<Product>
            {
                new Product
                {
                    CategoryId = 4,
                    Description = "Good",
                    Name = "Kolonya1",
                   
                    Price = 17,
                    Rating = "3",
                    ImageUrl = "https://cdn.dsmcdn.com/mnresize/415/622/ty29/product/media/images/20201202/12/34400517/115170453/1/1_org_zoom.jpg"

                },
                new Product
                {
                    CategoryId = 4,
                    Description = "Good",
                    Name = "Kolonya1",
                  
                    Price =  12 ,
                    Rating = "3",
                    ImageUrl = "https://n11scdn.akamaized.net/a1/640/ev-yasam/yuzey-temizleyiciler/eyup-sabri-tuncer-pine-est-dogal-cam-yagli-yuzey-temizleyici-1-l__0319452774734055.jpg"

                },
                new Product
                {
                    CategoryId = 4,
                    Description = "Good",
                    Name = "Kolonya1",
                   
                    Price = 15,
                    Rating = "3",
                    ImageUrl = "https://www.hijyenland.com/img/products/small/5lt_11.09.2020_0853e4f.jpg"

                },
                new Product
                {
                    CategoryId = 4,
                    Description = "Good",
                    Name = "Kolonya1",
                    
                    Price = 13,
                    Rating = "3",
                    ImageUrl = "https://cdn.dsmcdn.com//ty111/product/media/images/20210504/18/85688330/170816024/0/0_org.jpg"

                }
            };
        }
    }
}



