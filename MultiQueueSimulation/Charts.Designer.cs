namespace MultiQueueSimulation
{
    partial class Charts
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
            this.perServerChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.nextServerButton = new System.Windows.Forms.Button();
            this.metricsButton = new System.Windows.Forms.Button();
            this.previousServerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.perServerChart)).BeginInit();
            this.SuspendLayout();
            // 
            // perServerChart
            // 
            chartArea1.Name = "ChartArea1";
            this.perServerChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.perServerChart.Legends.Add(legend1);
            this.perServerChart.Location = new System.Drawing.Point(12, 35);
            this.perServerChart.Name = "perServerChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Performance";
            this.perServerChart.Series.Add(series1);
            this.perServerChart.Size = new System.Drawing.Size(1131, 481);
            this.perServerChart.TabIndex = 0;
            this.perServerChart.Text = "perServerChart";
            // 
            // nextServerButton
            // 
            this.nextServerButton.Location = new System.Drawing.Point(1015, 522);
            this.nextServerButton.Name = "nextServerButton";
            this.nextServerButton.Size = new System.Drawing.Size(128, 23);
            this.nextServerButton.TabIndex = 1;
            this.nextServerButton.Text = "Show next server";
            this.nextServerButton.UseVisualStyleBackColor = true;
            this.nextServerButton.Click += new System.EventHandler(this.nextServerButton_Click);
            // 
            // metricsButton
            // 
            this.metricsButton.Location = new System.Drawing.Point(503, 522);
            this.metricsButton.Name = "metricsButton";
            this.metricsButton.Size = new System.Drawing.Size(140, 23);
            this.metricsButton.TabIndex = 2;
            this.metricsButton.Text = "Retrn to metrics";
            this.metricsButton.UseVisualStyleBackColor = true;
            this.metricsButton.Click += new System.EventHandler(this.metricsButton_Click);
            // 
            // previousServerButton
            // 
            this.previousServerButton.Location = new System.Drawing.Point(13, 522);
            this.previousServerButton.Name = "previousServerButton";
            this.previousServerButton.Size = new System.Drawing.Size(127, 23);
            this.previousServerButton.TabIndex = 3;
            this.previousServerButton.Text = "Previous Server";
            this.previousServerButton.UseVisualStyleBackColor = true;
            this.previousServerButton.Click += new System.EventHandler(this.previousServerButton_Click);
            // 
            // Charts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 557);
            this.Controls.Add(this.previousServerButton);
            this.Controls.Add(this.metricsButton);
            this.Controls.Add(this.nextServerButton);
            this.Controls.Add(this.perServerChart);
            this.Name = "Charts";
            this.Text = "Charts";
            this.Load += new System.EventHandler(this.Charts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.perServerChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart perServerChart;
        private System.Windows.Forms.Button nextServerButton;
        private System.Windows.Forms.Button metricsButton;
        private System.Windows.Forms.Button previousServerButton;
    }
}