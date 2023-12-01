using Mopups.Services;

namespace Finanzas.Extensions;

public static class ServicesExtensions
{
    public static MauiAppBuilder UseServices(this MauiAppBuilder Builder)
    {
        Builder.Services.AddScoped<INavigationServices, MauiNavigationServices>();
        Builder.Services.AddScoped<ITopicServices, TopicServices>();
        Builder.Services.AddSingleton(MopupService.Instance);
        return Builder;
    }
}