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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(238, 344);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(117, 41);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Zakończ";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // recordingLabel
            // 
            this.recordingLabel.AutoSize = true;
            this.recordingLabel.Location = new System.Drawing.Point(235, 10);
            this.recordingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.recordingLabel.Name = "recordingLabel";
            this.recordingLabel.Size = new System.Drawing.Size(66, 13);
            this.recordingLabel.TabIndex = 1;
            this.recordingLabel.Text = "Nagrywanie:";
            // 
            // recordButton
            // 
            this.recordButton.Location = new System.Drawing.Point(237, 34);
            this.recordButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.recordButton.Name = "recordButton";
            this.recordButton.Size = new System.Drawing.Size(140, 30);
            this.recordButton.TabIndex = 2;
            this.recordButton.Text = "Nagrywaj";
            this.recordButton.UseVisualStyleBackColor = true;
            // 
            // recPauseButton
            // 
            this.recPauseButton.Location = new System.Drawing.Point(237, 82);
            this.recPauseButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.recPauseButton.Name = "recPauseButton";
            this.recPauseButton.Size = new System.Drawing.Size(139, 33);
            this.recPauseButton.TabIndex = 3;
            this.recPauseButton.Text = "Pauza";
            this.recPauseButton.UseVisualStyleBackColor = true;
            // 
            // recStopButton
            // 
            this.recStopButton.Location = new System.Drawing.Point(237, 128);
            this.recStopButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.recStopButton.Name = "recStopButton";
            this.recStopButton.Size = new System.Drawing.Size(136, 40);
            this.recStopButton.TabIndex = 4;
            this.recStopButton.Text = "Przerwij";
            this.recStopButton.UseVisualStyleBackColor = true;
            this.recStopButton.Click += new System.EventHandler(this.recStopButton_Click);
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Location = new System.Drawing.Point(20, 10);
            this.playerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(66, 13);
            this.playerLabel.TabIndex = 5;
            this.playerLabel.Text = "Odtwarzanie";
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(22, 38);
            this.playButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(139, 26);
            this.playButton.TabIndex = 6;
            this.playButton.Text = "Odtwarzaj";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(24, 82);
            this.stopButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(136, 33);
            this.stopButton.TabIndex = 7;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // fileButton
            // 
            this.fileButton.Location = new System.Drawing.Point(11, 345);
            this.fileButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(161, 40);
            this.fileButton.TabIndex = 8;
            this.fileButton.Text = "Wybierz plik";
            this.fileButton.UseVisualStyleBackColor = true;
            this.fileButton.Click += new System.EventHandler(this.fileButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(235, 188);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(138, 134);
            this.listBox1.TabIndex = 9;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 396);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.fileButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.recStopButton);
            this.Controls.Add(this.recPauseButton);
            this.Controls.Add(this.recordButton);
            this.Controls.Add(this.recordingLabel);
            this.Controls.Add(this.exitButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.ListBox listBox1;
    }
}

