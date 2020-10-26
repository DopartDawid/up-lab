namespace Skaner
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.scanImage = new System.Windows.Forms.PictureBox();
            this.scanButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.brightnessBar = new System.Windows.Forms.TrackBar();
            this.contrastBar = new System.Windows.Forms.TrackBar();
            this.scanerLabel = new System.Windows.Forms.Label();
            this.typeOfScanLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.typeOfScanCombo = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.scannerListBox = new System.Windows.Forms.ListBox();
            this.resolutionCombo = new System.Windows.Forms.ComboBox();
            this.resolutionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scanImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastBar)).BeginInit();
            this.SuspendLayout();
            // 
            // scanImage
            // 
            this.scanImage.Location = new System.Drawing.Point(512, 41);
            this.scanImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scanImage.Name = "scanImage";
            this.scanImage.Size = new System.Drawing.Size(345, 451);
            this.scanImage.TabIndex = 0;
            this.scanImage.TabStop = false;
            // 
            // scanButton
            // 
            this.scanButton.Location = new System.Drawing.Point(57, 437);
            this.scanButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(111, 53);
            this.scanButton.TabIndex = 1;
            this.scanButton.Text = "Skanuj";
            this.scanButton.UseVisualStyleBackColor = true;
            this.scanButton.Click += new System.EventHandler(this.scanBox_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(230, 437);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(111, 55);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Wyjdź";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // brightnessBar
            // 
            this.brightnessBar.Location = new System.Drawing.Point(56, 95);
            this.brightnessBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.brightnessBar.Maximum = 100;
            this.brightnessBar.Minimum = -100;
            this.brightnessBar.Name = "brightnessBar";
            this.brightnessBar.Size = new System.Drawing.Size(285, 56);
            this.brightnessBar.TabIndex = 4;
            this.brightnessBar.TickFrequency = 20;
            this.brightnessBar.Scroll += new System.EventHandler(this.brightnessBar_Scroll);
            // 
            // contrastBar
            // 
            this.contrastBar.LargeChange = 10;
            this.contrastBar.Location = new System.Drawing.Point(56, 162);
            this.contrastBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.contrastBar.Maximum = 100;
            this.contrastBar.Minimum = -100;
            this.contrastBar.Name = "contrastBar";
            this.contrastBar.Size = new System.Drawing.Size(285, 56);
            this.contrastBar.SmallChange = 10;
            this.contrastBar.TabIndex = 10;
            this.contrastBar.TickFrequency = 20;
            this.contrastBar.Scroll += new System.EventHandler(this.contrastBar_Scroll);
            // 
            // scanerLabel
            // 
            this.scanerLabel.AutoSize = true;
            this.scanerLabel.Location = new System.Drawing.Point(52, 11);
            this.scanerLabel.Name = "scanerLabel";
            this.scanerLabel.Size = new System.Drawing.Size(57, 17);
            this.scanerLabel.TabIndex = 6;
            this.scanerLabel.Text = "Skaner:";
            // 
            // typeOfScanLabel
            // 
            this.typeOfScanLabel.AutoSize = true;
            this.typeOfScanLabel.Location = new System.Drawing.Point(53, 220);
            this.typeOfScanLabel.Name = "typeOfScanLabel";
            this.typeOfScanLabel.Size = new System.Drawing.Size(134, 17);
            this.typeOfScanLabel.TabIndex = 8;
            this.typeOfScanLabel.Text = "Rodzaj skanowania:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Jasność:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kontrast";
            // 
            // typeOfScanCombo
            // 
            this.typeOfScanCombo.FormattingEnabled = true;
            this.typeOfScanCombo.Location = new System.Drawing.Point(56, 242);
            this.typeOfScanCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.typeOfScanCombo.Name = "typeOfScanCombo";
            this.typeOfScanCombo.Size = new System.Drawing.Size(285, 24);
            this.typeOfScanCombo.TabIndex = 11;
            this.typeOfScanCombo.SelectedIndexChanged += new System.EventHandler(this.typeOfScan_Box);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(61, 375);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(280, 28);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Zapisz do pliku";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // scannerListBox
            // 
            this.scannerListBox.FormattingEnabled = true;
            this.scannerListBox.ItemHeight = 16;
            this.scannerListBox.Location = new System.Drawing.Point(56, 31);
            this.scannerListBox.Margin = new System.Windows.Forms.Padding(4);
            this.scannerListBox.Name = "scannerListBox";
            this.scannerListBox.Size = new System.Drawing.Size(281, 36);
            this.scannerListBox.TabIndex = 13;
            // 
            // resolutionCombo
            // 
            this.resolutionCombo.FormattingEnabled = true;
            this.resolutionCombo.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "400",
            "500",
            "600"});
            this.resolutionCombo.Location = new System.Drawing.Point(61, 320);
            this.resolutionCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resolutionCombo.Name = "resolutionCombo";
            this.resolutionCombo.Size = new System.Drawing.Size(285, 24);
            this.resolutionCombo.TabIndex = 14;
            this.resolutionCombo.SelectedIndexChanged += new System.EventHandler(this.resolutionCombo_SelectedIndexChanged);
            // 
            // resolutionLabel
            // 
            this.resolutionLabel.AutoSize = true;
            this.resolutionLabel.Location = new System.Drawing.Point(58, 292);
            this.resolutionLabel.Name = "resolutionLabel";
            this.resolutionLabel.Size = new System.Drawing.Size(98, 17);
            this.resolutionLabel.TabIndex = 15;
            this.resolutionLabel.Text = "Rozdzielczość";
            this.resolutionLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 545);
            this.Controls.Add(this.resolutionLabel);
            this.Controls.Add(this.resolutionCombo);
            this.Controls.Add(this.scannerListBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.typeOfScanCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.typeOfScanLabel);
            this.Controls.Add(this.scanerLabel);
            this.Controls.Add(this.contrastBar);
            this.Controls.Add(this.brightnessBar);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.scanButton);
            this.Controls.Add(this.scanImage);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scanImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox scanImage;
        private System.Windows.Forms.Button scanButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TrackBar brightnessBar;
        private System.Windows.Forms.TrackBar contrastBar;
        private System.Windows.Forms.Label scanerLabel;
        private System.Windows.Forms.Label typeOfScanLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox typeOfScanCombo;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ListBox scannerListBox;
        private System.Windows.Forms.ComboBox resolutionCombo;
        private System.Windows.Forms.Label resolutionLabel;
    }
}

