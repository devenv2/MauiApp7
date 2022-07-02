namespace MauiApp7;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        var draw = new GraphicsDrawable
        {
            Text = "Hello"
        };
        GraphicsDrawable drawable = new GraphicsDrawable();
        graphicsView.Invalidate();
    }
}