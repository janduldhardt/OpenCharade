

using System;
using System.Timers;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using OpenCharade.Data.Models;
using OpenCharade.Views;
using Timer = System.Timers.Timer;

namespace OpenCharade.ViewModels
{
    [QueryProperty("Deck", "Deck")]
    public partial class PlayViewModel : BaseViewModel
    {
        Deck _deck;

        [ObservableProperty]
        int _points;

        public Deck Deck
        {
            get { return _deck; }
            set { _deck = value;
                NextCard();
                SetProperty(ref _deck, value);
            }
        }

        [ObservableProperty]
        Card? _currentCard;

        Timer _timer;

        DateTime _startDateTime;

        [ObservableProperty]
        public string _elapsedTime;


        public PlayViewModel()
        {
            //Accelerometer.ShakeDetected += OnShake;
            _startDateTime = DateTime.Now;
            _timer = new Timer(100);
            _timer.Start();
            _timer.Elapsed += OnTimed;
        }

        private void OnTimed(object? sender, ElapsedEventArgs e)
        {
            var seconds = (e.SignalTime - _startDateTime).TotalSeconds;
            ElapsedTime = seconds.ToString("N0");
            if(seconds > 5)
            {
                EndGame();
            }
        }

        private async void EndGame()
        {
              _timer.Stop();
            _timer.Dispose();
            await Device.InvokeOnMainThreadAsync(async () =>
            {
                await Shell.Current.GoToAsync("..");
            });
        }

        private void OnShake(object? sender, EventArgs e)
        {
            
        }

        [ICommand]
        void NextCard()
        {
            var random = new Random();
            CurrentCard = _deck.Cards[random.Next(0, _deck.Cards.Count)];
        }

        [ICommand]
        void Correct()
        {
            Points++;
            NextCard();
        }
    }
}
