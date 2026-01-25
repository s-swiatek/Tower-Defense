using System.Runtime.CompilerServices;

namespace projektprojekt
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            Application.Current.Quit();
        }

        private async void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Options());
        }
    }

}
