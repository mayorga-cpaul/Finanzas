namespace Finanzas.Extensions;

public static class PagesExtensions
{
    public static MauiAppBuilder UsePages(this MauiAppBuilder Builder)
    {
        Builder.Services.AddSingleton<HomePage>();
        Builder.Services.AddSingleton<SearchEquationPage>();
        Builder.Services.AddSingleton<DetailConceptPage>();
        Builder.Services.AddTransient<DetailTopicPage>();
        Builder.Services.AddSingleton<BondPage>();
        Builder.Services.AddSingleton<PresentBondPage>();

        return Builder;
    }
}
