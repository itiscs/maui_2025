using MauiApp18.Models;

namespace MauiApp18;

public partial class SecondPage : ContentPage
{
    PersonsDatabase db = new PersonsDatabase();

    public SecondPage()
	{
		InitializeComponent();
    }

    protected override void OnAppearing()
    {
        lstPeople.ItemsSource = db.GetPersons();
        base.OnAppearing();
    }

    private void Button_Clicked(object sender, EventArgs e)    {
        
		Shell.Current.GoToAsync("..");

    }

    private void lstPeople_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        Person p = e.Item as Person;
       // DisplayAlert("Пользователь", (e.Item as Person).Name, "ok");
       Shell.Current.GoToAsync($"itempage?name={p.Name}");
    }

    private void lstPeople_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var pers = e.CurrentSelection.First() as Person;
        Shell.Current.GoToAsync($"itempage?id={pers.Id}");
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync($"itempage");
    }
}