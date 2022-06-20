using System;

namespace CSTemplate.Forms
{
    partial class SequenceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SequenceForm));
            this.SensataImage = new System.Windows.Forms.PictureBox();
            this.RadioButtonProgram = new System.Windows.Forms.RadioButton();
            this.RadioButtonProgramTest = new System.Windows.Forms.RadioButton();
            this.RadioButtonInitial = new System.Windows.Forms.RadioButton();
            this.RadioButtonFinal = new System.Windows.Forms.RadioButton();
            this.StartButton1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TestOnlyradioButton = new System.Windows.Forms.RadioButton();
            this.ProgGrpBox = new System.Windows.Forms.GroupBox();
            this.SerialIDGrpBox = new System.Windows.Forms.GroupBox();
            this.IDGrpBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PN = new System.Windows.Forms.TextBox();
            this.SWVers = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Manuf = new System.Windows.Forms.TextBox();
            this.RadioButtonSerialID = new System.Windows.Forms.RadioButton();
            this.RadioButtonNoSerialID = new System.Windows.Forms.RadioButton();
            this.TempGrpBox = new System.Windows.Forms.GroupBox();
            this.ProgStateTxt = new System.Windows.Forms.Label();
            this.ProgStateLbl = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SensataImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.ProgGrpBox.SuspendLayout();
            this.SerialIDGrpBox.SuspendLayout();
            this.IDGrpBox.SuspendLayout();
            this.TempGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SensataImage
            // 
            this.SensataImage.Image = ((System.Drawing.Image)(resources.GetObject("SensataImage.Image")));
            this.SensataImage.Location = new System.Drawing.Point(12, 12);
            this.SensataImage.Name = "SensataImage";
            this.SensataImage.Size = new System.Drawing.Size(392, 64);
            this.SensataImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.SensataImage.TabIndex = 1;
            this.SensataImage.TabStop = false;
            // 
            // RadioButtonProgram
            // 
            this.RadioButtonProgram.AutoSize = true;
            this.RadioButtonProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonProgram.Location = new System.Drawing.Point(10, 25);
            this.RadioButtonProgram.Name = "RadioButtonProgram";
            this.RadioButtonProgram.Size = new System.Drawing.Size(87, 24);
            this.RadioButtonProgram.TabIndex = 23;
            this.RadioButtonProgram.TabStop = true;
            this.RadioButtonProgram.Text = "Program";
            this.RadioButtonProgram.UseVisualStyleBackColor = true;
            this.RadioButtonProgram.CheckedChanged += new System.EventHandler(this.RadioButtonProgram_CheckedChanged);
            // 
            // RadioButtonProgramTest
            // 
            this.RadioButtonProgramTest.AutoSize = true;
            this.RadioButtonProgramTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonProgramTest.Location = new System.Drawing.Point(114, 25);
            this.RadioButtonProgramTest.Name = "RadioButtonProgramTest";
            this.RadioButtonProgramTest.Size = new System.Drawing.Size(153, 24);
            this.RadioButtonProgramTest.TabIndex = 24;
            this.RadioButtonProgramTest.TabStop = true;
            this.RadioButtonProgramTest.Text = "Program and Test";
            this.RadioButtonProgramTest.UseVisualStyleBackColor = true;
            this.RadioButtonProgramTest.CheckedChanged += new System.EventHandler(this.RadioButtonProgramTest_CheckedChanged);
            // 
            // RadioButtonInitial
            // 
            this.RadioButtonInitial.AutoSize = true;
            this.RadioButtonInitial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonInitial.Location = new System.Drawing.Point(18, 36);
            this.RadioButtonInitial.Name = "RadioButtonInitial";
            this.RadioButtonInitial.Size = new System.Drawing.Size(64, 24);
            this.RadioButtonInitial.TabIndex = 26;
            this.RadioButtonInitial.TabStop = true;
            this.RadioButtonInitial.Text = "Initial";
            this.RadioButtonInitial.UseVisualStyleBackColor = true;
            this.RadioButtonInitial.CheckedChanged += new System.EventHandler(this.RadioButtonInitial_CheckedChanged);
            // 
            // RadioButtonFinal
            // 
            this.RadioButtonFinal.AutoSize = true;
            this.RadioButtonFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonFinal.Location = new System.Drawing.Point(124, 36);
            this.RadioButtonFinal.Name = "RadioButtonFinal";
            this.RadioButtonFinal.Size = new System.Drawing.Size(61, 24);
            this.RadioButtonFinal.TabIndex = 27;
            this.RadioButtonFinal.TabStop = true;
            this.RadioButtonFinal.Text = "Final";
            this.RadioButtonFinal.UseVisualStyleBackColor = true;
            this.RadioButtonFinal.CheckedChanged += new System.EventHandler(this.RadioButtonFinal_CheckedChanged);
            // 
            // StartButton1
            // 
            this.StartButton1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.StartButton1.Enabled = false;
            this.StartButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton1.Location = new System.Drawing.Point(50, 504);
            this.StartButton1.Name = "StartButton1";
            this.StartButton1.Size = new System.Drawing.Size(155, 36);
            this.StartButton1.TabIndex = 28;
            this.StartButton1.Text = "START";
            this.StartButton1.UseVisualStyleBackColor = true;
            this.StartButton1.Click += new System.EventHandler(this.StartButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TestOnlyradioButton);
            this.groupBox1.Controls.Add(this.RadioButtonProgram);
            this.groupBox1.Controls.Add(this.RadioButtonProgramTest);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 59);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sequence";
            // 
            // TestOnlyradioButton
            // 
            this.TestOnlyradioButton.AutoSize = true;
            this.TestOnlyradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestOnlyradioButton.Location = new System.Drawing.Point(288, 25);
            this.TestOnlyradioButton.Name = "TestOnlyradioButton";
            this.TestOnlyradioButton.Size = new System.Drawing.Size(93, 24);
            this.TestOnlyradioButton.TabIndex = 33;
            this.TestOnlyradioButton.TabStop = true;
            this.TestOnlyradioButton.Text = "Test Only";
            this.TestOnlyradioButton.UseVisualStyleBackColor = true;
            this.TestOnlyradioButton.CheckedChanged += new System.EventHandler(this.TestOnlyRadioButton_CheckedChanged);
            // 
            // ProgGrpBox
            // 
            this.ProgGrpBox.Controls.Add(this.SerialIDGrpBox);
            this.ProgGrpBox.Controls.Add(this.RadioButtonInitial);
            this.ProgGrpBox.Controls.Add(this.RadioButtonFinal);
            this.ProgGrpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgGrpBox.Location = new System.Drawing.Point(50, 212);
            this.ProgGrpBox.Name = "ProgGrpBox";
            this.ProgGrpBox.Size = new System.Drawing.Size(314, 286);
            this.ProgGrpBox.TabIndex = 30;
            this.ProgGrpBox.TabStop = false;
            this.ProgGrpBox.Text = "Program";
            // 
            // SerialIDGrpBox
            // 
            this.SerialIDGrpBox.Controls.Add(this.IDGrpBox);
            this.SerialIDGrpBox.Controls.Add(this.RadioButtonSerialID);
            this.SerialIDGrpBox.Controls.Add(this.RadioButtonNoSerialID);
            this.SerialIDGrpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerialIDGrpBox.Location = new System.Drawing.Point(18, 79);
            this.SerialIDGrpBox.Name = "SerialIDGrpBox";
            this.SerialIDGrpBox.Size = new System.Drawing.Size(285, 201);
            this.SerialIDGrpBox.TabIndex = 35;
            this.SerialIDGrpBox.TabStop = false;
            this.SerialIDGrpBox.Text = "Serial ID";
            // 
            // IDGrpBox
            // 
            this.IDGrpBox.Controls.Add(this.label3);
            this.IDGrpBox.Controls.Add(this.PN);
            this.IDGrpBox.Controls.Add(this.SWVers);
            this.IDGrpBox.Controls.Add(this.label2);
            this.IDGrpBox.Controls.Add(this.label1);
            this.IDGrpBox.Controls.Add(this.Manuf);
            this.IDGrpBox.Enabled = false;
            this.IDGrpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDGrpBox.Location = new System.Drawing.Point(14, 64);
            this.IDGrpBox.Name = "IDGrpBox";
            this.IDGrpBox.Size = new System.Drawing.Size(261, 122);
            this.IDGrpBox.TabIndex = 37;
            this.IDGrpBox.TabStop = false;
            this.IDGrpBox.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Customer PN:";
            // 
            // PN
            // 
            this.PN.Location = new System.Drawing.Point(131, 90);
            this.PN.Name = "PN";
            this.PN.Size = new System.Drawing.Size(122, 26);
            this.PN.TabIndex = 40;
            this.PN.TextChanged += new System.EventHandler(this.PN_TextChanged);
            // 
            // SWVers
            // 
            this.SWVers.Location = new System.Drawing.Point(131, 52);
            this.SWVers.Name = "SWVers";
            this.SWVers.Size = new System.Drawing.Size(122, 26);
            this.SWVers.TabIndex = 39;
            this.SWVers.TextChanged += new System.EventHandler(this.SWVers_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "SW Version:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manuf:";
            // 
            // Manuf
            // 
            this.Manuf.Location = new System.Drawing.Point(131, 16);
            this.Manuf.Name = "Manuf";
            this.Manuf.Size = new System.Drawing.Size(122, 26);
            this.Manuf.TabIndex = 0;
            this.Manuf.TextChanged += new System.EventHandler(this.Manuf_TextChanged);
            // 
            // RadioButtonSerialID
            // 
            this.RadioButtonSerialID.AutoSize = true;
            this.RadioButtonSerialID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonSerialID.Location = new System.Drawing.Point(9, 25);
            this.RadioButtonSerialID.Name = "RadioButtonSerialID";
            this.RadioButtonSerialID.Size = new System.Drawing.Size(100, 24);
            this.RadioButtonSerialID.TabIndex = 26;
            this.RadioButtonSerialID.TabStop = true;
            this.RadioButtonSerialID.Text = "Include ID";
            this.RadioButtonSerialID.UseVisualStyleBackColor = true;
            this.RadioButtonSerialID.CheckedChanged += new System.EventHandler(this.RadioButtonSerial_CheckedChanged);
            // 
            // RadioButtonNoSerialID
            // 
            this.RadioButtonNoSerialID.AutoSize = true;
            this.RadioButtonNoSerialID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonNoSerialID.Location = new System.Drawing.Point(115, 25);
            this.RadioButtonNoSerialID.Name = "RadioButtonNoSerialID";
            this.RadioButtonNoSerialID.Size = new System.Drawing.Size(68, 24);
            this.RadioButtonNoSerialID.TabIndex = 27;
            this.RadioButtonNoSerialID.TabStop = true;
            this.RadioButtonNoSerialID.Text = "No ID";
            this.RadioButtonNoSerialID.UseVisualStyleBackColor = true;
            this.RadioButtonNoSerialID.CheckedChanged += new System.EventHandler(this.RadioButtonNoSerial_CheckedChanged);
            // 
            // TempGrpBox
            // 
            this.TempGrpBox.Controls.Add(this.ProgStateTxt);
            this.TempGrpBox.Controls.Add(this.ProgStateLbl);
            this.TempGrpBox.Enabled = false;
            this.TempGrpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempGrpBox.Location = new System.Drawing.Point(17, 82);
            this.TempGrpBox.Name = "TempGrpBox";
            this.TempGrpBox.Size = new System.Drawing.Size(381, 59);
            this.TempGrpBox.TabIndex = 35;
            this.TempGrpBox.TabStop = false;
            // 
            // ProgStateTxt
            // 
            this.ProgStateTxt.BackColor = System.Drawing.SystemColors.Control;
            this.ProgStateTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProgStateTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgStateTxt.Location = new System.Drawing.Point(175, 16);
            this.ProgStateTxt.Name = "ProgStateTxt";
            this.ProgStateTxt.Size = new System.Drawing.Size(151, 26);
            this.ProgStateTxt.TabIndex = 16;
            this.ProgStateTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProgStateLbl
            // 
            this.ProgStateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgStateLbl.Location = new System.Drawing.Point(29, 18);
            this.ProgStateLbl.Name = "ProgStateLbl";
            this.ProgStateLbl.Size = new System.Drawing.Size(140, 22);
            this.ProgStateLbl.TabIndex = 1;
            this.ProgStateLbl.Text = "Program State:";
            this.ProgStateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CancelBtn
            // 
            this.CancelBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.Location = new System.Drawing.Point(220, 504);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(155, 36);
            this.CancelBtn.TabIndex = 36;
            this.CancelBtn.Text = "CANCEL";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SequenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 562);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.TempGrpBox);
            this.Controls.Add(this.ProgGrpBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StartButton1);
            this.Controls.Add(this.SensataImage);
            this.Name = "SequenceForm";
            this.Text = "DTC Offline Programmer";
            ((System.ComponentModel.ISupportInitialize)(this.SensataImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ProgGrpBox.ResumeLayout(false);
            this.ProgGrpBox.PerformLayout();
            this.SerialIDGrpBox.ResumeLayout(false);
            this.SerialIDGrpBox.PerformLayout();
            this.IDGrpBox.ResumeLayout(false);
            this.IDGrpBox.PerformLayout();
            this.TempGrpBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox SensataImage;
        private System.Windows.Forms.RadioButton RadioButtonProgram;
        private System.Windows.Forms.RadioButton RadioButtonProgramTest;
        private System.Windows.Forms.RadioButton RadioButtonInitial;
        private System.Windows.Forms.RadioButton RadioButtonFinal;
        private System.Windows.Forms.Button StartButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox ProgGrpBox;
        private System.Windows.Forms.RadioButton TestOnlyradioButton;
        private System.Windows.Forms.GroupBox SerialIDGrpBox;
        private System.Windows.Forms.RadioButton RadioButtonSerialID;
        private System.Windows.Forms.RadioButton RadioButtonNoSerialID;
        private System.Windows.Forms.GroupBox TempGrpBox;
        private System.Windows.Forms.Label ProgStateTxt;
        private System.Windows.Forms.Label ProgStateLbl;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.GroupBox IDGrpBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Manuf;
        private System.Windows.Forms.TextBox SWVers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PN;
    }
}

