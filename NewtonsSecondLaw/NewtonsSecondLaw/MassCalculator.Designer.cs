namespace NewtonsSecondLaw
{
    partial class MassCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtForce = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radEarth = new System.Windows.Forms.RadioButton();
            this.radMars = new System.Windows.Forms.RadioButton();
            this.radMoon = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblMass = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblEquation = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Anchor Steam NF", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(62, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Newton\'s Second Law";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("High Tower Text", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(127, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mass Calculator";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.IndianRed;
            this.groupBox1.Location = new System.Drawing.Point(7, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 259);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please Input Force in Newtons and Select an Acceleration";
            // 
            // txtForce
            // 
            this.txtForce.Location = new System.Drawing.Point(6, 29);
            this.txtForce.Name = "txtForce";
            this.txtForce.Size = new System.Drawing.Size(166, 30);
            this.txtForce.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtForce);
            this.groupBox2.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox2.Location = new System.Drawing.Point(28, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 68);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Force in Newtons";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radMoon);
            this.groupBox3.Controls.Add(this.radMars);
            this.groupBox3.Controls.Add(this.radEarth);
            this.groupBox3.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox3.Location = new System.Drawing.Point(212, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(178, 142);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Acceleration Options";
            // 
            // radEarth
            // 
            this.radEarth.AutoSize = true;
            this.radEarth.Font = new System.Drawing.Font("High Tower Text", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEarth.Location = new System.Drawing.Point(6, 24);
            this.radEarth.Name = "radEarth";
            this.radEarth.Size = new System.Drawing.Size(94, 23);
            this.radEarth.TabIndex = 0;
            this.radEarth.TabStop = true;
            this.radEarth.Text = "Earth (9.8)";
            this.radEarth.UseVisualStyleBackColor = true;
            // 
            // radMars
            // 
            this.radMars.AutoSize = true;
            this.radMars.Font = new System.Drawing.Font("High Tower Text", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMars.Location = new System.Drawing.Point(6, 62);
            this.radMars.Name = "radMars";
            this.radMars.Size = new System.Drawing.Size(90, 23);
            this.radMars.TabIndex = 1;
            this.radMars.TabStop = true;
            this.radMars.Text = "Mars (3.8)";
            this.radMars.UseVisualStyleBackColor = true;
            // 
            // radMoon
            // 
            this.radMoon.AutoSize = true;
            this.radMoon.Font = new System.Drawing.Font("High Tower Text", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMoon.Location = new System.Drawing.Point(6, 100);
            this.radMoon.Name = "radMoon";
            this.radMoon.Size = new System.Drawing.Size(103, 23);
            this.radMoon.TabIndex = 2;
            this.radMoon.TabStop = true;
            this.radMoon.Text = "Moon (1.625)";
            this.radMoon.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblMass);
            this.groupBox4.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox4.Location = new System.Drawing.Point(28, 103);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(178, 68);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Calculated Mass";
            // 
            // lblMass
            // 
            this.lblMass.ForeColor = System.Drawing.Color.IndianRed;
            this.lblMass.Location = new System.Drawing.Point(6, 26);
            this.lblMass.Name = "lblMass";
            this.lblMass.Size = new System.Drawing.Size(166, 28);
            this.lblMass.TabIndex = 4;
            this.lblMass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblEquation);
            this.groupBox5.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox5.Location = new System.Drawing.Point(28, 185);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(362, 68);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Final Equation";
            // 
            // lblEquation
            // 
            this.lblEquation.ForeColor = System.Drawing.Color.IndianRed;
            this.lblEquation.Location = new System.Drawing.Point(12, 26);
            this.lblEquation.Name = "lblEquation";
            this.lblEquation.Size = new System.Drawing.Size(344, 28);
            this.lblEquation.TabIndex = 4;
            this.lblEquation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Anchor Steam NF", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.IndianRed;
            this.btnCalculate.Location = new System.Drawing.Point(122, 377);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(206, 60);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate Mass";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // MassCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 451);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MassCalculator";
            this.Text = "MassCalculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblEquation;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblMass;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radMoon;
        private System.Windows.Forms.RadioButton radMars;
        private System.Windows.Forms.RadioButton radEarth;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtForce;
        private System.Windows.Forms.Button btnCalculate;
    }
}