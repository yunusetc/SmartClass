namespace SmartClass
{
    partial class frmOgrenciAna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOgrenciAna));
            this.btnOgrenciCikis = new System.Windows.Forms.Button();
            this.btnTestCöz = new System.Windows.Forms.Button();
            this.btnBar = new System.Windows.Forms.Button();
            this.pictureBoxTest = new System.Windows.Forms.PictureBox();
            this.btnCizgi = new System.Windows.Forms.Button();
            this.pictureBoxBar = new System.Windows.Forms.PictureBox();
            this.pictureBoxCizgi = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCizgi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOgrenciCikis
            // 
            this.btnOgrenciCikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOgrenciCikis.BackgroundImage")));
            this.btnOgrenciCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOgrenciCikis.Location = new System.Drawing.Point(655, 21);
            this.btnOgrenciCikis.Name = "btnOgrenciCikis";
            this.btnOgrenciCikis.Size = new System.Drawing.Size(59, 54);
            this.btnOgrenciCikis.TabIndex = 0;
            this.btnOgrenciCikis.UseVisualStyleBackColor = true;
            this.btnOgrenciCikis.Click += new System.EventHandler(this.btnOgrenciCikis_Click);
            // 
            // btnTestCöz
            // 
            this.btnTestCöz.BackColor = System.Drawing.Color.IndianRed;
            this.btnTestCöz.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTestCöz.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTestCöz.Location = new System.Drawing.Point(324, 176);
            this.btnTestCöz.Name = "btnTestCöz";
            this.btnTestCöz.Size = new System.Drawing.Size(224, 65);
            this.btnTestCöz.TabIndex = 1;
            this.btnTestCöz.Text = "Test Çöz";
            this.btnTestCöz.UseVisualStyleBackColor = false;
            this.btnTestCöz.Click += new System.EventHandler(this.btnTestCöz_Click);
            // 
            // btnBar
            // 
            this.btnBar.BackColor = System.Drawing.Color.IndianRed;
            this.btnBar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBar.Location = new System.Drawing.Point(324, 304);
            this.btnBar.Name = "btnBar";
            this.btnBar.Size = new System.Drawing.Size(224, 65);
            this.btnBar.TabIndex = 2;
            this.btnBar.Text = "Bar Grafiği";
            this.btnBar.UseVisualStyleBackColor = false;
            this.btnBar.Click += new System.EventHandler(this.btnBar_Click);
            // 
            // pictureBoxTest
            // 
            this.pictureBoxTest.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTest.Image")));
            this.pictureBoxTest.Location = new System.Drawing.Point(187, 165);
            this.pictureBoxTest.Name = "pictureBoxTest";
            this.pictureBoxTest.Size = new System.Drawing.Size(100, 91);
            this.pictureBoxTest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTest.TabIndex = 3;
            this.pictureBoxTest.TabStop = false;
            // 
            // btnCizgi
            // 
            this.btnCizgi.BackColor = System.Drawing.Color.IndianRed;
            this.btnCizgi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCizgi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCizgi.Location = new System.Drawing.Point(324, 425);
            this.btnCizgi.Name = "btnCizgi";
            this.btnCizgi.Size = new System.Drawing.Size(224, 65);
            this.btnCizgi.TabIndex = 4;
            this.btnCizgi.Text = "Çizgi Grafiği";
            this.btnCizgi.UseVisualStyleBackColor = false;
            this.btnCizgi.Click += new System.EventHandler(this.btnCizgi_Click);
            // 
            // pictureBoxBar
            // 
            this.pictureBoxBar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBar.Image")));
            this.pictureBoxBar.Location = new System.Drawing.Point(187, 291);
            this.pictureBoxBar.Name = "pictureBoxBar";
            this.pictureBoxBar.Size = new System.Drawing.Size(100, 91);
            this.pictureBoxBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBar.TabIndex = 5;
            this.pictureBoxBar.TabStop = false;
            // 
            // pictureBoxCizgi
            // 
            this.pictureBoxCizgi.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCizgi.Image")));
            this.pictureBoxCizgi.Location = new System.Drawing.Point(187, 412);
            this.pictureBoxCizgi.Name = "pictureBoxCizgi";
            this.pictureBoxCizgi.Size = new System.Drawing.Size(100, 91);
            this.pictureBoxCizgi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCizgi.TabIndex = 6;
            this.pictureBoxCizgi.TabStop = false;
            // 
            // frmOgrenciAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 592);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBoxCizgi);
            this.Controls.Add(this.pictureBoxBar);
            this.Controls.Add(this.btnCizgi);
            this.Controls.Add(this.pictureBoxTest);
            this.Controls.Add(this.btnBar);
            this.Controls.Add(this.btnTestCöz);
            this.Controls.Add(this.btnOgrenciCikis);
            this.Name = "frmOgrenciAna";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Öğrenci Ana Menü";
            this.Load += new System.EventHandler(this.frmOgrenciAna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCizgi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOgrenciCikis;
        private System.Windows.Forms.Button btnTestCöz;
        private System.Windows.Forms.Button btnBar;
        private System.Windows.Forms.PictureBox pictureBoxTest;
        private System.Windows.Forms.Button btnCizgi;
        private System.Windows.Forms.PictureBox pictureBoxBar;
        private System.Windows.Forms.PictureBox pictureBoxCizgi;
    }
}