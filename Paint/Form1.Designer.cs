namespace Paint
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
            this.rbtnEllipse = new System.Windows.Forms.RadioButton();
            this.rbtnRectangle = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numPenWidth = new System.Windows.Forms.NumericUpDown();
            this.btnPenColor = new System.Windows.Forms.Button();
            this.rbtnString = new System.Windows.Forms.RadioButton();
            this.rbtnLine = new System.Windows.Forms.RadioButton();
            this.rbtnFillRectangle = new System.Windows.Forms.RadioButton();
            this.rbtnFillEllipse = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPenWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtnEllipse
            // 
            this.rbtnEllipse.AutoSize = true;
            this.rbtnEllipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnEllipse.Location = new System.Drawing.Point(55, 88);
            this.rbtnEllipse.Name = "rbtnEllipse";
            this.rbtnEllipse.Size = new System.Drawing.Size(64, 20);
            this.rbtnEllipse.TabIndex = 0;
            this.rbtnEllipse.TabStop = true;
            this.rbtnEllipse.Text = "Elipse";
            this.rbtnEllipse.UseVisualStyleBackColor = true;
            // 
            // rbtnRectangle
            // 
            this.rbtnRectangle.AutoSize = true;
            this.rbtnRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnRectangle.Location = new System.Drawing.Point(162, 88);
            this.rbtnRectangle.Name = "rbtnRectangle";
            this.rbtnRectangle.Size = new System.Drawing.Size(88, 20);
            this.rbtnRectangle.TabIndex = 1;
            this.rbtnRectangle.TabStop = true;
            this.rbtnRectangle.Text = "Rectangle";
            this.rbtnRectangle.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.btnClean);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(651, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 559);
            this.panel1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLoadImage);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 378);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 181);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Image";
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLoadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadImage.ForeColor = System.Drawing.Color.White;
            this.btnLoadImage.Location = new System.Drawing.Point(40, 105);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(210, 48);
            this.btnLoadImage.TabIndex = 8;
            this.btnLoadImage.Text = "Load Image";
            this.btnLoadImage.UseVisualStyleBackColor = false;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Point";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(210, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(60, 26);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(60, 26);
            this.textBox1.TabIndex = 0;
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.ForeColor = System.Drawing.Color.White;
            this.btnClean.Location = new System.Drawing.Point(40, 314);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(210, 48);
            this.btnClean.TabIndex = 7;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numPenWidth);
            this.groupBox1.Controls.Add(this.btnPenColor);
            this.groupBox1.Controls.Add(this.rbtnString);
            this.groupBox1.Controls.Add(this.rbtnLine);
            this.groupBox1.Controls.Add(this.rbtnFillRectangle);
            this.groupBox1.Controls.Add(this.rbtnFillEllipse);
            this.groupBox1.Controls.Add(this.rbtnEllipse);
            this.groupBox1.Controls.Add(this.rbtnRectangle);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 299);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Draw";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pen Width";
            // 
            // numPenWidth
            // 
            this.numPenWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPenWidth.Location = new System.Drawing.Point(118, 253);
            this.numPenWidth.Name = "numPenWidth";
            this.numPenWidth.Size = new System.Drawing.Size(132, 22);
            this.numPenWidth.TabIndex = 7;
            this.numPenWidth.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // btnPenColor
            // 
            this.btnPenColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPenColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPenColor.ForeColor = System.Drawing.Color.White;
            this.btnPenColor.Location = new System.Drawing.Point(40, 178);
            this.btnPenColor.Name = "btnPenColor";
            this.btnPenColor.Size = new System.Drawing.Size(210, 48);
            this.btnPenColor.TabIndex = 6;
            this.btnPenColor.Text = "Pen Color";
            this.btnPenColor.UseVisualStyleBackColor = false;
            this.btnPenColor.Click += new System.EventHandler(this.btnPenColor_Click);
            // 
            // rbtnString
            // 
            this.rbtnString.AutoSize = true;
            this.rbtnString.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnString.Location = new System.Drawing.Point(162, 46);
            this.rbtnString.Name = "rbtnString";
            this.rbtnString.Size = new System.Drawing.Size(60, 20);
            this.rbtnString.TabIndex = 5;
            this.rbtnString.TabStop = true;
            this.rbtnString.Text = "String";
            this.rbtnString.UseVisualStyleBackColor = true;
            // 
            // rbtnLine
            // 
            this.rbtnLine.AutoSize = true;
            this.rbtnLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnLine.Location = new System.Drawing.Point(55, 46);
            this.rbtnLine.Name = "rbtnLine";
            this.rbtnLine.Size = new System.Drawing.Size(51, 20);
            this.rbtnLine.TabIndex = 4;
            this.rbtnLine.TabStop = true;
            this.rbtnLine.Text = "Line";
            this.rbtnLine.UseVisualStyleBackColor = true;
            // 
            // rbtnFillRectangle
            // 
            this.rbtnFillRectangle.AutoSize = true;
            this.rbtnFillRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFillRectangle.Location = new System.Drawing.Point(162, 134);
            this.rbtnFillRectangle.Name = "rbtnFillRectangle";
            this.rbtnFillRectangle.Size = new System.Drawing.Size(108, 20);
            this.rbtnFillRectangle.TabIndex = 3;
            this.rbtnFillRectangle.TabStop = true;
            this.rbtnFillRectangle.Text = "Fill Rectangle";
            this.rbtnFillRectangle.UseVisualStyleBackColor = true;
            // 
            // rbtnFillEllipse
            // 
            this.rbtnFillEllipse.AutoSize = true;
            this.rbtnFillEllipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFillEllipse.Location = new System.Drawing.Point(55, 134);
            this.rbtnFillEllipse.Name = "rbtnFillEllipse";
            this.rbtnFillEllipse.Size = new System.Drawing.Size(84, 20);
            this.rbtnFillEllipse.TabIndex = 2;
            this.rbtnFillEllipse.TabStop = true;
            this.rbtnFillEllipse.Text = "Fill Elipse";
            this.rbtnFillEllipse.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(651, 559);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 559);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Paint";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPenWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnEllipse;
        private System.Windows.Forms.RadioButton rbtnRectangle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnFillEllipse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numPenWidth;
        private System.Windows.Forms.Button btnPenColor;
        private System.Windows.Forms.RadioButton rbtnString;
        private System.Windows.Forms.RadioButton rbtnLine;
        private System.Windows.Forms.RadioButton rbtnFillRectangle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

