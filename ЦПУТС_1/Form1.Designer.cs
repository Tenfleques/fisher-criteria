namespace ЦПУТС_1
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonFire = new System.Windows.Forms.Button();
            this.chartShow = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.richTextBoxInfo = new System.Windows.Forms.RichTextBox();
            this.labela = new System.Windows.Forms.Label();
            this.labelb = new System.Windows.Forms.Label();
            this.labelF = new System.Windows.Forms.Label();
            this.labelFp = new System.Windows.Forms.Label();
            this.labeltet = new System.Windows.Forms.Label();
            this.labelconclusion = new System.Windows.Forms.Label();
            this.labelequation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartShow)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFire
            // 
            this.buttonFire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFire.Location = new System.Drawing.Point(616, 13);
            this.buttonFire.Name = "buttonFire";
            this.buttonFire.Size = new System.Drawing.Size(306, 23);
            this.buttonFire.TabIndex = 0;
            this.buttonFire.Text = "Начинать";
            this.buttonFire.UseVisualStyleBackColor = true;
            this.buttonFire.Click += new System.EventHandler(this.button1_Click);
            // 
            // chartShow
            // 
            this.chartShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chartShow.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartShow.Legends.Add(legend2);
            this.chartShow.Location = new System.Drawing.Point(13, 13);
            this.chartShow.Name = "chartShow";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Эксперименталбная линия регрессии";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Моделная линия регрессии";
            this.chartShow.Series.Add(series3);
            this.chartShow.Series.Add(series4);
            this.chartShow.Size = new System.Drawing.Size(597, 436);
            this.chartShow.TabIndex = 1;
            this.chartShow.Text = "Линия регрессии у по х";
            // 
            // richTextBoxInfo
            // 
            this.richTextBoxInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxInfo.Location = new System.Drawing.Point(616, 43);
            this.richTextBoxInfo.Name = "richTextBoxInfo";
            this.richTextBoxInfo.Size = new System.Drawing.Size(306, 234);
            this.richTextBoxInfo.TabIndex = 2;
            this.richTextBoxInfo.Text = "";
            // 
            // labela
            // 
            this.labela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labela.AutoSize = true;
            this.labela.Location = new System.Drawing.Point(616, 336);
            this.labela.Name = "labela";
            this.labela.Size = new System.Drawing.Size(0, 13);
            this.labela.TabIndex = 3;
            // 
            // labelb
            // 
            this.labelb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelb.AutoSize = true;
            this.labelb.Location = new System.Drawing.Point(616, 356);
            this.labelb.Name = "labelb";
            this.labelb.Size = new System.Drawing.Size(0, 13);
            this.labelb.TabIndex = 4;
            // 
            // labelF
            // 
            this.labelF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelF.AutoSize = true;
            this.labelF.Location = new System.Drawing.Point(616, 376);
            this.labelF.Name = "labelF";
            this.labelF.Size = new System.Drawing.Size(0, 13);
            this.labelF.TabIndex = 5;
            // 
            // labelFp
            // 
            this.labelFp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFp.AutoSize = true;
            this.labelFp.Location = new System.Drawing.Point(616, 396);
            this.labelFp.Name = "labelFp";
            this.labelFp.Size = new System.Drawing.Size(0, 13);
            this.labelFp.TabIndex = 6;
            // 
            // labeltet
            // 
            this.labeltet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labeltet.AutoSize = true;
            this.labeltet.Location = new System.Drawing.Point(616, 416);
            this.labeltet.Name = "labeltet";
            this.labeltet.Size = new System.Drawing.Size(0, 13);
            this.labeltet.TabIndex = 7;
            // 
            // labelconclusion
            // 
            this.labelconclusion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelconclusion.AutoSize = true;
            this.labelconclusion.Location = new System.Drawing.Point(616, 436);
            this.labelconclusion.Name = "labelconclusion";
            this.labelconclusion.Size = new System.Drawing.Size(0, 13);
            this.labelconclusion.TabIndex = 8;
            // 
            // labelequation
            // 
            this.labelequation.AutoSize = true;
            this.labelequation.Location = new System.Drawing.Point(616, 284);
            this.labelequation.Name = "labelequation";
            this.labelequation.Size = new System.Drawing.Size(0, 13);
            this.labelequation.TabIndex = 9;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 461);
            this.Controls.Add(this.labelequation);
            this.Controls.Add(this.labelconclusion);
            this.Controls.Add(this.labeltet);
            this.Controls.Add(this.labelFp);
            this.Controls.Add(this.labelF);
            this.Controls.Add(this.labelb);
            this.Controls.Add(this.labela);
            this.Controls.Add(this.richTextBoxInfo);
            this.Controls.Add(this.chartShow);
            this.Controls.Add(this.buttonFire);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Определение коэффициентов однопараметрических моделей";
            ((System.ComponentModel.ISupportInitialize)(this.chartShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFire;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartShow;
        private System.Windows.Forms.RichTextBox richTextBoxInfo;
        private System.Windows.Forms.Label labela;
        private System.Windows.Forms.Label labelb;
        private System.Windows.Forms.Label labelF;
        private System.Windows.Forms.Label labelFp;
        private System.Windows.Forms.Label labeltet;
        private System.Windows.Forms.Label labelconclusion;
        private System.Windows.Forms.Label labelequation;
    }
}

