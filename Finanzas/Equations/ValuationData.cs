namespace Finanzas.Equations;

public class ValuationData
{
    public ValuationData(double dividendo, double rendimiento, double tasaCrecimientoInicial1, int numeroPeriodos, double tasaCrecimientoInicial2)
    {
        Dividendo = dividendo;
        Rendimiento = rendimiento;
        TasaCrecimientoInicial1 = tasaCrecimientoInicial1;
        NumeroPeriodos = numeroPeriodos;
        TasaCrecimientoInicial2 = tasaCrecimientoInicial2;
    }

    public double Dividendo { get; set; }
    public double Rendimiento { get; set; }
    public double TasaCrecimientoInicial1 { get; set; }
    public int NumeroPeriodos { get; set; }
    public double TasaCrecimientoInicial2 { get; set; }
}
