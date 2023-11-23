namespace Finanzas.Pages;

public partial class PresentBondPage : ContentPage
{
	public PresentBondPage(PresentBondPageViewModel ViewModel)
	{
		InitializeComponent();
        BindingContext = ViewModel;
	}

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"///{nameof(HomePage)}");
    }
}