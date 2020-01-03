namespace SmartClass
{
    partial class form_giris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_giris));
            this.pictureboxGiris = new System.Windows.Forms.PictureBox();
            this.lblAdi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxAdi = new System.Windows.Forms.TextBox();
            this.txtbxParola = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnKayit = new System.Windows.Forms.Button();
            this.btnAsecenegi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxGiris)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureboxGiris
            // 
            this.pictureboxGiris.Image = ((System.Drawing.Image)(resources.GetObject("pictureboxGiris.Image")));
            this.pictureboxGiris.Location = new System.Drawing.Point(210, 127);
            this.pictureboxGiris.Name = "pictureboxGiris";
            this.pictureboxGiris.Size = new System.Drawing.Size(198, 170);
            this.pictureboxGiris.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureboxGiris.TabIndex = 5;
            this.pictureboxGiris.TabStop = false;
            // 
            // lblAdi
            // 
            this.lblAdi.AutoSize = true;
            this.lblAdi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdi.Location = new System.Drawing.Point(97, 380);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(159, 27);
            this.lblAdi.TabIndex = 7;
            this.lblAdi.Text = "Öğrenci Adı : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(62, 451);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "Öğrenci Parola : ";
            // 
            // txtbxAdi
            // 
            this.txtbxAdi.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbxAdi.Location = new System.Drawing.Point(333, 377);
            this.txtbxAdi.MaxLength = 15;
            this.txtbxAdi.Name = "txtbxAdi";
            this.txtbxAdi.Size = new System.Drawing.Size(200, 30);
            this.txtbxAdi.TabIndex = 9;
            // 
            // txtbxParola
            // 
            this.txtbxParola.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbxParola.Location = new System.Drawing.Point(333, 448);
            this.txtbxParola.MaxLength = 15;
            this.txtbxParola.Name = "txtbxParola";
            this.txtbxParola.Size = new System.Drawing.Size(200, 30);
            this.txtbxParola.TabIndex = 10;
            this.txtbxParola.UseSystemPasswordChar = true;
            // 
            // btnGiris
            // 
            this.btnGiris.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.Location = new System.Drawing.Point(412, 514);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(121, 36);
            this.btnGiris.TabIndex = 11;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnKayit
            // 
            this.btnKayit.BackColor = System.Drawing.Color.IndianRed;
            this.btnKayit.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKayit.Location = new System.Drawing.Point(23, 668);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(169, 49);
            this.btnKayit.TabIndex = 12;
            this.btnKayit.Text = "Kayıt Ol";
            this.btnKayit.UseVisualStyleBackColor = false;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // btnAsecenegi
            // 
            this.btnAsecenegi.BackColor = System.Drawing.Color.IndianRed;
            this.btnAsecenegi.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAsecenegi.ForeColor = System.Drawing.Color.Transparent;
            this.btnAsecenegi.Location = new System.Drawing.Point(412, 668);
            this.btnAsecenegi.Name = "btnAsecenegi";
            this.btnAsecenegi.Size = new System.Drawing.Size(169, 49);
            this.btnAsecenegi.TabIndex = 13;
            this.btnAsecenegi.Text = "Öğretmen Giriş";
            this.btnAsecenegi.UseVisualStyleBackColor = false;
            this.btnAsecenegi.Click += new System.EventHandler(this.btnOgretmenSayfa_Click);
            // 
            // form_giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 740);
            this.Controls.Add(this.btnAsecenegi);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtbxParola);
            this.Controls.Add(this.txtbxAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAdi);
            this.Controls.Add(this.pictureboxGiris);
            this.Name = "form_giris";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Giriş Yap";
            this.TransparencyKey = System.Drawing.SystemColors.MenuBar;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_giris_FormClosing);
            
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxGiris)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureboxGiris;
        private System.Windows.Forms.Label lblAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxAdi;
        private System.Windows.Forms.TextBox txtbxParola;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Button btnAsecenegi;
    }
}

