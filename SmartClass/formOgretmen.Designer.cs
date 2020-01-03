namespace SmartClass
{
    partial class formOgretmen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formOgretmen));
            this.buttonGeri = new System.Windows.Forms.Button();
            this.buttonSoruEkle = new System.Windows.Forms.Button();
            this.buttonTakip = new System.Windows.Forms.Button();
            this.pictureBoxTakip = new System.Windows.Forms.PictureBox();
            this.pictureBoxSoruEkle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSoruEkle)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGeri
            // 
            this.buttonGeri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGeri.BackgroundImage")));
            this.buttonGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonGeri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGeri.Location = new System.Drawing.Point(666, 15);
            this.buttonGeri.Name = "buttonGeri";
            this.buttonGeri.Size = new System.Drawing.Size(51, 44);
            this.buttonGeri.TabIndex = 0;
            this.buttonGeri.UseVisualStyleBackColor = true;
            this.buttonGeri.Click += new System.EventHandler(this.buttonGeri_Click);
            // 
            // buttonSoruEkle
            // 
            this.buttonSoruEkle.BackColor = System.Drawing.Color.IndianRed;
            this.buttonSoruEkle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSoruEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSoruEkle.Location = new System.Drawing.Point(321, 334);
            this.buttonSoruEkle.Name = "buttonSoruEkle";
            this.buttonSoruEkle.Size = new System.Drawing.Size(230, 71);
            this.buttonSoruEkle.TabIndex = 1;
            this.buttonSoruEkle.Text = "Soru Ekle";
            this.buttonSoruEkle.UseVisualStyleBackColor = false;
            this.buttonSoruEkle.Click += new System.EventHandler(this.buttonSoruEkle_Click);
            // 
            // buttonTakip
            // 
            this.buttonTakip.BackColor = System.Drawing.Color.IndianRed;
            this.buttonTakip.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonTakip.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTakip.Location = new System.Drawing.Point(321, 186);
            this.buttonTakip.Name = "buttonTakip";
            this.buttonTakip.Size = new System.Drawing.Size(230, 71);
            this.buttonTakip.TabIndex = 2;
            this.buttonTakip.Text = "Öğrenci Takip";
            this.buttonTakip.UseVisualStyleBackColor = false;
            this.buttonTakip.Click += new System.EventHandler(this.buttonTakip_Click);
            // 
            // pictureBoxTakip
            // 
            this.pictureBoxTakip.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTakip.Image")));
            this.pictureBoxTakip.Location = new System.Drawing.Point(202, 176);
            this.pictureBoxTakip.Name = "pictureBoxTakip";
            this.pictureBoxTakip.Size = new System.Drawing.Size(113, 90);
            this.pictureBoxTakip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTakip.TabIndex = 3;
            this.pictureBoxTakip.TabStop = false;
            // 
            // pictureBoxSoruEkle
            // 
            this.pictureBoxSoruEkle.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSoruEkle.Image")));
            this.pictureBoxSoruEkle.Location = new System.Drawing.Point(202, 325);
            this.pictureBoxSoruEkle.Name = "pictureBoxSoruEkle";
            this.pictureBoxSoruEkle.Size = new System.Drawing.Size(113, 90);
            this.pictureBoxSoruEkle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSoruEkle.TabIndex = 4;
            this.pictureBoxSoruEkle.TabStop = false;
            // 
            // formOgretmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 489);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBoxSoruEkle);
            this.Controls.Add(this.pictureBoxTakip);
            this.Controls.Add(this.buttonTakip);
            this.Controls.Add(this.buttonSoruEkle);
            this.Controls.Add(this.buttonGeri);
            this.Name = "formOgretmen";
            this.Text = "Ana Menü";
            this.Load += new System.EventHandler(this.formOgretmen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSoruEkle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGeri;
        private System.Windows.Forms.Button buttonSoruEkle;
        private System.Windows.Forms.Button buttonTakip;
        private System.Windows.Forms.PictureBox pictureBoxTakip;
        private System.Windows.Forms.PictureBox pictureBoxSoruEkle;
    }
}