using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using Point = vectorLibrary.Point;
using vectorLibrary;
using System.Threading.Tasks;

namespace geometryLibrary
{
    public class CurveElements<T> : List<T> where T : Curve
    {

        /// <summary>
        /// on parcoure la liste des courbes a dessiner
        /// </summary>
        /// <param name="g"></param>
        public void DrawElements(Graphics g)
        {
            foreach (T element in this)
            {
                element.Draw(g);
            }
        }
    }
}
