

using OpenCharade.Data.Models;
using OpenCharade.Services;
using System.Collections.ObjectModel;
using Microsoft.Extensions.Logging;
using OpenCharade.Views;
using CommunityToolkit.Mvvm.Input;
using OpenCharade.ViewModels;

namespace OpenCharade.Views.MainPage
{
    public partial class MainViewModel : BaseViewModel
    {
        public ObservableCollection<DeckViewModel> Decks { get; } = new ObservableCollection<DeckViewModel>();

        private readonly IDeckService _deckService;
        public MainViewModel(IDeckService deckService)
        {
            _deckService = deckService;
            GetDecksAsync().ConfigureAwait(false);
        }

        async Task GetDecksAsync()
        {
            try
            {
                var decks = await _deckService.GetDecksAsync();
                foreach (var deck in decks)
                {
                    Decks.Add(new DeckViewModel(deck));
                }
            }
            catch (Exception e)
            {

            }
        }

    }
}
