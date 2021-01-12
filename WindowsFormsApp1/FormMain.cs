using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vectorLibrary;
using geometryLibrary;

namespace WindowsFormsApp1
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// neur Drawing Objekt zum zeichnen
        /// </summary>
        private Drawing m_CAD = new Drawing(new Curve[0]);
        private ClickHandler _clickHandler = null;
        Polyline poly = new Polyline();
        private Curve m_currentCurve;
        public FormMain()
        {
            InitializeComponent();
            m_CAD.redraw += Drawing_redraw;
            StatusManager.Instance.StatusMessageChanged += (s, e) => toolStripStatusLabel1.Text = e.Message;

        }
        private void Drawing_redraw(object sender, EventArgs e)//
        {
            //Löst ein neue Zeichnen der Picturebox
            pictureBox1.Invalidate();
        }

        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            m_CAD.RemoveAllCurves();
        }

        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog sfd = new OpenFileDialog
            {
                AddExtension = true,
                DefaultExt = ".drw",
                CheckPathExists = true,
                Filter = "Drawing files (*.drw)|",
                InitialDirectory =
                    System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Title = "Please select a drawing file to ."
            };
            //
            DialogResult result = sfd.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                m_CAD.Load(sfd.FileName);
            }
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                AddExtension = true,
                DefaultExt = ".drw",
                CheckPathExists = true,
                Filter = "Drawing files (*.drw)|",
                InitialDirectory =
                    System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Title = "Please select a drawing file to save."
            };
            //Der Dialog wird geöffnet
            DialogResult result = sfd.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                m_CAD.Save(sfd.FileName);
            }
        }

        private void toolStripButtonLine_Click(object sender, EventArgs e)
        {
            m_currentCurve = null;
            
            _clickHandler = Line.Linie_ClickHandler;
            /* Bei jeder Maus-Klick wird die Anzeige im Toolstrip geändert*/
            StatusManager.Instance.SetStatus(Line.StartMessage);


        }

        private void toolStripButtonCircle_Click(object sender, EventArgs e)
        {
            m_currentCurve = null;
            _clickHandler = Circle.Circle_ClickHandler;
            StatusManager.Instance.SetStatus(Circle.StartMessage);

        }

        private void toolStripButtonPolyline_Click(object sender, EventArgs e)
        {
            m_currentCurve = null;
            _clickHandler = Polyline.Polyline_ClickHandler;
            StatusManager.Instance.SetStatus(Polyline.StartMessage);

        }
        private void SetGraphicsTransformToWorld(Graphics g)
        {
            g.ResetTransform();
            g.ScaleTransform(1f, -1f);
            g.TranslateTransform(0f, -pictureBox1.Height);
        }
        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            //Weist darauf hin, dass den Picturebox neu gezeichnet wird 
            //das Paint-Erreignis wird ausgelöst
            pictureBox1.Invalidate();

        }
        /*"m_clickHandler" wird aufgeruft und das Ergebnis wird in "result" gemerkt
                //Durch die Delegate-Methode "m_clickHandler" hat man einen Zugriff zu den in Kurven (Line,Circle, Polylinie)
                //statischen Funktionen*/
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (_clickHandler != null)
            {
                string statusMessage;
                ClickResult result = _clickHandler(e.Location, e.Button, pictureBox1.Height, ref m_currentCurve, out statusMessage);
                StatusManager.Instance.SetStatus(statusMessage);
                if (result == ClickResult.canceled)
                {
                    m_currentCurve = null;
                }
                //Wenn als Ergebnis finished zurückgegeben wird, konnte die Delegatfunktion ein
                //gültiges Curve-Objekt("m_currentCurve") fertigstellen.
                else if (result == ClickResult.finished)
                {
                    m_CAD.AddElement(m_currentCurve);
                    m_currentCurve = null;
                }
            }
        }
        //Bestimmt ob die gezeichnete Elemente in der PictureBox bleiben oder nicht
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            SetGraphicsTransformToWorld(e.Graphics);
            
            if (showLinesButton.Checked)
            {
                m_CAD.Lines().DrawElements(e.Graphics);
            }

            if (showCirclesButton.Checked)
            {
                m_CAD.Circles().DrawElements(e.Graphics);
            }

            if (showPolyLineButton.Checked)
            {
                m_CAD.Polylines().DrawElements(e.Graphics);
            }
        }
        private void InformationenButton_Click(object sender, EventArgs e)
        {
            ///zählt alle gezeichneten curvetypen
            int numOflines = m_CAD.Lines().Count;
            int numOfPolylines = m_CAD.Polylines().Count;
            int numOfCircle = m_CAD.Circles().Count;

            double gesamtLängeLines = 0;
            double gesamtLängeCircles = 0;
            double gesamtLängePolylines = poly.LängeBerechnung();
            foreach (var item in m_CAD.Lines())
            {
                gesamtLängeLines += item.StartPoint.DistanceTo(item.EndPoint);
            }
            //Berechnung der Gesamtlänge der Kreise
            foreach (var item in m_CAD.Circles())
            {
                gesamtLängeCircles += item.Radius * 2 * Math.PI;
            }


            MessageBox.Show("Lines: " + numOflines.ToString() + "  Circles: " + "   " + numOfCircle + "  Polylines: " + "   " + numOfPolylines + "  Gesamtlänge ligne" + "   " + Math.Round(gesamtLängeLines, 2)
                + "  Gesamtlänge Circle" + "   " + Math.Round(gesamtLängeCircles, 2) + "  Gesamtlänge Polylinie " + Math.Round(gesamtLängePolylines, 2));

        }

        private void showLinesButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void showCirclesButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void showPolyLineButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
