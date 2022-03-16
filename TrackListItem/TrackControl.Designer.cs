namespace TrackListItem
{
    partial class TrackControl
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
            this.lblTrackDuration = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblTrackNumber = new System.Windows.Forms.Label();
            this.nudTrackLPcm = new System.Windows.Forms.NumericUpDown();
            this.nudGapLPcm = new System.Windows.Forms.NumericUpDown();
            this.nudGapWidth = new System.Windows.Forms.NumericUpDown();
            this.lblTrack = new System.Windows.Forms.Label();
            this.lblGap = new System.Windows.Forms.Label();
            this.lblTrackWidth = new System.Windows.Forms.Label();
            this.lblGapDuration = new System.Windows.Forms.Label();
            this.lblTrackSteps = new System.Windows.Forms.Label();
            this.lblGapSteps = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrackLPcm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGapLPcm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGapWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTrackDuration
            // 
            this.lblTrackDuration.AutoSize = true;
            this.lblTrackDuration.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackDuration.Location = new System.Drawing.Point(344, 3);
            this.lblTrackDuration.Name = "lblTrackDuration";
            this.lblTrackDuration.Size = new System.Drawing.Size(15, 14);
            this.lblTrackDuration.TabIndex = 0;
            this.lblTrackDuration.Text = "0";
            this.lblTrackDuration.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblFileName
            // 
            this.lblFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.Location = new System.Drawing.Point(460, 5);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(12, 14);
            this.lblFileName.TabIndex = 1;
            this.lblFileName.Text = "-";
            // 
            // lblTrackNumber
            // 
            this.lblTrackNumber.AutoSize = true;
            this.lblTrackNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblTrackNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTrackNumber.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackNumber.Location = new System.Drawing.Point(3, 5);
            this.lblTrackNumber.Name = "lblTrackNumber";
            this.lblTrackNumber.Size = new System.Drawing.Size(26, 31);
            this.lblTrackNumber.TabIndex = 2;
            this.lblTrackNumber.Text = "-";
            this.lblTrackNumber.Click += new System.EventHandler(this.SelectTrack_Click);
            // 
            // nudTrackLPcm
            // 
            this.nudTrackLPcm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudTrackLPcm.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTrackLPcm.ForeColor = System.Drawing.Color.White;
            this.nudTrackLPcm.Location = new System.Drawing.Point(149, 3);
            this.nudTrackLPcm.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudTrackLPcm.Name = "nudTrackLPcm";
            this.nudTrackLPcm.Size = new System.Drawing.Size(50, 18);
            this.nudTrackLPcm.TabIndex = 0;
            // 
            // nudGapLPcm
            // 
            this.nudGapLPcm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudGapLPcm.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudGapLPcm.ForeColor = System.Drawing.Color.White;
            this.nudGapLPcm.Location = new System.Drawing.Point(149, 26);
            this.nudGapLPcm.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudGapLPcm.Name = "nudGapLPcm";
            this.nudGapLPcm.Size = new System.Drawing.Size(50, 18);
            this.nudGapLPcm.TabIndex = 4;
            // 
            // nudGapWidth
            // 
            this.nudGapWidth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudGapWidth.DecimalPlaces = 2;
            this.nudGapWidth.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudGapWidth.ForeColor = System.Drawing.Color.White;
            this.nudGapWidth.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nudGapWidth.Location = new System.Drawing.Point(240, 26);
            this.nudGapWidth.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudGapWidth.Name = "nudGapWidth";
            this.nudGapWidth.Size = new System.Drawing.Size(55, 18);
            this.nudGapWidth.TabIndex = 5;
            // 
            // lblTrack
            // 
            this.lblTrack.AutoSize = true;
            this.lblTrack.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrack.Location = new System.Drawing.Point(75, 3);
            this.lblTrack.Name = "lblTrack";
            this.lblTrack.Size = new System.Drawing.Size(39, 14);
            this.lblTrack.TabIndex = 6;
            this.lblTrack.Text = "Track";
            // 
            // lblGap
            // 
            this.lblGap.AutoSize = true;
            this.lblGap.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGap.Location = new System.Drawing.Point(75, 25);
            this.lblGap.Name = "lblGap";
            this.lblGap.Size = new System.Drawing.Size(32, 14);
            this.lblGap.TabIndex = 7;
            this.lblGap.Text = "Gap";
            // 
            // lblTrackWidth
            // 
            this.lblTrackWidth.AutoSize = true;
            this.lblTrackWidth.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackWidth.Location = new System.Drawing.Point(237, 3);
            this.lblTrackWidth.Name = "lblTrackWidth";
            this.lblTrackWidth.Size = new System.Drawing.Size(15, 14);
            this.lblTrackWidth.TabIndex = 8;
            this.lblTrackWidth.Text = "0";
            this.lblTrackWidth.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblGapDuration
            // 
            this.lblGapDuration.AutoSize = true;
            this.lblGapDuration.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGapDuration.Location = new System.Drawing.Point(344, 25);
            this.lblGapDuration.Name = "lblGapDuration";
            this.lblGapDuration.Size = new System.Drawing.Size(15, 14);
            this.lblGapDuration.TabIndex = 9;
            this.lblGapDuration.Text = "0";
            this.lblGapDuration.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTrackSteps
            // 
            this.lblTrackSteps.Location = new System.Drawing.Point(398, 4);
            this.lblTrackSteps.Name = "lblTrackSteps";
            this.lblTrackSteps.Size = new System.Drawing.Size(43, 16);
            this.lblTrackSteps.TabIndex = 10;
            this.lblTrackSteps.Text = "0";
            this.lblTrackSteps.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblGapSteps
            // 
            this.lblGapSteps.Location = new System.Drawing.Point(398, 26);
            this.lblGapSteps.Name = "lblGapSteps";
            this.lblGapSteps.Size = new System.Drawing.Size(43, 16);
            this.lblGapSteps.TabIndex = 11;
            this.lblGapSteps.Text = "0";
            this.lblGapSteps.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TrackControl
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblGapSteps);
            this.Controls.Add(this.lblTrackSteps);
            this.Controls.Add(this.lblTrackNumber);
            this.Controls.Add(this.lblGapDuration);
            this.Controls.Add(this.lblTrackWidth);
            this.Controls.Add(this.lblGap);
            this.Controls.Add(this.lblTrack);
            this.Controls.Add(this.nudGapWidth);
            this.Controls.Add(this.nudGapLPcm);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.lblTrackDuration);
            this.Controls.Add(this.nudTrackLPcm);
            this.Name = "TrackControl";
            this.Size = new System.Drawing.Size(791, 47);
            ((System.ComponentModel.ISupportInitialize)(this.nudTrackLPcm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGapLPcm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGapWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrackDuration;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblTrackNumber;
        private System.Windows.Forms.NumericUpDown nudTrackLPcm;
        private System.Windows.Forms.NumericUpDown nudGapLPcm;
        private System.Windows.Forms.NumericUpDown nudGapWidth;
        private System.Windows.Forms.Label lblTrack;
        private System.Windows.Forms.Label lblGap;
        private System.Windows.Forms.Label lblTrackWidth;
        private System.Windows.Forms.Label lblGapDuration;
        private System.Windows.Forms.Label lblTrackSteps;
        private System.Windows.Forms.Label lblGapSteps;
    }
}
