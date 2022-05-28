
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using OpenCharade.Data.Models;
using OpenCharade.Views;
using OpenCharade.Views.PlayPage;

namespace OpenCharade.ViewModels
{
    public partial class DeckViewModel : BaseViewModel
    {
        public Deck Deck { get; }

        public DeckViewModel(Deck deck)
        {
            Deck = deck;
        }

        [ICommand]
        async Task Navigate(Deck deck)
        {
            if(deck == null) {
                return;
            }

            await Shell.Current.GoToAsync($"{nameof(PlayPage)}", true,
                new Dictionary<string, object>
                {
                    {"Deck", deck }
                });
        }
    }
}
