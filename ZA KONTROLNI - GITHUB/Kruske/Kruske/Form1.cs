using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kruske
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //na mestu klika se pojavljuje kruska random velicine koja pocinje da pada random brzinom.
        struct Kruska
        {
            public int x, y, a, vy;// vy = brzina padanja
        }

        void Draw(Graphics g, Kruska k)
        {
            SolidBrush cetka = new SolidBrush(Color.Orange);
            //koordinate dve elipse
            g.FillEllipse(cetka, k.x - k.a, k.y + k.a, 2 * k.a, 2 * k.a);
            g.FillEllipse(cetka, k.x - k.a / 2, k.y, k.a, 3 * k.a);
            //promena boje cetke
            cetka.Color = Color.YellowGreen;
            g.FillEllipse(cetka, k.x, k.y - k.a, k.a, k.a / 2);
            //inicijalizacija olovke za crtaanje peteljke
            Pen olovka = new Pen(Color.Brown, 3);
            g.DrawLine(olovka, k.x, k.y - k.a, k.x, k.y);
        }

        //inicijalizacija niza krusaka
        Kruska[] k = new Kruska[50];
        int n = 0;

        Random r = new Random();

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //svaki put se menjaju vrednosti dok ne bude 50 krusaka nacrtano?
            if (n < 50)
            {
                k[n].a = r.Next(20, 40);
                k[n].vy = r.Next(1, 7);
                k[n].x = e.X;
                k[n].y = e.Y;
                n++;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < n; i++)
            {
                //dok se ne iscrta n puta ponavljace se metoda
                Draw(e.Graphics, k[i]);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < n; i++)
            {
                k[i].y += k[i].vy;
                if (k[i].y > ClientRectangle.Height - 3 * k[i].a)
                    k[i].vy = 0;
            }
            Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
