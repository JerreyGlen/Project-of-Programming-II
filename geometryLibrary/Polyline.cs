using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using Point = vectorLibrary.Point;
using vectorLibrary;
using System.Text;
using System.Threading.Tasks;

namespace geometryLibrary
{/// <summary>
/// Wie Polylinie gzeichnet werden sollen
/// </summary>
    public class Polyline: Curve, IArea
    {
        public const string StartMessage = "Bitte wählen Sie Der Startpoint von der Polyline.";
        public const string NextMessage = "Bitte wählen Sie Der Nextpoint von der Polyline klicken Sie mit der rechten Mousetaste";
        public const string EndMessage = "Bitte wählen Sie Der Nextpoint von der Polyline oder klicken Sie mit der rechten Mousetaste ";
        /// <summary>
        /// Eigenschaten
        /// </summary>
        public List<Point> Points = new List<Point>();
        public static double Lenght { get; }
        
        public static List<Point> PolylinePoints = new List<Point>();

        public Polyline()
        {

        }


        // Überprüft ob,der Startpunkt gleich dem Endpunkt ist
        public bool IsClosed
        {
            get
            {
                return (Points[0].x == Points[Points.Count - 1].x && Points[0].y == Points[Points.Count - 1].y) && Points[0].z == Points[Points.Count - 1].z;
            }
        }
        //Die Punkte liegen auf der Ebene
        public bool IsPlanar
        {
            get
            {
                double c = 0; double c1 = 0; double c2 = 0;
                for (int i = 1; i < Points.Count; i++)
                {
                    c = Points[0].x / Points[i].x;
                    c1 = Points[0].y / Points[i].y;
                    c2 = Points[0].z / Points[i].z;
                }
                return (Points.Count >= 3 && c == c1 && c1 == c2);


            }
        }
        //Zwei Punkte sind in der Liste
        public bool IsValid
        {
            get { return Points.Count >= 2; }
        }


        public void AddPoint(Point newPoint)
        {
            Points.Add(newPoint);
        }
        public void InsertPointAt(int position, Point newPoint)
        {
            Points.Insert(position, newPoint);
        }
        public void RemovePointAt(int position)
        {
            Points.RemoveAt(position);
        }
        /// <summary>
        /// Berechnung der Fläche der Polylinie
        /// </summary>
        public double Area
        {
            get
            {
                double fläche = 0;
                
                if (!(IsClosed && IsPlanar))
                {
                    fläche = 0;
                }
                else
                {
                    
                    for (int i = 0; i < Points.Count; i++)
                    {
                        fläche = 0.5 * ((Points[i].x * (Points[i + 1].y * Math.Pow(Points[i + 1].x, 2)) + Points[Points.Count - 1].x * (Points[0].y * Math.Pow(Points[0].x, 2))) -
                            (Points[i + 1].x * (Points[i].y * Math.Pow(Points[i].x, 2)) - Points[0].x * (Points[Points.Count - 1].y * Math.Pow(Points[Points.Count - 1].x, 2))));
                    }
                }

                return fläche;
            }
        }

        /// <summary>
        /// Zeichnet eine Reihe von Liniensegmenten, die ein Array von "PointF-Strukturen" verbinden.
        /// </summary>
        /// <param name="points">The points defining the polyline.</param>
        public Polyline(Point[] points)
        {
            Points.AddRange(points);

        }
        /// <summary>
        /// Berechnung der gezeichneten Polylinien
        /// </summary>
        /// <returns></returns>
        public double LängeBerechnung()
        {
            double länge = 0;
            //Länge einer Polylinie
            for (int i = 0; i < PolylinePoints.Count && PolylinePoints.Count >= 2 && i + 1 < PolylinePoints.Count; i++)
            {

                länge += PolylinePoints[i].DistanceTo(PolylinePoints[i + 1]);
            }
            return länge;
        }
        
        public override void Draw(Graphics g)
        {
            var points = Points.Select(p => new PointF((float)p.x, (float)p.y));
            g.DrawLines(DrawPen, points.ToArray());
        }
        
        public static ClickResult Polyline_ClickHandler(System.Drawing.Point pt, MouseButtons buttons,
           int screenHeight, ref Curve curElement, out string statusMessage)
        {
            ClickResult result = ClickResult.canceled;
            statusMessage = string.Empty;

            Point worldPoint = TransformScreen2World(pt, screenHeight);
            if (curElement == null || curElement.GetType() != typeof(Polyline))
            {
                if (buttons == MouseButtons.Left)
                {
                    PolylinePoints.Add(worldPoint);
                    curElement = new Polyline(new Point[] { worldPoint });
                    result = ClickResult.created;
                    statusMessage = NextMessage;
                }
                else if (buttons == MouseButtons.Right)
                {
                    result = ClickResult.canceled;
                    statusMessage = StartMessage;
                }
            }
            else
            {
                Polyline p = curElement as Polyline;

                if (buttons == MouseButtons.Left)
                {
                    PolylinePoints.Add(worldPoint);
                    p.AddPoint(worldPoint);
                    result = ClickResult.pointHandled;
                    statusMessage = EndMessage;

                }
                else if (buttons == MouseButtons.Right && p.Points.Count < 2)
                {
                    result = ClickResult.canceled;
                    statusMessage = StartMessage;
                }
                else if (buttons == MouseButtons.Right)
                {
                    result = ClickResult.finished;
                    statusMessage = StartMessage;
                }
            }

            return result;
        }
    }
}
