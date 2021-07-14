using ProjectXamarin.Models;
using ProjectXamarin.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Essentials;

namespace ProjectXamarin.ViewModels
{
    public class FirstPageViewMdel:BaseViewModel
    {
        private string _UserName;

        public string UserName
        {
            get { return _UserName; }
            set
            {
                _UserName = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Category> Categories { get; set; }
        public ObservableCollection<Product> Products { get; set; }

        public FirstPageViewMdel()
        {
            var uname = Preferences.Get("Username", String.Empty);
            if (String.IsNullOrEmpty(uname))
            {
                UserName = "Guest";
            }
            else
            {
                UserName = uname;
            }

            Categories = new ObservableCollection<Category>();
            Products = new ObservableCollection<Product>();


            //GetProductItems();
            //GetCategories();
           
        }

        //private async void GetProductItems()
        //{
        //    var data = await new ProductItemService().GetProductItemAsync();
        //    Products.Clear();
        //    foreach (var item in data)
        //    {
        //        Products.Add(item);
        //    }
        //}

        //private async void GetCategories()
        //{
        //    var data = await new CategoriesDataServices().GetCategoriesAsync();
        //    Categories.Clear();
        //    foreach (var item in data)
        //    {
        //        Categories.Add(item);
        //    }
        //}


    }
}
