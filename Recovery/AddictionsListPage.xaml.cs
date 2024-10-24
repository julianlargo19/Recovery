

namespace Recovery;

public partial class AddictionsListPage : ContentPage
{
    public AddictionsListPage()
    {
        InitializeComponent();
    }

    async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AddictionOwnPage());
    }

    async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new StartSobrietyDatePage());
    }
}