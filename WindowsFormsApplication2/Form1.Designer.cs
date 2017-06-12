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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel = new System.Windows.Forms.Panel();
            this.PaintButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SizeComboBox = new System.Windows.Forms.ComboBox();
            this.ColorComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LineButton = new System.Windows.Forms.Button();
            this.PencilButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.InvertingButton = new System.Windows.Forms.Button();
            this.EraserButton = new System.Windows.Forms.Button();
            this.EraseAllButton = new System.Windows.Forms.Button();
            this.SaveProjectButton = new System.Windows.Forms.Button();
            this.XResizeTextBox = new System.Windows.Forms.TextBox();
            this.YResizeTextBox = new System.Windows.Forms.TextBox();
            this.ResizePanelButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "y1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "x2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "y2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "x1";
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.SystemColors.Control;
            this.Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Panel.Location = new System.Drawing.Point(315, 12);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(800, 600);
            this.Panel.TabIndex = 5;
            this.Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            this.Panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseClick);
            this.Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            this.Panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseUp);
            // 
            // PaintButton
            // 
            this.PaintButton.Location = new System.Drawing.Point(32, 218);
            this.PaintButton.Name = "PaintButton";
            this.PaintButton.Size = new System.Drawing.Size(75, 23);
            this.PaintButton.TabIndex = 6;
            this.PaintButton.Text = "Paint";
            this.PaintButton.UseVisualStyleBackColor = true;
            this.PaintButton.Click += new System.EventHandler(this.PaintButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(62, 22);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(45, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(62, 22);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(45, 140);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(62, 22);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(46, 177);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(61, 22);
            this.textBox4.TabIndex = 7;
            // 
            // SizeComboBox
            // 
            this.SizeComboBox.FormattingEnabled = true;
            this.SizeComboBox.Location = new System.Drawing.Point(20, 272);
            this.SizeComboBox.Name = "SizeComboBox";
            this.SizeComboBox.Size = new System.Drawing.Size(121, 24);
            this.SizeComboBox.TabIndex = 8;
            // 
            // ColorComboBox
            // 
            this.ColorComboBox.FormattingEnabled = true;
            this.ColorComboBox.Location = new System.Drawing.Point(20, 323);
            this.ColorComboBox.Name = "ColorComboBox";
            this.ColorComboBox.Size = new System.Drawing.Size(121, 24);
            this.ColorComboBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Size";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Color";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(211, 63);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(87, 25);
            this.SaveButton.TabIndex = 13;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LineButton
            // 
            this.LineButton.Location = new System.Drawing.Point(129, 62);
            this.LineButton.Name = "LineButton";
            this.LineButton.Size = new System.Drawing.Size(76, 27);
            this.LineButton.TabIndex = 14;
            this.LineButton.Text = "Line";
            this.LineButton.UseVisualStyleBackColor = true;
            this.LineButton.Click += new System.EventHandler(this.LineButton_Click);
            // 
            // PencilButton
            // 
            this.PencilButton.Location = new System.Drawing.Point(129, 100);
            this.PencilButton.Name = "PencilButton";
            this.PencilButton.Size = new System.Drawing.Size(76, 24);
            this.PencilButton.TabIndex = 15;
            this.PencilButton.Text = "Pencil";
            this.PencilButton.UseVisualStyleBackColor = true;
            this.PencilButton.Click += new System.EventHandler(this.PencilButton_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(211, 100);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(87, 24);
            this.OpenButton.TabIndex = 16;
            this.OpenButton.Text = "Open file";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // InvertingButton
            // 
            this.InvertingButton.Location = new System.Drawing.Point(165, 175);
            this.InvertingButton.Name = "InvertingButton";
            this.InvertingButton.Size = new System.Drawing.Size(87, 24);
            this.InvertingButton.TabIndex = 17;
            this.InvertingButton.Text = "Invert";
            this.InvertingButton.UseVisualStyleBackColor = true;
            this.InvertingButton.Click += new System.EventHandler(this.InvertingButton_Click);
            // 
            // EraserButton
            // 
            this.EraserButton.Location = new System.Drawing.Point(129, 137);
            this.EraserButton.Name = "EraserButton";
            this.EraserButton.Size = new System.Drawing.Size(75, 23);
            this.EraserButton.TabIndex = 18;
            this.EraserButton.Text = "Eraser";
            this.EraserButton.UseVisualStyleBackColor = true;
            this.EraserButton.Click += new System.EventHandler(this.EraserButton_Click);
            // 
            // EraseAllButton
            // 
            this.EraseAllButton.Location = new System.Drawing.Point(211, 137);
            this.EraseAllButton.Name = "EraseAllButton";
            this.EraseAllButton.Size = new System.Drawing.Size(87, 23);
            this.EraseAllButton.TabIndex = 19;
            this.EraseAllButton.Text = "Erase all";
            this.EraseAllButton.UseVisualStyleBackColor = true;
            this.EraseAllButton.Click += new System.EventHandler(this.EraseAllButton_Click);
            // 
            // SaveProjectButton
            // 
            this.SaveProjectButton.Location = new System.Drawing.Point(20, 12);
            this.SaveProjectButton.Name = "SaveProjectButton";
            this.SaveProjectButton.Size = new System.Drawing.Size(87, 45);
            this.SaveProjectButton.TabIndex = 20;
            this.SaveProjectButton.Text = "Save as project";
            this.SaveProjectButton.UseVisualStyleBackColor = true;
            this.SaveProjectButton.Click += new System.EventHandler(this.SaveProjectButton_Click);
            // 
            // XResizeTextBox
            // 
            this.XResizeTextBox.Location = new System.Drawing.Point(20, 394);
            this.XResizeTextBox.Name = "XResizeTextBox";
            this.XResizeTextBox.Size = new System.Drawing.Size(100, 22);
            this.XResizeTextBox.TabIndex = 25;
            // 
            // YResizeTextBox
            // 
            this.YResizeTextBox.Location = new System.Drawing.Point(20, 433);
            this.YResizeTextBox.Name = "YResizeTextBox";
            this.YResizeTextBox.Size = new System.Drawing.Size(100, 22);
            this.YResizeTextBox.TabIndex = 26;
            // 
            // ResizePanelButton
            // 
            this.ResizePanelButton.Location = new System.Drawing.Point(20, 468);
            this.ResizePanelButton.Name = "ResizePanelButton";
            this.ResizePanelButton.Size = new System.Drawing.Size(75, 42);
            this.ResizePanelButton.TabIndex = 27;
            this.ResizePanelButton.Text = "Resize panel";
            this.ResizePanelButton.UseVisualStyleBackColor = true;
            this.ResizePanelButton.Click += new System.EventHandler(this.ResizePanelButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(126, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "New X coordinates";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(126, 438);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "New Y coordinates";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 632);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ResizePanelButton);
            this.Controls.Add(this.YResizeTextBox);
            this.Controls.Add(this.XResizeTextBox);
            this.Controls.Add(this.SaveProjectButton);
            this.Controls.Add(this.EraseAllButton);
            this.Controls.Add(this.EraserButton);
            this.Controls.Add(this.InvertingButton);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.PencilButton);
            this.Controls.Add(this.LineButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ColorComboBox);
            this.Controls.Add(this.SizeComboBox);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PaintButton);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Button PaintButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox SizeComboBox;
        private System.Windows.Forms.ComboBox ColorComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LineButton;
        private System.Windows.Forms.Button PencilButton;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Button InvertingButton;
        private System.Windows.Forms.Button EraserButton;
        private System.Windows.Forms.Button EraseAllButton;
        private System.Windows.Forms.Button SaveProjectButton;
        private System.Windows.Forms.TextBox XResizeTextBox;
        private System.Windows.Forms.TextBox YResizeTextBox;
        private System.Windows.Forms.Button ResizePanelButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

