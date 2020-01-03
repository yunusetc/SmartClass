namespace SmartClass
{
    partial class frmOgretKaydol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOgretKaydol));
            this.btnKayitGeri = new System.Windows.Forms.Button();
            this.buttonKayitOl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAdi = new System.Windows.Forms.TextBox();
            this.textBoxParola = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKayitGeri
            // 
            this.btnKayitGeri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKayitGeri.BackgroundImage")));
            this.btnKayitGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKayitGeri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKayitGeri.Location = new System.Drawing.Point(480, 21);
            this.btnKayitGeri.Name = "btnKayitGeri";
            this.btnKayitGeri.Size = new System.Drawing.Size(61, 44);
            this.btnKayitGeri.TabIndex = 0;
            this.btnKayitGeri.UseVisualStyleBackColor = true;
            this.btnKayitGeri.Click += new System.EventHandler(this.btnKayitGeri_Click);
            // 
            // buttonKayitOl
            // 
            this.buttonKayitOl.BackColor = System.Drawing.Color.IndianRed;
            this.buttonKayitOl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKayitOl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonKayitOl.Location = new System.Drawing.Point(351, 318);
            this.buttonKayitOl.Name = "buttonKayitOl";
            this.buttonKayitOl.Size = new System.Drawing.Size(125, 41);
            this.buttonKayitOl.TabIndex = 1;
            this.buttonKayitOl.Text = "Kayıt Ol";
            this.buttonKayitOl.UseVisualStyleBackColor = false;
            this.buttonKayitOl.Click += new System.EventHandler(this.buttonKayitOl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(78, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Öğretmen Adı : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(50, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Öğretmen Parola :";
            // 
            // textBoxAdi
            // 
            this.textBoxAdi.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxAdi.Location = new System.Drawing.Point(278, 173);
            this.textBoxAdi.MaxLength = 20;
            this.textBoxAdi.Name = "textBoxAdi";
            this.textBoxAdi.Size = new System.Drawing.Size(198, 30);
            this.textBoxAdi.TabIndex = 4;
            // 
            // textBoxParola
            // 
            this.textBoxParola.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxParola.Location = new System.Drawing.Point(278, 252);
            this.textBoxParola.MaxLength = 20;
            this.textBoxParola.Name = "textBoxParola";
            this.textBoxParola.Size = new System.Drawing.Size(198, 30);
            this.textBoxParola.TabIndex = 5;
            this.textBoxParola.UseSystemPasswordChar = true;
            // 
            // frmOgretKaydol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 409);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxParola);
            this.Controls.Add(this.textBoxAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKayitOl);
            this.Controls.Add(this.btnKayitGeri);
            this.Name = "frmOgretKaydol";
            this.Text = "Öğretmen Kayıt Ol";
            this.Load += new System.EventHandler(this.frmOgretKaydol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKayitGeri;
        private System.Windows.Forms.Button buttonKayitOl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAdi;
        private System.Windows.Forms.TextBox textBoxParola;
    }
}