using Microcharts;
using SkiaSharp;
using System.Text;

namespace Finanzas.Tools;

public static class Calculator
{
    public static List<ValorPresenteAnual> CalcularValorPresente(this Bond Bond)
    {
        List<ValorPresenteAnual> Resultados = new List<ValorPresenteAnual>();

        for (int t = 1; t <= Bond.NumeroPeriodos; t++)
        {
            double ValorPresente = Bond.FlujosEfectivo[t - 1] / Math.Pow(1 + Bond.TasaDescuento, t);

            Resultados.Add(new ValorPresenteAnual { Año = t, ValorPresente = ValorPresente });
        }

        return Resultados;
    }

    public static double CalcularPrecioBono(this Bond Bond)
    {
        double PrecioBono = Bond.InteresAnual * (1 - Math.Pow(1 + Bond.TasaCupon, -Bond.NumeroAniosVencimiento)) / Bond.TasaCupon
                           + Bond.ValorPar * Math.Pow(1 + Bond.TasaCupon, -Bond.NumeroAniosVencimiento);
        return PrecioBono;
    }

    public static string GetExplanationForResult(this Bond bono, double precio)
    {
        // Construir una cadena explicativa basada en condiciones específicas
        StringBuilder explicacion = new StringBuilder();
        explicacion.Append("Análisis del Bono:");
        explicacion.Append($"Tasa de Interés Anual: {Math.Round(bono.InteresAnual, 2):P} - ");
        explicacion.Append($"Tasa de Cupón: {Math.Round(bono.TasaCupon, 2):P} - ");
        explicacion.Append($"Años hasta el Vencimiento: {bono.NumeroAniosVencimiento} - ");
        explicacion.Append($"Valor Nominal: ${Math.Round(bono.ValorPar, 2)}  - ");
        explicacion.AppendLine();

        // Puedes personalizar estas condiciones según tus criterios
        if (EsOportunidadAtractiva(bono, precio))
        {
            explicacion.AppendLine("Recomendación: Este bono podría ser una oportunidad atractiva de inversión.");
        }
        else if (EsTasaBaja(bono))
        {
            explicacion.AppendLine("Recomendación: La tasa de interés de este bono es relativamente baja. Considera otras opciones con tasas más altas.");
        }
        else if (EsVencimientoLargo(bono))
        {
            explicacion.AppendLine("Recomendación: El vencimiento a largo plazo podría implicar un mayor riesgo. Evalúa tus objetivos de inversión a corto y largo plazo.");
        }
        else if (PrecioEnPrima(precio, bono.ValorPar))
        {
            explicacion.AppendLine("Recomendación: El precio del bono está en prima. Podrías explorar opciones con precios más atractivos.");
        }
        else
        {
            explicacion.AppendLine("Recomendación: Considera consultar con un asesor financiero para obtener recomendaciones personalizadas.");
        }

        return explicacion.ToString();
    }

    static bool EsOportunidadAtractiva(Bond bono, double precio)
    {
        // Puedes personalizar estas condiciones según tus criterios
        return bono.InteresAnual > 0.04 && bono.NumeroAniosVencimiento <= 5 && precio < bono.ValorPar;
    }

    static bool EsTasaBaja(Bond bono)
    {
        // Puedes personalizar estas condiciones según tus criterios
        return bono.InteresAnual <= 0.04;
    }

    static bool EsVencimientoLargo(Bond bono)
    {
        // Puedes personalizar estas condiciones según tus criterios
        return bono.NumeroAniosVencimiento > 5;
    }

    static bool PrecioEnPrima(double precio, double valorNominal)
    {
        // Puedes personalizar estas condiciones según tus criterios
        return precio > valorNominal;
    }

    public static List<ChartEntry> GetChartEntries(this Bond Bond)
    {
        var Entries = new List<ChartEntry>();
        var Years = Bond.NumeroAniosVencimiento;

        for (int i = 0; i < Years; i++)
        {
            Bond.NumeroAniosVencimiento = i + 1;
            Entries.Add(new ChartEntry((float)Bond.CalcularPrecioBono())
            {
                Label = $"Año {i + 1}",
                Color = SKColor.Parse("#2c3e50")
            });
        }

        return Entries;
    }
}