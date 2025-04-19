
using MauiApp18.Models;

namespace MauiApp18;

public partial class ItemPage : ContentPage, IQueryAttributable
{
    PersonsDatabase db = new PersonsDatabase();
	public ItemPage()
	{
		InitializeComponent();
	}

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        if (query.ContainsKey("id"))
        {
            var id = int.Parse(query["id"].ToString());
            BindingContext = db.GetPerson(id);
        }
        else
        {
            BindingContext = new Person();
        }

       
    }

    private void btnSave_Clicked(object sender, EventArgs e)
    {
        var pers = BindingContext as Person;
        db.SavePerson(pers);
        Shell.Current.GoToAsync("..");
    }

    private async void btnDel_Clicked(object sender, EventArgs e)
    {
        var pers = BindingContext as Person;
        bool answer = await DisplayAlert("Вы уверены?", $"Удалить {pers.Name}?", "Да", "Нет");
        if (answer)
        {
            db.DeletePerson(pers);
            await Shell.Current.GoToAsync("..");
        }

    }
}