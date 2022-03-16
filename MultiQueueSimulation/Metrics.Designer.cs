namespace MultiQueueSimulation
{
    partial class Metrics
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
            this.perServerGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.averageText = new System.Windows.Forms.TextBox();
            this.waitText = new System.Windows.Forms.TextBox();
            this.maxQText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.simOutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.perServerGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // perServerGrid
            // 
            this.perServerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.perServerGrid.Location = new System.Drawing.Point(320, 41);
            this.perServerGrid.Name = "perServerGrid";
            this.perServerGrid.RowHeadersWidth = 51;
            this.perServerGrid.RowTemplate.Height = 24;
            this.perServerGrid.Size = new System.Drawing.Size(595, 471);
            this.perServerGrid.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(840, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Per Server Metrics";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Average wait time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Waiting probability";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Max Queue Length";
            // 
            // averageText
            // 
            this.averageText.Location = new System.Drawing.Point(131, 59);
            this.averageText.Name = "averageText";
            this.averageText.Size = new System.Drawing.Size(100, 22);
            this.averageText.TabIndex = 6;
            // 
            // waitText
            // 
            this.waitText.Location = new System.Drawing.Point(131, 125);
            this.waitText.Name = "waitText";
            this.waitText.Size = new System.Drawing.Size(100, 22);
            this.waitText.TabIndex = 7;
            // 
            // maxQText
            // 
            this.maxQText.Location = new System.Drawing.Point(131, 193);
            this.maxQText.Name = "maxQText";
            this.maxQText.Size = new System.Drawing.Size(100, 22);
            this.maxQText.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "System Metrics";
            // 
            // simOutButton
            // 
            this.simOutButton.Location = new System.Drawing.Point(15, 518);
            this.simOutButton.Name = "simOutButton";
            this.simOutButton.Size = new System.Drawing.Size(140, 23);
            this.simOutButton.TabIndex = 10;
            this.simOutButton.Text = "Return to Sim output";
            this.simOutButton.UseVisualStyleBackColor = true;
            this.simOutButton.Click += new System.EventHandler(this.SimOutButton_Click);
            // 
            // Metrics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 553);
            this.Controls.Add(this.simOutButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maxQText);
            this.Controls.Add(this.waitText);
            this.Controls.Add(this.averageText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.perServerGrid);
            this.Name = "Metrics";
            this.Text = "Performance Metricss";
            this.Load += new System.EventHandler(this.Metrics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.perServerGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView perServerGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox averageText;
        private System.Windows.Forms.TextBox waitText;
        private System.Windows.Forms.TextBox maxQText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button simOutButton;
    }
}