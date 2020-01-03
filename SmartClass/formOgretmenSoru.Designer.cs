namespace SmartClass
{
    partial class formOgretmenSoru
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formOgretmenSoru));
            this.txtbxCevap = new System.Windows.Forms.TextBox();
            this.txtbxSoru = new System.Windows.Forms.TextBox();
            this.txtbxKonu = new System.Windows.Forms.TextBox();
            this.lblCevap = new System.Windows.Forms.Label();
            this.lblSoru = new System.Windows.Forms.Label();
            this.lblKonu = new System.Windows.Forms.Label();
            this.btnSoruEkle = new System.Windows.Forms.Button();
            this.btnogretmenCikis = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelKonu10 = new System.Windows.Forms.Label();
            this.labelKonu8 = new System.Windows.Forms.Label();
            this.labelKonu9 = new System.Windows.Forms.Label();
            this.labelKonu3 = new System.Windows.Forms.Label();
            this.labelKonu1 = new System.Windows.Forms.Label();
            this.labelKonu2 = new System.Windows.Forms.Label();
            this.labelKonu4 = new System.Windows.Forms.Label();
            this.labelKonu7 = new System.Windows.Forms.Label();
            this.labelKonu5 = new System.Windows.Forms.Label();
            this.labelKonu6 = new System.Windows.Forms.Label();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbxCevap
            // 
            this.txtbxCevap.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbxCevap.Location = new System.Drawing.Point(520, 453);
            this.txtbxCevap.MaxLength = 20;
            this.txtbxCevap.Name = "txtbxCevap";
            this.txtbxCevap.Size = new System.Drawing.Size(306, 30);
            this.txtbxCevap.TabIndex = 13;
            // 
            // txtbxSoru
            // 
            this.txtbxSoru.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbxSoru.Location = new System.Drawing.Point(520, 290);
            this.txtbxSoru.Multiline = true;
            this.txtbxSoru.Name = "txtbxSoru";
            this.txtbxSoru.Size = new System.Drawing.Size(306, 109);
            this.txtbxSoru.TabIndex = 12;
            // 
            // txtbxKonu
            // 
            this.txtbxKonu.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbxKonu.Location = new System.Drawing.Point(520, 209);
            this.txtbxKonu.MaxLength = 2;
            this.txtbxKonu.Name = "txtbxKonu";
            this.txtbxKonu.Size = new System.Drawing.Size(306, 30);
            this.txtbxKonu.TabIndex = 11;
            this.txtbxKonu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxKonu_KeyPress);
            this.txtbxKonu.Leave += new System.EventHandler(this.txtbxKonu_Leave);
            // 
            // lblCevap
            // 
            this.lblCevap.AutoSize = true;
            this.lblCevap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCevap.Location = new System.Drawing.Point(377, 456);
            this.lblCevap.Name = "lblCevap";
            this.lblCevap.Size = new System.Drawing.Size(101, 27);
            this.lblCevap.TabIndex = 10;
            this.lblCevap.Text = "Cevap : ";
            // 
            // lblSoru
            // 
            this.lblSoru.AutoSize = true;
            this.lblSoru.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoru.Location = new System.Drawing.Point(394, 327);
            this.lblSoru.Name = "lblSoru";
            this.lblSoru.Size = new System.Drawing.Size(84, 27);
            this.lblSoru.TabIndex = 9;
            this.lblSoru.Text = "Soru : ";
            // 
            // lblKonu
            // 
            this.lblKonu.AutoSize = true;
            this.lblKonu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKonu.Location = new System.Drawing.Point(278, 212);
            this.lblKonu.Name = "lblKonu";
            this.lblKonu.Size = new System.Drawing.Size(200, 27);
            this.lblKonu.TabIndex = 8;
            this.lblKonu.Text = "Konu Numarası : ";
            // 
            // btnSoruEkle
            // 
            this.btnSoruEkle.BackColor = System.Drawing.Color.IndianRed;
            this.btnSoruEkle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSoruEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSoruEkle.Location = new System.Drawing.Point(687, 528);
            this.btnSoruEkle.Name = "btnSoruEkle";
            this.btnSoruEkle.Size = new System.Drawing.Size(139, 48);
            this.btnSoruEkle.TabIndex = 7;
            this.btnSoruEkle.Text = "Soru Ekle";
            this.btnSoruEkle.UseVisualStyleBackColor = false;
            this.btnSoruEkle.Click += new System.EventHandler(this.btnSoruEkle_Click);
            // 
            // btnogretmenCikis
            // 
            this.btnogretmenCikis.BackColor = System.Drawing.Color.White;
            this.btnogretmenCikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnogretmenCikis.BackgroundImage")));
            this.btnogretmenCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnogretmenCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnogretmenCikis.Location = new System.Drawing.Point(886, 20);
            this.btnogretmenCikis.Name = "btnogretmenCikis";
            this.btnogretmenCikis.Size = new System.Drawing.Size(64, 47);
            this.btnogretmenCikis.TabIndex = 14;
            this.btnogretmenCikis.UseVisualStyleBackColor = false;
            this.btnogretmenCikis.Click += new System.EventHandler(this.btnogretmenCikis_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.labelKonu10);
            this.panel1.Controls.Add(this.labelKonu8);
            this.panel1.Controls.Add(this.labelKonu9);
            this.panel1.Controls.Add(this.labelKonu3);
            this.panel1.Controls.Add(this.labelKonu1);
            this.panel1.Controls.Add(this.labelKonu2);
            this.panel1.Controls.Add(this.labelKonu4);
            this.panel1.Controls.Add(this.labelKonu7);
            this.panel1.Controls.Add(this.labelKonu5);
            this.panel1.Controls.Add(this.labelKonu6);
            this.panel1.Controls.Add(this.lblBaslik);
            this.panel1.Location = new System.Drawing.Point(0, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 566);
            this.panel1.TabIndex = 15;
            // 
            // labelKonu10
            // 
            this.labelKonu10.AutoSize = true;
            this.labelKonu10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKonu10.Location = new System.Drawing.Point(23, 467);
            this.labelKonu10.Name = "labelKonu10";
            this.labelKonu10.Size = new System.Drawing.Size(159, 21);
            this.labelKonu10.TabIndex = 23;
            this.labelKonu10.Text = "10- Ardışık Sayılar";
            // 
            // labelKonu8
            // 
            this.labelKonu8.AutoSize = true;
            this.labelKonu8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKonu8.Location = new System.Drawing.Point(23, 397);
            this.labelKonu8.Name = "labelKonu8";
            this.labelKonu8.Size = new System.Drawing.Size(119, 21);
            this.labelKonu8.TabIndex = 22;
            this.labelKonu8.Text = "8- Eşitsizlikler";
            // 
            // labelKonu9
            // 
            this.labelKonu9.AutoSize = true;
            this.labelKonu9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKonu9.Location = new System.Drawing.Point(23, 432);
            this.labelKonu9.Name = "labelKonu9";
            this.labelKonu9.Size = new System.Drawing.Size(131, 21);
            this.labelKonu9.TabIndex = 21;
            this.labelKonu9.Text = "9- Trigonometri";
            // 
            // labelKonu3
            // 
            this.labelKonu3.AutoSize = true;
            this.labelKonu3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKonu3.Location = new System.Drawing.Point(23, 197);
            this.labelKonu3.Name = "labelKonu3";
            this.labelKonu3.Size = new System.Drawing.Size(126, 21);
            this.labelKonu3.TabIndex = 16;
            this.labelKonu3.Text = "3- Asal Sayılar";
            // 
            // labelKonu1
            // 
            this.labelKonu1.AutoSize = true;
            this.labelKonu1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKonu1.Location = new System.Drawing.Point(23, 114);
            this.labelKonu1.Name = "labelKonu1";
            this.labelKonu1.Size = new System.Drawing.Size(76, 21);
            this.labelKonu1.TabIndex = 16;
            this.labelKonu1.Text = "1- Açılar";
            // 
            // labelKonu2
            // 
            this.labelKonu2.AutoSize = true;
            this.labelKonu2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKonu2.Location = new System.Drawing.Point(23, 155);
            this.labelKonu2.Name = "labelKonu2";
            this.labelKonu2.Size = new System.Drawing.Size(173, 21);
            this.labelKonu2.TabIndex = 17;
            this.labelKonu2.Text = "2- Bölme ve Çarpma";
            // 
            // labelKonu4
            // 
            this.labelKonu4.AutoSize = true;
            this.labelKonu4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKonu4.Location = new System.Drawing.Point(23, 239);
            this.labelKonu4.Name = "labelKonu4";
            this.labelKonu4.Size = new System.Drawing.Size(151, 21);
            this.labelKonu4.TabIndex = 18;
            this.labelKonu4.Text = "4- Oran ve Orantı";
            // 
            // labelKonu7
            // 
            this.labelKonu7.AutoSize = true;
            this.labelKonu7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKonu7.Location = new System.Drawing.Point(23, 357);
            this.labelKonu7.Name = "labelKonu7";
            this.labelKonu7.Size = new System.Drawing.Size(139, 21);
            this.labelKonu7.TabIndex = 20;
            this.labelKonu7.Text = "7- Kombinasyon";
            // 
            // labelKonu5
            // 
            this.labelKonu5.AutoSize = true;
            this.labelKonu5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKonu5.Location = new System.Drawing.Point(23, 280);
            this.labelKonu5.Name = "labelKonu5";
            this.labelKonu5.Size = new System.Drawing.Size(176, 21);
            this.labelKonu5.TabIndex = 19;
            this.labelKonu5.Text = "5- Yüzde Problemleri";
            // 
            // labelKonu6
            // 
            this.labelKonu6.AutoSize = true;
            this.labelKonu6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKonu6.Location = new System.Drawing.Point(23, 320);
            this.labelKonu6.Name = "labelKonu6";
            this.labelKonu6.Size = new System.Drawing.Size(93, 21);
            this.labelKonu6.TabIndex = 20;
            this.labelKonu6.Text = "6- Olasılık";
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(13, 32);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(203, 24);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "KONU NUMARALARI";
            // 
            // formOgretmenSoru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 664);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnogretmenCikis);
            this.Controls.Add(this.txtbxCevap);
            this.Controls.Add(this.txtbxSoru);
            this.Controls.Add(this.txtbxKonu);
            this.Controls.Add(this.lblCevap);
            this.Controls.Add(this.lblSoru);
            this.Controls.Add(this.lblKonu);
            this.Controls.Add(this.btnSoruEkle);
            this.Name = "formOgretmenSoru";
            this.Text = "Öğretmen Soru Ekle";
            this.Load += new System.EventHandler(this.formOgretmenAna_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxCevap;
        private System.Windows.Forms.TextBox txtbxSoru;
        private System.Windows.Forms.TextBox txtbxKonu;
        private System.Windows.Forms.Label lblCevap;
        private System.Windows.Forms.Label lblSoru;
        private System.Windows.Forms.Label lblKonu;
        private System.Windows.Forms.Button btnSoruEkle;
        private System.Windows.Forms.Button btnogretmenCikis;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label labelKonu10;
        private System.Windows.Forms.Label labelKonu8;
        private System.Windows.Forms.Label labelKonu9;
        private System.Windows.Forms.Label labelKonu3;
        private System.Windows.Forms.Label labelKonu1;
        private System.Windows.Forms.Label labelKonu2;
        private System.Windows.Forms.Label labelKonu4;
        private System.Windows.Forms.Label labelKonu7;
        private System.Windows.Forms.Label labelKonu5;
        private System.Windows.Forms.Label labelKonu6;
    }
}