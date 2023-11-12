using Microcharts.Maui;
using UraniumUI;

namespace Finanzas;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var Builder = MauiApp.CreateBuilder();
        Builder.UseMauiApp<App>().UsePages().UseViewModels()
               .UseMauiCommunityToolkit().UseServices().UseFonts()
               .UseUraniumUI().UseUraniumUIMaterial().UseMicrocharts();

#if DEBUG
        Builder.Logging.AddDebug();
#endif

        return Builder.Build();
    }
}