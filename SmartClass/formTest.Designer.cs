namespace SmartClass
{
    partial class formTest
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTest));
            this.timersure = new System.Windows.Forms.Timer(this.components);
            this.btnSinavaBasla = new MetroFramework.Controls.MetroButton();
            this.btnBsecenegi = new MetroFramework.Controls.MetroButton();
            this.btnCsecenegi = new MetroFramework.Controls.MetroButton();
            this.btnDsecenegi = new MetroFramework.Controls.MetroButton();
            this.pictureBoxDegis = new System.Windows.Forms.PictureBox();
            this.btnSinaviBitir = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_d = new System.Windows.Forms.Label();
            this.label_b = new System.Windows.Forms.Label();
            this.label_c = new System.Windows.Forms.Label();
            this.btnAsecenegi = new MetroFramework.Controls.MetroButton();
            this.label_a = new System.Windows.Forms.Label();
            this.lblSoruMetni = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.lblSayac = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSure = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDegis)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timersure
            // 
            this.timersure.Enabled = true;
            this.timersure.Interval = 1000;
            this.timersure.Tick += new System.EventHandler(this.timersure_Tick);
            // 
            // btnSinavaBasla
            // 
            this.btnSinavaBasla.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSinavaBasla.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSinavaBasla.Location = new System.Drawing.Point(749, 160);
            this.btnSinavaBasla.Margin = new System.Windows.Forms.Padding(4);
            this.btnSinavaBasla.Name = "btnSinavaBasla";
            this.btnSinavaBasla.Size = new System.Drawing.Size(166, 78);
            this.btnSinavaBasla.TabIndex = 25;
            this.btnSinavaBasla.Text = "TESTİ BAŞLAT";
            this.btnSinavaBasla.UseSelectable = true;
            this.btnSinavaBasla.Click += new System.EventHandler(this.btnSinavaBasla_Click);
            // 
            // btnBsecenegi
            // 
            this.btnBsecenegi.Location = new System.Drawing.Point(328, 124);
            this.btnBsecenegi.Margin = new System.Windows.Forms.Padding(4);
            this.btnBsecenegi.Name = "btnBsecenegi";
            this.btnBsecenegi.Size = new System.Drawing.Size(164, 60);
            this.btnBsecenegi.TabIndex = 27;
            this.btnBsecenegi.UseSelectable = true;
            this.btnBsecenegi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnDsecenegi_MouseClick);
            // 
            // btnCsecenegi
            // 
            this.btnCsecenegi.Location = new System.Drawing.Point(83, 240);
            this.btnCsecenegi.Margin = new System.Windows.Forms.Padding(4);
            this.btnCsecenegi.Name = "btnCsecenegi";
            this.btnCsecenegi.Size = new System.Drawing.Size(164, 60);
            this.btnCsecenegi.TabIndex = 28;
            this.btnCsecenegi.UseSelectable = true;
            this.btnCsecenegi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnDsecenegi_MouseClick);
            // 
            // btnDsecenegi
            // 
            this.btnDsecenegi.Location = new System.Drawing.Point(328, 240);
            this.btnDsecenegi.Margin = new System.Windows.Forms.Padding(4);
            this.btnDsecenegi.Name = "btnDsecenegi";
            this.btnDsecenegi.Size = new System.Drawing.Size(164, 60);
            this.btnDsecenegi.TabIndex = 29;
            this.btnDsecenegi.UseSelectable = true;
            this.btnDsecenegi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnDsecenegi_MouseClick);
            // 
            // pictureBoxDegis
            // 
            this.pictureBoxDegis.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDegis.Image")));
            this.pictureBoxDegis.Location = new System.Drawing.Point(465, 26);
            this.pictureBoxDegis.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxDegis.Name = "pictureBoxDegis";
            this.pictureBoxDegis.Size = new System.Drawing.Size(55, 44);
            this.pictureBoxDegis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDegis.TabIndex = 32;
            this.pictureBoxDegis.TabStop = false;
            this.pictureBoxDegis.Click += new System.EventHandler(this.pictureBoxDegis_Click);
            // 
            // btnSinaviBitir
            // 
            this.btnSinaviBitir.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSinaviBitir.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSinaviBitir.Location = new System.Drawing.Point(749, 160);
            this.btnSinaviBitir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSinaviBitir.Name = "btnSinaviBitir";
            this.btnSinaviBitir.Size = new System.Drawing.Size(166, 78);
            this.btnSinaviBitir.Style = MetroFramework.MetroColorStyle.Black;
            this.btnSinaviBitir.TabIndex = 34;
            this.btnSinaviBitir.Text = "TESTİ BİTİR";
            this.btnSinaviBitir.UseSelectable = true;
            this.btnSinaviBitir.Click += new System.EventHandler(this.btnSinaviBitir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightCyan;
            this.groupBox1.Controls.Add(this.label_d);
            this.groupBox1.Controls.Add(this.label_b);
            this.groupBox1.Controls.Add(this.label_c);
            this.groupBox1.Controls.Add(this.btnAsecenegi);
            this.groupBox1.Controls.Add(this.pictureBoxDegis);
            this.groupBox1.Controls.Add(this.btnCsecenegi);
            this.groupBox1.Controls.Add(this.btnDsecenegi);
            this.groupBox1.Controls.Add(this.btnBsecenegi);
            this.groupBox1.Controls.Add(this.label_a);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(208, 438);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 331);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CEVAP ŞIKLARI";
            // 
            // label_d
            // 
            this.label_d.AutoSize = true;
            this.label_d.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_d.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_d.Location = new System.Drawing.Point(269, 253);
            this.label_d.Name = "label_d";
            this.label_d.Size = new System.Drawing.Size(53, 32);
            this.label_d.TabIndex = 3;
            this.label_d.Text = "D-)";
            // 
            // label_b
            // 
            this.label_b.AutoSize = true;
            this.label_b.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_b.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_b.Location = new System.Drawing.Point(269, 139);
            this.label_b.Name = "label_b";
            this.label_b.Size = new System.Drawing.Size(52, 32);
            this.label_b.TabIndex = 2;
            this.label_b.Text = "B-)";
            // 
            // label_c
            // 
            this.label_c.AutoSize = true;
            this.label_c.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_c.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_c.Location = new System.Drawing.Point(24, 253);
            this.label_c.Name = "label_c";
            this.label_c.Size = new System.Drawing.Size(53, 32);
            this.label_c.TabIndex = 1;
            this.label_c.Text = "C-)";
            // 
            // btnAsecenegi
            // 
            this.btnAsecenegi.Location = new System.Drawing.Point(83, 124);
            this.btnAsecenegi.Margin = new System.Windows.Forms.Padding(4);
            this.btnAsecenegi.Name = "btnAsecenegi";
            this.btnAsecenegi.Size = new System.Drawing.Size(164, 60);
            this.btnAsecenegi.TabIndex = 26;
            this.btnAsecenegi.UseSelectable = true;
            this.btnAsecenegi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnDsecenegi_MouseClick);
            // 
            // label_a
            // 
            this.label_a.AutoSize = true;
            this.label_a.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_a.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_a.Location = new System.Drawing.Point(24, 139);
            this.label_a.Name = "label_a";
            this.label_a.Size = new System.Drawing.Size(52, 32);
            this.label_a.TabIndex = 0;
            this.label_a.Text = "A-)";
            // 
            // lblSoruMetni
            // 
            this.lblSoruMetni.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoruMetni.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblSoruMetni.Location = new System.Drawing.Point(203, 209);
            this.lblSoruMetni.Name = "lblSoruMetni";
            this.lblSoruMetni.Size = new System.Drawing.Size(525, 211);
            this.lblSoruMetni.TabIndex = 36;
            // 
            // btnGeri
            // 
            this.btnGeri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGeri.BackgroundImage")));
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGeri.Location = new System.Drawing.Point(866, 18);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(60, 44);
            this.btnGeri.TabIndex = 37;
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // lblSayac
            // 
            this.lblSayac.AutoSize = true;
            this.lblSayac.BackColor = System.Drawing.Color.LightCyan;
            this.lblSayac.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayac.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSayac.Location = new System.Drawing.Point(106, 20);
            this.lblSayac.Name = "lblSayac";
            this.lblSayac.Size = new System.Drawing.Size(26, 29);
            this.lblSayac.TabIndex = 38;
            this.lblSayac.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.lblSure);
            this.panel1.Controls.Add(this.lblSayac);
            this.panel1.Location = new System.Drawing.Point(33, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 62);
            this.panel1.TabIndex = 39;
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSure.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSure.Location = new System.Drawing.Point(18, 24);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(82, 23);
            this.lblSure.TabIndex = 40;
            this.lblSure.Text = "SÜRE : ";
            // 
            // formTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(949, 791);
            this.ControlBox = false;
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.lblSoruMetni);
            this.Controls.Add(this.btnSinaviBitir);
            this.Controls.Add(this.btnSinavaBasla);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formTest";
            this.Padding = new System.Windows.Forms.Padding(30, 76, 30, 31);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Tag = "";
            this.Text = "Test Çöz";
            this.Load += new System.EventHandler(this.formTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDegis)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timersure;
        private MetroFramework.Controls.MetroButton btnSinavaBasla;
        private MetroFramework.Controls.MetroButton btnBsecenegi;
        private MetroFramework.Controls.MetroButton btnCsecenegi;
        private MetroFramework.Controls.MetroButton btnDsecenegi;
        private System.Windows.Forms.PictureBox pictureBoxDegis;
        private MetroFramework.Controls.MetroButton btnSinaviBitir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_d;
        private System.Windows.Forms.Label label_b;
        private System.Windows.Forms.Label label_c;
        private System.Windows.Forms.Label label_a;
        private System.Windows.Forms.Label lblSoruMetni;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label lblSayac;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSure;
        private MetroFramework.Controls.MetroButton btnAsecenegi;
    }
}