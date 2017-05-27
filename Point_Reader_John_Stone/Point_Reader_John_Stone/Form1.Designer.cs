namespace Point_Reader_John_Stone
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
            this.picBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.getFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.drawLine = new System.Windows.Forms.Button();
            this.lineBox = new System.Windows.Forms.TextBox();
            this.lineCheck = new System.Windows.Forms.CheckBox();
            this.nnButton = new System.Windows.Forms.Button();
            this.hButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.convexHull = new System.Windows.Forms.Button();
            this.randAlg = new System.Windows.Forms.Button();
            this.totalDistBox = new System.Windows.Forms.TextBox();
            this.gridBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBox.Location = new System.Drawing.Point(0, 24);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(1306, 668);
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getFileToolStripMenuItem,
            this.saveFileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1306, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // getFileToolStripMenuItem
            // 
            this.getFileToolStripMenuItem.Name = "getFileToolStripMenuItem";
            this.getFileToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.getFileToolStripMenuItem.Text = "Get File";
            this.getFileToolStripMenuItem.Click += new System.EventHandler(this.getFileToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.saveFileToolStripMenuItem.Text = "Save File";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Scale Factor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(144, 1);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(49, 20);
            this.textBox.TabIndex = 3;
            this.textBox.Text = "1";
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(280, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(65, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "2";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(351, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Dot Size";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // drawLine
            // 
            this.drawLine.Location = new System.Drawing.Point(484, -1);
            this.drawLine.Name = "drawLine";
            this.drawLine.Size = new System.Drawing.Size(75, 23);
            this.drawLine.TabIndex = 6;
            this.drawLine.Text = "Line Size";
            this.drawLine.UseVisualStyleBackColor = true;
            this.drawLine.Click += new System.EventHandler(this.drawLine_Click);
            // 
            // lineBox
            // 
            this.lineBox.Location = new System.Drawing.Point(432, 2);
            this.lineBox.Name = "lineBox";
            this.lineBox.Size = new System.Drawing.Size(46, 20);
            this.lineBox.TabIndex = 7;
            this.lineBox.Text = "2";
            this.lineBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lineCheck
            // 
            this.lineCheck.AutoSize = true;
            this.lineCheck.Location = new System.Drawing.Point(565, 2);
            this.lineCheck.Name = "lineCheck";
            this.lineCheck.Size = new System.Drawing.Size(54, 17);
            this.lineCheck.TabIndex = 9;
            this.lineCheck.Text = "Lines ";
            this.lineCheck.UseVisualStyleBackColor = true;
            this.lineCheck.CheckedChanged += new System.EventHandler(this.lineCheck_CheckedChanged);
            // 
            // nnButton
            // 
            this.nnButton.Location = new System.Drawing.Point(625, 0);
            this.nnButton.Name = "nnButton";
            this.nnButton.Size = new System.Drawing.Size(120, 23);
            this.nnButton.TabIndex = 12;
            this.nnButton.Text = "Nearest Neighbor";
            this.nnButton.UseVisualStyleBackColor = true;
            this.nnButton.Click += new System.EventHandler(this.nnButton_Click);
            // 
            // hButton
            // 
            this.hButton.Location = new System.Drawing.Point(751, -1);
            this.hButton.Name = "hButton";
            this.hButton.Size = new System.Drawing.Size(75, 23);
            this.hButton.TabIndex = 13;
            this.hButton.Text = "Heuristic";
            this.hButton.UseVisualStyleBackColor = true;
            this.hButton.Click += new System.EventHandler(this.hButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(832, -2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Heuristic 2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // convexHull
            // 
            this.convexHull.Location = new System.Drawing.Point(913, -2);
            this.convexHull.Name = "convexHull";
            this.convexHull.Size = new System.Drawing.Size(75, 23);
            this.convexHull.TabIndex = 15;
            this.convexHull.Text = "Convex Hull";
            this.convexHull.UseVisualStyleBackColor = true;
            this.convexHull.Click += new System.EventHandler(this.convexHull_Click);
            // 
            // randAlg
            // 
            this.randAlg.Location = new System.Drawing.Point(994, -1);
            this.randAlg.Name = "randAlg";
            this.randAlg.Size = new System.Drawing.Size(75, 23);
            this.randAlg.TabIndex = 16;
            this.randAlg.Text = "Random";
            this.randAlg.UseVisualStyleBackColor = true;
            this.randAlg.Click += new System.EventHandler(this.randAlg_Click);
            // 
            // totalDistBox
            // 
            this.totalDistBox.Location = new System.Drawing.Point(1206, 672);
            this.totalDistBox.Name = "totalDistBox";
            this.totalDistBox.Size = new System.Drawing.Size(100, 20);
            this.totalDistBox.TabIndex = 17;
            // 
            // gridBox
            // 
            this.gridBox.Location = new System.Drawing.Point(1075, 1);
            this.gridBox.Name = "gridBox";
            this.gridBox.Size = new System.Drawing.Size(67, 20);
            this.gridBox.TabIndex = 18;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1148, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "Grid Size";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1229, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 20;
            this.button5.Text = "Run Grid";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 692);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.gridBox);
            this.Controls.Add(this.totalDistBox);
            this.Controls.Add(this.randAlg);
            this.Controls.Add(this.convexHull);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.hButton);
            this.Controls.Add(this.nnButton);
            this.Controls.Add(this.lineCheck);
            this.Controls.Add(this.lineBox);
            this.Controls.Add(this.drawLine);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Point Locations";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem getFileToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button drawLine;
        private System.Windows.Forms.TextBox lineBox;
        private System.Windows.Forms.CheckBox lineCheck;
        private System.Windows.Forms.Button nnButton;
        private System.Windows.Forms.Button hButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.Button convexHull;
        private System.Windows.Forms.Button randAlg;
        private System.Windows.Forms.TextBox totalDistBox;
        private System.Windows.Forms.TextBox gridBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

