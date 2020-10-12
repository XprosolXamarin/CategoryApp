using CategoryApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CategoryApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CategoryPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
