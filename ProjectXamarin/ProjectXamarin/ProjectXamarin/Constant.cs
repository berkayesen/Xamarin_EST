using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProjectXamarin
{
    public class Constant
    {
        public const string DatabaseFileName = "ProductsDb.db3";

        public const SQLite.SQLiteOpenFlags Flags =

            SQLite.SQLiteOpenFlags.ReadWrite |
            SQLite.SQLiteOpenFlags.Create |
            SQLite.SQLiteOpenFlags.SharedCache;


        public static string DatabasePath
        {
            get
            {
                var basePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                return Path.Combine(basePath, DatabaseFileName);
            }
        }
    }
}
