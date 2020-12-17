namespace Bluetooth
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
            this.adaptersListBox = new System.Windows.Forms.ListBox();
            this.devicesListBox = new System.Windows.Forms.ListBox();
            this.searchAdapterButton = new System.Windows.Forms.Button();
            this.adaptersInfoButton = new System.Windows.Forms.Button();
            this.searchDevicesButton = new System.Windows.Forms.Button();
            this.deviceInfoButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.sendFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adaptersListBox
            // 
            this.adaptersListBox.FormattingEnabled = true;
            this.adaptersListBox.ItemHeight = 16;
            this.adaptersListBox.Location = new System.Drawing.Point(50, 262);
            this.adaptersListBox.Name = "adaptersListBox";
            this.adaptersListBox.Size = new System.Drawing.Size(297, 116);
            this.adaptersListBox.TabIndex = 0;
            this.adaptersListBox.SelectedIndexChanged += new System.EventHandler(this.adaptersListBox_SelectedIndexChanged);
            // 
            // devicesListBox
            // 
            this.devicesListBox.FormattingEnabled = true;
            this.devicesListBox.ItemHeight = 16;
            this.devicesListBox.Location = new System.Drawing.Point(395, 262);
            this.devicesListBox.Name = "devicesListBox";
            this.devicesListBox.Size = new System.Drawing.Size(322, 116);
            this.devicesListBox.TabIndex = 1;
            this.devicesListBox.SelectedIndexChanged += new System.EventHandler(this.devicesListBox_SelectedIndexChanged);
            // 
            // searchAdapterButton
            // 
            this.searchAdapterButton.Location = new System.Drawing.Point(80, 81);
            this.searchAdapterButton.Name = "searchAdapterButton";
            this.searchAdapterButton.Size = new System.Drawing.Size(207, 46);
            this.searchAdapterButton.TabIndex = 2;
            this.searchAdapterButton.Text = "Search Adapters";
            this.searchAdapterButton.UseVisualStyleBackColor = true;
            this.searchAdapterButton.Click += new System.EventHandler(this.searchAdapterButton_Click);
            // 
            // adaptersInfoButton
            // 
            this.adaptersInfoButton.Location = new System.Drawing.Point(80, 172);
            this.adaptersInfoButton.Name = "adaptersInfoButton";
            this.adaptersInfoButton.Size = new System.Drawing.Size(207, 34);
            this.adaptersInfoButton.TabIndex = 3;
            this.adaptersInfoButton.Text = "Adapter Info";
            this.adaptersInfoButton.UseVisualStyleBackColor = true;
            this.adaptersInfoButton.Click += new System.EventHandler(this.adaptersInfoButton_Click);
            // 
            // searchDevicesButton
            // 
            this.searchDevicesButton.Location = new System.Drawing.Point(476, 37);
            this.searchDevicesButton.Name = "searchDevicesButton";
            this.searchDevicesButton.Size = new System.Drawing.Size(197, 40);
            this.searchDevicesButton.TabIndex = 4;
            this.searchDevicesButton.Text = "Search Devices";
            this.searchDevicesButton.UseVisualStyleBackColor = true;
            this.searchDevicesButton.Click += new System.EventHandler(this.searchDevicesButton_Click);
            // 
            // deviceInfoButton
            // 
            this.deviceInfoButton.Location = new System.Drawing.Point(476, 86);
            this.deviceInfoButton.Name = "deviceInfoButton";
            this.deviceInfoButton.Size = new System.Drawing.Size(197, 37);
            this.deviceInfoButton.TabIndex = 5;
            this.deviceInfoButton.Text = "Device Info";
            this.deviceInfoButton.UseVisualStyleBackColor = true;
            this.deviceInfoButton.Click += new System.EventHandler(this.deviceInfoButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(476, 176);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(197, 37);
            this.connectButton.TabIndex = 6;
            this.connectButton.Text = "Connect device";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // sendFileButton
            // 
            this.sendFileButton.Location = new System.Drawing.Point(476, 133);
            this.sendFileButton.Name = "sendFileButton";
            this.sendFileButton.Size = new System.Drawing.Size(197, 37);
            this.sendFileButton.TabIndex = 7;
            this.sendFileButton.Text = "Send File";
            this.sendFileButton.UseVisualStyleBackColor = true;
            this.sendFileButton.Click += new System.EventHandler(this.sendFileButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sendFileButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.deviceInfoButton);
            this.Controls.Add(this.searchDevicesButton);
            this.Controls.Add(this.adaptersInfoButton);
            this.Controls.Add(this.searchAdapterButton);
            this.Controls.Add(this.devicesListBox);
            this.Controls.Add(this.adaptersListBox);
            this.Name = "Form1";
            this.Text = "Bluetooth";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox adaptersListBox;
        private System.Windows.Forms.ListBox devicesListBox;
        private System.Windows.Forms.Button searchAdapterButton;
        private System.Windows.Forms.Button adaptersInfoButton;
        private System.Windows.Forms.Button searchDevicesButton;
        private System.Windows.Forms.Button deviceInfoButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button sendFileButton;
    }
}

