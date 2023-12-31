using Mopups.Interfaces;

namespace Finanzas.Pages;

public partial class FinancialAppeceamentPage : ContentPage
{
    private readonly IPopupNavigation PopupNavigation;
   
    public FinancialAppeceamentPage(IPopupNavigation PopupNavigation)
    {
        InitializeComponent();
        this.PopupNavigation = PopupNavigation;
    }

    private void CalculateClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(TxtUAII.Text) ||
            string.IsNullOrEmpty(TxtRate.Text) ||
            string.IsNullOrEmpty(TxtTasa.Text) ||
            string.IsNullOrEmpty(TxtDepreciation.Text))
        {
            PopupNavigation.PushAsync(new ErrorPopup("Campos vac�os", "Por favor asegurese de rellenar todos los campos"));
        }
        else
        {
            FinancialAppeceament FinancialAppeceament = new(
                double.Parse(TxtUAII.Text),
                double.Parse(TxtTasa.Text),
                double.Parse(TxtDepreciation.Text),
                double.Parse(TxtRate.Text));

            (bool IsValid, double Value, string Explanation) = FinancialAppeceament.CalculateFinancialLeverage();

            if (!IsValid)
            {
                return;
            }

            TxtExplanation.Text = Explanation;
            TxtValue.Text = $"El resultado es: {Value}";
        }
    }

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"///{nameof(HomePage)}");
    }
}