namespace Finanzas.Pages;

public partial class DetailTopicPage : ContentPage
{
	public DetailTopicPage(SearchPageViewModel ViewModel)
	{
		InitializeComponent();
        BindingContext = ViewModel;
	}

    protected override void OnNavigatedFrom(NavigatedFromEventArgs args)
    {
        base.OnNavigatedFrom(args);
        Behaviors.Add(new
            CommunityToolkit.Maui.Behaviors.StatusBarBehavior
        {
            StatusBarColor = Color.FromHex("512BD4"),
            StatusBarStyle = CommunityToolkit.Maui.Core.StatusBarStyle.LightContent
        });
    }

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"///{nameof(HomePage)}");
    }

    private async void ButtonView_Tapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"{nameof(BondPage)}");
    }

    private async void PresentValuesTapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"{nameof(PresentBondPage)}");
    }
}