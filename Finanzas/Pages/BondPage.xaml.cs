using Microcharts;
using Mopups.Interfaces;

namespace Finanzas.Pages;

public partial class BondPage : ContentPage
{
    private readonly IPopupNavigation PopupNavigation;
    public BondPage(IPopupNavigation PopupNavigation)
    {
        InitializeComponent();
        this.PopupNavigation = PopupNavigation;
    }

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"///{nameof(HomePage)}");
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(TxtAños.Text) || 
            string.IsNullOrEmpty(TxtInteresAnual.Text) ||
            string.IsNullOrEmpty(TxtTasaCupon.Text) ||
            string.IsNullOrEmpty(TxtValoPar.Text))
        {
            PopupNavigation.PushAsync(new ErrorPopup("Campos vacíos", "Por favor asegurese de rellenar todos los campos"));
        }
        else
        {
            var Bond = new Bond(
                Double.Parse(TxtInteresAnual.Text),
                Double.Parse(TxtTasaCupon.Text),
                Int32.Parse(TxtAños.Text), Double.Parse(TxtValoPar.Text));
            
            var Result = Math.Round(Bond.CalcularPrecioBono(), 2);

            chartBond.Chart = new LineChart
            {
                Entries = Bond.GetChartEntries()
            };

            TxtIA.Text = Bond.GetExplanationForResult(Result);
            TxtResult.Text = $"El resultado es: {Result}";
        }


    }
}