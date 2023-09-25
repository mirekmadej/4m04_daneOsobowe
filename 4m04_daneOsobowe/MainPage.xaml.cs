namespace _4m04_daneOsobowe
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnPokazClicked(object sender, EventArgs e)
        {
            string wynik = entImie.Text + " " + entNazwisko.Text + " " + entStanowisko.Text;
            lblWynik.Text = wynik;
            SemanticScreenReader.Announce(lblWynik.Text);
            lblWynik.IsVisible = true;
            lblDaneOsobowe.IsVisible = false;
        }




    }
}