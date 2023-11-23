namespace Finanzas.ViewModels;

public partial class PresentBondPageViewModel : ObservableObject
{
    public ObservableCollection<double> Flows { get; set; } = new();

    [RelayCommand]
    public void Remove()
    {
        if (Flows.Count > 0)
        {
            Flows.RemoveAt(Flows.Count - 1);
        }
    }

    [RelayCommand]
    public void Add(double Value)
    {
        Flows.Add(Value);
    }
}
