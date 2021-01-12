using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Point = vectorLibrary.Point;
using vectorLibrary;
using geometryLibrary;

namespace ÜbungenPr2
{
    public partial class FrmMain : Form
    {
        private Drawing m_CAD = new Drawing(new Curve[0]);
        private ClickHandler m_clickHandler = null;
        Polyline poly = new Polyline();
        /// <summary>
        /// 
        /// </summary>
        private Curve m_currentCurve;
        public FrmMain()
        {
            InitializeComponent();
            m_CAD.redraw += Drawing_redraw;

            StatusManager.Instance.StatusMessageChanged += (s, e) => toolStripStatus.Text = e.Message;

        }
        private void Drawing_redraw(object sender, EventArgs e)//
        {
            //Löst ein neue Zeichnen der Picturebox
            pictureBox.Invalidate();
        }

        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_Resize(object sender, EventArgs e)
        {
            pictureBox.Invalidate();
        }

        private void toolStripStatus_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonLine_Click(object sender, EventArgs e)
        {
            m_currentCurve = null;
            //Die Methode "Linie_ClickHandler" wird der Delegate-Variable zugewiesen
            m_clickHandler = Line.Linie_ClickHandler;
            // Bei jeder Maus-Klick wird die Anzeige im Toolstrip geändert
            StatusManager.Instance.SetStatus(Line.StartMessage);


        }

        private void toolStripButtonCircle_Click(object sender, EventArgs e)
        {
            m_currentCurve = null;
            m_clickHandler = Circle.Circle_ClickHandler;
            StatusManager.Instance.SetStatus(Circle.StartMessage);


        }

        private void toolStripButtonPolyline_Click(object sender, EventArgs e)
        {
            m_currentCurve = null;
            m_clickHandler = Polyline.Polyline_ClickHandler;
            StatusManager.Instance.SetStatus(Polyline.StartMessage);

        }
        private void SetGraphicsTransformToWorld(Graphics g)
        {
            g.ResetTransform();
            g.ScaleTransform(1f, -1f);
            g.TranslateTransform(0f, -pictureBox.Height);
        }

        private void InformationenButton_Click(object sender, EventArgs e)
        {
            double gesamtLängeLines = 0;
            double gesamtLängeCircles = 0;
            double gesamtLängePolylines = poly.LängeBerechnung();
            int anzahl_von_lines = m_CAD.Lines().Count;
            int anzahl_von_cycles = m_CAD.Circles().Count;
            int anzahl_von_polylines = m_CAD.Polylines().Count;
            //Berechnung der Gesamtlänge der Linien
            foreach (var item in m_CAD.Lines())
            {
                gesamtLängeLines += item.StartPoint.DistanceTo(item.EndPoint);
            }
            //Berechnung der Gesamtlänge der Kreise
            foreach (var item in m_CAD.Circles())
            {
                gesamtLängeCircles += item.Radius * 2 * Math.PI;
            }

            //Anzahl der Kurven wird ausgegeben
            MessageBox.Show($"Lines:{anzahl_von_lines}, Circles:{ anzahl_von_cycles}, " +
                $"Polylines:  {anzahl_von_polylines}\n\n Gesamtelänge der Linien: {gesamtLängeLines}" +
                $"\nGesamtelänge der Kreise: {gesamtLängeCircles}\nGesamtelänge der Polylinien: {gesamtLängePolylines} ");



        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            SetGraphicsTransformToWorld(e.Graphics);
            //Bestimmt ob die gezeichnete Linien in der PictureBox bleiben oder nicht
            if (ShowLinesButton8.Checked)
            {
                m_CAD.Lines().DrawElements(e.Graphics);
            }

            if (ShowCirclesButton.Checked)
            {
                m_CAD.Circles().DrawElements(e.Graphics);
            }

            if (ShowPolylineButton.Checked)
            {
                m_CAD.Polylines().DrawElements(e.Graphics);
            }
        }

        private void ShowLinesButton8_Click(object sender, EventArgs e)
        {
            pictureBox.Invalidate();
        }

        private void ShowCirclesButton_Click(object sender, EventArgs e)
        {
            pictureBox.Invalidate();
        }

        private void ShowPolylineButton_Click(object sender, EventArgs e)
        {
            pictureBox.Invalidate();
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
    
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (m_clickHandler != null)
            {
                string statusMessage;
                //"m_clickHandler" wird aufgeruft und das Ergebnis wird in "result" gemerkt
                //Durch die Delegate-Methode "m_clickHandler" hat man einen Zugriff zu den in Kurven (Line,Circle, Polylinie)
                //statischen Funktionen
                ClickResult result = m_clickHandler(e.Location, e.Button,
                    pictureBox.Height, ref m_currentCurve, out statusMessage);
                //Bei neu Mouse-Klick in der PictureBox 
                StatusManager.Instance.SetStatus(statusMessage);
                //Wenn der Befehl abgebrochen wurde(enum ist cancelled) wird lediglich
                //m_currentCurve auf null gesetzt.
                if (result == ClickResult.canceled)
                {
                    m_currentCurve = null;
                }
                //Wenn als Ergebnis finished zurückgegeben wird, konnte die Delegatfunktion ein
                //gültiges Curve-Objekt("m_currentCurve") fertigstellen.
                else if (result == ClickResult.finished)
                {
                    m_CAD.AddElement(m_currentCurve);
                    //Hier muss m_currentCurve wieder auf null gesetzt werden, um einen neuen
                    //Durchlauf zu starten.
                    m_currentCurve = null;
                }
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
