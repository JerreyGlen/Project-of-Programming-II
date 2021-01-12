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
    /// <summary>
    /// Delegattypen utilise lorsque on clique
    /// </summary>
    /// <param name="clickPoint">Le point de la surface clique.</param>
    /// <param name="buttons">le point qui a ete presse.</param>
    /// <param name="screenHeight">The height of the given control.</param>
    /// <param name="currentElement">The current <see cref="Curve"/> element.</param>
    /// <param name="statusMessage">Le status</param>
    /// <returns>clickresult.</returns>
    public delegate ClickResult ClickHandler(System.Drawing.Point pt,
       MouseButtons but, int screenHeight, ref Curve curElement, out string statusMessage);
        /// <summary>
        /// Enumeration qui determine les resultats lors de la creation des Kurven per Mouse
        
        /// </summary>
        public enum ClickResult
        {
            created,
            pointHandled,
            finished,
            canceled
        }
    
}
