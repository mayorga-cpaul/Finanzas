using Microcharts.Maui;
using Mopups.Hosting;
using UraniumUI;

namespace Finanzas;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var Builder = MauiApp.CreateBuilder();
        Builder.UseMauiApp<App>().UsePages().UseViewModels()
               .UseMauiCommunityToolkit().UseServices().UseFonts()
               .UseUraniumUI().UseUraniumUIMaterial().UseMicrocharts()
               .ConfigureMopups();

#if DEBUG
        Builder.Logging.AddDebug();
#endif

        return Builder.Build();
    }
}