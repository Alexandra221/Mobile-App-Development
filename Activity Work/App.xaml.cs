using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Activity_Work
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            MainPage.DisplayAlert("Warning", "Application started", "Fine");
        }

        protected override void OnSleep()
        {
            MainPage.DisplayAlert("Warning", "Application hibernated", "Okay");
        }

        protected override void OnResume()
        {
            MainPage.DisplayAlert("Warning", "Application resumed", "Good");
        }
    }
}
