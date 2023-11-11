namespace Finanzas.ViewModels;

public partial class HomePageViewModel : ObservableObject
{
    public HomePageViewModel()
    {
        Equations = new(new List<Equation>()
        {
            new Equation() { TopicId = 1, EquationName = "Bonos", Image = "calculator.png"   , Color = new Color(255, 165, 0) },
            new Equation() { TopicId = 1, EquationName = "Bonos", Image = "blackboard.png"   , Color = new Color(245, 165, 0) },
            new Equation() { TopicId = 1, EquationName = "Bonos", Image = "presentation.png" , Color = new Color(240, 165, 0) },
            new Equation() { TopicId = 1, EquationName = "Bonos", Image = "formul.png"       , Color = new Color(235, 165, 0) },
            new Equation() { TopicId = 1, EquationName = "Bonos", Image = "formula.png"      , Color = new Color(255, 150, 0) },
            new Equation() { TopicId = 1, EquationName = "Bonos", Image = "calculator.png"   , Color = new Color(255, 155, 0) },
            new Equation() { TopicId = 1, EquationName = "Bonos", Image = "money_bag.png"    , Color = new Color(255, 110, 0) },
            new Equation() { TopicId = 1, EquationName = "Bonos", Image = "money_bag.png"    , Color = new Color(255, 140, 0) },
            new Equation() { TopicId = 1, EquationName = "Bonos", Image = "money_bag.png"    , Color = new Color(255, 150, 0) },
            new Equation() { TopicId = 1, EquationName = "Bonos", Image = "money_bag.png"    , Color = new Color(255, 150, 0) }
        });

        Topics = new(new List<Topic>()
        {
            new Topic() { Color = new Color(150, 150, 130),  Name ="Bonos", Image = "business.png", Description="Sección de bonos sobre inversiones en bonos", ReadTime="10 min" },
            new Topic() { Color = new Color(100, 128, 128),  Name="Acciones", Image = "finance.png", Description="Sección de acciones en el mercado financiero", ReadTime="15 min"},
            new Topic() { Color = new Color(255, 204, 0),  Name="Apalancamiento", Image = "bars.png", Description="Conceptos de apalancamiento financiero", ReadTime="8 min"},
            new Topic() { Color = new Color(192, 192, 192),  Name="Arrendamiento", Image = "money.png", Description="Arrendamiento financiero y sus ventajas", ReadTime="12 min"},
            new Topic() { Color = new Color(255, 0, 255),  Name="Razones Financieras", Image = "business.png", Description="Análisis de razones financieras", ReadTime="20 min"},
            new Topic() { Color = new Color(255, 155, 0),  Name="Conceptos", Image = "topic.png", Description="Conceptos clave en el mundo financiero", ReadTime="10 min"},
        });               
    }                    
                          
    [ObservableProperty] 
    private Topic _selectedTopic;

    [ObservableProperty]
    private ObservableCollection<Topic> _topics;

    [ObservableProperty]
    private Equation _selectedEquation;

    [ObservableProperty]
    private ObservableCollection<Equation> _equations;
}