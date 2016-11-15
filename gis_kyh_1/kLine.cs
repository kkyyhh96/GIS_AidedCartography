using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gis_kyh_1
{
    public class kLine
    {
        private Bitmap map;
        private Color color;
        public Point pt1 { set; get; }
        public Point pt2 { set; get; }
        public double k
        {
            get
            {
                return (pt2.Y - pt1.Y) * 1.0 / ((pt2.X - pt1.X) * 1.0);
            }
        }
        public double angle
        {
            set { }
            get
            {
                return Math.Atan(k);
            }
        }
        public double distance { get { return Math.Sqrt(Math.Pow(pt2.X - pt1.X, 2) + Math.Pow(pt2.Y - pt1.Y, 2)); } }

        public kLine(Point pt1, Point pt2, Bitmap map, Color color)
        {
            this.map = map;
            this.color = color;
            this.pt1 = pt1;
            this.pt2 = pt2;
        }

        public kLine(int x0, int y0, int x1, int y1, Bitmap map, Color color)
        {
            Point pt1 = new Point(x0, y0);
            Point pt2 = new Point(x1, y1);
            this.pt1 = pt1;
            this.pt2 = pt2;
            this.map = map;
            this.color = color;
        }

        #region Basic algorithm: Draw line.
        private void DrawLine(int x0, int y0, int x1, int y1, Bitmap map, Color color)
        {
            // Draw line (DDA Algorithm)
            int dx, dy, n;
            float xinc, yinc, x, y;
            dx = x1 - x0;
            dy = y1 - y0;
            if (Math.Abs(dx) > Math.Abs(dy)) n = Math.Abs(dx);
            else n = Math.Abs(dy);
            xinc = (float)dx / n;
            yinc = (float)dy / n;
            x = x0; y = y0;
            for (int i = 0; i < n; i++)
            {
                if (x >= 0 && y >= 0 && x < map.Width && y < map.Height)
                    map.SetPixel((int)x, (int)y, color);
                else break;
                x += xinc;
                y += yinc;
            }
        }

        public void DrawLine()
        {
            DrawLine(this.pt1.X, this.pt1.Y, this.pt2.X, this.pt2.Y, this.map, this.color);
        }

        public void Rotate(double rotateAngle)
        {
            double realAngle = Math.Atan((k + Math.Tan(rotateAngle) / (1 - Math.Tan(rotateAngle) * k)));
            pt1 = new Point((int)(pt1.X + distance / 2 * Math.Cos(realAngle)), (int)(pt1.Y + distance / 2 * Math.Sin(realAngle)));
            pt2 = new Point((int)(pt1.X - distance / 2 * Math.Cos(realAngle)), (int)(pt1.Y - distance / 2 * Math.Sin(realAngle)));
        }
        #endregion

        #region Draw symbol: Interval short line, double line
        public void DrawInterval(int interval, int length)
        {
            // Compute the interval point and draw
            double distance;
            int count = 0;
            distance = Math.Sqrt(Math.Pow(pt2.X - pt1.X, 2) + Math.Pow(pt2.Y - pt1.Y, 2));
            count = (int)(distance / interval);
            if (pt2.X == pt1.X)
            {
                this.angle = Math.PI / 4;
            }

            if (pt1.X <= pt2.X)
            {
                DrawIntervalLine(pt1, interval, length, count);
            }
            else
            {
                DrawIntervalLine(pt2, interval, length, count);
            }
        }

        private void DrawIntervalLine(Point pt, int interval, int length, int count)
        {
            // Draw the short line perpendicular to the main line
            for (int i = 1; i <= count; i++)
            {
                Point ptTop = new Point((int)(pt.X + i * interval * Math.Cos(angle) - length / 2 * Math.Sin(angle)), (int)(pt.Y + i * interval * Math.Sin(angle) + length / 2 * Math.Cos(angle)));
                Point ptBottom = new Point((int)(pt.X + i * interval * Math.Cos(angle) + length / 2 * Math.Sin(angle)), (int)(pt.Y + i * interval * Math.Sin(angle) - length / 2 * Math.Cos(angle)));
                kLine line = new gis_kyh_1.kLine(ptTop, ptBottom, this.map, this.color);
                line.DrawLine();
            }
        }
        #endregion
    }
}
