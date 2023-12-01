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
        Routing.RegisterRoute(nameof(BondPage), typeof(BondPage));
        Routing.RegisterRoute(nameof(DetailleversPage), typeof(DetailleversPage));
        Routing.RegisterRoute(nameof(FinancialAppeceamentPage), typeof(FinancialAppeceamentPage));
        Routing.RegisterRoute(nameof(OperatingLeveragePage), typeof(OperatingLeveragePage));
        Routing.RegisterRoute(nameof(DetailActionsPage), typeof(DetailActionsPage));
        Routing.RegisterRoute(nameof(ActionsPage), typeof(ActionsPage));
    }
}