using MauiApp18.Models;

namespace MauiApp18;

public partial class SecondPage : ContentPage
{
	public SecondPage()
	{
		InitializeComponent();
		lstPeople.ItemsSource = Models.Person.GetPeople();
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
    
}