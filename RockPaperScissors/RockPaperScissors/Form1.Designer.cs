namespace RockPaperScissors
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
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRock = new System.Windows.Forms.Label();
            this.lblPaper = new System.Windows.Forms.Label();
            this.lblScissors = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picklePicturePaper = new System.Windows.Forms.PictureBox();
            this.duckPictureRock = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picklePicturePaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duckPictureRock)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(710, 111);
            this.label1.TabIndex = 0;
            this.label1.Text = "Duck beats Becca\r\nBecca beats Pickle\r\nPickle beats Duck";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRock
            // 
            this.btnRock.Font = new System.Drawing.Font("Century", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRock.Location = new System.Drawing.Point(50, 333);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(125, 52);
            this.btnRock.TabIndex = 5;
            this.btnRock.Text = "Duck";
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.Font = new System.Drawing.Font("Century", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnPaper.Location = new System.Drawing.Point(311, 333);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(125, 52);
            this.btnPaper.TabIndex = 6;
            this.btnPaper.Text = "Pickle";
            this.btnPaper.UseVisualStyleBackColor = true;
            // 
            // btnScissors
            // 
            this.btnScissors.Font = new System.Drawing.Font("Century", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnScissors.Location = new System.Drawing.Point(552, 333);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(125, 52);
            this.btnScissors.TabIndex = 7;
            this.btnScissors.Text = "Becca";
            this.btnScissors.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Score:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(549, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Score:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Score:";
            // 
            // lblRock
            // 
            this.lblRock.AutoSize = true;
            this.lblRock.Location = new System.Drawing.Point(91, 317);
            this.lblRock.Name = "lblRock";
            this.lblRock.Size = new System.Drawing.Size(0, 13);
            this.lblRock.TabIndex = 14;
            // 
            // lblPaper
            // 
            this.lblPaper.AutoSize = true;
            this.lblPaper.Location = new System.Drawing.Point(352, 317);
            this.lblPaper.Name = "lblPaper";
            this.lblPaper.Size = new System.Drawing.Size(0, 13);
            this.lblPaper.TabIndex = 15;
            // 
            // lblScissors
            // 
            this.lblScissors.AutoSize = true;
            this.lblScissors.Location = new System.Drawing.Point(587, 317);
            this.lblScissors.Name = "lblScissors";
            this.lblScissors.Size = new System.Drawing.Size(0, 13);
            this.lblScissors.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RockPaperScissors.Properties.Resources.happy;
            this.pictureBox1.Location = new System.Drawing.Point(188, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // picklePicturePaper
            // 
            this.picklePicturePaper.Image = global::RockPaperScissors.Properties.Resources.unnamed;
            this.picklePicturePaper.Location = new System.Drawing.Point(188, 113);
            this.picklePicturePaper.Name = "picklePicturePaper";
            this.picklePicturePaper.Size = new System.Drawing.Size(308, 191);
            this.picklePicturePaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picklePicturePaper.TabIndex = 18;
            this.picklePicturePaper.TabStop = false;
            this.picklePicturePaper.Visible = false;
            // 
            // duckPictureRock
            // 
            this.duckPictureRock.Image = global::RockPaperScissors.Properties.Resources.source;
            this.duckPictureRock.Location = new System.Drawing.Point(188, 113);
            this.duckPictureRock.Name = "duckPictureRock";
            this.duckPictureRock.Size = new System.Drawing.Size(306, 191);
            this.duckPictureRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.duckPictureRock.TabIndex = 17;
            this.duckPictureRock.TabStop = false;
            this.duckPictureRock.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(705, 397);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picklePicturePaper);
            this.Controls.Add(this.duckPictureRock);
            this.Controls.Add(this.lblScissors);
            this.Controls.Add(this.lblPaper);
            this.Controls.Add(this.lblRock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picklePicturePaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duckPictureRock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button btnRock;
        internal System.Windows.Forms.Button btnPaper;
        internal System.Windows.Forms.Button btnScissors;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label lblRock;
        internal System.Windows.Forms.Label lblPaper;
        internal System.Windows.Forms.Label lblScissors;
        private System.Windows.Forms.PictureBox duckPictureRock;
        private System.Windows.Forms.PictureBox picklePicturePaper;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}

