using System;

using Xamarin.Forms;

namespace MysteryBoxGame
{
    public class PlayerClass : ContentPage
    {
        public PlayerClass()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

