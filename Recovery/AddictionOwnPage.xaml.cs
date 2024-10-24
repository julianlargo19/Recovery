namespace Recovery;

public partial class AddictionOwnPage : ContentPage
{
	public AddictionOwnPage()
	{
		InitializeComponent();
	}

    async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new StartSobrietyDatePage());
    }
}