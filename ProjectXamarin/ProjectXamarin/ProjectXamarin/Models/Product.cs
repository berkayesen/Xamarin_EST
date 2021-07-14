using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectXamarin.Models
{
    public class Product
    {
        [PrimaryKey,AutoIncrement]
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public double Price { get; set; }
        public string Rating { get; set; }
    }
}
