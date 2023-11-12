namespace Finanzas.Interfaces;

public interface ITopicServices
{
    IEnumerable<Topic> GetTopics();

    IEnumerable<Concept> GetPopularConcepts(int Count = 15);

    IEnumerable<Concept> SearchConcept(string SearchTerm);

    Concept GetConceptById(int ConceptId);
}