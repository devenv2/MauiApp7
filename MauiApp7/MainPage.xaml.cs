using System.Diagnostics;

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
            Text = entText.Text

        };

        Debug.WriteLine("MainPage: " + draw.Text);

        GraphicsDrawable drawable = new GraphicsDrawable();
        graphicsView.Invalidate();
    }
}