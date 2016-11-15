using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gis_kyh_1
{
    public class kPoint
    {
        private Bitmap map;
        private Color color;
        public int x { set; get; }
        public int y { set; get; }

        public kPoint(MouseEventArgs e, Bitmap map, Color color)
        {
            this.x = e.X;
            this.y = e.Y;
            this.map = map;
            this.color = color;
        }

        #region Basic algorithm: Draw line, draw circle and fill the point
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

        private void DrawLine(Point pt1, Point pt2)
        {
            DrawLine(pt1.X, pt1.Y, pt2.X, pt2.Y, this.map, this.color);
        }

        private void DrawLine(int x0, int y0, int x1, int y1)
        {
            DrawLine(x0, y0, x1, y1, this.map, this.color);
        }

        private void DrawCircle(Point center, int R)
        {
            // Draw circle(Eight points)
            double x, y, d;
            d = 1.25 - R; x = 0; y = R;
            for (x = 0; x <= y; x++)
            {
                DrawCirclePixel(x, y, center);
                if (d < 0)
                {
                    d += 2 * x + 3;
                }
                else
                {
                    d += 2 * (x - y) + 5;
                    y--;
                }
            }
        }

        private void DrawCirclePixel(double x, double y, Point center_point)
        {
            // Draw circle for each pixel
            if ((int)x + center_point.X >= 0 && (int)x + center_point.X < this.map.Width
                && (int)y + center_point.Y >= 0 && (int)y + center_point.Y < this.map.Height)
                map.SetPixel((int)x + center_point.X, (int)y + center_point.Y, color);

            if ((int)-x + center_point.X >= 0 && (int)-x + center_point.X < this.map.Width
                && (int)y + center_point.Y >= 0 && (int)y + center_point.Y < this.map.Height)
                map.SetPixel((int)-x + center_point.X, (int)y + center_point.Y, color);

            if ((int)y + center_point.X >= 0 && (int)y + center_point.X < this.map.Width
                && (int)x + center_point.Y >= 0 && (int)x + center_point.Y < this.map.Height)
                map.SetPixel((int)y + center_point.X, (int)x + center_point.Y, color);

            if ((int)-y + center_point.X >= 0 && (int)-y + center_point.X < this.map.Width
                && (int)x + center_point.Y >= 0 && (int)x + center_point.Y < this.map.Height)
                map.SetPixel((int)-y + center_point.X, (int)x + center_point.Y, color);

            if ((int)x + center_point.X >= 0 && (int)x + center_point.X < this.map.Width
                && (int)-y + center_point.Y >= 0 && (int)-y + center_point.Y < this.map.Height)
                map.SetPixel((int)x + center_point.X, (int)-y + center_point.Y, color);

            if ((int)-x + center_point.X >= 0 && (int)-x + center_point.X < this.map.Width
                && (int)-y + center_point.Y >= 0 && (int)-y + center_point.Y < this.map.Height)
                map.SetPixel((int)-x + center_point.X, (int)-y + center_point.Y, color);

            if ((int)y + center_point.X >= 0 && (int)y + center_point.X < this.map.Width
                && (int)-x + center_point.Y >= 0 && (int)-x + center_point.Y < this.map.Height)
                map.SetPixel((int)y + center_point.X, (int)-x + center_point.Y, color);

            if ((int)-y + center_point.X >= 0 && (int)-y + center_point.X < this.map.Width
                && (int)-x + center_point.Y >= 0 && (int)-x + center_point.Y < this.map.Height)
                map.SetPixel((int)-y + center_point.X, (int)-x + center_point.Y, color);
        }

        private void FillPolygon(Point startSeed)
        {
            // Fill polygon
            Stack<Point> seed = new Stack<Point>();
            seed.Push(startSeed);
            while (seed.Count != 0)
            {
                FillSeed(ref seed);
            }
        }

        private void FillSeed(ref Stack<Point> seed)
        {
            try
            {
                // Fill the seed point
                Point seedPoint = seed.Pop();
                map.SetPixel(seedPoint.X, seedPoint.Y, color);
                // Four points near seed point
                Point left = new Point(seedPoint.X - 1, seedPoint.Y);
                Point right = new Point(seedPoint.X + 1, seedPoint.Y);
                Point top = new Point(seedPoint.X, seedPoint.Y - 1);
                Point bottom = new Point(seedPoint.X, seedPoint.Y + 1);
                if (EqualColor(left))
                {
                    seed.Push(left);
                    map.SetPixel(left.X, left.Y, color);
                }
                if (EqualColor(right))
                {
                    seed.Push(right);
                    map.SetPixel(right.X, right.Y, color);
                }
                if (EqualColor(top))
                {
                    seed.Push(top);
                    map.SetPixel(top.X, top.Y, color);
                }
                if (EqualColor(bottom))
                {
                    seed.Push(bottom);
                    map.SetPixel(bottom.X, bottom.Y, color);
                }
            }
            catch { }
        }

        private bool EqualColor(Point point)
        {
            // If point has been filled, return false, else return true
            try
            {
                Color c = map.GetPixel(1, 1);
                if (map.GetPixel(point.X, point.Y).R == color.R && map.GetPixel(point.X, point.Y).G == color.G
                    && map.GetPixel(point.X, point.Y).B == color.B) return false;
                else return true;
            }
            catch { return true; }
        }
        #endregion

        #region Draw symbol: Circle, triangle and pentagram

        public void DrawCircleSymbol(MouseEventArgs e, int R)
        {
            Point centerPoint = new Point(e.X, e.Y);
            DrawCircle(centerPoint, R);
        }

        public void DrawFilledCircleSymbol(MouseEventArgs e, int R)
        {
            Point centerPoint = new Point(e.X, e.Y);
            DrawCircle(centerPoint, R);
            FillPolygon(centerPoint);
        }

        public void DrawTriangleSymbol(MouseEventArgs e, int R)
        {
            Point[] pts = new Point[4];
            pts[0].X = e.X; pts[0].Y = e.Y;
            pts[1].X = pts[0].X; pts[1].Y = pts[0].Y - R;
            pts[2].X = pts[0].X - (int)(R * Math.Cos(Math.PI / 6));
            pts[2].Y = pts[0].Y + (int)(R * Math.Sin(Math.PI / 6));
            pts[3].X = pts[0].X + (int)(R * Math.Cos(Math.PI / 6));
            pts[3].Y = pts[2].Y;
            DrawPolygon(pts);
        }

        public void DrawFilledTriangleSymbol(MouseEventArgs e, int R)
        {
            Point centerPoint = new Point(e.X, e.Y);
            DrawTriangleSymbol(e, R);
            FillPolygon(centerPoint);
        }

        public void DrawPentagramSymbol(MouseEventArgs e, int R)
        {
            Point[] pts = new Point[11];
            pts[0].X = e.X; pts[0].Y = e.Y;

            pts[1].X = pts[0].X;
            pts[1].Y = pts[0].Y - (int)(R * Math.Sin(Math.PI * 0.7) / Math.Sin(Math.PI * 0.1));
            pts[2].X = pts[0].X - (int)(R * Math.Sin(Math.PI * 0.2));
            pts[2].Y = pts[0].Y - (int)(R * Math.Cos(Math.PI * 0.2));
            pts[3].X = pts[0].X - (int)(R * Math.Sin(Math.PI * 0.2)) - (int)(R * Math.Sin(Math.PI * 0.2) / Math.Sin(Math.PI * 0.1));
            pts[3].Y = pts[0].Y - (int)(R * Math.Cos(Math.PI * 0.2));
            pts[4].X = pts[0].X - (int)(R * Math.Sin(Math.PI * 0.4));
            pts[4].Y = pts[0].Y + (int)(R * Math.Cos(Math.PI * 0.4));
            pts[5].X = pts[0].X - (int)(R * Math.Sin(Math.PI * 0.2) / Math.Sin(Math.PI * 0.1) * Math.Sin(Math.PI * 0.3));
            pts[5].Y = pts[0].Y + R + (int)(R * Math.Sin(Math.PI * 0.2) / Math.Sin(Math.PI * 0.1) * Math.Cos(Math.PI * 0.3));
            pts[6].X = pts[0].X;
            pts[6].Y = pts[0].Y + R;
            pts[7].X = pts[0].X + (int)(R * Math.Sin(Math.PI * 0.2) / Math.Sin(Math.PI * 0.1) * Math.Sin(Math.PI * 0.3));
            pts[7].Y = pts[5].Y;
            pts[8].X = pts[0].X + (int)(R * Math.Sin(Math.PI * 0.4));
            pts[8].Y = pts[4].Y;
            pts[9].X = pts[0].X + (int)(R * Math.Sin(Math.PI * 0.2)) + (int)(R * Math.Sin(Math.PI * 0.2) / Math.Sin(Math.PI * 0.1));
            pts[9].Y = pts[3].Y;
            pts[10].X = pts[0].X + (int)(R * Math.Sin(Math.PI * 0.2));
            pts[10].Y = pts[2].Y;
            DrawPolygon(pts);
        }

        public void DrawFilledPentagramSymbol(MouseEventArgs e, int R)
        {
            Point centerPoint = new Point(e.X, e.Y);
            DrawPentagramSymbol(e, R);
            FillPolygon(centerPoint);
        }

        public void DrawFanSymbol(MouseEventArgs e,int R)
        {
            Point centerPoint = new Point(e.X, e.Y);
            DrawCircle(centerPoint, R);
            DrawLine(e.X + R, e.Y, e.X - R, e.Y);
            DrawLine(e.X, e.Y + R, e.X, e.Y - R);
        }

        private void DrawPolygon(Point[] pts)
        {
            for (int i = 1; i < pts.Length; i++)
            {
                if (i + 1 == pts.Length)
                    DrawLine(pts[i], pts[1]);
                else
                    DrawLine(pts[i], pts[i + 1]);
            }
        }

        #endregion
    }
}
