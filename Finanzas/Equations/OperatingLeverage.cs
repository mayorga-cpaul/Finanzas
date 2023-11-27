namespace Finanzas.Equations;

public class OperatingLeverage
{
    public OperatingLeverage(double ventas, double precioVenta, double costoVariable, double costoFijo)
    {
        Ventas = ventas;
        PrecioVenta = precioVenta;
        CostoVariable = costoVariable;
        CostoFijo = costoFijo;
    }

    public double Ventas { get; set; }
    
    public double PrecioVenta { get; set; }
    
    public double CostoVariable { get; set; }
    
    public double CostoFijo { get; set; }

    public (bool, double, string) ResultGAO => this.CalculateOperatingLeverage();
}