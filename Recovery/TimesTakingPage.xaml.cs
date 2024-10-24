using System;
using Microsoft.Maui.Controls;

namespace Recovery
{
    public partial class TimesTakingPage : ContentPage
    {
        private int _timesCount = 0;

        public TimesTakingPage()
        {
            InitializeComponent();
            UpdateTimesCountDisplay();
        }

        private void OnDecreaseClicked(object sender, EventArgs e)
        {
            if (_timesCount > 0)
            {
                _timesCount--;
                UpdateTimesCountDisplay();
            }
        }

        private void OnIncreaseClicked(object sender, EventArgs e)
        {
            if (_timesCount < 10)
            {
                _timesCount++;
                UpdateTimesCountDisplay();
            }
        }

        private void UpdateTimesCountDisplay()
        {
            
            if (_timesCount == 0)
            {
                TimesCountLabel.Text = "0 veces";
            }
            
            else if (_timesCount == 1)
            {
                TimesCountLabel.Text = "1 vez";
            }
            
            else if (_timesCount >= 10)
            {
                TimesCountLabel.Text = "10+ veces";
            }
            
            else
            {
                TimesCountLabel.Text = $"{_timesCount} veces";
            }

            
            TimesCountContainer.Children.Clear();

            
            for (int i = 0; i < _timesCount; i++)
            {
                var circleButton = new Button
                {
                    Text = "X",
                    WidthRequest = 40,
                    HeightRequest = 40,
                    BackgroundColor = Colors.Black,
                    TextColor = Colors.White,
                    CornerRadius = 20,
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Center
                };

                TimesCountContainer.Children.Add(circleButton);
            }
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ReasonSoberPage());
        }
    }
}


