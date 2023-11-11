namespace Finanzas.Services;

public class MauiNavigationServices : INavigationServices
{
    public Task InitializeAsync()
    {
        return Shell.Current.GoToAsync(nameof(HomePage));
    }

    public Task NavigateToAsync(string Route, IDictionary<string, object> RouteParameters = null)
    {
        return RouteParameters is null
            ? Shell.Current.GoToAsync(Route)
            : Shell.Current.GoToAsync(Route, RouteParameters);
    }

    public Task PopAsync() =>
        Shell.Current.GoToAsync("..");
}