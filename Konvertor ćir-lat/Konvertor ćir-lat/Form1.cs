using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Konvertor_ćir_lat
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> words = new Dictionary<string, string>();
        public Form1()
        {
            words.Add("а", "a");
            words.Add("б", "b");
            words.Add("в", "v");
            words.Add("г", "g");
            words.Add("д", "d");
            words.Add("ђ", "đ");
            words.Add("е", "e");
            words.Add("ж", "ž");
            words.Add("з", "z");
            words.Add("и", "i");
            words.Add("j", "j");
            words.Add("к", "k");
            words.Add("л", "l");
            words.Add("љ", "lj");
            words.Add("м", "m");
            words.Add("н", "n");
            words.Add("њ", "nj");
            words.Add("о", "o");
            words.Add("п", "p");
            words.Add("р", "r");
            words.Add("с", "s");
            words.Add("т", "t");
            words.Add("ћ", "ć");
            words.Add("у", "u");
            words.Add("ф", "f");
            words.Add("х", "h");
            words.Add("ц", "c");
            words.Add("ч", "č");
            words.Add("џ", "dž");
            words.Add("ш", "š");
            //CAPS
            words.Add("А", "A");
            words.Add("Б", "B");
            words.Add("В", "V");
            words.Add("Г", "G");
            words.Add("Д", "D");
            words.Add("Ђ", "Đ");
            words.Add("Е", "E");
            words.Add("Ж", "Ž");
            words.Add("З", "Z");
            words.Add("И", "I");
            words.Add("Ј", "J");
            words.Add("К", "K");
            words.Add("Л", "L");
            words.Add("Љ", "LJ");
            words.Add("М", "M");
            words.Add("Н", "N");
            words.Add("Њ", "NJ");
            words.Add("О", "O");
            words.Add("П", "P");
            words.Add("Р", "R");
            words.Add("С", "S");
            words.Add("Т", "T");
            words.Add("Ћ", "Ć");
            words.Add("У", "U");
            words.Add("Ф", "F");
            words.Add("Х", "H");
            words.Add("Ц", "C");
            words.Add("Ч", "Č");
            words.Add("Џ", "DŽ");
            words.Add("Ш", "Š");
            //cifre
            words.Add("1", "1");
            words.Add("2", "2");
            words.Add("3", "3");
            words.Add("4", "4");
            words.Add("5", "5");
            words.Add("6", "6");
            words.Add("7", "7");
            words.Add("8", "8");
            words.Add("9", "9");
            words.Add("0", "0");
            //simboli
            words.Add("!", "!");
            words.Add("#", "#");
            words.Add("$", "$");
            words.Add("%", "%");
            words.Add("&", "&");
            words.Add("/", "/");
            words.Add("(", "(");
            words.Add(")", ")");
            words.Add("=", "=");
            words.Add("?", "?");
            words.Add("'", "'");
            words.Add("*", "*");
            words.Add("+", "+");
            words.Add("~", "~");
            words.Add("-", "-");
            words.Add("<", "<");
            words.Add(">", ">");
            words.Add(",", ",");
            words.Add(";", ";");
            words.Add(".", ".");
            words.Add(":", ":");
            words.Add("_", "_");
            words.Add("@", "@");
            words.Add("{", "{");
            words.Add("}", "}");
            words.Add("×", "×");
            words.Add("÷", "÷");
            words.Add("˝", "˝");
            
            InitializeComponent();
        }
        private void bCirULat_Click_1(object sender, EventArgs e)
        {
            try
            {
                //CheckBox Italic
                if (cbItalic.Checked == true)
                {
                    Font font = new Font(rtbChanged.Font, FontStyle.Italic);
                    rtbChanged.Font = font;
                }

                if (cbItalic.Checked == false)
                {
                    Font font = new Font(rtbChanged.Font, FontStyle.Regular);
                    rtbChanged.Font = font;
                }

                string source = rtbText.Text;
                foreach (KeyValuePair<string, string> pair in words)
                {
                    source = source.Replace(pair.Key, pair.Value);
                }
                rtbChanged.Text = source;

            }
            catch
            {
                MessageBox.Show("Restartujte aplikaciju", "Fatalna greška");
            }
        }

        private void cbItalic_Click(object sender, EventArgs e)
        {
            rtbChanged.Refresh();
        }

        private void bLatUĆir_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cbItalic.Checked == true)
                {
                    Font font = new Font(rtbChanged.Font, FontStyle.Italic);
                    rtbChanged.Font = font;
                }

                if (cbItalic.Checked == false)
                {
                    Font font = new Font(rtbChanged.Font, FontStyle.Regular);
                    rtbChanged.Font = font;
                }
                string source = rtbText.Text;
                foreach (KeyValuePair<string, string> pair in words)
                {
                    source = source.Replace(pair.Value, pair.Key);
                }
                rtbChanged.Text = source;
            }
            catch
            {
                MessageBox.Show("Restartujte aplikaciju", "Fatalna greška");
            }
            
        }

        private void bErase_Click(object sender, EventArgs e)
        {
            rtbChanged.Clear();
            rtbText.Clear();
        }

        private void bColors_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;
        }

        private void bCopy_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(rtbChanged.Text);
            }
            catch
            {
                MessageBox.Show("Morate uneti tekst u polje za konverziju, pa ga tek onda kopirati.", "Problem");
            }
            
        }

        private void bErase_MouseDown(object sender, MouseEventArgs e)
        {
            Color boja = Color.FromArgb(255, 255, 20);
            this.BackColor = boja;
            rtbChanged.BackColor = boja;
            rtbText.BackColor = boja;
        }

        private void bErase_MouseUp(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.Empty;
            rtbChanged.BackColor = Color.Empty;
            rtbText.BackColor = Color.Empty;
        }
    }
}
