namespace Recovery;

public partial class EmailPage : ContentPage
{
	public EmailPage()
	{
		InitializeComponent();
	}

    async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CreateUserPage());
    }
}