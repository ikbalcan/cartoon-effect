namespace Karikatur
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.picOrig = new System.Windows.Forms.PictureBox();
            this.picResult = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TrackBar();
            this.tb2 = new System.Windows.Forms.TrackBar();
            this.tb4 = new System.Windows.Forms.TrackBar();
            this.lblcrmin = new System.Windows.Forms.Label();
            this.lblcbmin = new System.Windows.Forms.Label();
            this.lblcbmax = new System.Windows.Forms.Label();
            this.lblcrmax = new System.Windows.Forms.Label();
            this.tb5 = new System.Windows.Forms.TrackBar();
            this.tb3 = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.default1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picOrig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.default1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "GRİ GÖRÜNTÜ",
            "THRESHOLD HESAPLAMA",
            "SİYAH BEYAZ",
            "YATAY KENAR",
            "DİKEY KENAR",
            "KENAR GÖRÜNTÜSÜ",
            "TERS ÇEVİR",
            "KARINCA GİDERME",
            "KARİKATURİZASYON",
            "RESIZE",
            "GAUSSIAN",
            "YCBCR",
            "DERİ BOYA",
            "ÇİZGİ FİLM EFEKTİ",
            "KARAKALEM",
            "RENK",
            "RENKLİ KENAR",
            "YARI/YARI"});
            this.comboBox1.Location = new System.Drawing.Point(12, 448);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 30);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // picOrig
            // 
            this.picOrig.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picOrig.ErrorImage = null;
            this.picOrig.InitialImage = null;
            this.picOrig.Location = new System.Drawing.Point(12, 13);
            this.picOrig.Name = "picOrig";
            this.picOrig.Size = new System.Drawing.Size(544, 408);
            this.picOrig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picOrig.TabIndex = 1;
            this.picOrig.TabStop = false;
            // 
            // picResult
            // 
            this.picResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picResult.ErrorImage = null;
            this.picResult.InitialImage = null;
            this.picResult.Location = new System.Drawing.Point(601, 12);
            this.picResult.Name = "picResult";
            this.picResult.Size = new System.Drawing.Size(544, 408);
            this.picResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picResult.TabIndex = 2;
            this.picResult.TabStop = false;
            this.picResult.Click += new System.EventHandler(this.picResult_Click);
            this.picResult.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picResult_MouseDown);
            this.picResult.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picResult_MouseMove);
            this.picResult.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picResult_MouseUp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(227, 439);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(108, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Aç";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(464, 438);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 35);
            this.button2.TabIndex = 4;
            this.button2.Text = "Kaydet";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(350, 438);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(108, 35);
            this.button3.TabIndex = 5;
            this.button3.Text = "Uygula";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(776, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Threshold degeri";
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(601, 426);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(152, 45);
            this.tb1.TabIndex = 7;
            this.tb1.Scroll += new System.EventHandler(this.tb1_Scroll);
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(18, 494);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(152, 45);
            this.tb2.TabIndex = 8;
            this.tb2.Scroll += new System.EventHandler(this.tb2_Scroll);
            // 
            // tb4
            // 
            this.tb4.Location = new System.Drawing.Point(18, 525);
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(152, 45);
            this.tb4.TabIndex = 9;
            this.tb4.Scroll += new System.EventHandler(this.tb4_Scroll);
            // 
            // lblcrmin
            // 
            this.lblcrmin.AutoSize = true;
            this.lblcrmin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcrmin.Location = new System.Drawing.Point(193, 494);
            this.lblcrmin.Name = "lblcrmin";
            this.lblcrmin.Size = new System.Drawing.Size(52, 19);
            this.lblcrmin.TabIndex = 10;
            this.lblcrmin.Text = "Cr Min";
            // 
            // lblcbmin
            // 
            this.lblcbmin.AutoSize = true;
            this.lblcbmin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcbmin.Location = new System.Drawing.Point(193, 525);
            this.lblcbmin.Name = "lblcbmin";
            this.lblcbmin.Size = new System.Drawing.Size(55, 19);
            this.lblcbmin.TabIndex = 11;
            this.lblcbmin.Text = "Cb Min";
            // 
            // lblcbmax
            // 
            this.lblcbmax.AutoSize = true;
            this.lblcbmax.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcbmax.Location = new System.Drawing.Point(525, 525);
            this.lblcbmax.Name = "lblcbmax";
            this.lblcbmax.Size = new System.Drawing.Size(58, 19);
            this.lblcbmax.TabIndex = 15;
            this.lblcbmax.Text = "Cb Max";
            // 
            // lblcrmax
            // 
            this.lblcrmax.AutoSize = true;
            this.lblcrmax.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcrmax.Location = new System.Drawing.Point(525, 491);
            this.lblcrmax.Name = "lblcrmax";
            this.lblcrmax.Size = new System.Drawing.Size(55, 19);
            this.lblcrmax.TabIndex = 14;
            this.lblcrmax.Text = "Cr Max";
            // 
            // tb5
            // 
            this.tb5.Location = new System.Drawing.Point(350, 525);
            this.tb5.Name = "tb5";
            this.tb5.Size = new System.Drawing.Size(152, 45);
            this.tb5.TabIndex = 13;
            this.tb5.Scroll += new System.EventHandler(this.tb5_Scroll);
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(350, 491);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(152, 45);
            this.tb3.TabIndex = 12;
            this.tb3.Scroll += new System.EventHandler(this.tb3_Scroll);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.default1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panel1.Location = new System.Drawing.Point(620, 477);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 108);
            this.panel1.TabIndex = 16;
            // 
            // default1
            // 
            this.default1.BackColor = System.Drawing.Color.Black;
            this.default1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.default1.Image = ((System.Drawing.Image)(resources.GetObject("default1.Image")));
            this.default1.Location = new System.Drawing.Point(0, 0);
            this.default1.Name = "default1";
            this.default1.Size = new System.Drawing.Size(104, 105);
            this.default1.TabIndex = 0;
            this.default1.TabStop = false;
            this.default1.Click += new System.EventHandler(this.default1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1240, 597);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblcbmax);
            this.Controls.Add(this.lblcrmax);
            this.Controls.Add(this.tb5);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.lblcbmin);
            this.Controls.Add(this.lblcrmin);
            this.Controls.Add(this.tb4);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picResult);
            this.Controls.Add(this.picOrig);
            this.Controls.Add(this.comboBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Karikatürizasyon ** Bitirme Projesi ** Muhammed İkbal CAN ** Eray SİLİĞ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picOrig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb3)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.default1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox picOrig;
        private System.Windows.Forms.PictureBox picResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tb1;
        private System.Windows.Forms.TrackBar tb2;
        private System.Windows.Forms.TrackBar tb4;
        private System.Windows.Forms.Label lblcrmin;
        private System.Windows.Forms.Label lblcbmin;
        private System.Windows.Forms.Label lblcbmax;
        private System.Windows.Forms.Label lblcrmax;
        private System.Windows.Forms.TrackBar tb5;
        private System.Windows.Forms.TrackBar tb3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox default1;
    }
}

