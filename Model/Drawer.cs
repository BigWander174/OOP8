using OOP8.Model.Figures;

namespace OOP8.Model
{
    internal class Drawer
    {
        private IFigure[] _figures;
        private Pen _pen;
        private Tuple<Point, Point> _points;
        private SolidBrush _brush;
        private Graphics _graphics;
        private int _choice;

        public Drawer(Graphics graphics)
        {
            _graphics = graphics;
            _points = new Tuple<Point, Point>(Point.Empty, Point.Empty);
            _figures = new IFigure[]
            {
                new Line(),
                new Ellipse(),
                new Squad(),
            };
        }

        public void SetPenColor(object item)
        {
            var color = (Color)item;
            _pen = new Pen(color, 3);
        }

        public void CreateNewPoint(Point location)
        {
            if (_points.Item1.IsEmpty)
            {
                _points = new Tuple<Point, Point>(location, Point.Empty);
            }
            else
            {
                _points = new Tuple<Point, Point>(_points.Item1, location);
                _figures[_choice].Draw(_graphics, _pen, _points, _brush);
                _points = new Tuple<Point, Point>(Point.Empty, Point.Empty);
            }
        }

        internal void SetFigure(int index)
        {
            if (index < 0)
            {
                _choice = 0;
            }
            else
            {
                _choice = index;
            }

        }

        internal void SetBrush(object selectedItem)
        {
            var color = (Color)selectedItem;
            _brush = new SolidBrush(color);
        }
    }
}
