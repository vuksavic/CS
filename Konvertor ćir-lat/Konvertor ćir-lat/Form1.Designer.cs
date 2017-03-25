namespace Konvertor_ćir_lat
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rtbChanged = new System.Windows.Forms.RichTextBox();
            this.bErase = new System.Windows.Forms.Button();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.lPolje2 = new System.Windows.Forms.Label();
            this.cbItalic = new System.Windows.Forms.CheckBox();
            this.lPolja = new System.Windows.Forms.Label();
            this.bCirULat = new System.Windows.Forms.Button();
            this.bLatUĆir = new System.Windows.Forms.Button();
            this.lHeading = new System.Windows.Forms.Label();
            this.lBy = new System.Windows.Forms.Label();
            this.bColors = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.bCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbChanged
            // 
            this.rtbChanged.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtbChanged.Location = new System.Drawing.Point(543, 112);
            this.rtbChanged.Name = "rtbChanged";
            this.rtbChanged.ReadOnly = true;
            this.rtbChanged.Size = new System.Drawing.Size(381, 427);
            this.rtbChanged.TabIndex = 12;
            this.rtbChanged.Text = "";
            // 
            // bErase
            // 
            this.bErase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bErase.ForeColor = System.Drawing.Color.Red;
            this.bErase.Location = new System.Drawing.Point(425, 265);
            this.bErase.Name = "bErase";
            this.bErase.Size = new System.Drawing.Size(112, 27);
            this.bErase.TabIndex = 18;
            this.bErase.Text = "Briši sve!";
            this.bErase.UseVisualStyleBackColor = true;
            this.bErase.Click += new System.EventHandler(this.bErase_Click);
            this.bErase.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bErase_MouseDown);
            this.bErase.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bErase_MouseUp);
            // 
            // rtbText
            // 
            this.rtbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtbText.Location = new System.Drawing.Point(12, 112);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(407, 427);
            this.rtbText.TabIndex = 11;
            this.rtbText.Text = "";
            // 
            // lPolje2
            // 
            this.lPolje2.AutoSize = true;
            this.lPolje2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lPolje2.Location = new System.Drawing.Point(539, 89);
            this.lPolje2.Name = "lPolje2";
            this.lPolje2.Size = new System.Drawing.Size(120, 20);
            this.lPolje2.TabIndex = 17;
            this.lPolje2.Text = "Pretvoren tekst:";
            // 
            // cbItalic
            // 
            this.cbItalic.AutoSize = true;
            this.cbItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbItalic.Location = new System.Drawing.Point(451, 320);
            this.cbItalic.Name = "cbItalic";
            this.cbItalic.Size = new System.Drawing.Size(61, 24);
            this.cbItalic.TabIndex = 13;
            this.cbItalic.Text = "Italic";
            this.cbItalic.UseVisualStyleBackColor = true;
            // 
            // lPolja
            // 
            this.lPolja.AutoSize = true;
            this.lPolja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lPolja.Location = new System.Drawing.Point(8, 89);
            this.lPolja.Name = "lPolja";
            this.lPolja.Size = new System.Drawing.Size(156, 20);
            this.lPolja.TabIndex = 16;
            this.lPolja.Text = "Tekst za pretvaranje:";
            // 
            // bCirULat
            // 
            this.bCirULat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bCirULat.Location = new System.Drawing.Point(425, 148);
            this.bCirULat.Name = "bCirULat";
            this.bCirULat.Size = new System.Drawing.Size(112, 27);
            this.bCirULat.TabIndex = 14;
            this.bCirULat.Text = "Ćirilica -> latinica";
            this.bCirULat.UseVisualStyleBackColor = true;
            this.bCirULat.Click += new System.EventHandler(this.bCirULat_Click_1);
            // 
            // bLatUĆir
            // 
            this.bLatUĆir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bLatUĆir.Location = new System.Drawing.Point(425, 181);
            this.bLatUĆir.Name = "bLatUĆir";
            this.bLatUĆir.Size = new System.Drawing.Size(112, 27);
            this.bLatUĆir.TabIndex = 15;
            this.bLatUĆir.Text = "Latinica -> ćirilica";
            this.bLatUĆir.UseVisualStyleBackColor = true;
            this.bLatUĆir.Click += new System.EventHandler(this.bLatUĆir_Click_1);
            // 
            // lHeading
            // 
            this.lHeading.AutoSize = true;
            this.lHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lHeading.Location = new System.Drawing.Point(244, 9);
            this.lHeading.Name = "lHeading";
            this.lHeading.Size = new System.Drawing.Size(462, 31);
            this.lHeading.TabIndex = 19;
            this.lHeading.Text = "Cyrillic-latin and latin-cyrilic converter";
            // 
            // lBy
            // 
            this.lBy.AutoSize = true;
            this.lBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lBy.Location = new System.Drawing.Point(412, 40);
            this.lBy.Name = "lBy";
            this.lBy.Size = new System.Drawing.Size(138, 20);
            this.lBy.TabIndex = 20;
            this.lBy.Text = "By Aleksa Peštalić";
            // 
            // bColors
            // 
            this.bColors.Location = new System.Drawing.Point(12, 9);
            this.bColors.Name = "bColors";
            this.bColors.Size = new System.Drawing.Size(75, 51);
            this.bColors.TabIndex = 21;
            this.bColors.Text = "Promena boje pozadine";
            this.bColors.UseVisualStyleBackColor = true;
            this.bColors.Click += new System.EventHandler(this.bColors_Click);
            // 
            // bCopy
            // 
            this.bCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bCopy.Location = new System.Drawing.Point(425, 236);
            this.bCopy.Name = "bCopy";
            this.bCopy.Size = new System.Drawing.Size(112, 27);
            this.bCopy.TabIndex = 22;
            this.bCopy.Text = "Kopiraj tekst -->";
            this.bCopy.UseVisualStyleBackColor = true;
            this.bCopy.Click += new System.EventHandler(this.bCopy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 551);
            this.Controls.Add(this.bCopy);
            this.Controls.Add(this.bColors);
            this.Controls.Add(this.lBy);
            this.Controls.Add(this.lHeading);
            this.Controls.Add(this.rtbChanged);
            this.Controls.Add(this.bErase);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.lPolje2);
            this.Controls.Add(this.cbItalic);
            this.Controls.Add(this.lPolja);
            this.Controls.Add(this.bCirULat);
            this.Controls.Add(this.bLatUĆir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cyrilic-latin & latin-cyrilic converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbChanged;
        private System.Windows.Forms.Button bErase;
        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.Label lPolje2;
        private System.Windows.Forms.CheckBox cbItalic;
        private System.Windows.Forms.Label lPolja;
        private System.Windows.Forms.Button bCirULat;
        private System.Windows.Forms.Button bLatUĆir;
        private System.Windows.Forms.Label lHeading;
        private System.Windows.Forms.Label lBy;
        private System.Windows.Forms.Button bColors;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button bCopy;


    }
}

