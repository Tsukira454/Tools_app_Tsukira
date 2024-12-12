namespace Tools_app_Tsukira
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void nfcBtnCliked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NfcTools());
        }
    }

}
