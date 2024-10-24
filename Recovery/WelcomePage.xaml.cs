namespace Recovery;

public partial class WelcomePage : ContentPage
{
	public WelcomePage()
	{
		InitializeComponent();
	}

    async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new AddictionsListPage());
    }

    async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new  EmailPage());
    }
}