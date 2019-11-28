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
            this.LocationLabel = new System.Windows.Forms.Label();
            this.Locations = new System.Windows.Forms.ComboBox();
            this.AllotmentPatchesGroup = new System.Windows.Forms.GroupBox();
            this.AllotmentHerbComboBox = new System.Windows.Forms.ComboBox();
            this.AllotmentFlowerComboBox = new System.Windows.Forms.ComboBox();
            this.AllotmentPatchComboBox2 = new System.Windows.Forms.ComboBox();
            this.AllotmentPatchComboBox1 = new System.Windows.Forms.ComboBox();
            this.AllotmentPatch1Btn = new System.Windows.Forms.Button();
            this.AllotmentPatch2Btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.FlowerPatchBtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.HerbPatchBtn = new System.Windows.Forms.Button();
            this.ResultBox = new System.Windows.Forms.RichTextBox();
            this.AllotmentPatchesGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Location = new System.Drawing.Point(12, 9);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(48, 13);
            this.LocationLabel.TabIndex = 4;
            this.LocationLabel.Text = "Location";
            // 
            // Locations
            // 
            this.Locations.FormattingEnabled = true;
            this.Locations.Location = new System.Drawing.Point(15, 25);
            this.Locations.Name = "Locations";
            this.Locations.Size = new System.Drawing.Size(250, 21);
            this.Locations.TabIndex = 5;
            this.Locations.SelectedIndexChanged += new System.EventHandler(this.Locations_SelectedIndexChanged);
            // 
            // AllotmentPatchesGroup
            // 
            this.AllotmentPatchesGroup.Controls.Add(this.groupBox4);
            this.AllotmentPatchesGroup.Controls.Add(this.groupBox3);
            this.AllotmentPatchesGroup.Controls.Add(this.groupBox2);
            this.AllotmentPatchesGroup.Controls.Add(this.groupBox1);
            this.AllotmentPatchesGroup.Location = new System.Drawing.Point(15, 52);
            this.AllotmentPatchesGroup.Name = "AllotmentPatchesGroup";
            this.AllotmentPatchesGroup.Size = new System.Drawing.Size(250, 386);
            this.AllotmentPatchesGroup.TabIndex = 6;
            this.AllotmentPatchesGroup.TabStop = false;
            this.AllotmentPatchesGroup.Text = "Allotment Patches";
            // 
            // AllotmentHerbComboBox
            // 
            this.AllotmentHerbComboBox.FormattingEnabled = true;
            this.AllotmentHerbComboBox.Location = new System.Drawing.Point(6, 19);
            this.AllotmentHerbComboBox.Name = "AllotmentHerbComboBox";
            this.AllotmentHerbComboBox.Size = new System.Drawing.Size(219, 21);
            this.AllotmentHerbComboBox.TabIndex = 11;
            // 
            // AllotmentFlowerComboBox
            // 
            this.AllotmentFlowerComboBox.FormattingEnabled = true;
            this.AllotmentFlowerComboBox.Location = new System.Drawing.Point(6, 19);
            this.AllotmentFlowerComboBox.Name = "AllotmentFlowerComboBox";
            this.AllotmentFlowerComboBox.Size = new System.Drawing.Size(219, 21);
            this.AllotmentFlowerComboBox.TabIndex = 9;
            // 
            // AllotmentPatchComboBox2
            // 
            this.AllotmentPatchComboBox2.FormattingEnabled = true;
            this.AllotmentPatchComboBox2.Location = new System.Drawing.Point(6, 19);
            this.AllotmentPatchComboBox2.Name = "AllotmentPatchComboBox2";
            this.AllotmentPatchComboBox2.Size = new System.Drawing.Size(219, 21);
            this.AllotmentPatchComboBox2.TabIndex = 7;
            // 
            // AllotmentPatchComboBox1
            // 
            this.AllotmentPatchComboBox1.FormattingEnabled = true;
            this.AllotmentPatchComboBox1.Location = new System.Drawing.Point(6, 19);
            this.AllotmentPatchComboBox1.Name = "AllotmentPatchComboBox1";
            this.AllotmentPatchComboBox1.Size = new System.Drawing.Size(219, 21);
            this.AllotmentPatchComboBox1.TabIndex = 0;
            // 
            // AllotmentPatch1Btn
            // 
            this.AllotmentPatch1Btn.Location = new System.Drawing.Point(6, 46);
            this.AllotmentPatch1Btn.Name = "AllotmentPatch1Btn";
            this.AllotmentPatch1Btn.Size = new System.Drawing.Size(89, 23);
            this.AllotmentPatch1Btn.TabIndex = 7;
            this.AllotmentPatch1Btn.Text = "Plant";
            this.AllotmentPatch1Btn.UseVisualStyleBackColor = true;
            this.AllotmentPatch1Btn.Click += new System.EventHandler(this.AllotmentPatch1Btn_Click);
            // 
            // AllotmentPatch2Btn
            // 
            this.AllotmentPatch2Btn.Location = new System.Drawing.Point(6, 43);
            this.AllotmentPatch2Btn.Name = "AllotmentPatch2Btn";
            this.AllotmentPatch2Btn.Size = new System.Drawing.Size(89, 23);
            this.AllotmentPatch2Btn.TabIndex = 8;
            this.AllotmentPatch2Btn.Text = "Plant";
            this.AllotmentPatch2Btn.UseVisualStyleBackColor = true;
            this.AllotmentPatch2Btn.Click += new System.EventHandler(this.AllotmentPatch2Btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.AllotmentPatchComboBox1);
            this.groupBox1.Controls.Add(this.AllotmentPatch1Btn);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 77);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Allotment patch I";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.AllotmentPatch2Btn);
            this.groupBox2.Controls.Add(this.AllotmentPatchComboBox2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(6, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 73);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Allotment patch II";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.FlowerPatchBtn);
            this.groupBox3.Controls.Add(this.AllotmentFlowerComboBox);
            this.groupBox3.Location = new System.Drawing.Point(6, 181);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(236, 76);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Flower patch";
            // 
            // FlowerPatchBtn
            // 
            this.FlowerPatchBtn.Location = new System.Drawing.Point(6, 46);
            this.FlowerPatchBtn.Name = "FlowerPatchBtn";
            this.FlowerPatchBtn.Size = new System.Drawing.Size(89, 23);
            this.FlowerPatchBtn.TabIndex = 13;
            this.FlowerPatchBtn.Text = "Plant";
            this.FlowerPatchBtn.UseVisualStyleBackColor = true;
            this.FlowerPatchBtn.Click += new System.EventHandler(this.FlowerPatchBtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox4.Controls.Add(this.HerbPatchBtn);
            this.groupBox4.Controls.Add(this.AllotmentHerbComboBox);
            this.groupBox4.Location = new System.Drawing.Point(6, 263);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(236, 74);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Herb patch";
            // 
            // HerbPatchBtn
            // 
            this.HerbPatchBtn.Location = new System.Drawing.Point(6, 46);
            this.HerbPatchBtn.Name = "HerbPatchBtn";
            this.HerbPatchBtn.Size = new System.Drawing.Size(89, 23);
            this.HerbPatchBtn.TabIndex = 9;
            this.HerbPatchBtn.Text = "Plant";
            this.HerbPatchBtn.UseVisualStyleBackColor = true;
            this.HerbPatchBtn.Click += new System.EventHandler(this.HerbPatchBtn_Click);
            // 
            // ResultBox
            // 
            this.ResultBox.Location = new System.Drawing.Point(400, 25);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(388, 413);
            this.ResultBox.TabIndex = 15;
            this.ResultBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.AllotmentPatchesGroup);
            this.Controls.Add(this.Locations);
            this.Controls.Add(this.LocationLabel);
            this.Name = "Form1";
            this.Text = "Runescape - Farming Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.AllotmentPatchesGroup.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.ComboBox Locations;
        private System.Windows.Forms.GroupBox AllotmentPatchesGroup;
        private System.Windows.Forms.ComboBox AllotmentHerbComboBox;
        private System.Windows.Forms.ComboBox AllotmentFlowerComboBox;
        private System.Windows.Forms.ComboBox AllotmentPatchComboBox2;
        private System.Windows.Forms.ComboBox AllotmentPatchComboBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button HerbPatchBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button FlowerPatchBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button AllotmentPatch2Btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AllotmentPatch1Btn;
        private System.Windows.Forms.RichTextBox ResultBox;
    }
}

