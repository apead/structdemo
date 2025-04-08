using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsStructDemo
{
    public partial class NoStructHouseForm : Form
    {
        public NoStructHouseForm()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Define coordinates for the house base
            int baseTopLeftX = 100, baseTopLeftY = 200;
            int baseTopRightX = 300, baseTopRightY = 200;
            int baseBottomLeftX = 100, baseBottomLeftY = 400;
            int baseBottomRightX = 300, baseBottomRightY = 400;

            // Define coordinates for the roof
            int roofPeakX = 200, roofPeakY = 100;
            int roofLeftX = 100, roofLeftY = 200;
            int roofRightX = 300, roofRightY = 200;

            // Define coordinates for the door
            int doorTopLeftX = 180, doorTopLeftY = 300;
            int doorTopRightX = 220, doorTopRightY = 300;
            int doorBottomLeftX = 180, doorBottomLeftY = 400;
            int doorBottomRightX = 220, doorBottomRightY = 400;

            // Draw the house base
            DrawRectangle(g, baseTopLeftX, baseTopLeftY, baseTopRightX, baseTopRightY, baseBottomLeftX, baseBottomLeftY, baseBottomRightX, baseBottomRightY, Brushes.LightBlue);

            // Draw the roof
            DrawTriangle(g, roofPeakX, roofPeakY, roofLeftX, roofLeftY, roofRightX, roofRightY, Brushes.Brown);

            // Draw the door
            DrawRectangle(g, doorTopLeftX, doorTopLeftY, doorTopRightX, doorTopRightY, doorBottomLeftX, doorBottomLeftY, doorBottomRightX, doorBottomRightY, Brushes.DarkRed);
        }

        private void DrawRectangle(Graphics g, int topLeftX, int topLeftY, int topRightX, int topRightY, int bottomLeftX, int bottomLeftY, int bottomRightX, int bottomRightY, Brush brush)
        {
            System.Drawing.Point[] points = {
                new System.Drawing.Point(topLeftX, topLeftY),
                new System.Drawing.Point(topRightX, topRightY),
                new System.Drawing.Point(bottomRightX, bottomRightY),
                new System.Drawing.Point(bottomLeftX, bottomLeftY)
            };
            g.FillPolygon(brush, points);
        }

        private void DrawTriangle(Graphics g, int peakX, int peakY, int leftX, int leftY, int rightX, int rightY, Brush brush)
        {
            System.Drawing.Point[] points = {
                new System.Drawing.Point(peakX, peakY),
                new System.Drawing.Point(leftX, leftY),
                new System.Drawing.Point(rightX, rightY)
            };
            g.FillPolygon(brush, points);
        }

        private void DrawPoint(Graphics g, int x, int y)
        {
            g.FillEllipse(Brushes.Black, x - 2, y - 2, 4, 4);
        }
    }
}
