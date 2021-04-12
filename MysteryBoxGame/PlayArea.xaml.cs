using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MysteryBoxGame
{
    public partial class PlayArea : ContentPage
    {
        PlayerClass player;



        public PlayArea(PlayerClass p)
        {
            InitializeComponent();
            player = p;
            
            Box1.Source = "03.gif";
        }
        // on open boxes
        private void OnOpenBoxes(object sender, EventArgs e)
        {
            List<int> values = player.OpenBoxes();
            Box1.Source = $"a0{values[0]}.gif";
            Box2.Source = $"_0{values[0]}.gif";
            Box3.Source = $"_0{values[0]}.gif";
        }

        //put a letter infront of file name 

        // feedback
        //private void FeedbackToPlayer()
        //{
        //    string welcome = string.Format("Welcome your starting balance is");
        //}

        // pop up summary of Help Page
        private void HelpAlertClicked(object sender, EventArgs e)
        {
            
            string Caption = "Help";
            string Message = "Click the 'Open Boxes' button to see whats inside the box. If the box contains gold, you can earn $30 (low stakes). If they contained copper, silver, and gold, you would recieve $13 ($1 + $2 + $10) and so on. You can quit the game at any time, however once you are out of money the button will turn red and you will have to quit the game.";


            DisplayAlert(Caption, Message, "Ok");

        }

        // go to statistics
        private void OnGameStatsClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new GameStats();
        }
    }
}
