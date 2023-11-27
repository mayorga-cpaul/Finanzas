namespace Finanzas.Pages;

public partial class DetailleversPage : ContentPage
{
	public DetailleversPage(SearchPageViewModel ViewModel)
	{
		InitializeComponent();
        BindingContext = ViewModel;
	}

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"///{nameof(HomePage)}");
    }

    private async void FinancialAppeceamentTapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"{nameof(FinancialAppeceamentPage)}");
    }

    private async void OperatingLeverageTapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"{nameof(OperatingLeveragePage)}");
    }
}