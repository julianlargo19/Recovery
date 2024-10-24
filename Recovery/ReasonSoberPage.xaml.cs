namespace Recovery;

public partial class ReasonSoberPage : ContentPage
{
	public ReasonSoberPage()
	{
		InitializeComponent();
	}

    async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DailyPromisePage());

    }
}