using Microcharts;
using SkiaSharp;

namespace Finanzas.Pages;

public partial class BondPage : ContentPage
{
    public BondPage()
    {
        InitializeComponent();
        chartBond.Chart = new LineChart
        {
            Entries = entries
        };
    }

    ChartEntry[] entries = new[]
       {
            new ChartEntry(212)
            {
                Label = "Ploriferative",
                Color = SKColor.Parse("#2c3e50")
            },
            new ChartEntry(14)
            {
                Label = "Temp",
                Color = SKColor.Parse("#2c3e50")
            },
            new ChartEntry(248)
            {
                Label = "MILD",
                Color = SKColor.Parse("#77d065")
            },
            new ChartEntry(128)
            {
                Label = "NO_DR",
                Color = SKColor.Parse("#b455b6")
            },
            new ChartEntry(514)
            {
                Label = "Moderate",
                Color = SKColor.Parse("#3498db")
            }
        };

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"///{nameof(HomePage)}");
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"///{nameof(HomePage)}");
    }
}