namespace Finanzas.Pages;

public partial class DetailActionsPage : ContentPage
{
    public DetailActionsPage(SearchPageViewModel ViewModel)
    {
        InitializeComponent();
        BindingContext = ViewModel;
    }

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"///{nameof(HomePage)}");
    }

    private async void ButtonView_Tapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"{nameof(ActionsPage)}");
    }
}