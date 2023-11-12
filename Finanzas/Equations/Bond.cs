namespace Finanzas.Equations;

public class Bond : IEquation
{
    public Bond(double TasaDescuento, int NumeroPeriodos, List<double> FlujosEfectivo)
    {
        this.TasaDescuento = TasaDescuento;
        this.NumeroPeriodos = NumeroPeriodos;
        this.FlujosEfectivo = FlujosEfectivo;
    }

    public double TasaDescuento { get; set; }

    public int NumeroPeriodos { get; set; }
    
    public List<double> FlujosEfectivo { get; set; }


    public double InteresAnual { get; set; }
    
    public double TasaCupon { get; set; }
    
    public int NumeroAniosVencimiento { get; set; }
    
    public double ValorPar { get; set; }

    public double YearBondZero => this.CalcularPrecioBono();

    public List<ValorPresenteAnual> valorPresenteAnuals => this.CalcularValorPresente();

    public Bond(double PagoInteresAnual, double TasaCupon, int NumeroAniosVencimiento, double ValorPar)
    {
        this.InteresAnual = PagoInteresAnual;
        this.TasaCupon = TasaCupon;
        this.NumeroAniosVencimiento = NumeroAniosVencimiento;
        this.ValorPar = ValorPar;
    }
}