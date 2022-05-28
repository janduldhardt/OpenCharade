using OpenCharade.Views.MainPage;

namespace OpenCharade;

public partial class MainPage : ContentPage
{

    public MainPage(MainViewModel mainViewModel)
    {
        InitializeComponent();
        BindingContext = mainViewModel;
    }
}

