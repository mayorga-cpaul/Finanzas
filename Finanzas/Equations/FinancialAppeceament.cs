namespace Finanzas.Equations;

public class FinancialAppeceament
{
    public FinancialAppeceament(double UAII, double Intereses, double Depreciacion, double TasaImpuestos)
    {
        this.UAII = UAII;
        this.Intereses = Intereses;
        this.Depreciacion = Depreciacion;
        this.TasaImpuestos = TasaImpuestos;
    }

    public double UAII { get; set; }
    
    public double Intereses { get; set; }
    
    public double Depreciacion { get; set; }
    
    public double TasaImpuestos { get; set; }

    public (bool, double, string) ResultGAF => this.ResultGAF;
}
