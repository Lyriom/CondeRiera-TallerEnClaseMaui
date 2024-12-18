namespace CondeRiera_TallerEnClaseMaui;

public partial class FlexLayoutPage : ContentPage
{
    public FlexLayoutPage()
    {
        InitializeComponent();
    }

    private async void OnImageTapped(object sender, EventArgs e)
    {
        // Navegación a AbsoluteLayoutPage
        await Navigation.PushAsync(new AbsoluteLayoutPage());
    }

    private async void OnButtonClicked(object sender, EventArgs e)
    {
        // Navegación desde el botón adicional
        await Navigation.PushAsync(new AbsoluteLayoutPage());
    }
}

