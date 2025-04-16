namespace MauiApp18
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            txtHello.Text = $"Hello, {txtName.Text}!";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void date1_DateSelected(object sender, DateChangedEventArgs e)
        {
            
            DisplayAlert("Сообщение", date1.Date.ToShortDateString(),"OK");

        }

        private void btnSecondPage_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("second");
        }
    }

}
