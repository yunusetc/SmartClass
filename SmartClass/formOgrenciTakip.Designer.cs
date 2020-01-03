namespace SmartClass
{
    partial class formOgrenciTakip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formOgrenciTakip));
            this.btnAsecenegi = new System.Windows.Forms.Button();
            this.listViewTakip = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnAsecenegi
            // 
            this.btnAsecenegi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAsecenegi.BackgroundImage")));
            this.btnAsecenegi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAsecenegi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsecenegi.Location = new System.Drawing.Point(705, 13);
            this.btnAsecenegi.Name = "btnAsecenegi";
            this.btnAsecenegi.Size = new System.Drawing.Size(54, 46);
            this.btnAsecenegi.TabIndex = 0;
            this.btnAsecenegi.UseVisualStyleBackColor = true;
            this.btnAsecenegi.Click += new System.EventHandler(this.buttonGeri_Click);
            // 
            // listViewTakip
            // 
            this.listViewTakip.BackColor = System.Drawing.Color.LightCyan;
            this.listViewTakip.Location = new System.Drawing.Point(9, 93);
            this.listViewTakip.Name = "listViewTakip";
            this.listViewTakip.Size = new System.Drawing.Size(750, 410);
            this.listViewTakip.TabIndex = 1;
            this.listViewTakip.UseCompatibleStateImageBehavior = false;
            // 
            // formOgrenciTakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 536);
            this.ControlBox = false;
            this.Controls.Add(this.listViewTakip);
            this.Controls.Add(this.btnAsecenegi);
            this.Name = "formOgrenciTakip";
            this.Text = "Öğrenci Takip";
            this.Load += new System.EventHandler(this.formOgrenciTakip_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAsecenegi;
        private System.Windows.Forms.ListView listViewTakip;
    }
}