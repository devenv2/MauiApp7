using System.Diagnostics;

namespace MauiApp7
{
    public class GraphicsDrawable : IDrawable
    {
        public string Text { get; set; }
        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            Debug.WriteLine("GraphicsDrawable: " + Text);
            canvas.DrawString(Text, 60, 60, HorizontalAlignment.Center);

            
        }
    }
}