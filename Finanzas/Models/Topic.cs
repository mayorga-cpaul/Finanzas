namespace Finanzas.Models;

public partial class Topic : ObservableObject
{
    [ObservableProperty]
    private int _topicId;

    [ObservableProperty]
    private string _name;

    [ObservableProperty]
    private string _image;

    [ObservableProperty]
    private string _description;

    [ObservableProperty]
    private string _readTime;

    [ObservableProperty]
    private Color _color;

    [ObservableProperty]
    private IEnumerable<Concept> _concepts;
}