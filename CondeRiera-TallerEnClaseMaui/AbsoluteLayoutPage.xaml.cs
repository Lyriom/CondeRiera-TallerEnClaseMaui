namespace CondeRiera_TallerEnClaseMaui;

public partial class AbsoluteLayoutPage : ContentPage
{
    public AbsoluteLayoutPage()
    {
        InitializeComponent();
    }

    private async void OnButtonClicked(object sender, EventArgs e)
    {
        // Navegar a GridLayoutPage
        await Navigation.PushAsync(new GridLayoutPage());
    }
}
