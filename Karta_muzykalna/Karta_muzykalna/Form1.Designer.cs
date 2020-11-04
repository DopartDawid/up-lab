namespace Karta_muzykalna
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
            this.exitButton = new System.Windows.Forms.Button();
            this.recordingLabel = new System.Windows.Forms.Label();
            this.recordButton = new System.Windows.Forms.Button();
            this.recPauseButton = new System.Windows.Forms.Button();
            this.recStopButton = new System.Windows.Forms.Button();
            this.playerLabel = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.fileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(316, 359);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(156, 50);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Zakończ";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // recordingLabel
            // 
            this.recordingLabel.AutoSize = true;
            this.recordingLabel.Location = new System.Drawing.Point(313, 12);
            this.recordingLabel.Name = "recordingLabel";
            this.recordingLabel.Size = new System.Drawing.Size(86, 17);
            this.recordingLabel.TabIndex = 1;
            this.recordingLabel.Text = "Nagrywanie:";
            // 
            // recordButton
            // 
            this.recordButton.Location = new System.Drawing.Point(316, 42);
            this.recordButton.Name = "recordButton";
            this.recordButton.Size = new System.Drawing.Size(186, 37);
            this.recordButton.TabIndex = 2;
            this.recordButton.Text = "Nagrywaj";
            this.recordButton.UseVisualStyleBackColor = true;
            // 
            // recPauseButton
            // 
            this.recPauseButton.Location = new System.Drawing.Point(316, 101);
            this.recPauseButton.Name = "recPauseButton";
            this.recPauseButton.Size = new System.Drawing.Size(185, 41);
            this.recPauseButton.TabIndex = 3;
            this.recPauseButton.Text = "Pauza";
            this.recPauseButton.UseVisualStyleBackColor = true;
            // 
            // recStopButton
            // 
            this.recStopButton.Location = new System.Drawing.Point(316, 158);
            this.recStopButton.Name = "recStopButton";
            this.recStopButton.Size = new System.Drawing.Size(181, 49);
            this.recStopButton.TabIndex = 4;
            this.recStopButton.Text = "Przerwij";
            this.recStopButton.UseVisualStyleBackColor = true;
            this.recStopButton.Click += new System.EventHandler(this.recStopButton_Click);
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Location = new System.Drawing.Point(26, 12);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(87, 17);
            this.playerLabel.TabIndex = 5;
            this.playerLabel.Text = "Odtwarzanie";
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(29, 47);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(185, 32);
            this.playButton.TabIndex = 6;
            this.playButton.Text = "Odtwarzaj";
            this.playButton.UseVisualStyleBackColor = true;
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(32, 101);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(182, 41);
            this.stopButton.TabIndex = 7;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            // 
            // fileButton
            // 
            this.fileButton.Location = new System.Drawing.Point(41, 279);
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(215, 49);
            this.fileButton.TabIndex = 8;
            this.fileButton.Text = "Wybierz plik";
            this.fileButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 488);
            this.Controls.Add(this.fileButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.recStopButton);
            this.Controls.Add(this.recPauseButton);
            this.Controls.Add(this.recordButton);
            this.Controls.Add(this.recordingLabel);
            this.Controls.Add(this.exitButton);
            this.Name = "Form1";
            this.Text = "Karta_muzyczna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label recordingLabel;
        private System.Windows.Forms.Button recordButton;
        private System.Windows.Forms.Button recPauseButton;
        private System.Windows.Forms.Button recStopButton;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button fileButton;
    }
}

