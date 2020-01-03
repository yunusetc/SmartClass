namespace SmartClass
{
    partial class frmÖgretmenGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmÖgretmenGiris));
            this.pictureBoxOgretmen = new System.Windows.Forms.PictureBox();
            this.lblOgretmenAdi = new System.Windows.Forms.Label();
            this.lblOgretmenParola = new System.Windows.Forms.Label();
            this.txtbxOgretmenAdi = new System.Windows.Forms.TextBox();
            this.txtbxOgretmenParola = new System.Windows.Forms.TextBox();
            this.btnOgretmenGiris = new System.Windows.Forms.Button();
            this.btnGeri = new MetroFramework.Controls.MetroButton();
            this.btnOgretmenKayit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOgretmen)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxOgretmen
            // 
            this.pictureBoxOgretmen.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOgretmen.Image")));
            this.pictureBoxOgretmen.Location = new System.Drawing.Point(227, 135);
            this.pictureBoxOgretmen.Name = "pictureBoxOgretmen";
            this.pictureBoxOgretmen.Size = new System.Drawing.Size(176, 187);
            this.pictureBoxOgretmen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOgretmen.TabIndex = 0;
            this.pictureBoxOgretmen.TabStop = false;
            // 
            // lblOgretmenAdi
            // 
            this.lblOgretmenAdi.AutoSize = true;
            this.lblOgretmenAdi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgretmenAdi.Location = new System.Drawing.Point(97, 409);
            this.lblOgretmenAdi.Name = "lblOgretmenAdi";
            this.lblOgretmenAdi.Size = new System.Drawing.Size(182, 27);
            this.lblOgretmenAdi.TabIndex = 1;
            this.lblOgretmenAdi.Text = "Öğretmen Adı : ";
            // 
            // lblOgretmenParola
            // 
            this.lblOgretmenParola.AutoSize = true;
            this.lblOgretmenParola.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgretmenParola.Location = new System.Drawing.Point(62, 500);
            this.lblOgretmenParola.Name = "lblOgretmenParola";
            this.lblOgretmenParola.Size = new System.Drawing.Size(217, 27);
            this.lblOgretmenParola.TabIndex = 2;
            this.lblOgretmenParola.Text = "Öğretmen Parola : ";
            // 
            // txtbxOgretmenAdi
            // 
            this.txtbxOgretmenAdi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbxOgretmenAdi.Location = new System.Drawing.Point(315, 401);
            this.txtbxOgretmenAdi.MaxLength = 15;
            this.txtbxOgretmenAdi.Name = "txtbxOgretmenAdi";
            this.txtbxOgretmenAdi.Size = new System.Drawing.Size(213, 35);
            this.txtbxOgretmenAdi.TabIndex = 3;
            // 
            // txtbxOgretmenParola
            // 
            this.txtbxOgretmenParola.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbxOgretmenParola.Location = new System.Drawing.Point(315, 492);
            this.txtbxOgretmenParola.MaxLength = 15;
            this.txtbxOgretmenParola.Name = "txtbxOgretmenParola";
            this.txtbxOgretmenParola.Size = new System.Drawing.Size(213, 35);
            this.txtbxOgretmenParola.TabIndex = 4;
            this.txtbxOgretmenParola.UseSystemPasswordChar = true;
            // 
            // btnOgretmenGiris
            // 
            this.btnOgretmenGiris.BackColor = System.Drawing.Color.IndianRed;
            this.btnOgretmenGiris.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgretmenGiris.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOgretmenGiris.Location = new System.Drawing.Point(394, 552);
            this.btnOgretmenGiris.Name = "btnOgretmenGiris";
            this.btnOgretmenGiris.Size = new System.Drawing.Size(134, 45);
            this.btnOgretmenGiris.TabIndex = 5;
            this.btnOgretmenGiris.Text = "Giriş Yap";
            this.btnOgretmenGiris.UseVisualStyleBackColor = false;
            this.btnOgretmenGiris.Click += new System.EventHandler(this.btnOgretmenGiris_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGeri.BackgroundImage")));
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeri.Location = new System.Drawing.Point(533, 20);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(48, 42);
            this.btnGeri.TabIndex = 7;
            this.btnGeri.UseSelectable = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnOgretmenKayit
            // 
            this.btnOgretmenKayit.BackColor = System.Drawing.Color.IndianRed;
            this.btnOgretmenKayit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgretmenKayit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOgretmenKayit.Location = new System.Drawing.Point(23, 672);
            this.btnOgretmenKayit.Name = "btnOgretmenKayit";
            this.btnOgretmenKayit.Size = new System.Drawing.Size(134, 45);
            this.btnOgretmenKayit.TabIndex = 8;
            this.btnOgretmenKayit.Text = "Kayıt Ol";
            this.btnOgretmenKayit.UseVisualStyleBackColor = false;
            this.btnOgretmenKayit.Click += new System.EventHandler(this.btnOgretmenKayit_Click);
            // 
            // frmÖgretmenGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 740);
            this.ControlBox = false;
            this.Controls.Add(this.btnOgretmenKayit);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnOgretmenGiris);
            this.Controls.Add(this.txtbxOgretmenParola);
            this.Controls.Add(this.txtbxOgretmenAdi);
            this.Controls.Add(this.lblOgretmenParola);
            this.Controls.Add(this.lblOgretmenAdi);
            this.Controls.Add(this.pictureBoxOgretmen);
            this.Name = "frmÖgretmenGiris";
            this.Text = "Öğretmen Giriş";
            this.Load += new System.EventHandler(this.frmÖgretmenGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOgretmen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxOgretmen;
        private System.Windows.Forms.Label lblOgretmenAdi;
        private System.Windows.Forms.Label lblOgretmenParola;
        private System.Windows.Forms.TextBox txtbxOgretmenAdi;
        private System.Windows.Forms.TextBox txtbxOgretmenParola;
        private System.Windows.Forms.Button btnOgretmenGiris;
        private MetroFramework.Controls.MetroButton btnGeri;
        private System.Windows.Forms.Button btnOgretmenKayit;
    }
}