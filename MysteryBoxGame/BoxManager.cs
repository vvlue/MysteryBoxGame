using System;

using Xamarin.Forms;

namespace MysteryBoxGame
{
    public class BoxManager : ContentPage
    {
        public BoxManager()
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

