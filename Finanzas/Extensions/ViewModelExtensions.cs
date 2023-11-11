namespace Finanzas.Extensions;

public static class ViewModelExtensions
{
    public static MauiAppBuilder UseViewModels(this MauiAppBuilder Builder)
    {
        Builder.Services.AddSingleton<HomePageViewModel>();
        return Builder;
    }
}
