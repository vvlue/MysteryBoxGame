using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MysteryBoxGame
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //var playPage = new MainPage();
            //Application.Current.MainPage = playPage;

            var mainPage = new MainPage();
            Application.Current.MainPage = new NavigationPage(mainPage);

            
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
