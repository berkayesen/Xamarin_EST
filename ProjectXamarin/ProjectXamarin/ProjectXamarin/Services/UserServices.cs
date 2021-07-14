using Firebase.Database;
using Firebase.Database.Query;
using ProjectXamarin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectXamarin.Services
{
    public class UserServices
    {
        FirebaseClient client;
        public UserServices()
        {
            client = new FirebaseClient("https://appxamarin-90f3f-default-rtdb.firebaseio.com/");  
        }
        public async Task<bool> IsUserExist(string uname)
        {
            var user = (await client.Child("Users").OnceAsync<User>()).Where(u => u.Object.Username == uname).FirstOrDefault();

            return (user != null);
        }

        public async Task<bool> RegisterUser(string uname, string passwd)
        {
            if (await IsUserExist(uname) == false)
            {
                await client.Child("Users").PostAsync(new User()
                {
                    Username = uname,
                    Password = passwd
                });

                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> LoginUser(string uname, string passwd)
        {
            var user = (await client.Child("Users").OnceAsync<User>()).Where(u => u.Object.Username == uname)
                .Where(u => u.Object.Password == passwd).FirstOrDefault();


            return (user != null);
        }
    }
}
