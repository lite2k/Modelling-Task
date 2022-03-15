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
            this.SuspendLayout();
            this.NS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SM = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Browse_Button
            // 
            // 
            // NS
            // 
            this.NS.Location = new System.Drawing.Point(135, 125);
            this.NS.Name = "NS";
            this.NS.Size = new System.Drawing.Size(100, 22);
            this.NS.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of service";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Stopping critiria";
            // 
            // SC
            // 
            this.SC.Location = new System.Drawing.Point(135, 242);
            this.SC.Name = "SC";
            this.SC.Size = new System.Drawing.Size(100, 22);
            this.SC.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Stopping number";
            // 
            // SN
            // 
            this.SN.Location = new System.Drawing.Point(135, 185);
            this.SN.Name = "SN";
            this.SN.Size = new System.Drawing.Size(100, 22);
            this.SN.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Selection method";
            // 
            // SM
            // 
            this.SM.Location = new System.Drawing.Point(134, 303);
            this.SM.Name = "SM";
            this.SM.Size = new System.Drawing.Size(100, 22);
            this.SM.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

            this.ClientSize = new System.Drawing.Size(1021, 493);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NS);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();


        }

        #endregion


        static public System.Windows.Forms.Button Browse_Button;
        private System.Windows.Forms.TextBox NS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SM;

    }
}

