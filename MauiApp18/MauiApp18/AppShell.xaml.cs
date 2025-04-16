namespace MauiApp18
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("mainpaige", typeof(MainPage));
            Routing.RegisterRoute("second", typeof(SecondPage));
            Routing.RegisterRoute("itempage", typeof(ItemPage));

        }
    }
}
