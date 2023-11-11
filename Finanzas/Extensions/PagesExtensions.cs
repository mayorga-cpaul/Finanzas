namespace Finanzas.Extensions;

public static class PagesExtensions
{
    public static MauiAppBuilder UsePages(this MauiAppBuilder Builder)
    {
        Builder.Services.AddSingleton<HomePage>();
        return Builder;
    }
}
