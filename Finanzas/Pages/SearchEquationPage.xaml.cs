namespace Finanzas.Pages;

public partial class SearchEquationPage : ContentPage
{
    private readonly SearchPageViewModel ViewModel;

	public SearchEquationPage(SearchPageViewModel ViewModel)
	{
		InitializeComponent();
        this.ViewModel = ViewModel;
		BindingContext = ViewModel;
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        if (ViewModel.FromSearch)
        {
            await Task.Delay(100);
            searchBar.Focus();
        }
    }

    private void searchBar_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (!string.IsNullOrEmpty(e.OldTextValue)
            && string.IsNullOrEmpty(e.NewTextValue))
        {
            ViewModel.SearchConceptsCommand.Execute(null);
        }
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