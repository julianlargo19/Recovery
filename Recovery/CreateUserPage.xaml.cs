using System.ComponentModel;
using Microsoft.Maui.Controls;

namespace Recovery
{
    public partial class CreateUserPage : ContentPage, INotifyPropertyChanged
    {
        private string username;
        private string password;
        private bool isTermsAccepted;

        public event PropertyChangedEventHandler PropertyChanged;

        public Command OnNextCommand { get; set; }

        public bool IsNextButtonEnabled => !string.IsNullOrEmpty(username) && password?.Length >= 8 && isTermsAccepted;

        // Constructor correcto
        public CreateUserPage()
        {
            InitializeComponent();
            OnNextCommand = new Command(OnNext);
            BindingContext = this;

            // Suscribirse a eventos de los controles
            UsernameEntry.TextChanged += (s, e) =>
            {
                username = e.NewTextValue;
                OnPropertyChanged(nameof(IsNextButtonEnabled));
            };

            PasswordEntry.TextChanged += (s, e) =>
            {
                password = e.NewTextValue;
                OnPropertyChanged(nameof(IsNextButtonEnabled));
            };

            TermsCheckBox.CheckedChanged += (s, e) =>
            {
                isTermsAccepted = e.Value;
                OnPropertyChanged(nameof(IsNextButtonEnabled));
            };
        }

        private async void OnNext()
        {
            
            await DisplayAlert("Registro", "Usuario y contraseña registrados correctamente.", "OK");
            
        }

        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddictionsListPage());
        }
    }
}
