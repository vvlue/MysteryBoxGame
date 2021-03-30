using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MysteryBoxGame
{
    public partial class PlayArea : ContentPage
    {
        public PlayArea()
        {
            InitializeComponent();
        }
        // on open boxes
        private void OnOpenBoxes(object sender, EventArgs e)
        {

        }

        // feedback

        private void FeedbackToPlayer()
        {
            string welcome = string.Format("Welcome your starting balance is");
        }

        // go to help page
        private void OnHelpPageClicked(object sender, EventArgs e)
        {
            var helpPage = new HelpPage();
            Application.Current.MainPage.Navigation.PopAsync();
            Application.Current.MainPage.Navigation.PushAsync(helpPage);

        }

        // go to statistics
        private void OnGameStatsClicked(object sender, EventArgs e)
        {
            var gameStats = new GameStats();
            Application.Current.MainPage.Navigation.PopAsync();
            Application.Current.MainPage.Navigation.PushAsync(gameStats);
        }
    }
}
