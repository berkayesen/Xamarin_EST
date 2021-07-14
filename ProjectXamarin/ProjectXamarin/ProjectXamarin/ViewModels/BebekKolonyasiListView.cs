using ProjectXamarin.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ProjectXamarin.ViewModels
{
    public class BebekKolonyasiListView
    {
        public ObservableCollection<Product> BebekKolonyasi { get; set; }

        public BebekKolonyasiListView()
        {
            BebekKolonyasi = new ObservableCollection<Product>
            {
                new Product
                {
                    CategoryId = 1,
                    Description = "Good",
                    Name = "Kolonya1",
                  
                    Price = 20,
                    Rating = "3",
                    ImageUrl = "https://productimages.hepsiburada.net/s/25/1500/10108053684274.jpg"

                },
                new Product
                {
                    CategoryId = 1,
                    Description = "Good",
                    Name = "Kolonya1",
                   
                    Price =  15 ,
                    Rating = "3",
                    ImageUrl = "https://cdn.dsmcdn.com/mnresize/415/622/ty16/product/media/images/20201011/22/15097052/20892054/1/1_org_zoom.jpg"

                },
                new Product
                {
                    CategoryId = 1,
                    Description = "Good",
                    Name = "Kolonya1",
                   
                    Price = 11,
                    Rating = "3",
                    ImageUrl = "https://www.kozmela.com/UserFiles/Product/big/8691685002520.jpg"

                },
                new Product
                {
                    CategoryId = 1,
                    Description = "Good",
                    Name = "Kolonya1",
                   
                    Price = 13,
                    Rating = "3",
                    ImageUrl = "https://cdn.e-bebek.com/www.ebebek/i/p/hd/50/lEST-9450_1.jpg"

                }
            };
        }
    }
}




