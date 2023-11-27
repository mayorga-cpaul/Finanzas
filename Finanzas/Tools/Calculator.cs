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



    public static (bool, double, string) CalculateOperatingLeverage(this OperatingLeverage Financial)
    {
        double numerador = Financial.Ventas * (Financial.PrecioVenta - Financial.CostoVariable);
        double denominador = Financial.Ventas * (Financial.PrecioVenta - Financial.CostoVariable) - Financial.CostoFijo;

        if (denominador != 0)
        {
            double margenContribucion = numerador / denominador;
            string recomendacion = ObtenerRecomendacion(margenContribucion);
            return (true, margenContribucion, recomendacion);
        }
        else
        {
            return (false, double.NaN, "No se puede calcular el apalancamiento operativo debido a un denominador cero.");
        }
    }

    private static string ObtenerRecomendacion(double margenContribucion)
    {
        if (margenContribucion > 1)
        {
            return "El apalancamiento operativo es alto. La empresa muestra una fuerte sensibilidad a las variaciones en las ventas. Se sugiere una revisión detallada de la estructura de costos, considerando posibles ajustes para mejorar la eficiencia operativa y reducir la exposición al riesgo.";
        }
        else if (margenContribucion < 1)
        {
            return "El apalancamiento operativo es bajo. La empresa tiene una menor dependencia de costos fijos, proporcionando flexibilidad en situaciones de fluctuaciones en las ventas. Aunque esto puede reducir el riesgo financiero, es importante evaluar las oportunidades para mejorar la rentabilidad mediante estrategias de crecimiento y eficiencia en los costos variables.";
        }
        else
        {
            return "El apalancamiento operativo es igual a 1. La empresa tiene un equilibrio entre costos fijos y variables. Se sugiere monitorear de cerca la estructura de costos y realizar ajustes según sea necesario para mantener un equilibrio saludable.";
        }
    }


    public static (bool, double, string) CalculateFinancialLeverage(this FinancialAppeceament Financial)
    {
        double impuestos = Financial.UAII;
        double denominador = Financial.UAII - Financial.Intereses - (Financial.Depreciacion * (1 / (1 - Financial.TasaImpuestos)));

        if (denominador != 0)
        {
            double apalancamientoFinanciero = (Financial.UAII) / denominador;
            string recomendacion = GetRecommendationGAF(apalancamientoFinanciero);
            return (true, apalancamientoFinanciero, recomendacion);
        }
        else
        {
            return (false, double.NaN, "No se puede calcular el apalancamiento financiero debido a un denominador cero.");
        }
    }

    private static string GetRecommendationGAF(double financialLeverage)
    {
        if (financialLeverage > 1)
        {
            return "El apalancamiento financiero es alto. La empresa está utilizando un nivel significativo de deuda para financiar sus operaciones. Se recomienda evaluar cuidadosamente la estructura de capital y considerar estrategias para gestionar el riesgo asociado con la deuda.";
        }
        else if (financialLeverage < 1)
        {
            return "El apalancamiento financiero es bajo. La empresa muestra una menor dependencia de la deuda para financiar sus operaciones. Esto puede indicar una posición financiera más sólida, pero es importante equilibrar el uso de la deuda para aprovechar oportunidades de crecimiento.";
        }
        else
        {
            return "El apalancamiento financiero es igual a 1. La empresa tiene un equilibrio en la utilización de la deuda para financiar sus operaciones. Se sugiere monitorear de cerca la estructura de capital y ajustar según sea necesario para optimizar la eficiencia financiera.";
        }
    }
}