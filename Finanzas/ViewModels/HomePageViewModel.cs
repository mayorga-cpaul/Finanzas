using Finanzas.Constanst;

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

    [RelayCommand]
    public async Task DetailAsync(Topic SelectedTopic)
    {
        if (SelectedTopic  != null)
        {
            if (SelectedTopic.Name.Equals("Apalancamiento"))
            {
                ConstantsFor.TopicId = SelectedTopic.TopicId;
                await NavigationServices.NavigateToAsync(nameof(DetailleversPage), Key(nameof(SelectedTopic)).Value(SelectedTopic));
            }
            else if (SelectedTopic.Name.Equals("Secretos de los Bonos"))
            {
                ConstantsFor.TopicId = SelectedTopic.TopicId;
                await NavigationServices.NavigateToAsync(nameof(DetailTopicPage), Key(nameof(SelectedTopic)).Value(SelectedTopic));
            }

        }
    }

    [RelayCommand]
    public async Task SuggestedAsync(Concept Concept)
    {
        if (Concept != null)
        {
            await NavigationServices.NavigateToAsync(nameof(DetailConceptPage), Key(nameof(Concept)).Value(Concept));
        }
    }
}