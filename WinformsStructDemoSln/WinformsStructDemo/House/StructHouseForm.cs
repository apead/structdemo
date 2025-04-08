namespace WinformsStructDemo
{

    public struct Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }

    public partial class StructHouseForm : Form
    {


        public StructHouseForm()
        {
            InitializeComponent();

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Define points for the house base
            Point baseTopLeft = new Point(100, 200);
            Point baseTopRight = new Point(300, 200);
            Point baseBottomLeft = new Point(100, 400);
            Point baseBottomRight = new Point(300, 400);

            // Define points for the roof
            Point roofPeak = new Point(200, 100);
            Point roofLeft = new Point(100, 200);
            Point roofRight = new Point(300, 200);

            // Define points for the door
            Point doorTopLeft = new Point(180, 300);
            Point doorTopRight = new Point(220, 300);
            Point doorBottomLeft = new Point(180, 400);
            Point doorBottomRight = new Point(220, 400);

            // Draw the house base
            DrawRectangle(g, baseTopLeft, baseTopRight, baseBottomLeft, baseBottomRight, Brushes.LightBlue);

            // Draw the roof
            DrawTriangle(g, roofPeak, roofLeft, roofRight, Brushes.Brown);

            // Draw the door
            DrawRectangle(g, doorTopLeft, doorTopRight, doorBottomLeft, doorBottomRight, Brushes.DarkRed);
        }

        private void DrawRectangle(Graphics g, Point topLeft, Point topRight, Point bottomLeft, Point bottomRight, Brush brush)
        {
            Point[] points = { new Point(topLeft.X, topLeft.Y), new Point(topRight.X, topRight.Y), new Point(bottomRight.X, bottomRight.Y), new Point(bottomLeft.X, bottomLeft.Y) };
            g.FillPolygon(brush, points.Select(p => new System.Drawing.Point(p.X, p.Y)).ToArray());
        }

        private void DrawTriangle(Graphics g, Point peak, Point left, Point right, Brush brush)
        {
            Point[] points = { new Point(peak.X, peak.Y), new Point(left.X, left.Y), new Point(right.X, right.Y) };
            g.FillPolygon(brush, points.Select(p => new System.Drawing.Point(p.X, p.Y)).ToArray());
        }

        private void DrawPoint(Graphics g, Point point)
        {
            g.FillEllipse(Brushes.Black, point.X - 2, point.Y - 2, 4, 4);
        }
    }
}
