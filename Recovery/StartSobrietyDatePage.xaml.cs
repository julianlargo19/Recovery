namespace Recovery;

public partial class StartSobrietyDatePage : ContentPage
{
	public StartSobrietyDatePage()
	{
		InitializeComponent();
	}

    async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new TrackStartPage());
    }
}