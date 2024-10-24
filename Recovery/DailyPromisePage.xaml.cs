namespace Recovery;

public partial class DailyPromisePage : ContentPage
{
	public DailyPromisePage()
	{
		InitializeComponent();
	}

    async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LobbyPage());
    }
}