namespace Recovery
{
    public partial class TrackStartPage : ContentPage
    {
        public TrackStartPage()
        {
            InitializeComponent(); 
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DaysTakingPage());

        }
    }
}
