using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ProjectXamarin.Services;
using ProjectXamarin.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ProjectXamarin.ViewModels
{
    public class LoginViewModel:BaseViewModel
    {
        private string _Username;
        public string Username
        {
            get
            {
                return this._Username;
            }
            set
            {
                this._Username = value;
                OnPropertyChanged();
            }
        }
        private string _Password;
        public string Password
        {
            get
            {
                return this._Password;
            }
            set
            {
                this._Password = value;
                OnPropertyChanged();
            }
        }
        private bool _IsBusy;
        public bool IsBusy
        {
            get
            {
                return this._IsBusy;
            }
            set
            {
                this._IsBusy = value;
                OnPropertyChanged();
            }
        }
        private bool _Result;
        public bool Result
        {
            get
            {
                return this._Result;
            }
            set
            {
                this._Result = value;
                OnPropertyChanged();
            }
        }

        public Command LoginCommand { get; set; }
        public Command RegisterCommand { get; set; }


        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await LoginCommandAsync());
            RegisterCommand = new Command(async () => await RegisterCommandAsync());

        }

        private async Task RegisterCommandAsync()
        {
            if (IsBusy)
            {
                return;
            }
            try
            {
                IsBusy = true;
                var userService = new UserServices();
                Result = await userService.RegisterUser(Username, Password);
                if (Result)
                {
                    await Application.Current.MainPage.DisplayAlert("Success", "User Registered", "OK");
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "User already exist with this credentials", "OK");
                }
            }
            catch (Exception ex)
            {

                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
            finally
            {
                IsBusy = false;
            }

        }

        private async Task LoginCommandAsync()
        {
            if (IsBusy)
            {
                return;
            }
            try
            {
                IsBusy = true;
                var userService = new UserServices();
                Result = await userService.LoginUser(Username, Password);
                if (Result)
                {
                    Preferences.Set("Username", Username);
                    Preferences.Set("Password", Password);
                    await Application.Current.MainPage.Navigation.PushModalAsync(new FirstPage());
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "Invalid Username or Password", "OK");
                }
            }
            catch (Exception ex)
            {

                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
