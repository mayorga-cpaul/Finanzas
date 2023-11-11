namespace Finanzas.Interfaces;

public interface INavigationServices
{
    Task InitializeAsync();

    Task NavigateToAsync(string Route, IDictionary<string, object> RouteParameters = null);

    Task PopAsync();
}