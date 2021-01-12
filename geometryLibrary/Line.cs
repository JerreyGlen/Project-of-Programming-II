using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Point = vectorLibrary.Point;
using vectorLibrary;
using System.Windows.Forms;

namespace geometryLibrary
{
    public class Line: Curve
    {
        public const string StartMessage = "Bitte wählen Sie den StartPunkt";
        public const string EndMessage = "Bitte wählen Sie den EndPunkt.";

        /// <summary>
        /// Methoden
        /// </summary>
        /// <param name="startPoint"></param>
        /// <param name="endPoint"></param>
        public Line(Point startPoint, Point endPoint)
        {
            this.StartPoint = startPoint;
            this.EndPoint = endPoint;
        }
        /// <summary>
        /// Berechnet den normalisierten Vektor von einem Punkt zu einem anderen Punkt
        /// </summary>
        public Vector Direction
        {
            get
            {
                Vector ret = new Vector(EndPoint.x - StartPoint.x, EndPoint.y - StartPoint.y, EndPoint.z - StartPoint.z);
                return ret.Normalize();
            }
        }
        //Berechnung der Gesamtlänge des Kreises
        public double Lenght()
        {

            return StartPoint.DistanceTo(EndPoint) * Math.PI;

        }
        // <summary>
        /// Das Zeichnen der Linie wird jetzt per Maus-Click betätigt
        /// </summary>
        /// <param name="pt">Nimmt die Werte von "e.Location"</param>
        /// <param name="buttons">Bestimmt, ob es ein rechter oder linker Mouse-Klick ist </param>
        /// <param name="screenHeight">Höhe der PictureBox</param>
        /// <param name="curElement"></param>
        /// <param name="statusMessage">Aktuelle Anzeige von dem Toolstrip"Infos vom System"</param>
        /// <returns></returns>
        public static ClickResult Linie_ClickHandler(System.Drawing.Point pt, MouseButtons buttons,
           int screenHeight, ref Curve curElement, out string statusMessage)
        {
            statusMessage = string.Empty;
            ClickResult result = ClickResult.canceled;
            Point worldPoint = TransformScreen2World(pt, screenHeight);
            if (buttons != MouseButtons.Right)
            {
                if (curElement == null || curElement.GetType() != typeof(Line))
                {
                    curElement = new Line(worldPoint, worldPoint);
                    result = ClickResult.created;
                    statusMessage = EndMessage;
                }
                else
                {
                    (curElement as Line).EndPoint = worldPoint;
                    result = ClickResult.finished;
                    statusMessage = StartMessage;
                }
            }
            return result;
        }

        public Line()
        {

        }
        public Line(double x, double y, double z = 0)
        {

        }
        /// <summary>
        /// Die Linie wird gezeichnet
        /// </summary>
        /// <param name="g"></param>
        public override void Draw(Graphics g)
        {
            g.DrawLine(DrawPen, (float)StartPoint.x, (float)StartPoint.y, (float)EndPoint.x, (float)EndPoint.y);
        }


        
    }
}
