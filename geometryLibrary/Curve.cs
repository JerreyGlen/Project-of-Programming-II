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
    public abstract class Curve
    {
        //Es wird die Eigenschaten von dem DrawPen definiert
        public double Length { get; }
        
        public Pen DrawPen { get; set; } = new Pen(Color.Blue, 2);
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="screenPoint">
        /// Hier wird der screenPoint in einen Point mit korrekter Koordinatenangabe umgewandelt.
        /// </param>
        /// <param name="screenHeight">Höhe der Picturebox</param>
        /// <returns></returns>
        public static Point TransformScreen2World(
            System.Drawing.Point screenPoint, int screenHeight)
        {
            return new Point(screenPoint.X, -(screenPoint.Y - screenHeight));
        }

        public Curve()
        {

        }
        /// <summary>
        /// Wird  überschriebenin den abgeleiteten Klassen von "Curve"
        /// </summary>
        /// <param name="g"></param>
        public abstract void Draw(Graphics g);

        
    }
}
