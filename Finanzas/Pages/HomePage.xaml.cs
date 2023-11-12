namespace Finanzas.Pages;

public partial class HomePage : ContentPage
{
	public HomePage(HomePageViewModel ViewModel)
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
        BindingContext = ViewModel;
	}

    protected override void OnNavigatedFrom(NavigatedFromEventArgs args)
    {
        base.OnNavigatedFrom(args);
        Behaviors.Add(new
            CommunityToolkit.Maui.Behaviors.StatusBarBehavior
        {
            StatusBarColor = Color.FromHex("FFFFFF"),
            StatusBarStyle = CommunityToolkit.Maui.Core.StatusBarStyle.DarkContent
        });
    }
}