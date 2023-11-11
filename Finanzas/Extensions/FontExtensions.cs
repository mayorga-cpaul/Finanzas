namespace Finanzas.Extensions;

public static class FontExtensions
{
    public static MauiAppBuilder UseFonts(this MauiAppBuilder Builder)
    {
        Builder.ConfigureFonts(Fonts =>
        {
            Fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            Fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
        });

        return Builder;
    }

}