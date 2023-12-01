using Mopups.Interfaces;

namespace Finanzas.Pages;

public partial class ActionsPage : ContentPage
{
    private readonly IPopupNavigation PopupNavigation;

    public ActionsPage(IPopupNavigation PopupNavigation)
    {
        InitializeComponent();
        this.PopupNavigation = PopupNavigation;
        dgData.ItemsSource = Enumerable.Empty<ValuationData>().ToList();
    }

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"///{nameof(HomePage)}");
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(TxtDividendo.Text) ||
            string.IsNullOrEmpty(TxtRendimiento.Text) ||
            string.IsNullOrEmpty(TxtCrecimientoInicial.Text) ||
            string.IsNullOrEmpty(TxtPeriodos.Text) ||
            string.IsNullOrEmpty(TxtCrecimientoFinal.Text))
        {
            PopupNavigation.PushAsync(new ErrorPopup("Campos vacíos", "Por favor asegurese de rellenar todos los campos"));
        }
        else
        {
            ValuationData FinancialAppeceament = new(
                double.Parse(TxtDividendo.Text),
                double.Parse(TxtRendimiento.Text),
                double.Parse(TxtCrecimientoInicial.Text),
                int.Parse(TxtPeriodos.Text),
                double.Parse(TxtCrecimientoFinal.Text));

            (bool IsValid, var Value, string Explanation) = FinancialAppeceament.GetValuationData();

            if (double.Parse(TxtCrecimientoFinal.Text) < double.Parse(TxtRendimiento.Text))
            {
                PopupNavigation.PushAsync(new ErrorPopup("Error", "Asegurate de que el el crecimiento sea menor al rendimiento"));
            }
            else
            {
                if (!IsValid)
                {
                    return;
                }

                dgData.ItemsSource = Value;
                
                TxtValue.Text = $"Suma de valor presente: {Value.Sum(e => e.Presente)}";

            }


        }
    }
}