namespace Finanzas.Pages;

public partial class ErrorPopup
{
    public ErrorPopup(string ErrorTitle, string Description)
	{
		InitializeComponent();
        FillFields(ErrorTitle, Description);
    }

    private void FillFields(string errorTitle, string description)
    {
        TxtErrorName.Text = errorTitle;
        TxtConcept.Text = description;
    }

    private void ReturnClicked(object sender, EventArgs e)
    {
        MopupService.Instance.PopAsync();
    }
}