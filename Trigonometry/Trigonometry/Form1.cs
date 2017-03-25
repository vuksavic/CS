using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trigonometry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void CrtanjeKruz(int x, int y, Graphics g)
        {
            Pen pen = new Pen(Color.Red, 2);
            Pen penThin = new Pen(Color.Red, 1);
            g.DrawEllipse(pen, x, y, ClientRectangle.Width / 2, ClientRectangle.Width / 2);
            Point UpperV = new Point(x + ClientRectangle.Width / 4, y);
            Point LowerV = new Point(x + ClientRectangle.Width / 4, y + ClientRectangle.Width / 2);
            g.DrawLine(penThin, UpperV, LowerV);
            Point LeftH = new Point(x, y + ClientRectangle.Width / 4);
            Point RightH = new Point(x + ClientRectangle.Width / 2, y + ClientRectangle.Width / 4);
            g.DrawLine(penThin, LeftH, RightH);
        }

        void BezKruga(int x, int y, Graphics g)
        {
            Pen pen = new Pen(Color.Red, 2);
            Pen penThin = new Pen(Color.Red, 1);
            //bez kruga
            Point center = new Point(ClientRectangle.Width / 2 + 90, ClientRectangle.Height / 2);
            Point yLOW = new Point(center.X, center.Y + ClientRectangle.Width / 4);
            Point yUPPER = new Point(center.X, center.Y - ClientRectangle.Width / 4);
            Point xR = new Point(center.X + ClientRectangle.Width / 4, center.Y);
            Point xL = new Point(center.X - ClientRectangle.Width / 4, center.Y);

            g.DrawLine(pen, yLOW, yUPPER);
            g.DrawLine(pen, xL, xR);

            Point LeftH = new Point(x, y + ClientRectangle.Width / 4);
            Point RightH = new Point(x + ClientRectangle.Width / 2, y + ClientRectangle.Width / 4);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pbWarning.Hide();
            lWarning.Hide();
            lWarning.Location = new Point(55, ClientRectangle.Height - 30);
            pbWarning.Location = new Point(7, ClientRectangle.Height - 45);
          
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = CreateGraphics();
            int x = ClientRectangle.Width / 2 - (ClientRectangle.Width / 2) / 2 + 90;
            int y = ClientRectangle.Height / 2 - (ClientRectangle.Width / 2) / 2;
            BezKruga(x, y, g);
            if (cbCircle.Checked)
            {
                timer1.Start();
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Refresh();
            lWarning.Location = new Point(55, ClientRectangle.Height - 30);
            pbWarning.Location = new Point(7, ClientRectangle.Height - 45);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            int xK = ClientRectangle.Width / 2 - (ClientRectangle.Width / 2) / 2; //x Kruznica
            int yK = ClientRectangle.Height / 2 - (ClientRectangle.Width / 2) / 2; //y Kruznica
            Refresh();
            int x = e.X; int y = e.Y;
            Point XY = new Point(x, y);
            /*
             * int x = ClientRectangle.Width / 2 - (ClientRectangle.Width / 2) / 2;
            int y = ClientRectangle.Height / 2 - (ClientRectangle.Width / 2) / 2;
             * */
            int xC = (ClientRectangle.Width / 2 - ClientRectangle.Width / 4) + ClientRectangle.Width / 4 + 90;
            int yC = (ClientRectangle.Height / 2 - ClientRectangle.Width / 4) + ClientRectangle.Width / 4;
            Graphics g = CreateGraphics();
            Pen pen = new Pen(Color.Black, 4);
            Point center = new Point(xC, yC);
            g.DrawLine(pen, xC, yC, x, y);

            //cursor
            int xNC = x; //x Non Constant
            int yCONST = yC; //y Constant

            Point ptNC = new Point(xNC, yCONST);
            g.DrawLine(pen, center, ptNC);

            //spajanje i formiranje trougla
            g.DrawLine(pen, XY, ptNC);

            //uslovi za rad (abs x>r)
            double a = ptNC.Y - y;
            double b = ptNC.X - xC;
            double c = Math.Sqrt(a * a + b * b);
            
            if (c > ClientRectangle.Width / 4)
            {
                pbWarning.Show();
                lWarning.Show();
            }
            else
            {
                lWarning.Hide();
                pbWarning.Hide();
            }

            //DATA CALCULATION
            //location
            lLocationX.Text = "X = " + x + " px";
            lLocationY.Text = "Y = " + y + " px";
            //stranice u px
            double strA = ptNC.Y - y;
            double strB = ptNC.X - xC;
            double strC = Math.Sqrt(a * a + b * b);
            //str u cm (1px = 0.026458cm)
            const double cm = 0.026458;
            double aCM = Math.Abs(strA * cm);
            double bCm = Math.Abs(strB * cm);
            double cCM = Math.Abs(strC * cm);
            //prikaz u labelama
            lA.Text = "a = " + aCM.ToString("0.00") + " cm";
            lB.Text = "b = " + bCm.ToString("0.00") + " cm";
            lC.Text = "x = " + cCM.ToString("0.00") + " cm";
            //calc COS
            double cosA = (bCm * bCm + cCM * cCM - aCM * aCM) / (2 * bCm * cCM); //po pravilu kosinusa
            double cosB = (cCM * cCM + aCM * aCM - bCm * bCm) / (2 * aCM * cCM);
            double cosC = (aCM * aCM + bCm * bCm - cCM * cCM) / (2 * aCM * bCm);
            lCosAlpha.Text = "Cos 	α = " + cosA.ToString("0.00");
            lCosBeta.Text = "Cos 	β = " + cosB.ToString("0.00");
            lCosGama.Text = "Cos 	γ = " + cosC.ToString("0.00"); //uvek je 0 (cos 90 = 0)
            //angles in deg
            const double deg = 57.2958;
            double angA = Math.Acos(cosA) * deg; //from rad to deg
            double angB = Math.Acos(cosB) * deg;
            double angC = Math.Acos(cosC) * deg;
            lAlpha.Text = "α = " + (angA).ToString("0.00") + " deg";
            lBeta.Text = "β = " + (angB).ToString("0.00") + " deg";
            lGama.Text = "γ = " + (angC).ToString("0.00") + " deg";

            //sin alpha, beta, gamma;
            double sinA = Math.Abs(Math.Sin(angA));
            double sinB = Math.Abs(Math.Sin(angB));
            double sinC = Math.Abs(Math.Sin(angC));
            lSinAlpha.Text = "Sin α = " + sinA.ToString("0.00");
            lSinBeta.Text = "Sin β = " + sinB.ToString("0.00");
            lSinGama.Text = "Sin γ = " + sinC.ToString("0.00");

            //tan alpha, beta, gamma;
            double tanA = Math.Abs(Math.Tan(angA));
            double tanB = Math.Abs(Math.Tan(angB));
            double tanC = Math.Abs(Math.Tan(angC));
            lTanAlpha.Text = "tan α = " + tanA.ToString("0.00");
            lTanBeta.Text = "tan β = " + tanB.ToString("0.00");
            lTanGama.Text = "tan γ = " + tanC.ToString("0.00");
        }
        int n = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (n == 1) Refresh();
            if (cbCircle.Checked)
            {
                n++;
                Graphics g = CreateGraphics();
                int x = ClientRectangle.Width / 2 - (ClientRectangle.Width / 2) / 2 + 90;
                int y = ClientRectangle.Height / 2 - (ClientRectangle.Width / 2) / 2;
                CrtanjeKruz(x, y, g);
            }
        }
    }
}
