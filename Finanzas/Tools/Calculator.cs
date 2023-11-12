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
}
