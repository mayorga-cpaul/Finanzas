namespace Finanzas.Pages;

public partial class HomePage : ContentPage
{
	public HomePage(HomePageViewModel ViewModel)
	{
		InitializeComponent();
		BindingContext = ViewModel;
	}
}