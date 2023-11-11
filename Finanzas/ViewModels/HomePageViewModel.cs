namespace Finanzas.ViewModels;

public partial class HomePageViewModel : ObservableObject
{
    private readonly INavigationServices NavigationServices;
    private readonly ITopicServices TopicServices;
    
    public HomePageViewModel(INavigationServices NavigationServices, ITopicServices TopicServices)
    {
        this.NavigationServices = NavigationServices;
        this.TopicServices = TopicServices;

        Concepts = new(TopicServices.GetPopularConcepts());
        Topics = new(TopicServices.GetTopics());
    }

    [ObservableProperty] 
    private Topic _selectedTopic;

    [ObservableProperty]
    private ObservableCollection<Topic> _topics;

    [ObservableProperty]
    private Concept _selectedConcept;

    [ObservableProperty]
    private ObservableCollection<Concept> _concepts;

    [RelayCommand]
    public async Task GoToSearchPageAsync()
    {
        await NavigationServices.NavigateToAsync(nameof(SearchEquationPage));
    }
}