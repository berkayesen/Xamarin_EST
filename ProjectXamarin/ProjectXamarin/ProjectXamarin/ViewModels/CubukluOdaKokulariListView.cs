using ProjectXamarin.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ProjectXamarin.ViewModels
{
    class CubukluOdaKokulariListView
    {

        public ObservableCollection<Product> CubukluOdaKokulari { get; set; }

        public CubukluOdaKokulariListView()
        {
            CubukluOdaKokulari = new ObservableCollection<Product>
            {
                new Product
                {
                    CategoryId = 1,
                    Description = "Good",
                    Name = "Kolonya1",
                    
                    Price = 26,
                    Rating = "3",
                    ImageUrl = "https://www.eyupsabrituncer.com/Uploads/UrunResimleri/thumb/reed-diffuser-alacati-lavanta-oda-kokusu-8568.jpg"

                },
                new Product
                {
                    CategoryId = 1,
                    Description = "Good",
                    Name = "Kolonya1",
                    
                    Price =  15 ,
                    Rating = "3",
                    ImageUrl = "https://www.dermoeczanem.com/eyup-sabri-tuncer-alacati-4lu-kisisel-bakim-seti-eyup-sabri-tuncer-150046-66-B.jpg"

                },
                new Product
                {
                    CategoryId = 1,
                    Description = "Good",
                    Name = "Kolonya1",
                   
                    Price = 12,
                    Rating = "3",
                    ImageUrl = "https://www.eselami.com/images/shelf/5c8bf9fd32bd0507212d9609/b/reed-diffuser-mystic-amber-100-ml-772-982.jpg"

                },
                new Product
                {
                    CategoryId = 1,
                    Description = "Good",
                    Name = "Kolonya1",
                    
                    Price = 7,
                    Rating = "3",
                    ImageUrl = "https://www.eyupsabrituncer.com/Uploads/UrunResimleri/thumb/reed-diffuser-graceful-hyacinth-oda-koku-baf0.jpg"

                }
            };
        }
    }
}



