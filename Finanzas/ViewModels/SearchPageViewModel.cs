namespace Finanzas.ViewModels;

[QueryProperty(nameof(FromSearch), nameof(FromSearch))]
[QueryProperty(nameof(SelectedConcept), nameof(SelectedConcept))]
public partial class SearchPageViewModel : ObservableObject
{
    private readonly INavigationServices NavigationService;
    public ObservableCollection<Concept> Concepts { get; set; }
    private readonly ITopicServices TopicServices;

    public SearchPageViewModel(INavigationServices NavigationService, ITopicServices TopicServices)
    {
        this.NavigationService = NavigationService;
        this.TopicServices = TopicServices;
        Concepts = new(TopicServices.SearchConcept("A"));
    }

    [ObservableProperty]
    private bool _fromSearch;

    [ObservableProperty]
    private bool _searching;
    
    [ObservableProperty]
    private Concept _selectedConcept;

    [RelayCommand]
    private async Task SearchConcepts(string searchTerm)
    {
        Concepts.Clear();
        Searching = true;
        await Task.Delay(1000);
        
        foreach (var pizza in TopicServices.SearchConcept(searchTerm))
        {
            if (pizza != null)
            {
                Concepts.Add(pizza);
            }
        }

        Searching = false;
    }

    [RelayCommand]
    private async Task DetailAsync(Concept concept)
    {
        if (concept != null)
        {
            await NavigationService.NavigateToAsync(nameof(DetailConceptPage),
               Key(nameof(Concept)).Value(concept));
        }
    }
}
