using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zeichnen
{
    public partial class FrmZeichnen : Form
    {
        public FrmZeichnen()
        {
            InitializeComponent();
        }

        private void FrmZeichnen_Paint(object sender, PaintEventArgs e)
        {
            
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            Pen p = new Pen(Color.Red);
            int width = ClientSize.Width;
            int height = ClientSize.Height;
            Point linksoben = new Point(0, 0);
            Point linksunten = new Point(0, height);
            Point rechtoben = new Point(width, 0);
            Point rechtsunten = new Point(width, height);
            Point mitteoben = new Point(width / 2, 0);
            Point mittemitte = new Point(width / 2, height / 2);
            Point mitteunten = new Point(width / 2, height);
            //Line
            g.DrawLine(p, mitteoben, mitteunten);
            //g.DrawLine(p,linksoben, mittemitte);
            //g.DrawLine(p, rechtoben, mittemitte);
            //g.DrawLine(p, linksunten, mittemitte);
            //g.DrawLine(p, rechtsunten, mittemitte);
            //Dreicek
            p.Color = Color.Green;
            Point[] t = new Point[] { mitteoben, rechtsunten, linksunten };
            g.DrawPolygon(p, t);
            //Kreis
            p.Color = Color.Blue;
            Rectangle r = new Rectangle(width / 4, height /4 , width * 2 / 4, height * 3 / 4);
            g.DrawRectangle(p, r);
            g.DrawEllipse(p, r);
        }

        private void FrmZeichnen_Resize(object sender, EventArgs e)
        {
            Refresh();

        }
    }
}
