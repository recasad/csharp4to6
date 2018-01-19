namespace GreenvilleRevenueGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Revenue = new System.Windows.Forms.Label();
            this.PreviousContestants = new System.Windows.Forms.TextBox();
            this.CurrentContestants = new System.Windows.Forms.TextBox();
            this.MoreOrLess = new System.Windows.Forms.Label();
            this.CalculateRev = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please input the current number of contestants:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please input the previous number of contestants:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Expected Revenue:";
            // 
            // Revenue
            // 
            this.Revenue.AccessibleName = "Revenue";
            this.Revenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Revenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Revenue.Location = new System.Drawing.Point(173, 90);
            this.Revenue.Name = "Revenue";
            this.Revenue.Size = new System.Drawing.Size(189, 41);
            this.Revenue.TabIndex = 7;
            this.Revenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PreviousContestants
            // 
            this.PreviousContestants.AccessibleName = "PreviousContestants";
            this.PreviousContestants.Location = new System.Drawing.Point(262, 59);
            this.PreviousContestants.Name = "PreviousContestants";
            this.PreviousContestants.Size = new System.Drawing.Size(100, 20);
            this.PreviousContestants.TabIndex = 8;
            // 
            // CurrentContestants
            // 
            this.CurrentContestants.AccessibleName = "CurrentContestants";
            this.CurrentContestants.Location = new System.Drawing.Point(262, 30);
            this.CurrentContestants.Name = "CurrentContestants";
            this.CurrentContestants.Size = new System.Drawing.Size(100, 20);
            this.CurrentContestants.TabIndex = 9;
            // 
            // MoreOrLess
            // 
            this.MoreOrLess.AccessibleName = "MoreOrLess";
            this.MoreOrLess.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MoreOrLess.Location = new System.Drawing.Point(19, 210);
            this.MoreOrLess.Name = "MoreOrLess";
            this.MoreOrLess.Size = new System.Drawing.Size(343, 100);
            this.MoreOrLess.TabIndex = 10;
            // 
            // CalculateRev
            // 
            this.CalculateRev.AccessibleName = "CalcualteRev";
            this.CalculateRev.Location = new System.Drawing.Point(125, 134);
            this.CalculateRev.Name = "CalculateRev";
            this.CalculateRev.Size = new System.Drawing.Size(116, 59);
            this.CalculateRev.TabIndex = 11;
            this.CalculateRev.Text = "Calculate Revenue";
            this.CalculateRev.UseVisualStyleBackColor = true;
            this.CalculateRev.Click += new System.EventHandler(this.CalculateRev_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 319);
            this.Controls.Add(this.CalculateRev);
            this.Controls.Add(this.MoreOrLess);
            this.Controls.Add(this.CurrentContestants);
            this.Controls.Add(this.PreviousContestants);
            this.Controls.Add(this.Revenue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Revenue;
        private System.Windows.Forms.TextBox PreviousContestants;
        private System.Windows.Forms.TextBox CurrentContestants;
        private System.Windows.Forms.Label MoreOrLess;
        private System.Windows.Forms.Button CalculateRev;
    }
}

