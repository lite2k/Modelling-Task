namespace MultiQueueSimulation
{
    partial class SimOutput
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
            this.interarrivalGrid = new System.Windows.Forms.DataGridView();
            this.outButton = new System.Windows.Forms.Button();
            this.simGrid = new System.Windows.Forms.DataGridView();
            this.ServerGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Performance_Button = new System.Windows.Forms.Button();
            this.inputButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.interarrivalGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServerGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // interarrivalGrid
            // 
            this.interarrivalGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.interarrivalGrid.Location = new System.Drawing.Point(9, 531);
            this.interarrivalGrid.Name = "interarrivalGrid";
            this.interarrivalGrid.RowHeadersWidth = 51;
            this.interarrivalGrid.RowTemplate.Height = 24;
            this.interarrivalGrid.Size = new System.Drawing.Size(561, 339);
            this.interarrivalGrid.TabIndex = 0;
            // 
            // outButton
            // 
            this.outButton.Location = new System.Drawing.Point(526, 876);
            this.outButton.Name = "outButton";
            this.outButton.Size = new System.Drawing.Size(95, 23);
            this.outButton.TabIndex = 2;
            this.outButton.Text = "Show output";
            this.outButton.UseVisualStyleBackColor = true;
            this.outButton.Click += new System.EventHandler(this.outButton_Click);
            // 
            // simGrid
            // 
            this.simGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.simGrid.Location = new System.Drawing.Point(9, 28);
            this.simGrid.Name = "simGrid";
            this.simGrid.RowHeadersWidth = 51;
            this.simGrid.RowTemplate.Height = 24;
            this.simGrid.Size = new System.Drawing.Size(1435, 466);
            this.simGrid.TabIndex = 3;
            // 
            // ServerGrid
            // 
            this.ServerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServerGrid.Location = new System.Drawing.Point(576, 531);
            this.ServerGrid.Name = "ServerGrid";
            this.ServerGrid.RowHeadersWidth = 51;
            this.ServerGrid.RowTemplate.Height = 24;
            this.ServerGrid.Size = new System.Drawing.Size(868, 339);
            this.ServerGrid.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Simulation Table";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 512);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Interarrival Table";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(577, 512);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Server Table";
            // 
            // Performance_Button
            // 
            this.Performance_Button.Location = new System.Drawing.Point(1264, 875);
            this.Performance_Button.Name = "Performance_Button";
            this.Performance_Button.Size = new System.Drawing.Size(180, 23);
            this.Performance_Button.TabIndex = 11;
            this.Performance_Button.Text = "Show performance metrics";
            this.Performance_Button.UseVisualStyleBackColor = true;
            this.Performance_Button.Click += new System.EventHandler(this.Performance_Button_Click);
            // 
            // inputButton
            // 
            this.inputButton.Location = new System.Drawing.Point(15, 875);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(172, 23);
            this.inputButton.TabIndex = 12;
            this.inputButton.Text = "Return to input window";
            this.inputButton.UseVisualStyleBackColor = true;
            this.inputButton.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // SimOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 905);
            this.Controls.Add(this.inputButton);
            this.Controls.Add(this.Performance_Button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ServerGrid);
            this.Controls.Add(this.simGrid);
            this.Controls.Add(this.outButton);
            this.Controls.Add(this.interarrivalGrid);
            this.Name = "SimOutput";
            this.Text = "Simulation Window";
            this.Load += new System.EventHandler(this.SimOutput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.interarrivalGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServerGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView interarrivalGrid;
        private System.Windows.Forms.Button outButton;
        private System.Windows.Forms.DataGridView simGrid;
        private System.Windows.Forms.DataGridView ServerGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Performance_Button;
        private System.Windows.Forms.Button inputButton;
    }
}