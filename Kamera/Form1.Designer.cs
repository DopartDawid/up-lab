namespace Kamera
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.contrastBar = new System.Windows.Forms.TrackBar();
            this.brightnessBar = new System.Windows.Forms.TrackBar();
            this.saturationBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.normalRadioButton = new System.Windows.Forms.RadioButton();
            this.BWradioButton1 = new System.Windows.Forms.RadioButton();
            this.grayRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.screenButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturationBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(398, 13);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(280, 164);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(553, 209);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(16, 245);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(653, 346);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 209);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "Record";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(124, 209);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 4;
            this.button3.Text = "Stop";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // contrastBar
            // 
            this.contrastBar.Location = new System.Drawing.Point(16, 29);
            this.contrastBar.Maximum = 100;
            this.contrastBar.Name = "contrastBar";
            this.contrastBar.Size = new System.Drawing.Size(208, 56);
            this.contrastBar.TabIndex = 5;
            this.contrastBar.TickFrequency = 10;
            this.contrastBar.Value = 50;
            this.contrastBar.ValueChanged += new System.EventHandler(this.contrastBar_ValueChanged);
            // 
            // brightnessBar
            // 
            this.brightnessBar.Location = new System.Drawing.Point(16, 84);
            this.brightnessBar.Maximum = 100;
            this.brightnessBar.Minimum = -100;
            this.brightnessBar.Name = "brightnessBar";
            this.brightnessBar.Size = new System.Drawing.Size(208, 56);
            this.brightnessBar.TabIndex = 6;
            this.brightnessBar.TickFrequency = 20;
            this.brightnessBar.ValueChanged += new System.EventHandler(this.brightnessBar_ValueChanged);
            // 
            // saturationBar
            // 
            this.saturationBar.Location = new System.Drawing.Point(16, 146);
            this.saturationBar.Maximum = 100;
            this.saturationBar.Minimum = -100;
            this.saturationBar.Name = "saturationBar";
            this.saturationBar.Size = new System.Drawing.Size(208, 56);
            this.saturationBar.TabIndex = 7;
            this.saturationBar.TickFrequency = 20;
            this.saturationBar.ValueChanged += new System.EventHandler(this.saturationBar_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Contrast";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Brightness";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Saturation";
            // 
            // normalRadioButton
            // 
            this.normalRadioButton.AutoSize = true;
            this.normalRadioButton.Checked = true;
            this.normalRadioButton.Location = new System.Drawing.Point(23, 21);
            this.normalRadioButton.Name = "normalRadioButton";
            this.normalRadioButton.Size = new System.Drawing.Size(74, 21);
            this.normalRadioButton.TabIndex = 11;
            this.normalRadioButton.TabStop = true;
            this.normalRadioButton.Text = "Normal";
            this.normalRadioButton.UseVisualStyleBackColor = true;
            this.normalRadioButton.CheckedChanged += new System.EventHandler(this.normalRadioButton_CheckedChanged);
            // 
            // BWradioButton1
            // 
            this.BWradioButton1.AutoSize = true;
            this.BWradioButton1.Location = new System.Drawing.Point(23, 91);
            this.BWradioButton1.Name = "BWradioButton1";
            this.BWradioButton1.Size = new System.Drawing.Size(131, 21);
            this.BWradioButton1.TabIndex = 13;
            this.BWradioButton1.Text = "Black and White";
            this.BWradioButton1.UseVisualStyleBackColor = true;
            this.BWradioButton1.CheckedChanged += new System.EventHandler(this.BWradioButton1_CheckedChanged);
            // 
            // grayRadioButton
            // 
            this.grayRadioButton.AutoSize = true;
            this.grayRadioButton.Location = new System.Drawing.Point(23, 56);
            this.grayRadioButton.Name = "grayRadioButton";
            this.grayRadioButton.Size = new System.Drawing.Size(60, 21);
            this.grayRadioButton.TabIndex = 14;
            this.grayRadioButton.TabStop = true;
            this.grayRadioButton.Text = "Gray";
            this.grayRadioButton.UseVisualStyleBackColor = true;
            this.grayRadioButton.CheckedChanged += new System.EventHandler(this.grayRadioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.normalRadioButton);
            this.groupBox1.Controls.Add(this.BWradioButton1);
            this.groupBox1.Controls.Add(this.grayRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(230, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 134);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(398, 209);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(79, 28);
            this.resetButton.TabIndex = 16;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // screenButton
            // 
            this.screenButton.Location = new System.Drawing.Point(312, 210);
            this.screenButton.Name = "screenButton";
            this.screenButton.Size = new System.Drawing.Size(79, 28);
            this.screenButton.TabIndex = 17;
            this.screenButton.Text = "Snapshot";
            this.screenButton.UseVisualStyleBackColor = true;
            this.screenButton.Click += new System.EventHandler(this.screenButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 604);
            this.Controls.Add(this.screenButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saturationBar);
            this.Controls.Add(this.brightnessBar);
            this.Controls.Add(this.contrastBar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Camera";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturationBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TrackBar contrastBar;
        private System.Windows.Forms.TrackBar brightnessBar;
        private System.Windows.Forms.TrackBar saturationBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton normalRadioButton;
        private System.Windows.Forms.RadioButton BWradioButton1;
        private System.Windows.Forms.RadioButton grayRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button screenButton;
    }
}

