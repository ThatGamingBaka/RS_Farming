namespace RS_Farming
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
            this.AllotmentCrops = new System.Windows.Forms.ComboBox();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.AllotmentsLabel = new System.Windows.Forms.Label();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.Locations = new System.Windows.Forms.ComboBox();
            this.AllotmentsHarvestTime = new System.Windows.Forms.Label();
            this.AllotmentPlant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AllotmentCrops
            // 
            this.AllotmentCrops.FormattingEnabled = true;
            this.AllotmentCrops.Location = new System.Drawing.Point(15, 94);
            this.AllotmentCrops.Name = "AllotmentCrops";
            this.AllotmentCrops.Size = new System.Drawing.Size(231, 21);
            this.AllotmentCrops.TabIndex = 0;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(12, 12);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshButton.TabIndex = 1;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // AllotmentsLabel
            // 
            this.AllotmentsLabel.AutoSize = true;
            this.AllotmentsLabel.Location = new System.Drawing.Point(12, 78);
            this.AllotmentsLabel.Name = "AllotmentsLabel";
            this.AllotmentsLabel.Size = new System.Drawing.Size(55, 13);
            this.AllotmentsLabel.TabIndex = 3;
            this.AllotmentsLabel.Text = "Allotments";
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Location = new System.Drawing.Point(12, 38);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(48, 13);
            this.LocationLabel.TabIndex = 4;
            this.LocationLabel.Text = "Location";
            // 
            // Locations
            // 
            this.Locations.FormattingEnabled = true;
            this.Locations.Location = new System.Drawing.Point(15, 54);
            this.Locations.Name = "Locations";
            this.Locations.Size = new System.Drawing.Size(231, 21);
            this.Locations.TabIndex = 5;
            // 
            // AllotmentsHarvestTime
            // 
            this.AllotmentsHarvestTime.AutoSize = true;
            this.AllotmentsHarvestTime.Location = new System.Drawing.Point(252, 97);
            this.AllotmentsHarvestTime.Name = "AllotmentsHarvestTime";
            this.AllotmentsHarvestTime.Size = new System.Drawing.Size(22, 13);
            this.AllotmentsHarvestTime.TabIndex = 7;
            this.AllotmentsHarvestTime.Text = "--:--";
            // 
            // AllotmentPlant
            // 
            this.AllotmentPlant.Location = new System.Drawing.Point(15, 121);
            this.AllotmentPlant.Name = "AllotmentPlant";
            this.AllotmentPlant.Size = new System.Drawing.Size(84, 23);
            this.AllotmentPlant.TabIndex = 8;
            this.AllotmentPlant.Text = "Plant allotment";
            this.AllotmentPlant.UseVisualStyleBackColor = true;
            this.AllotmentPlant.Click += new System.EventHandler(this.AllotmentPlant_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AllotmentPlant);
            this.Controls.Add(this.AllotmentsHarvestTime);
            this.Controls.Add(this.Locations);
            this.Controls.Add(this.LocationLabel);
            this.Controls.Add(this.AllotmentsLabel);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.AllotmentCrops);
            this.Name = "Form1";
            this.Text = "Runescape - Farming Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AllotmentCrops;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Label AllotmentsLabel;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.ComboBox Locations;
        private System.Windows.Forms.Label AllotmentsHarvestTime;
        private System.Windows.Forms.Button AllotmentPlant;
    }
}

