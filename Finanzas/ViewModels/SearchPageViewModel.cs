using Finanzas.Constanst;
using Mopups.Interfaces;

namespace Finanzas.ViewModels;

[QueryProperty(nameof(FromSearch), nameof(FromSearch))]
[QueryProperty(nameof(SelectedConcept), nameof(SelectedConcept))]
[QueryProperty(nameof(SelectedTopic), nameof(SelectedTopic))]
public partial class SearchPageViewModel : ObservableObject
{
    private readonly INavigationServices NavigationService;
    public ObservableCollection<Concept> Concepts { get; set; }
    private readonly ITopicServices TopicServices;
    private readonly IPopupNavigation PopupNavigation;

    public SearchPageViewModel(
        INavigationServices NavigationService, 
        ITopicServices TopicServices,
        IPopupNavigation PopupNavigation)
    {
        this.PopupNavigation = PopupNavigation;
        this.NavigationService = NavigationService;
        this.TopicServices = TopicServices;
        Concepts = new(TopicServices.SearchConcept().Where(Concept => Concept.TopicId == ConstantsFor.TopicId));
    }

    [ObservableProperty]
    private bool _fromSearch;

    [ObservableProperty]
    private bool _searching;
    
    [ObservableProperty]
    private Concept _selectedConcept;

    [ObservableProperty]
    private Topic _selectedTopic;

    [RelayCommand]
    private async Task SearchConcepts(string searchTerm)
    {
        Concepts.Clear();
        Searching = true;
        await Task.Delay(1000);
        
        foreach (var concept in TopicServices.SearchConcept(searchTerm))
        {
            if (concept != null)
            {
                Concepts.Add(concept);
            }
        }

        Searching = false;
    }

    [RelayCommand]
    private async Task DetailAsync(Concept concept)
    {
        if (concept != null)
        {
            await PopupNavigation.PushAsync(new PopupPage(concept));

            //await NavigationService.NavigateToAsync(nameof(DetailConceptPage),
            //   Key(nameof(Concept)).Value(concept));
        }
    }
}
