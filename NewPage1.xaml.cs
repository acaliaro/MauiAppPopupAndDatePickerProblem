namespace MauiApp7;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
		BindingContext = new NewViewModel1();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		dp.Focus();
    }
}