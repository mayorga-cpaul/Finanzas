namespace Finanzas.Pages;

public partial class PopupPage
{
	public PopupPage(Concept concept)
	{
		InitializeComponent();
        FillFields(concept);
    }

    private void ReturnClicked(object sender, EventArgs e)
    {
        MopupService.Instance.PopAsync();
    }

    private void FillFields(Concept concept)
    {
        TxtConceptName.Text = concept.Title;
        TxtConcept.Text = concept.ConceptText;
    }
}