namespace Finanzas;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
        Routing.RegisterRoute(nameof(SearchEquationPage), typeof(SearchEquationPage));
        Routing.RegisterRoute(nameof(DetailConceptPage), typeof(DetailConceptPage));
        Routing.RegisterRoute(nameof(DetailTopicPage), typeof(DetailTopicPage));
    }
}