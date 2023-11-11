namespace Finanzas.Services;

public class TopicServices : ITopicServices
{
    public Concept GetConceptById(int ConceptId) => 
        DataOnMemory.Concepts.Where(C => C.ConceptId == ConceptId).FirstOrDefault();

    public IEnumerable<Concept> GetPopularConcepts(int Count = 15) =>
        DataOnMemory.Concepts
        .Take(Count);

    public IEnumerable<Topic> GetTopics() => DataOnMemory.Topics;

    public IEnumerable<Concept> SearchConcept(string SearchTerm = "") =>
        string.IsNullOrEmpty(SearchTerm)
        ? DataOnMemory.Concepts.Take(10)
        : DataOnMemory.Concepts.Where(p => p.ConceptText.Contains(SearchTerm, StringComparison.OrdinalIgnoreCase));
}
