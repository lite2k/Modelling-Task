namespace MultiQueueSimulation
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Browse_button = new System.Windows.Forms.Button();
            this.Out_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.StoppingCriteria_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // NS
            // 
            this.NS.Location = new System.Drawing.Point(131, 66);
            this.NS.Name = "NS";
            this.NS.Size = new System.Drawing.Size(100, 22);
            this.NS.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 66);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 170);
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
            this.StoppingCriteria_group.Location = new System.Drawing.Point(15, 295);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(254, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(443, 417);
            this.dataGridView1.TabIndex = 12;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(731, 66);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(469, 417);
            this.dataGridView2.TabIndex = 13;
            // 
            // Browse_button
            // 
            this.Browse_button.Location = new System.Drawing.Point(533, 27);
            this.Browse_button.Name = "Browse_button";
            this.Browse_button.Size = new System.Drawing.Size(75, 23);
            this.Browse_button.TabIndex = 14;
            this.Browse_button.Text = "Browse";
            this.Browse_button.UseVisualStyleBackColor = true;
            this.Browse_button.Click += new System.EventHandler(this.Browse_button_Click);
            // 
            // Out_button
            // 
            this.Out_button.Location = new System.Drawing.Point(1044, 510);
            this.Out_button.Name = "Out_button";
            this.Out_button.Size = new System.Drawing.Size(114, 23);
            this.Out_button.TabIndex = 15;
            this.Out_button.Text = "Show output";
            this.Out_button.UseVisualStyleBackColor = true;
            this.Out_button.Click += new System.EventHandler(this.Out_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 562);
            this.Controls.Add(this.Out_button);
            this.Controls.Add(this.Browse_button);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.StoppingCriteria_group);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NS);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.StoppingCriteria_group.ResumeLayout(false);
            this.StoppingCriteria_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Browse_button;
        private System.Windows.Forms.Button Out_button;
    }
}

