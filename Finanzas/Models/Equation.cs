namespace Finanzas.Models;

public partial class Equation : ObservableObject
{
    [ObservableProperty]
    private int _topicId;

    [ObservableProperty]
    private string _equationName;

    [ObservableProperty]
    private string _image;

    [ObservableProperty]
    private Color _color;
}
