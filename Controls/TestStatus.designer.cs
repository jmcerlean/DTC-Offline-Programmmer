namespace CSTemplate.Controls
{
    partial class TestStatus
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TestStatusLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TestStatusLbl
            // 
            this.TestStatusLbl.BackColor = System.Drawing.SystemColors.Control;
            this.TestStatusLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TestStatusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestStatusLbl.Location = new System.Drawing.Point(0, 0);
            this.TestStatusLbl.Name = "TestStatusLbl";
            this.TestStatusLbl.Size = new System.Drawing.Size(290, 132);
            this.TestStatusLbl.TabIndex = 0;
            this.TestStatusLbl.Text = "label1";
            this.TestStatusLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TestStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TestStatusLbl);
            this.Name = "TestStatus";
            this.Size = new System.Drawing.Size(290, 132);
            this.Load += new System.EventHandler(this.TestStatus_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TestStatusLbl;
    }
}
