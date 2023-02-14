namespace Numerology
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartMariage = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bttnCalculation = new System.Windows.Forms.Button();
            this.dtTmPckrBirthday = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.chartMariage)).BeginInit();
            this.SuspendLayout();
            // 
            // chartMariage
            // 
            chartArea1.Name = "ChartArea1";
            this.chartMariage.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartMariage.Legends.Add(legend1);
            this.chartMariage.Location = new System.Drawing.Point(26, 21);
            this.chartMariage.Name = "chartMariage";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartMariage.Series.Add(series1);
            this.chartMariage.Size = new System.Drawing.Size(985, 677);
            this.chartMariage.TabIndex = 0;
            this.chartMariage.Text = "chartMariage";
            // 
            // bttnCalculation
            // 
            this.bttnCalculation.Location = new System.Drawing.Point(1047, 76);
            this.bttnCalculation.Name = "bttnCalculation";
            this.bttnCalculation.Size = new System.Drawing.Size(126, 27);
            this.bttnCalculation.TabIndex = 1;
            this.bttnCalculation.Text = "Calculation";
            this.bttnCalculation.UseVisualStyleBackColor = true;
            this.bttnCalculation.Click += new System.EventHandler(this.bttnCalculation_Click);
            // 
            // dtTmPckrBirthday
            // 
            this.dtTmPckrBirthday.Location = new System.Drawing.Point(1047, 34);
            this.dtTmPckrBirthday.Name = "dtTmPckrBirthday";
            this.dtTmPckrBirthday.Size = new System.Drawing.Size(266, 22);
            this.dtTmPckrBirthday.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 710);
            this.Controls.Add(this.dtTmPckrBirthday);
            this.Controls.Add(this.bttnCalculation);
            this.Controls.Add(this.chartMariage);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chartMariage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartMariage;
        private System.Windows.Forms.Button bttnCalculation;
        private System.Windows.Forms.DateTimePicker dtTmPckrBirthday;
    }
}

