namespace SmartClass
{
    partial class formBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formBar));
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            this.buttonGeri = new System.Windows.Forms.Button();
            this.chartKonu = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.chartKonu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGeri
            // 
            this.buttonGeri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGeri.BackgroundImage")));
            this.buttonGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGeri.Location = new System.Drawing.Point(1221, 22);
            this.buttonGeri.Name = "buttonGeri";
            this.buttonGeri.Size = new System.Drawing.Size(49, 35);
            this.buttonGeri.TabIndex = 0;
            this.buttonGeri.UseVisualStyleBackColor = true;
            this.buttonGeri.Click += new System.EventHandler(this.buttonGeri_Click);
            // 
            // chartKonu
            // 
            this.chartKonu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.chartKonu.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartKonu.Diagram = xyDiagram1;
            this.chartKonu.Legend.Name = "Default Legend";
            this.chartKonu.Location = new System.Drawing.Point(32, 112);
            this.chartKonu.Name = "chartKonu";
            this.chartKonu.PaletteName = "Flow";
            series1.Name = "Konular";
            this.chartKonu.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartKonu.Size = new System.Drawing.Size(1238, 633);
            this.chartKonu.TabIndex = 1;
            // 
            // formBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 773);
            this.ControlBox = false;
            this.Controls.Add(this.chartKonu);
            this.Controls.Add(this.buttonGeri);
            this.Name = "formBar";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Bar Grafiği";
            this.Load += new System.EventHandler(this.formIstatistik_Load);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartKonu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGeri;
        private DevExpress.XtraCharts.ChartControl chartKonu;
    }
}