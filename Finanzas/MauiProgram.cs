namespace Finanzas;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var Builder = MauiApp.CreateBuilder();
        Builder.UseMauiApp<App>().UsePages().UseViewModels()
               .UseMauiCommunityToolkit().UseServices().UseFonts();

#if DEBUG
        Builder.Logging.AddDebug();
#endif

        return Builder.Build();
    }
}