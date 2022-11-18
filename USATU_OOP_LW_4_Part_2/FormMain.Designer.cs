namespace USATU_OOP_LW_4_Part_2
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
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.numericUpDownA = new System.Windows.Forms.NumericUpDown();
            this.trackBarA = new System.Windows.Forms.TrackBar();
            this.labelInequality = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.numericUpDownB = new System.Windows.Forms.NumericUpDown();
            this.trackBarB = new System.Windows.Forms.TrackBar();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.numericUpDownC = new System.Windows.Forms.NumericUpDown();
            this.trackBarC = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDownA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.trackBarA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDownB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.trackBarB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDownC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.trackBarC)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(69, 147);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(120, 20);
            this.textBoxA.TabIndex = 0;
            this.textBoxA.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxA_KeyUp);
            this.textBoxA.Leave += new System.EventHandler(this.textBoxA_Leave);
            // 
            // numericUpDownA
            // 
            this.numericUpDownA.Location = new System.Drawing.Point(69, 173);
            this.numericUpDownA.Name = "numericUpDownA";
            this.numericUpDownA.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownA.TabIndex = 1;
            // 
            // trackBarA
            // 
            this.trackBarA.Location = new System.Drawing.Point(70, 199);
            this.trackBarA.Name = "trackBarA";
            this.trackBarA.Size = new System.Drawing.Size(119, 45);
            this.trackBarA.TabIndex = 2;
            // 
            // labelInequality
            // 
            this.labelInequality.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.labelInequality.Location = new System.Drawing.Point(12, 9);
            this.labelInequality.Name = "labelInequality";
            this.labelInequality.Size = new System.Drawing.Size(549, 135);
            this.labelInequality.TabIndex = 3;
            this.labelInequality.Text = "A <= B <= C";
            this.labelInequality.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(221, 147);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(120, 20);
            this.textBoxB.TabIndex = 0;
            this.textBoxB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxB_KeyUp);
            this.textBoxB.Leave += new System.EventHandler(this.textBoxB_Leave);
            // 
            // numericUpDownB
            // 
            this.numericUpDownB.Location = new System.Drawing.Point(221, 173);
            this.numericUpDownB.Name = "numericUpDownB";
            this.numericUpDownB.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownB.TabIndex = 1;
            // 
            // trackBarB
            // 
            this.trackBarB.Location = new System.Drawing.Point(222, 199);
            this.trackBarB.Name = "trackBarB";
            this.trackBarB.Size = new System.Drawing.Size(119, 45);
            this.trackBarB.TabIndex = 2;
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(375, 147);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(120, 20);
            this.textBoxC.TabIndex = 0;
            this.textBoxC.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxC_KeyUp);
            this.textBoxC.Leave += new System.EventHandler(this.textBoxC_Leave);
            // 
            // numericUpDownC
            // 
            this.numericUpDownC.Location = new System.Drawing.Point(375, 173);
            this.numericUpDownC.Name = "numericUpDownC";
            this.numericUpDownC.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownC.TabIndex = 1;
            // 
            // trackBarC
            // 
            this.trackBarC.Location = new System.Drawing.Point(376, 199);
            this.trackBarC.Name = "trackBarC";
            this.trackBarC.Size = new System.Drawing.Size(119, 45);
            this.trackBarC.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 261);
            this.Controls.Add(this.labelInequality);
            this.Controls.Add(this.trackBarC);
            this.Controls.Add(this.trackBarB);
            this.Controls.Add(this.trackBarA);
            this.Controls.Add(this.numericUpDownC);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.numericUpDownB);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.numericUpDownA);
            this.Controls.Add(this.textBoxA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormMain";
            this.Text = "LW 4";
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDownA)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.trackBarA)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDownB)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.trackBarB)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDownC)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.trackBarC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.NumericUpDown numericUpDownB;
        private System.Windows.Forms.TrackBar trackBarB;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.NumericUpDown numericUpDownC;
        private System.Windows.Forms.TrackBar trackBarC;

        private System.Windows.Forms.TrackBar trackBarA;
        private System.Windows.Forms.Label labelInequality;

        private System.Windows.Forms.NumericUpDown numericUpDownA;

        private System.Windows.Forms.TextBox textBoxA;

        #endregion
    }
}