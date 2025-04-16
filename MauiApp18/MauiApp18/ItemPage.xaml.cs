
namespace MauiApp18;

public partial class ItemPage : ContentPage, IQueryAttributable
{
	public ItemPage()
	{
		InitializeComponent();
	}

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        string name = query["name"].ToString();

        BindingContext = Models.Person.GetPeople().FirstOrDefault(p => p.Name == name);

       
    }
}