using OpenCharade.Services;
using OpenCharade.ViewModels;
using OpenCharade.Views;
using OpenCharade.Views.MainPage;
using OpenCharade.Views.PlayPage;
using Serilog;

namespace OpenCharade;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

      Log.Logger = new LoggerConfiguration()
      .Enrich.FromLogContext()
      .CreateLogger();

        builder.Services.AddLogging(logging =>
        {
            logging.AddSerilog();

        });
        builder.Services.AddSingleton<IDeckService, DeckService>();
        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<MainViewModel>();
        builder.Services.AddTransient<PlayPage>();
        builder.Services.AddTransient<PlayViewModel>();


		return builder.Build();
	}
}
