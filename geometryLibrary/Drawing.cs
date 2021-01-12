using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Point = vectorLibrary.Point;
using vectorLibrary;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace geometryLibrary
{
    public delegate void RedrawHandler(object sender, EventArgs e);
    public class Drawing
    {
        /// <summary>
        /// Eigenschaften
        /// </summary>
        public List<Curve> Elements = new List<Curve>();
        //Definition eines Ereignisses(Event)
        public event EventHandler redraw;
        public void Save(string fileName)
        {

            //Serialisierung und Deserialisierung von Collections 

            var serializer = new JsonSerializer { TypeNameHandling = TypeNameHandling.Auto };
            using (TextWriter writer = File.CreateText(fileName))
            {

                serializer.Serialize(writer, Elements);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        public void Load(string fileName)
        {
            var serializer = new JsonSerializer { TypeNameHandling = TypeNameHandling.Auto };
            using (StreamReader reader = File.OpenText(fileName))
            {
                Elements.Clear();
                Elements.AddRange(serializer.Deserialize(reader, typeof(Curve[])) as Curve[]);

                if (redraw != null)
                {
                    redraw(Elements.ToArray(), EventArgs.Empty);
                }
            }
        }
        /// <summary>
        /// Creates a new instance.
        /// </summary>
        /// <param name="curves">The curves to be contained in the drawing.</param>
        public Drawing(Curve[] curves)
        {
            Elements.AddRange(curves);
        }

        public void AddElement(Curve Element)
        {
            Elements.Add(Element);
            //Geprüft wird, ob jemand sich für das Ereignis registriert hat
            if (redraw != null)
            {
                //Der Ereignis "redraw" wird jetzt wie eine Methode aufgerufen
                redraw(this, EventArgs.Empty);
            }

        }
        public void RemoveElement(Curve Element)
        {
            Elements.Remove(Element);
            if (redraw != null) redraw(this, EventArgs.Empty);
        }
        
        public void RemoveAllCurves()
        {
            Curve[] previousCurves = Elements.ToArray();
            Elements.Clear();
            if (redraw != null)
            {
                redraw(previousCurves, EventArgs.Empty);
            }
        }
        public void RemoveElementAt(int Index)
        {
            Elements.RemoveAt(Index);
            if (redraw != null) redraw(this, EventArgs.Empty);
        }

        public Drawing()
        {

        }

        /// <summary>
        /// Alle gezeichnete Linien werden in der Variable "Lines" hinzugefügt
        /// </summary>
        /// <returns></returns>
        public CurveElements<Line> Lines()
        {
            CurveElements<Line> lines = new CurveElements<Line>();
            lines.AddRange(Elements.Where(Element => Element.GetType() == typeof(Line)).Select(line => line as Line));
            return lines;
        }

        /// <summary>
        /// Alle gezeichnete Kreise werden in der Variable "Circles" hinzugefügt
        /// </summary>
        public CurveElements<Circle> Circles()
        {
            CurveElements<Circle> circles = new CurveElements<Circle>();
            circles.AddRange(Elements.Where(Element => Element.GetType() == typeof(Circle)).Select(circle => circle as Circle));
            return circles;
        }

        /// <summary>
        /// Alle gezeichnete Polylinien werden in der Variable "Polylines" hinzugefügt
        /// </summary>
        public CurveElements<Polyline> Polylines()
        {
            CurveElements<Polyline> polylines = new CurveElements<Polyline>();
            polylines.AddRange(Elements.Where(Element => Element.GetType() == typeof(Polyline)).Select(polyline => polyline as Polyline));
            return polylines;
        }

        
        
    }
}

