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
    public class Circle: Curve, IArea
    {
        public const string StartMessage = "Bitte wählen Sie das Center der Kreise in.";
        public const string EndMessage = "Bitte wählen einen anderen Punkt um den Radius zu bilden";
        /// <summary>
        /// Alle Eigenschaten hier
        /// </summary>
        public Vector Normal { get; set; }
        public Point CenterPoint { get; set; }
        public double Radius;
        public double Lenght { get; }
        /// <summary>
        /// Die Fläche des Kreises wird berechnet
        /// </summary>
        public double Area
        {
            get
            {
                //Fläche des Kreises
                return Math.Pow(Radius, 2) * Math.PI;
            }
        }

        public Circle()
        {

        }
        /// <summary>
        /// der Kreis wird gezeichnet
        /// </summary>
        /// <param name="g">der Grafikkontext</param>
        public override void Draw(Graphics g)
        {
            // Ein "rectangle" wird aufgebaut, um unseren Kreis zu beschreiben
            float x = (float)(CenterPoint.x - Radius);
            float y = (float)(CenterPoint.y - Radius);
            float durchmesser = 2f * (float)Radius;
            RectangleF rectangle = new RectangleF(x, y, durchmesser, durchmesser);
            g.DrawEllipse(DrawPen, rectangle);

        }
        /// <summary>
        
        /// </summary>
        /// <param name="centerPoint">Centre du cercle</param>
        /// <param name="normal">Vecteur normal</param>
        /// <param name="radius"></param>
        public Circle(Point centerPoint, Vector normal, double radius)
        {
            this.CenterPoint = centerPoint;
            this.Normal = normal;
            this.Radius = radius;
        }

        /// <summary>
        /// Das Zeichnen des Kreises wird jetzt per Maus-Klick bestätigt
        /// </summary>
        /// <param name="pt"></param>
        /// <param name="buttons"></param>
        /// <param name="screenHeight"></param>
        /// <param name="curElement"></param>
        /// <param name="statusMessage"></param>
        /// <returns></returns>
        public static ClickResult Circle_ClickHandler(System.Drawing.Point pt, MouseButtons buttons,
           int screenHeight, ref Curve curElement, out string statusMessage)
        {
            ClickResult result = ClickResult.canceled;
            statusMessage = string.Empty;

            Point worldPoint = TransformScreen2World(pt, screenHeight);
            if (buttons != MouseButtons.Right)
            {
                if (curElement == null || curElement.GetType() != typeof(Circle))
                {
                    //Der Kreis-Center wird gemerkt
                    curElement = new Circle(worldPoint, new Vector(), 0);
                    result = ClickResult.created;
                    statusMessage = EndMessage;
                }
                else
                {
                    Circle c = curElement as Circle;
                    //Der Raduis wird berechnen durch 
                    c.Radius = c.CenterPoint.DistanceTo(worldPoint);
                    result = ClickResult.finished;
                    statusMessage = StartMessage;
                }
            }

            return result;
        }
    }
}
