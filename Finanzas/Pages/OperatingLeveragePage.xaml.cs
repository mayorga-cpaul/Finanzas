using Mopups.Interfaces;

namespace Finanzas.Pages;

public partial class OperatingLeveragePage : ContentPage
{
    private readonly IPopupNavigation PopupNavigation;

    public OperatingLeveragePage(IPopupNavigation PopupNavigation)
    {
        InitializeComponent();
        this.PopupNavigation = PopupNavigation;
    }

    private void CalculateClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(TxtVentas.Text) ||
            string.IsNullOrEmpty(TxtPrecioVenta.Text) ||
            string.IsNullOrEmpty(TxtCostoVariable.Text) ||
            string.IsNullOrEmpty(TxtCostoFijo.Text))
        {
            PopupNavigation.PushAsync(new ErrorPopup("Campos vacíos", "Por favor asegurese de rellenar todos los campos"));
        }
        else
        {
            OperatingLeverage FinancialAppeceament = new(
                double.Parse(TxtVentas.Text),
                double.Parse(TxtPrecioVenta.Text),
                double.Parse(TxtCostoVariable.Text),
                double.Parse(TxtCostoFijo.Text));

            (bool IsValid, double Value, string Explanation) = FinancialAppeceament.CalculateOperatingLeverage();

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