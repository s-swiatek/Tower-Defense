using System.Runtime.CompilerServices;

namespace projektprojekt
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void exitbtn_Clicked(object sender, EventArgs e)
        {
            Application.Current.Quit();
        }

        private async void options_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Options());
        }

        private async void startbtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GameScreen());
        }
    }

}
