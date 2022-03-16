namespace MultiQueueSimulation
{
    partial class InputForm
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
            this.NS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SN = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Random_radioButton = new System.Windows.Forms.RadioButton();
            this.HP_radioButton = new System.Windows.Forms.RadioButton();
            this.StoppingCriteria_group = new System.Windows.Forms.GroupBox();
            this.EndTime_radioButton = new System.Windows.Forms.RadioButton();
            this.Number_radioButton = new System.Windows.Forms.RadioButton();
            this.InterarrivalGrid = new System.Windows.Forms.DataGridView();
            this.ServerGrid = new System.Windows.Forms.DataGridView();
            this.Browse_button = new System.Windows.Forms.Button();
            this.Out_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.StoppingCriteria_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InterarrivalGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServerGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // NS
            // 
            this.NS.Location = new System.Drawing.Point(134, 85);
            this.NS.Name = "NS";
            this.NS.Size = new System.Drawing.Size(100, 22);
            this.NS.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of service";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Stopping number";
            // 
            // SN
            // 
            this.SN.Location = new System.Drawing.Point(131, 125);
            this.SN.Name = "SN";
            this.SN.Size = new System.Drawing.Size(100, 22);
            this.SN.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Random_radioButton);
            this.groupBox1.Controls.Add(this.HP_radioButton);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox1.Location = new System.Drawing.Point(15, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SelectionMethod";
            // 
            // Random_radioButton
            // 
            this.Random_radioButton.AutoSize = true;
            this.Random_radioButton.Location = new System.Drawing.Point(19, 49);
            this.Random_radioButton.Name = "Random_radioButton";
            this.Random_radioButton.Size = new System.Drawing.Size(80, 20);
            this.Random_radioButton.TabIndex = 1;
            this.Random_radioButton.TabStop = true;
            this.Random_radioButton.Text = "Random";
            this.Random_radioButton.UseVisualStyleBackColor = true;
            // 
            // HP_radioButton
            // 
            this.HP_radioButton.AutoSize = true;
            this.HP_radioButton.Location = new System.Drawing.Point(19, 22);
            this.HP_radioButton.Name = "HP_radioButton";
            this.HP_radioButton.Size = new System.Drawing.Size(118, 20);
            this.HP_radioButton.TabIndex = 0;
            this.HP_radioButton.TabStop = true;
            this.HP_radioButton.Text = "Highest Priority";
            this.HP_radioButton.UseVisualStyleBackColor = true;
            // 
            // StoppingCriteria_group
            // 
            this.StoppingCriteria_group.Controls.Add(this.EndTime_radioButton);
            this.StoppingCriteria_group.Controls.Add(this.Number_radioButton);
            this.StoppingCriteria_group.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.StoppingCriteria_group.Location = new System.Drawing.Point(15, 273);
            this.StoppingCriteria_group.Name = "StoppingCriteria_group";
            this.StoppingCriteria_group.Size = new System.Drawing.Size(200, 100);
            this.StoppingCriteria_group.TabIndex = 11;
            this.StoppingCriteria_group.TabStop = false;
            this.StoppingCriteria_group.Text = "Stoppin Criteria";
            // 
            // EndTime_radioButton
            // 
            this.EndTime_radioButton.AutoSize = true;
            this.EndTime_radioButton.Location = new System.Drawing.Point(19, 49);
            this.EndTime_radioButton.Name = "EndTime_radioButton";
            this.EndTime_radioButton.Size = new System.Drawing.Size(86, 20);
            this.EndTime_radioButton.TabIndex = 1;
            this.EndTime_radioButton.TabStop = true;
            this.EndTime_radioButton.Text = "End Time";
            this.EndTime_radioButton.UseVisualStyleBackColor = true;
            // 
            // Number_radioButton
            // 
            this.Number_radioButton.AutoSize = true;
            this.Number_radioButton.Location = new System.Drawing.Point(19, 22);
            this.Number_radioButton.Name = "Number_radioButton";
            this.Number_radioButton.Size = new System.Drawing.Size(155, 20);
            this.Number_radioButton.TabIndex = 0;
            this.Number_radioButton.TabStop = true;
            this.Number_radioButton.Text = "Number of customers";
            this.Number_radioButton.UseVisualStyleBackColor = true;
            // 
            // InterarrivalGrid
            // 
            this.InterarrivalGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InterarrivalGrid.Location = new System.Drawing.Point(282, 66);
            this.InterarrivalGrid.Name = "InterarrivalGrid";
            this.InterarrivalGrid.RowHeadersWidth = 51;
            this.InterarrivalGrid.RowTemplate.Height = 24;
            this.InterarrivalGrid.Size = new System.Drawing.Size(443, 417);
            this.InterarrivalGrid.TabIndex = 12;
            // 
            // ServerGrid
            // 
            this.ServerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServerGrid.Location = new System.Drawing.Point(731, 66);
            this.ServerGrid.Name = "ServerGrid";
            this.ServerGrid.RowHeadersWidth = 51;
            this.ServerGrid.RowTemplate.Height = 24;
            this.ServerGrid.Size = new System.Drawing.Size(469, 417);
            this.ServerGrid.TabIndex = 13;
            // 
            // Browse_button
            // 
            this.Browse_button.Location = new System.Drawing.Point(622, 12);
            this.Browse_button.Name = "Browse_button";
            this.Browse_button.Size = new System.Drawing.Size(75, 23);
            this.Browse_button.TabIndex = 14;
            this.Browse_button.Text = "Browse";
            this.Browse_button.UseVisualStyleBackColor = true;
            this.Browse_button.Click += new System.EventHandler(this.Browse_button_Click);
            // 
            // Out_button
            // 
            this.Out_button.Location = new System.Drawing.Point(1086, 527);
            this.Out_button.Name = "Out_button";
            this.Out_button.Size = new System.Drawing.Size(114, 23);
            this.Out_button.TabIndex = 15;
            this.Out_button.Text = "Show output";
            this.Out_button.UseVisualStyleBackColor = true;
            this.Out_button.Click += new System.EventHandler(this.Out_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "System input";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Interarrival Input";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(731, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Server Input";
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 562);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Out_button);
            this.Controls.Add(this.Browse_button);
            this.Controls.Add(this.ServerGrid);
            this.Controls.Add(this.InterarrivalGrid);
            this.Controls.Add(this.StoppingCriteria_group);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NS);
            this.Name = "InputForm";
            this.Text = "Input Window";
            this.Load += new System.EventHandler(this.InputForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.StoppingCriteria_group.ResumeLayout(false);
            this.StoppingCriteria_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InterarrivalGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServerGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.TextBox NS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Random_radioButton;
        private System.Windows.Forms.RadioButton HP_radioButton;
        private System.Windows.Forms.GroupBox StoppingCriteria_group;
        private System.Windows.Forms.RadioButton EndTime_radioButton;
        private System.Windows.Forms.RadioButton Number_radioButton;
        private System.Windows.Forms.DataGridView InterarrivalGrid;
        private System.Windows.Forms.DataGridView ServerGrid;
        private System.Windows.Forms.Button Browse_button;
        private System.Windows.Forms.Button Out_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

