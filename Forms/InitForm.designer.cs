using System;

namespace CSTemplate.Forms
{
    partial class InitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitForm));
            this.SensataImage = new System.Windows.Forms.PictureBox();
            this.ASICPartNumLabel = new System.Windows.Forms.Label();
            this.CoHapPortLabel = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.PartNumCmbBox = new System.Windows.Forms.ComboBox();
            this.DUTPortCmbBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.SensataImage)).BeginInit();
            this.SuspendLayout();
            // 
            // SensataImage
            // 
            this.SensataImage.Image = ((System.Drawing.Image)(resources.GetObject("SensataImage.Image")));
            this.SensataImage.Location = new System.Drawing.Point(3, 3);
            this.SensataImage.Name = "SensataImage";
            this.SensataImage.Size = new System.Drawing.Size(392, 64);
            this.SensataImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.SensataImage.TabIndex = 1;
            this.SensataImage.TabStop = false;
            // 
            // ASICPartNumLabel
            // 
            this.ASICPartNumLabel.AutoSize = true;
            this.ASICPartNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ASICPartNumLabel.Location = new System.Drawing.Point(77, 101);
            this.ASICPartNumLabel.Name = "ASICPartNumLabel";
            this.ASICPartNumLabel.Size = new System.Drawing.Size(146, 20);
            this.ASICPartNumLabel.TabIndex = 19;
            this.ASICPartNumLabel.Text = "Sensata Part No:";
            // 
            // CoHapPortLabel
            // 
            this.CoHapPortLabel.AutoSize = true;
            this.CoHapPortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoHapPortLabel.Location = new System.Drawing.Point(77, 169);
            this.CoHapPortLabel.Name = "CoHapPortLabel";
            this.CoHapPortLabel.Size = new System.Drawing.Size(148, 20);
            this.CoHapPortLabel.TabIndex = 20;
            this.CoHapPortLabel.Text = "CoHap DUT Port:";
            // 
            // NextButton
            // 
            this.NextButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(117, 243);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(155, 36);
            this.NextButton.TabIndex = 28;
            this.NextButton.Text = "NEXT";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton1_Click);
            // 
            // PartNumCmbBox
            // 
            this.PartNumCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PartNumCmbBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartNumCmbBox.FormattingEnabled = true;
            this.PartNumCmbBox.ItemHeight = 20;
            this.PartNumCmbBox.Location = new System.Drawing.Point(81, 124);
            this.PartNumCmbBox.Name = "PartNumCmbBox";
            this.PartNumCmbBox.Size = new System.Drawing.Size(229, 28);
            this.PartNumCmbBox.TabIndex = 38;
            this.PartNumCmbBox.SelectedIndexChanged += new System.EventHandler(this.PartNumCmbBox_SelectedIndexChanged);
            // 
            // DUTPortCmbBox
            // 
            this.DUTPortCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DUTPortCmbBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DUTPortCmbBox.FormattingEnabled = true;
            this.DUTPortCmbBox.ItemHeight = 20;
            this.DUTPortCmbBox.Location = new System.Drawing.Point(81, 192);
            this.DUTPortCmbBox.Name = "DUTPortCmbBox";
            this.DUTPortCmbBox.Size = new System.Drawing.Size(229, 28);
            this.DUTPortCmbBox.TabIndex = 39;
            this.DUTPortCmbBox.SelectedIndexChanged += new System.EventHandler(this.DUTPortCmbBox_SelectedIndexChanged);
            // 
            // InitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 305);
            this.Controls.Add(this.DUTPortCmbBox);
            this.Controls.Add(this.PartNumCmbBox);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CoHapPortLabel);
            this.Controls.Add(this.ASICPartNumLabel);
            this.Controls.Add(this.SensataImage);
            this.Name = "InitForm";
            this.Text = "DTC Offline Programmer";
            ((System.ComponentModel.ISupportInitialize)(this.SensataImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox SensataImage;
        private System.Windows.Forms.Label ASICPartNumLabel;
        private System.Windows.Forms.Label CoHapPortLabel;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.ComboBox PartNumCmbBox;
        private System.Windows.Forms.ComboBox DUTPortCmbBox;
    }
}

