using OOP8.Extensions;

namespace OOP8.Model.Figures
{
    internal class Squad : IFigure
    {
        public void Draw(Graphics graphics, Pen pen, Tuple<Point, Point> points, SolidBrush solidBrush)
        {
            graphics.DrawRectangle(pen, points, solidBrush);
        }
    }
}
