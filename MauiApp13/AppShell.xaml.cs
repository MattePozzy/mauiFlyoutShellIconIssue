namespace MauiApp13
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        public static void ChangeHamburger()
        {
            Color color = Colors.Red;
            Shell.Current.FlyoutIcon = IconaMenu(MaterialFontIcons.HamburgerCheck, color);
        }


        public static void UpdateIconMenu(string title, string materialIcon, Color color)
        {
            int indx = Shell.Current.Items.ToList().FindIndex(x => string.Equals(x.Title, title, StringComparison.InvariantCultureIgnoreCase));
            if (indx > -1)
            {
                Shell.Current.Items[indx].FlyoutIcon = IconaMenu(materialIcon, color);
            }
        }

        public static FontImageSource IconaMenu(string icona, Color colore)
        {
            return new FontImageSource()
            {
                Glyph = icona,
                FontAutoScalingEnabled = true,
                FontFamily = "FontIcone",
                Color = colore,
                Size = 30
            };
        }

    }
}
