namespace Laba_5
{
    partial class DeviceView
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
            this.devicesList = new System.Windows.Forms.ListView();
            this.GUIDcolumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HardwareId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Manufacter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Provider = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DescriptionDevice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PathToFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DriverPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StatusDevice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CanDisable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.waitGif = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.waitGif)).BeginInit();
            this.SuspendLayout();
            // 
            // devicesList
            // 
            this.devicesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.GUIDcolumn,
            this.HardwareId,
            this.Manufacter,
            this.Provider,
            this.DescriptionDevice,
            this.PathToFile,
            this.DriverPath,
            this.StatusDevice,
            this.CanDisable});
            this.devicesList.Location = new System.Drawing.Point(12, 12);
            this.devicesList.Name = "devicesList";
            this.devicesList.Size = new System.Drawing.Size(1186, 454);
            this.devicesList.TabIndex = 0;
            this.devicesList.UseCompatibleStateImageBehavior = false;
            this.devicesList.View = System.Windows.Forms.View.Details;
            this.devicesList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DisableEnableDevice);
            // 
            // GUIDcolumn
            // 
            this.GUIDcolumn.Text = "GUID";
            this.GUIDcolumn.Width = 189;
            // 
            // HardwareId
            // 
            this.HardwareId.Text = "Hardware Id";
            this.HardwareId.Width = 291;
            // 
            // Manufacter
            // 
            this.Manufacter.Text = "Manufacter";
            this.Manufacter.Width = 132;
            // 
            // Provider
            // 
            this.Provider.Text = "Provider";
            this.Provider.Width = 0;
            // 
            // DescriptionDevice
            // 
            this.DescriptionDevice.Text = "Description";
            this.DescriptionDevice.Width = 279;
            // 
            // PathToFile
            // 
            this.PathToFile.Text = "Path to .sys file";
            // 
            // DriverPath
            // 
            this.DriverPath.Text = "Path to driver";
            // 
            // StatusDevice
            // 
            this.StatusDevice.Text = "Status";
            this.StatusDevice.Width = 57;
            // 
            // CanDisable
            // 
            this.CanDisable.Text = "Is Run";
            // 
            // waitGif
            // 
            this.waitGif.Image = global::Laba_5.Properties.Resources._745;
            this.waitGif.Location = new System.Drawing.Point(472, 472);
            this.waitGif.Name = "waitGif";
            this.waitGif.Size = new System.Drawing.Size(256, 32);
            this.waitGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.waitGif.TabIndex = 1;
            this.waitGif.TabStop = false;
            // 
            // DeviceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1210, 514);
            this.Controls.Add(this.waitGif);
            this.Controls.Add(this.devicesList);
            this.Name = "DeviceView";
            this.Text = "Device Manager";
            this.Load += new System.EventHandler(this.LoadForm);
            ((System.ComponentModel.ISupportInitialize)(this.waitGif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView devicesList;
        private System.Windows.Forms.ColumnHeader GUIDcolumn;
        private System.Windows.Forms.ColumnHeader HardwareId;
        private System.Windows.Forms.ColumnHeader Manufacter;
        private System.Windows.Forms.ColumnHeader Provider;
        private System.Windows.Forms.ColumnHeader DescriptionDevice;
        private System.Windows.Forms.ColumnHeader PathToFile;
        private System.Windows.Forms.ColumnHeader DriverPath;
        private System.Windows.Forms.ColumnHeader StatusDevice;
        private System.Windows.Forms.ColumnHeader CanDisable;
        private System.Windows.Forms.PictureBox waitGif;
    }
}

