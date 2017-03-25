using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random r = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Empty;
            long max = Convert.ToInt64(textBox1.Text);
            int unos = 0;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = ".txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                for (int i = 0; i < max; i++)
                {
                    unos = r.Next(10000);
                    sw.WriteLine(unos);
                }
                sw.Close();
            }
            //animacija
            
            timer1.Interval = 10; //10ms
            timer1.Start();
        }
       

        int incr = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;
            incr++;
            pictureBox1.Location = new Point(x += incr, y);

            if (pictureBox1.Location.X > ClientRectangle.Width)
            {
                pictureBox1.Location = new Point(12, 155);
            }

            if (incr > 100)
            {
                timer1.Stop();
                incr = 1;
                pictureBox1.Location = new Point(12, 155);
            }
            Refresh();
        }


       
       
    }
}
