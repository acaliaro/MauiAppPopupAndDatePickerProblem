namespace MauiApp7;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
		BindingContext = new NewViewModel1();
	}
}