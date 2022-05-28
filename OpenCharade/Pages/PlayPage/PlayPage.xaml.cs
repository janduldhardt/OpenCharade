using OpenCharade.ViewModels;

namespace OpenCharade.Views.PlayPage;

public partial class PlayPage : ContentPage
{
    public PlayPage(PlayViewModel playViewModel)
    {
        InitializeComponent();
        BindingContext = playViewModel;

    }

}
