namespace OpenCharade.Pages;

public class SettingsPage : ContentPage
{
	public SettingsPage()
	{
		Content = new StackLayout
		{
			Children = {
				new Label { Text = "Welcome to .NET MAUI!" }
			}
		};
	}
}