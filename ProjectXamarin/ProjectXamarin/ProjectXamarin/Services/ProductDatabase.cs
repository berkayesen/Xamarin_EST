using ProjectXamarin.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjectXamarin.Services
{
    public class ProductDatabase
    {
        //readonly SQLiteAsyncConnection _database;

        //public ProductDatabase(string db)
        //{
        //    _database = new SQLiteAsyncConnection(db);
        //    _database.CreateTableAsync<Product>().Wait();
        //}

        //public Task<List<Product>> GetProductAsync()
        //{
        //    return _database.Table<Product>().ToListAsync();
        //}

        //public Task<int> SaveProductAsync(Product product)
        //{
        //    return _database.InsertAsync(product);
        //}

        static SQLiteAsyncConnection database;

        public static readonly AsyncLazy<ProductDatabase> Instance = new AsyncLazy<ProductDatabase>(async () =>
        {
            var instance = new ProductDatabase();
            CreateTableResult result = await database.CreateTableAsync<Product>();
            return instance;
        });

        public ProductDatabase()
        {
            database = new SQLiteAsyncConnection(Constant.DatabasePath, Constant.Flags);
        }

        public Task<List<Product>> GetItemAsync()
        {
            return database.Table<Product>().ToListAsync();
        }

        public Task<List<Product>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<Product>("SELECT * FROM [TodoItem] WHERE [Done] = 0");
        }

        public Task<Product> GetItemAsync(int id)
        {
            return database.Table<Product>().Where(i => i.ProductId == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(Product item)
        {
            if (item.ProductId != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(Product item)
        {
            return database.DeleteAsync(item);
        }
    }
}
