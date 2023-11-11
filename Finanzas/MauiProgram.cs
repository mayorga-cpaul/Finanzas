using Microsoft.Extensions.Logging;

namespace Finanzas
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var Builder = MauiApp.CreateBuilder();
            Builder
                .UseMauiApp<App>()
                .UsePages()
                .UseViewModels()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            Builder.Logging.AddDebug();
#endif

            return Builder.Build();
        }
    }
}