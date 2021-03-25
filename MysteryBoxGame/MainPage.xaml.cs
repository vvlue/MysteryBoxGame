using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MysteryBoxGame
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        // Low
        private void OnLowStakesClicked(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(entryAmount.Text);
            if (amount == 5 )
            {
                //var playGame = new PlayGame();
                Application.Current.MainPage = new PlayGame();
                //Application.Current.MainPage.Navigation.PushAsync(playGame);
                ClearFields();
            }
            else if (amount < 5)
            {
                string Caption = "Amount to Low";
                string Message = "Please Enter a higher amount, you can not afford to play this game.";

                DisplayAlert(Caption, Message, "Ok");
            }
            else if (amount > 50)
            {
                Console.WriteLine("Amount to high");
                string Caption = "Amount to High";
                string Message = "The most you can spend in this game is $50, please enter a lower amount.";

                DisplayAlert(Caption, Message, "Ok");
            }
            else
            {
                string Caption = "Wrong Amount";
                string Message = "Please enter an amount between $5 and $50";

                DisplayAlert(Caption, Message, "Ok");
            }

            
            
        }

        // Medium
        private void OnMedStakesClicked(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(entryAmount.Text);
            if (amount >= 10)
            {
                var playGame = new PlayGame();
                //Application.Current.MainPage.Navigation.PopAsync();
                //Application.Current.MainPage.Navigation.PushAsync(playGame);

                Application.Current.MainPage = new PlayGame();

                ClearFields();
            }
            else if (amount < 10)
            {
                string Caption = "Amount to Low";
                string Message = "Please Enter a higher amount, you can not afford to play this game.";

                DisplayAlert(Caption, Message, "Ok");
            }
            else if (amount > 50)
            {
                string Caption = "Amount to High";
                string Message = "The most you can spend in this game is $50, please enter a lower amount.";

                DisplayAlert(Caption, Message, "Ok");
            }
            else
            {
                string Caption = "Wrong Amount";
                string Message = "Please enter an amount between $5 and $50";

                DisplayAlert(Caption, Message, "Ok");
            }
        }


        // High
        private void OnHighStakesClicked(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(entryAmount.Text);
            if (amount >= 15)
            {
                var playGame = new PlayGame();
                Application.Current.MainPage.Navigation.PopAsync();
                Application.Current.MainPage.Navigation.PushAsync(playGame);

                //Application.Current.MainPage = new NavigationPage(playGame);

                ClearFields();
            }
            else if (amount < 15)
            {
                Console.WriteLine("Amount to Low");
                string Caption = "Amount to Low";
                string Message = "Please Enter a higher amount, you can not afford to play this game.";

                DisplayAlert(Caption, Message, "Ok");
            }
            else if (amount > 50)
            {
                string Caption = "Amount to High";
                string Message = "The most you can spend in this game is $50, please enter a lower amount.";

                DisplayAlert(Caption, Message, "Ok");
            }
            else
            {
                string Caption = "Wrong Amount";
                string Message = "Please enter an amount between $5 and $50";

                DisplayAlert(Caption, Message, "Ok");
            }
        }

        // go to help page
        private void OnHelpPageClicked(object sender, EventArgs e)
        {
            var helpPage = new HelpPage();
            Application.Current.MainPage.Navigation.PopAsync();
            Application.Current.MainPage.Navigation.PushAsync(helpPage);

        }

        // go to play game



        private void ClearFields()
        {
            entryAmount.Text = " ";
        }


    }
}
