using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ProjectXamarin.ViewModels
{
    public class CartViewModel:BaseViewModel
    {
        private int _ProductId;

        public int ProductId
        {
            get { return _ProductId; }
            set 
            {
                _ProductId = value;
                OnPropertyChanged();
            }
        }

        private int _CategoryId;

        public int CategoryId
        {
            get { return _CategoryId; }
            set
            {
                _CategoryId = value;
                OnPropertyChanged();
            }
        }

        private string _Name;

        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
                OnPropertyChanged();
            }
        }

        private int _Price;

        public int Price
        {
            get { return this._Price; }
            set
            {
                this._Price = value;
                OnPropertyChanged();
            }
        }

        public Command RegisterCommand { get; set; }

        public CartViewModel()
        {

        }



    }
}
