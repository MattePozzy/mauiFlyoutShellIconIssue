namespace MauiApp13
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

            SemanticScreenReader.Announce(CounterBtn.Text);

            // Try to change the home menu's voice.
            string menuToFind = "Home";
            AppShell.UpdateIconMenu(menuToFind, MaterialFontIcons.Abacus, Colors.Orange);

            // try to change the hamburger top icon.
            AppShell.ChangeHamburger();

            DisplayAlert("info", "methods called, flyout menu and 'home' icons and colors should be changed.", "ok");
        }
    }

}
