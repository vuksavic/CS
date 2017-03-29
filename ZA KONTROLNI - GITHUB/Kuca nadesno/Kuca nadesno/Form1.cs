using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kuca_nadesno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        //po pokretanju se pojavi 20 kuca koje se pomeraju nadesno...
        
        struct Kuca
        {
            public int x, y, a, vx;
            public Color boja;
        }

        void Draw(Graphics g, Kuca k)
        {
            //koordinate i draw
            SolidBrush cetka = new SolidBrush(k.boja);
            g.FillRectangle(cetka, k.x - k.a, k.y, 2 * k.a, 2 * k.a);
            cetka.Color = Color.Red;
            Point p1 = new Point(k.x - k.a, k.y);
            Point p2 = new Point(k.x, k.y - k.a);
            Point p3 = new Point(k.x + k.a, k.y);
            Point[] krov = { p1, p2, p3 };
            g.FillPolygon(cetka, krov);
        }
        Kuca[] k = new Kuca[20]; // vrednosti se mogu menjati, ali uvek mora k == n!;
        int n = 20;

        Random r = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < n; i++)
            {
                //deklarisu se vrednosti variabli
                k[i].x = r.Next(ClientRectangle.Width);
                k[i].y = r.Next(ClientRectangle.Height); // menjaju se za svaki crtez
                k[i].a = r.Next(10, 20);
                k[i].vx = 5;
                k[i].boja = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            }
            timer1.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //ciklus koji crta
            for (int i = 0; i < n; i++)
            {
                Draw(e.Graphics, k[i]); // k[i] znaci da se svakim obrtom ciklusa pomeri pokazivac u nizu za 1...
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // svakim obrtom ciklusa var x se poveca za var vx...
            for (int i = 0; i < n; i++)
            {
                k[i].x += k[i].vx;
            }
            Refresh();
        }

    }
}
