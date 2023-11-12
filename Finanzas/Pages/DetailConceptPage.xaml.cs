namespace Finanzas.Pages;

public partial class DetailConceptPage : ContentPage
{
	public DetailConceptPage()
	{
		InitializeComponent();
	}

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync($"///{nameof(HomePage)}");
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
}