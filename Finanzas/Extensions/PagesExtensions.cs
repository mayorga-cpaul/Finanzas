namespace Finanzas.Extensions;

public static class PagesExtensions
{
    public static MauiAppBuilder UsePages(this MauiAppBuilder Builder)
    {
        Builder.Services.AddTransient<HomePage>();
        Builder.Services.AddTransient<SearchEquationPage>();
        Builder.Services.AddTransient<DetailConceptPage>();
        Builder.Services.AddTransient<DetailTopicPage>();
        Builder.Services.AddTransient<BondPage>();
        Builder.Services.AddTransient<PresentBondPage>();
        Builder.Services.AddTransient<FinancialAppeceamentPage>();
        Builder.Services.AddTransient<OperatingLeveragePage>();
        Builder.Services.AddTransient<DetailleversPage>();
        Builder.Services.AddTransient<DetailActionsPage>();
        Builder.Services.AddTransient<ActionsPage>();
        return Builder;
    }
}
