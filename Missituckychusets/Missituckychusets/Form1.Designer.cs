namespace Missituckychusets
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
            this.txtCanOne = new System.Windows.Forms.TextBox();
            this.txtCanTwo = new System.Windows.Forms.TextBox();
            this.txtDelagates = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCanTwoDel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCanOneDel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCanThreeDel = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCanOne
            // 
            this.txtCanOne.Location = new System.Drawing.Point(137, 11);
            this.txtCanOne.Name = "txtCanOne";
            this.txtCanOne.Size = new System.Drawing.Size(100, 20);
            this.txtCanOne.TabIndex = 0;
            // 
            // txtCanTwo
            // 
            this.txtCanTwo.Location = new System.Drawing.Point(137, 37);
            this.txtCanTwo.Name = "txtCanTwo";
            this.txtCanTwo.Size = new System.Drawing.Size(100, 20);
            this.txtCanTwo.TabIndex = 1;
            // 
            // txtDelagates
            // 
            this.txtDelagates.Location = new System.Drawing.Point(137, 63);
            this.txtDelagates.Name = "txtDelagates";
            this.txtDelagates.Size = new System.Drawing.Size(100, 20);
            this.txtDelagates.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Candidate 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Delegates:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Candidate 2:";
            // 
            // lblCanTwoDel
            // 
            this.lblCanTwoDel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCanTwoDel.Location = new System.Drawing.Point(137, 121);
            this.lblCanTwoDel.Name = "lblCanTwoDel";
            this.lblCanTwoDel.Size = new System.Drawing.Size(100, 20);
            this.lblCanTwoDel.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Candidate 2 Delegates:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Candidate 1 Delegates:";
            // 
            // lblCanOneDel
            // 
            this.lblCanOneDel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCanOneDel.Location = new System.Drawing.Point(137, 99);
            this.lblCanOneDel.Name = "lblCanOneDel";
            this.lblCanOneDel.Size = new System.Drawing.Size(100, 20);
            this.lblCanOneDel.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Candidate 3 Delegates:";
            // 
            // lblCanThreeDel
            // 
            this.lblCanThreeDel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCanThreeDel.Location = new System.Drawing.Point(137, 141);
            this.lblCanThreeDel.Name = "lblCanThreeDel";
            this.lblCanThreeDel.Size = new System.Drawing.Size(100, 20);
            this.lblCanThreeDel.TabIndex = 12;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(16, 164);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(221, 34);
            this.btnGo.TabIndex = 14;
            this.btnGo.Text = "Distribute Delegates";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 210);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblCanThreeDel);
            this.Controls.Add(this.lblCanOneDel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCanTwoDel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDelagates);
            this.Controls.Add(this.txtCanTwo);
            this.Controls.Add(this.txtCanOne);
            this.Name = "Form1";
            this.Text = "Delegates";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCanOne;
        private System.Windows.Forms.TextBox txtCanTwo;
        private System.Windows.Forms.TextBox txtDelagates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCanTwoDel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCanOneDel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCanThreeDel;
        private System.Windows.Forms.Button btnGo;
    }
}

