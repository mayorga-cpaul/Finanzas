namespace Finanzas.Models;

public partial class Concept : ObservableObject
{
    [ObservableProperty]
    private int _conceptId;

    [ObservableProperty]
    private int _topicId;

    [ObservableProperty]
    private string _title;

    [ObservableProperty]
    private string _conceptText;

    [ObservableProperty]
    private string _image;

    [ObservableProperty]
    private Color _color;
}
