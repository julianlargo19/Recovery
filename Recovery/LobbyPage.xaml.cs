using System;
using Microsoft.Maui.Controls;
using System.Timers; // Importa el Timer de System.Timers
using Timer = System.Timers.Timer; // Usa un alias para evitar ambigüedades

namespace Recovery
{
    public partial class LobbyPage : ContentPage
    {
        private Timer _timer; // Timer que se activa cada segundo
        private DateTime _startTime;

        public LobbyPage()
        {
            InitializeComponent();
            _startTime = DateTime.Now;
            StartTimer();
        }

        private void StartTimer()
        {
            _timer = new Timer(1000); // Timer que se activa cada segundo
            _timer.Elapsed += OnTimedEvent;
            _timer.AutoReset = true;
            _timer.Enabled = true;
        }

        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            TimeSpan elapsed = DateTime.Now - _startTime;
            UpdateElapsedTimeDisplay(elapsed);
        }

        private void UpdateElapsedTimeDisplay(TimeSpan elapsed)
        {
            MainThread.BeginInvokeOnMainThread(() =>
            {
                DaysLabel.Text = $"{elapsed.Days} Días";
                HoursLabel.Text = $"{elapsed.Hours} Horas";
                MinutesLabel.Text = $"{elapsed.Minutes} Minutos";
                SecondsLabel.Text = $"{elapsed.Seconds} Segundos";
            });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            _timer?.Stop();
        }

        private void Reiniciar_Clicked(object sender, EventArgs e)
        {
            _startTime = DateTime.Now;
            UpdateElapsedTimeDisplay(TimeSpan.Zero);
        }

        private async void Mensaje_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Mensaje", "Este es tu mensaje de apoyo.", "Aceptar");
        }

        private async void Compartir_Clicked(object sender, EventArgs e)
        {
            TimeSpan elapsed = DateTime.Now - _startTime;
            string message = $"He estado sobrio durante {elapsed.Days} días, {elapsed.Hours} horas, {elapsed.Minutes} minutos y {elapsed.Seconds} segundos.";

            await Share.RequestAsync(new ShareTextRequest
            {
                Text = message,
                Title = "Compartir Progreso"
            });
        }
    }
}



