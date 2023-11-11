namespace Finanzas.Extensions;

public static class ServicesExtensions
{
    public static MauiAppBuilder UseServices(this MauiAppBuilder Builder)
    {
        Builder.Services.AddScoped<INavigationServices, MauiNavigationServices>();
        Builder.Services.AddScoped<ITopicServices, TopicServices>();
        return Builder;
    }
}