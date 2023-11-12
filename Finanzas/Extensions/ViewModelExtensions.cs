namespace Finanzas.Extensions;

public static class ViewModelExtensions
{
    public static MauiAppBuilder UseViewModels(this MauiAppBuilder Builder)
    {
        Builder.Services.AddSingleton<HomePageViewModel>();
        Builder.Services.AddSingleton<SearchPageViewModel>();
        
        return Builder;
    }
}
