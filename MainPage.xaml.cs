using CommunityToolkit.Maui.Views;

namespace MauiApp7
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(NewPage1));
        }

        private async void ShowPopup_Clicked(object sender, EventArgs e)
        {
            var popup = new MyPopupView();

            await this.ShowPopupAsync(popup);
        }
    }

}
