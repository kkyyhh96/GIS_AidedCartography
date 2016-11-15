using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gis_kyh_1
{
    public class kPolyline
    {
        public Queue<Point> pts = new Queue<Point>();// Storage all points of one polyline
        Bitmap map;
        public Color color { set; get; }

        public kPolyline(Bitmap map, Color color)
        {
            this.map = map;
            this.color = color;
        }

        #region Basic algorithm: Draw line
        private void DrawPolyline(MouseEventArgs e, int interval, int length)
        {
            // Draw short line
            Point pt = new Point(e.X, e.Y);
            pts.Enqueue(pt);
            if (pts.Count >= 2)
            {
                kLine line = new kLine(pts.ElementAt(pts.Count - 2), pts.Last(), map, color);
                line.DrawLine();
                line.DrawInterval(interval, length);
            }
            if (pts.Count >= 3)
            {
                // Draw angle bisector
                kVector vector1 = new gis_kyh_1.kVector(pts.ElementAt(pts.Count - 2).X, pts.ElementAt(pts.Count - 2).Y,
                    pts.ElementAt(pts.Count - 3).X, pts.ElementAt(pts.Count - 3).Y);
                kVector vector2 = new gis_kyh_1.kVector(pts.ElementAt(pts.Count - 2).X, pts.ElementAt(pts.Count - 2).Y,
                    pts.Last().X, pts.Last().Y);
                kVector vector = new gis_kyh_1.kVector(vector1.X + vector2.X, vector1.Y + vector2.Y);
                vector = vector.eVector();

                // Two points of angle bisctor
                Point ptBottom = new Point((int)(length / 2 * vector.X + pts.ElementAt(pts.Count - 2).X), (int)(length / 2 * vector.Y) + pts.ElementAt(pts.Count - 2).Y);
                Point ptTop = new Point((int)(-length / 2 * vector.X + pts.ElementAt(pts.Count - 2).X), (int)(-length / 2 * vector.Y) + pts.ElementAt(pts.Count - 2).Y);
                kLine line = new kLine(ptBottom, ptTop, map, color);
                line.DrawLine();
            }
        }

        private void DrawPolyline(MouseEventArgs e, int interval)
        {
            interval /= 2;
            // Draw short line
            Point pt = new Point(e.X, e.Y);
            pts.Enqueue(pt);
            if (pts.Count >= 2)
            {
                // Relevant variables
                Point pt1 = pts.ElementAt(pts.Count - 2);
                Point pt2 = pts.Last();
                double tanAngle = (pt2.Y - pt1.Y) / (pt2.X - pt1.X);
                double aAngle = Math.Atan(1 / tanAngle);

                Point ptTop1 = new Point((int)(pt1.X - interval * Math.Cos(aAngle)), (int)(pt1.Y + interval * Math.Sin(aAngle)));
                Point ptTop2 = new Point((int)(pt2.X - interval * Math.Cos(aAngle)), (int)(pt2.Y + interval * Math.Sin(aAngle)));
                Point ptBottom1 = new Point((int)(pt1.X + interval * Math.Cos(aAngle)), (int)(pt1.Y - interval * Math.Sin(aAngle)));
                Point ptBottom2 = new Point((int)(pt2.X + interval * Math.Cos(aAngle)), (int)(pt2.Y - interval * Math.Sin(aAngle)));

                kLine lineTop = new kLine(ptTop1, ptTop2, map, color);
                lineTop.DrawLine();
                kLine lineBottom = new kLine(ptBottom1, ptBottom2, map, color);
                lineBottom.DrawLine();
            }
        }
        #endregion

        #region Draw symbol: Interval short line, double line
        public void DrawGeneralLineSymbol(MouseEventArgs e, int interval, int length)
        {
            DrawPolyline(e, interval, length);
        }

        public void DrawDoubleLineSymbol(MouseEventArgs e, int interval)
        {
            DrawPolyline(e, interval);
        }
        #endregion
    }
}