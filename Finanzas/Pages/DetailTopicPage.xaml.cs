namespace Finanzas.Pages;

public partial class DetailTopicPage : ContentPage
{
	public DetailTopicPage()
	{
		InitializeComponent();
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
}