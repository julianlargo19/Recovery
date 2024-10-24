namespace Recovery;

public partial class DaysTakingPage : ContentPage
{
    private int _dias;

    public DaysTakingPage()
    {
        InitializeComponent();
        _dias = 0; 
        ActualizarDiasLabel();
        ActualizarBotones(); 
    }

    private void OnIncrementClicked(object sender, EventArgs e)
    {
        if (_dias < 7) 
        {
            _dias++;
            ActualizarDiasLabel();
            ActualizarBotones(); 
        }
    }

    private void OnDecrementClicked(object sender, EventArgs e)
    {
        if (_dias > 0) 
        {
            _dias--;
            ActualizarDiasLabel();
            ActualizarBotones(); 
        }
    }

    private void ActualizarDiasLabel()
    {
        DiasLabel.Text = $"{_dias} días"; 
    }

    private void ActualizarBotones()
    {
       
        for (int i = 1; i <= 7; i++)
        {
            var boton = (Button)FindByName($"Boton{i}");
            if (i <= _dias)
            {
                boton.Text = "X"; 
                boton.BackgroundColor = Colors.Black;
                boton.TextColor = Colors.White;
            }
            else
            {
                boton.Text = "✓";
                boton.BackgroundColor = Colors.White;
                boton.TextColor = Colors.Black; 
            }
        }
    }

    async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TimesTakingPage());

    }
}