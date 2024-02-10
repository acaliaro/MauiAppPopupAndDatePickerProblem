﻿using CommunityToolkit.Maui.Views;

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

        private void ShowDatePickerOk_Clicked(object sender, EventArgs e)
        {
            datepickerok.Focus();
        }

        private void ShowDatePickerProblem_Clicked(object sender, EventArgs e)
        {
            datepickerproblem.Focus();
        }
    }

}
