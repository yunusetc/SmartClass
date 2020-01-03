namespace SmartClass
{
    partial class form_kayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_kayit));
            this.button_kayit_geri = new MetroFramework.Controls.MetroButton();
            this.lblÖgrenciAdi = new System.Windows.Forms.Label();
            this.lblOgrenciParols = new System.Windows.Forms.Label();
            this.btnOgrenciKayit = new System.Windows.Forms.Button();
            this.txtbxAdi = new System.Windows.Forms.TextBox();
            this.txtbxParola = new System.Windows.Forms.TextBox();
            this.lblOgrenciSoyadi = new System.Windows.Forms.Label();
            this.txtbxSoyadi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_kayit_geri
            // 
            this.button_kayit_geri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_kayit_geri.BackgroundImage")));
            this.button_kayit_geri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_kayit_geri.Location = new System.Drawing.Point(500, 17);
            this.button_kayit_geri.Name = "button_kayit_geri";
            this.button_kayit_geri.Size = new System.Drawing.Size(48, 42);
            this.button_kayit_geri.TabIndex = 5;
            this.button_kayit_geri.UseSelectable = true;
            this.button_kayit_geri.Click += new System.EventHandler(this.button_kayit_geri_Click);
            // 
            // lblÖgrenciAdi
            // 
            this.lblÖgrenciAdi.AutoSize = true;
            this.lblÖgrenciAdi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblÖgrenciAdi.Location = new System.Drawing.Point(79, 147);
            this.lblÖgrenciAdi.Name = "lblÖgrenciAdi";
            this.lblÖgrenciAdi.Size = new System.Drawing.Size(159, 27);
            this.lblÖgrenciAdi.TabIndex = 6;
            this.lblÖgrenciAdi.Text = "Öğrenci Adı : ";
            // 
            // lblOgrenciParols
            // 
            this.lblOgrenciParols.AutoSize = true;
            this.lblOgrenciParols.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrenciParols.Location = new System.Drawing.Point(51, 289);
            this.lblOgrenciParols.Name = "lblOgrenciParols";
            this.lblOgrenciParols.Size = new System.Drawing.Size(187, 27);
            this.lblOgrenciParols.TabIndex = 7;
            this.lblOgrenciParols.Text = "Öğrenci Parola :";
            // 
            // btnOgrenciKayit
            // 
            this.btnOgrenciKayit.BackColor = System.Drawing.Color.IndianRed;
            this.btnOgrenciKayit.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenciKayit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOgrenciKayit.Location = new System.Drawing.Point(383, 356);
            this.btnOgrenciKayit.Name = "btnOgrenciKayit";
            this.btnOgrenciKayit.Size = new System.Drawing.Size(114, 39);
            this.btnOgrenciKayit.TabIndex = 8;
            this.btnOgrenciKayit.Text = "Kayıt Ol";
            this.btnOgrenciKayit.UseVisualStyleBackColor = false;
            this.btnOgrenciKayit.Click += new System.EventHandler(this.btnOgrenciKayit_Click);
            // 
            // txtbxAdi
            // 
            this.txtbxAdi.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbxAdi.Location = new System.Drawing.Point(313, 147);
            this.txtbxAdi.MaxLength = 15;
            this.txtbxAdi.Name = "txtbxAdi";
            this.txtbxAdi.Size = new System.Drawing.Size(184, 30);
            this.txtbxAdi.TabIndex = 9;
            // 
            // txtbxParola
            // 
            this.txtbxParola.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbxParola.Location = new System.Drawing.Point(313, 286);
            this.txtbxParola.MaxLength = 15;
            this.txtbxParola.Name = "txtbxParola";
            this.txtbxParola.Size = new System.Drawing.Size(184, 30);
            this.txtbxParola.TabIndex = 10;
            this.txtbxParola.UseSystemPasswordChar = true;
            // 
            // lblOgrenciSoyadi
            // 
            this.lblOgrenciSoyadi.AutoSize = true;
            this.lblOgrenciSoyadi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrenciSoyadi.Location = new System.Drawing.Point(46, 221);
            this.lblOgrenciSoyadi.Name = "lblOgrenciSoyadi";
            this.lblOgrenciSoyadi.Size = new System.Drawing.Size(192, 27);
            this.lblOgrenciSoyadi.TabIndex = 11;
            this.lblOgrenciSoyadi.Text = "Öğrenci Soyadı :";
            // 
            // txtbxSoyadi
            // 
            this.txtbxSoyadi.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbxSoyadi.Location = new System.Drawing.Point(313, 221);
            this.txtbxSoyadi.MaxLength = 20;
            this.txtbxSoyadi.Name = "txtbxSoyadi";
            this.txtbxSoyadi.Size = new System.Drawing.Size(184, 30);
            this.txtbxSoyadi.TabIndex = 12;
            // 
            // form_kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 462);
            this.ControlBox = false;
            this.Controls.Add(this.txtbxSoyadi);
            this.Controls.Add(this.lblOgrenciSoyadi);
            this.Controls.Add(this.txtbxParola);
            this.Controls.Add(this.txtbxAdi);
            this.Controls.Add(this.btnOgrenciKayit);
            this.Controls.Add(this.lblOgrenciParols);
            this.Controls.Add(this.lblÖgrenciAdi);
            this.Controls.Add(this.button_kayit_geri);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Name = "form_kayit";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Kayıt Ol";
            this.Load += new System.EventHandler(this.form_kayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton button_kayit_geri;
        private System.Windows.Forms.Label lblÖgrenciAdi;
        private System.Windows.Forms.Label lblOgrenciParols;
        private System.Windows.Forms.Button btnOgrenciKayit;
        private System.Windows.Forms.TextBox txtbxAdi;
        private System.Windows.Forms.TextBox txtbxParola;
        private System.Windows.Forms.Label lblOgrenciSoyadi;
        private System.Windows.Forms.TextBox txtbxSoyadi;
    }
}