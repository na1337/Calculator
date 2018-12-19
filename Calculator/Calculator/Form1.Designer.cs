namespace Calculator
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
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.rbPlus = new System.Windows.Forms.RadioButton();
            this.rbMin = new System.Windows.Forms.RadioButton();
            this.rbX = new System.Windows.Forms.RadioButton();
            this.rbDiv = new System.Windows.Forms.RadioButton();
            this.numInput1 = new System.Windows.Forms.NumericUpDown();
            this.numInput2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numInput1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInput2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(13, 61);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(136, 20);
            this.txtOutput.TabIndex = 999;
            this.txtOutput.TabStop = false;
            // 
            // rbPlus
            // 
            this.rbPlus.AutoSize = true;
            this.rbPlus.Location = new System.Drawing.Point(12, 12);
            this.rbPlus.Name = "rbPlus";
            this.rbPlus.Size = new System.Drawing.Size(31, 17);
            this.rbPlus.TabIndex = 995;
            this.rbPlus.Text = "+";
            this.rbPlus.UseVisualStyleBackColor = true;
            this.rbPlus.CheckedChanged += new System.EventHandler(this.rbPlus_CheckedChanged);
            // 
            // rbMin
            // 
            this.rbMin.AutoSize = true;
            this.rbMin.Location = new System.Drawing.Point(49, 12);
            this.rbMin.Name = "rbMin";
            this.rbMin.Size = new System.Drawing.Size(28, 17);
            this.rbMin.TabIndex = 996;
            this.rbMin.Text = "-";
            this.rbMin.UseVisualStyleBackColor = true;
            this.rbMin.CheckedChanged += new System.EventHandler(this.rbMin_CheckedChanged);
            // 
            // rbX
            // 
            this.rbX.AutoSize = true;
            this.rbX.Location = new System.Drawing.Point(83, 12);
            this.rbX.Name = "rbX";
            this.rbX.Size = new System.Drawing.Size(30, 17);
            this.rbX.TabIndex = 997;
            this.rbX.Text = "x";
            this.rbX.UseVisualStyleBackColor = true;
            this.rbX.CheckedChanged += new System.EventHandler(this.rbX_CheckedChanged);
            // 
            // rbDiv
            // 
            this.rbDiv.AutoSize = true;
            this.rbDiv.Location = new System.Drawing.Point(119, 12);
            this.rbDiv.Name = "rbDiv";
            this.rbDiv.Size = new System.Drawing.Size(30, 17);
            this.rbDiv.TabIndex = 998;
            this.rbDiv.Text = "/";
            this.rbDiv.UseVisualStyleBackColor = true;
            this.rbDiv.CheckedChanged += new System.EventHandler(this.rbDiv_CheckedChanged);
            // 
            // numInput1
            // 
            this.numInput1.Location = new System.Drawing.Point(13, 35);
            this.numInput1.Name = "numInput1";
            this.numInput1.Size = new System.Drawing.Size(70, 20);
            this.numInput1.TabIndex = 0;
            this.numInput1.ValueChanged += new System.EventHandler(this.numInput1_ValueChanged);
            // 
            // numInput2
            // 
            this.numInput2.Location = new System.Drawing.Point(79, 35);
            this.numInput2.Name = "numInput2";
            this.numInput2.Size = new System.Drawing.Size(70, 20);
            this.numInput2.TabIndex = 1;
            this.numInput2.ValueChanged += new System.EventHandler(this.numInput2_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(163, 110);
            this.Controls.Add(this.numInput2);
            this.Controls.Add(this.numInput1);
            this.Controls.Add(this.rbDiv);
            this.Controls.Add(this.rbX);
            this.Controls.Add(this.rbMin);
            this.Controls.Add(this.rbPlus);
            this.Controls.Add(this.txtOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numInput1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInput2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.RadioButton rbPlus;
        private System.Windows.Forms.RadioButton rbMin;
        private System.Windows.Forms.RadioButton rbX;
        private System.Windows.Forms.RadioButton rbDiv;
        private System.Windows.Forms.NumericUpDown numInput1;
        private System.Windows.Forms.NumericUpDown numInput2;
    }
}

