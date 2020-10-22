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
            this.scanerBox = new System.Windows.Forms.TextBox();
            this.brightnessBar = new System.Windows.Forms.TrackBar();
            this.contrastBar = new System.Windows.Forms.TrackBar();
            this.scanerLabel = new System.Windows.Forms.Label();
            this.typeOfScanLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.typeOfScanCombo = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scanImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastBar)).BeginInit();
            this.SuspendLayout();
            // 
            // scanImage
            // 
            this.scanImage.Location = new System.Drawing.Point(466, 35);
            this.scanImage.Name = "scanImage";
            this.scanImage.Size = new System.Drawing.Size(286, 379);
            this.scanImage.TabIndex = 0;
            this.scanImage.TabStop = false;
            // 
            // scanButton
            // 
            this.scanButton.Location = new System.Drawing.Point(56, 361);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(111, 53);
            this.scanButton.TabIndex = 1;
            this.scanButton.Text = "Skanuj";
            this.scanButton.UseVisualStyleBackColor = true;
            this.scanButton.Click += new System.EventHandler(this.scanBox_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(230, 361);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(111, 55);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Wyjdź";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // scanerBox
            // 
            this.scanerBox.Location = new System.Drawing.Point(56, 35);
            this.scanerBox.Name = "scanerBox";
            this.scanerBox.Size = new System.Drawing.Size(285, 22);
            this.scanerBox.TabIndex = 3;
            // 
            // brightnessBar
            // 
            this.brightnessBar.Location = new System.Drawing.Point(56, 95);
            this.brightnessBar.Name = "brightnessBar";
            this.brightnessBar.Size = new System.Drawing.Size(285, 56);
            this.brightnessBar.TabIndex = 4;
            this.brightnessBar.Scroll += new System.EventHandler(this.brightnessBar_Scroll);
            // 
            // contrastBar
            // 
            this.contrastBar.Location = new System.Drawing.Point(56, 161);
            this.contrastBar.Name = "contrastBar";
            this.contrastBar.Size = new System.Drawing.Size(285, 56);
            this.contrastBar.TabIndex = 5;
            this.contrastBar.Scroll += new System.EventHandler(this.contrastBar_Scroll);
            // 
            // scanerLabel
            // 
            this.scanerLabel.AutoSize = true;
            this.scanerLabel.Location = new System.Drawing.Point(53, 15);
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
            this.typeOfScanCombo.Location = new System.Drawing.Point(56, 243);
            this.typeOfScanCombo.Name = "typeOfScanCombo";
            this.typeOfScanCombo.Size = new System.Drawing.Size(285, 24);
            this.typeOfScanCombo.TabIndex = 11;
            this.typeOfScanCombo.SelectedIndexChanged += new System.EventHandler(this.typeOfScan_Box);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(60, 299);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(280, 28);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Zapisz do pliku";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.typeOfScanCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.typeOfScanLabel);
            this.Controls.Add(this.scanerLabel);
            this.Controls.Add(this.contrastBar);
            this.Controls.Add(this.brightnessBar);
            this.Controls.Add(this.scanerBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.scanButton);
            this.Controls.Add(this.scanImage);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.TextBox scanerBox;
        private System.Windows.Forms.TrackBar brightnessBar;
        private System.Windows.Forms.TrackBar contrastBar;
        private System.Windows.Forms.Label scanerLabel;
        private System.Windows.Forms.Label typeOfScanLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox typeOfScanCombo;
        private System.Windows.Forms.Button saveButton;
    }
}

