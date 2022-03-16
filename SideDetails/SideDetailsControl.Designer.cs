namespace SideDetails
{
    partial class SideDetailsControl
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
            this.pnlSideSizes = new System.Windows.Forms.Panel();
            this.nudLockRadius = new System.Windows.Forms.NumericUpDown();
            this.nudStartRadius = new System.Windows.Forms.NumericUpDown();
            this.lblLastTrackRadius = new System.Windows.Forms.Label();
            this.lblLockGrooveRadius = new System.Windows.Forms.Label();
            this.lblStartRadius = new System.Windows.Forms.Label();
            this.pnlSideSettings = new System.Windows.Forms.Panel();
            this.lblPreProgSteps = new System.Windows.Forms.Label();
            this.lblPreProgDuration = new System.Windows.Forms.Label();
            this.nudPreProgWidth = new System.Windows.Forms.NumericUpDown();
            this.nudPreProgLPcm = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblRunOutSteps = new System.Windows.Forms.Label();
            this.lblRunInSteps = new System.Windows.Forms.Label();
            this.lblSetDownSteps = new System.Windows.Forms.Label();
            this.lblTotalDuration = new System.Windows.Forms.Label();
            this.lblRunOutDuration = new System.Windows.Forms.Label();
            this.lblRunInDuration = new System.Windows.Forms.Label();
            this.lblSetDownDuration = new System.Windows.Forms.Label();
            this.lblSpaceRemaining = new System.Windows.Forms.Label();
            this.lblRunOutWidth = new System.Windows.Forms.Label();
            this.nudRunOutLPcm = new System.Windows.Forms.NumericUpDown();
            this.nudRunInWidth = new System.Windows.Forms.NumericUpDown();
            this.nudRunInLPcm = new System.Windows.Forms.NumericUpDown();
            this.nudSetDownWidth = new System.Windows.Forms.NumericUpDown();
            this.nudSetDownLPcm = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTracks = new System.Windows.Forms.Panel();
            this.pnlSideSizes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLockRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartRadius)).BeginInit();
            this.pnlSideSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreProgWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreProgLPcm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRunOutLPcm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRunInWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRunInLPcm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSetDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSetDownLPcm)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSideSizes
            // 
            this.pnlSideSizes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSideSizes.BackColor = System.Drawing.Color.MediumOrchid;
            this.pnlSideSizes.Controls.Add(this.nudLockRadius);
            this.pnlSideSizes.Controls.Add(this.nudStartRadius);
            this.pnlSideSizes.Controls.Add(this.lblLastTrackRadius);
            this.pnlSideSizes.Controls.Add(this.lblLockGrooveRadius);
            this.pnlSideSizes.Controls.Add(this.lblStartRadius);
            this.pnlSideSizes.Location = new System.Drawing.Point(10, 10);
            this.pnlSideSizes.Name = "pnlSideSizes";
            this.pnlSideSizes.Size = new System.Drawing.Size(963, 27);
            this.pnlSideSizes.TabIndex = 10;
            // 
            // nudLockRadius
            // 
            this.nudLockRadius.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudLockRadius.DecimalPlaces = 2;
            this.nudLockRadius.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLockRadius.ForeColor = System.Drawing.Color.White;
            this.nudLockRadius.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudLockRadius.Location = new System.Drawing.Point(360, 4);
            this.nudLockRadius.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudLockRadius.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudLockRadius.Name = "nudLockRadius";
            this.nudLockRadius.Size = new System.Drawing.Size(51, 18);
            this.nudLockRadius.TabIndex = 4;
            this.nudLockRadius.Value = new decimal(new int[] {
            48,
            0,
            0,
            65536});
            // 
            // nudStartRadius
            // 
            this.nudStartRadius.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudStartRadius.DecimalPlaces = 2;
            this.nudStartRadius.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudStartRadius.ForeColor = System.Drawing.Color.White;
            this.nudStartRadius.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nudStartRadius.Location = new System.Drawing.Point(128, 4);
            this.nudStartRadius.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudStartRadius.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudStartRadius.Name = "nudStartRadius";
            this.nudStartRadius.Size = new System.Drawing.Size(51, 18);
            this.nudStartRadius.TabIndex = 3;
            this.nudStartRadius.Value = new decimal(new int[] {
            875,
            0,
            0,
            131072});
            // 
            // lblLastTrackRadius
            // 
            this.lblLastTrackRadius.AutoSize = true;
            this.lblLastTrackRadius.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastTrackRadius.ForeColor = System.Drawing.Color.White;
            this.lblLastTrackRadius.Location = new System.Drawing.Point(451, 4);
            this.lblLastTrackRadius.Name = "lblLastTrackRadius";
            this.lblLastTrackRadius.Size = new System.Drawing.Size(200, 14);
            this.lblLastTrackRadius.TabIndex = 2;
            this.lblLastTrackRadius.Text = "Last track groove radius (cm): ";
            // 
            // lblLockGrooveRadius
            // 
            this.lblLockGrooveRadius.AutoSize = true;
            this.lblLockGrooveRadius.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLockGrooveRadius.ForeColor = System.Drawing.Color.White;
            this.lblLockGrooveRadius.Location = new System.Drawing.Point(202, 4);
            this.lblLockGrooveRadius.Name = "lblLockGrooveRadius";
            this.lblLockGrooveRadius.Size = new System.Drawing.Size(157, 14);
            this.lblLockGrooveRadius.TabIndex = 1;
            this.lblLockGrooveRadius.Text = "Lock groove radius (cm)";
            // 
            // lblStartRadius
            // 
            this.lblStartRadius.AutoSize = true;
            this.lblStartRadius.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartRadius.ForeColor = System.Drawing.Color.White;
            this.lblStartRadius.Location = new System.Drawing.Point(4, 4);
            this.lblStartRadius.Name = "lblStartRadius";
            this.lblStartRadius.Size = new System.Drawing.Size(112, 14);
            this.lblStartRadius.TabIndex = 0;
            this.lblStartRadius.Text = "Start radius (cm)";
            // 
            // pnlSideSettings
            // 
            this.pnlSideSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSideSettings.BackColor = System.Drawing.Color.MediumOrchid;
            this.pnlSideSettings.Controls.Add(this.lblPreProgSteps);
            this.pnlSideSettings.Controls.Add(this.lblPreProgDuration);
            this.pnlSideSettings.Controls.Add(this.nudPreProgWidth);
            this.pnlSideSettings.Controls.Add(this.nudPreProgLPcm);
            this.pnlSideSettings.Controls.Add(this.label11);
            this.pnlSideSettings.Controls.Add(this.label9);
            this.pnlSideSettings.Controls.Add(this.lblRunOutSteps);
            this.pnlSideSettings.Controls.Add(this.lblRunInSteps);
            this.pnlSideSettings.Controls.Add(this.lblSetDownSteps);
            this.pnlSideSettings.Controls.Add(this.lblTotalDuration);
            this.pnlSideSettings.Controls.Add(this.lblRunOutDuration);
            this.pnlSideSettings.Controls.Add(this.lblRunInDuration);
            this.pnlSideSettings.Controls.Add(this.lblSetDownDuration);
            this.pnlSideSettings.Controls.Add(this.lblSpaceRemaining);
            this.pnlSideSettings.Controls.Add(this.lblRunOutWidth);
            this.pnlSideSettings.Controls.Add(this.nudRunOutLPcm);
            this.pnlSideSettings.Controls.Add(this.nudRunInWidth);
            this.pnlSideSettings.Controls.Add(this.nudRunInLPcm);
            this.pnlSideSettings.Controls.Add(this.nudSetDownWidth);
            this.pnlSideSettings.Controls.Add(this.nudSetDownLPcm);
            this.pnlSideSettings.Controls.Add(this.label8);
            this.pnlSideSettings.Controls.Add(this.label7);
            this.pnlSideSettings.Controls.Add(this.label6);
            this.pnlSideSettings.Controls.Add(this.label5);
            this.pnlSideSettings.Controls.Add(this.label4);
            this.pnlSideSettings.Controls.Add(this.label3);
            this.pnlSideSettings.Controls.Add(this.label2);
            this.pnlSideSettings.Controls.Add(this.label1);
            this.pnlSideSettings.Location = new System.Drawing.Point(10, 47);
            this.pnlSideSettings.Name = "pnlSideSettings";
            this.pnlSideSettings.Size = new System.Drawing.Size(966, 195);
            this.pnlSideSettings.TabIndex = 11;
            // 
            // lblPreProgSteps
            // 
            this.lblPreProgSteps.ForeColor = System.Drawing.Color.White;
            this.lblPreProgSteps.Location = new System.Drawing.Point(400, 76);
            this.lblPreProgSteps.Name = "lblPreProgSteps";
            this.lblPreProgSteps.Size = new System.Drawing.Size(43, 23);
            this.lblPreProgSteps.TabIndex = 27;
            this.lblPreProgSteps.Text = "0";
            this.lblPreProgSteps.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPreProgDuration
            // 
            this.lblPreProgDuration.AutoSize = true;
            this.lblPreProgDuration.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreProgDuration.ForeColor = System.Drawing.Color.White;
            this.lblPreProgDuration.Location = new System.Drawing.Point(346, 75);
            this.lblPreProgDuration.Name = "lblPreProgDuration";
            this.lblPreProgDuration.Size = new System.Drawing.Size(27, 14);
            this.lblPreProgDuration.TabIndex = 26;
            this.lblPreProgDuration.Text = "0.0";
            this.lblPreProgDuration.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // nudPreProgWidth
            // 
            this.nudPreProgWidth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudPreProgWidth.DecimalPlaces = 2;
            this.nudPreProgWidth.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPreProgWidth.ForeColor = System.Drawing.Color.White;
            this.nudPreProgWidth.Increment = new decimal(new int[] {
            2,
            0,
            0,
            131072});
            this.nudPreProgWidth.Location = new System.Drawing.Point(240, 74);
            this.nudPreProgWidth.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.nudPreProgWidth.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            131072});
            this.nudPreProgWidth.Name = "nudPreProgWidth";
            this.nudPreProgWidth.Size = new System.Drawing.Size(55, 18);
            this.nudPreProgWidth.TabIndex = 25;
            this.nudPreProgWidth.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // nudPreProgLPcm
            // 
            this.nudPreProgLPcm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudPreProgLPcm.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPreProgLPcm.ForeColor = System.Drawing.Color.White;
            this.nudPreProgLPcm.Location = new System.Drawing.Point(149, 74);
            this.nudPreProgLPcm.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.nudPreProgLPcm.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudPreProgLPcm.Name = "nudPreProgLPcm";
            this.nudPreProgLPcm.Size = new System.Drawing.Size(50, 18);
            this.nudPreProgLPcm.TabIndex = 24;
            this.nudPreProgLPcm.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(32, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 14);
            this.label11.TabIndex = 23;
            this.label11.Text = "Pre-prog spiral ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(409, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Steps";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRunOutSteps
            // 
            this.lblRunOutSteps.ForeColor = System.Drawing.Color.White;
            this.lblRunOutSteps.Location = new System.Drawing.Point(400, 100);
            this.lblRunOutSteps.Name = "lblRunOutSteps";
            this.lblRunOutSteps.Size = new System.Drawing.Size(43, 23);
            this.lblRunOutSteps.TabIndex = 21;
            this.lblRunOutSteps.Text = "0";
            this.lblRunOutSteps.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblRunInSteps
            // 
            this.lblRunInSteps.ForeColor = System.Drawing.Color.White;
            this.lblRunInSteps.Location = new System.Drawing.Point(400, 52);
            this.lblRunInSteps.Name = "lblRunInSteps";
            this.lblRunInSteps.Size = new System.Drawing.Size(43, 23);
            this.lblRunInSteps.TabIndex = 20;
            this.lblRunInSteps.Text = "0";
            this.lblRunInSteps.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSetDownSteps
            // 
            this.lblSetDownSteps.ForeColor = System.Drawing.Color.White;
            this.lblSetDownSteps.Location = new System.Drawing.Point(400, 28);
            this.lblSetDownSteps.Name = "lblSetDownSteps";
            this.lblSetDownSteps.Size = new System.Drawing.Size(43, 23);
            this.lblSetDownSteps.TabIndex = 19;
            this.lblSetDownSteps.Text = "0";
            this.lblSetDownSteps.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTotalDuration
            // 
            this.lblTotalDuration.AutoSize = true;
            this.lblTotalDuration.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDuration.ForeColor = System.Drawing.Color.White;
            this.lblTotalDuration.Location = new System.Drawing.Point(346, 124);
            this.lblTotalDuration.Name = "lblTotalDuration";
            this.lblTotalDuration.Size = new System.Drawing.Size(27, 14);
            this.lblTotalDuration.TabIndex = 18;
            this.lblTotalDuration.Text = "0.0";
            this.lblTotalDuration.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblRunOutDuration
            // 
            this.lblRunOutDuration.AutoSize = true;
            this.lblRunOutDuration.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunOutDuration.ForeColor = System.Drawing.Color.White;
            this.lblRunOutDuration.Location = new System.Drawing.Point(346, 99);
            this.lblRunOutDuration.Name = "lblRunOutDuration";
            this.lblRunOutDuration.Size = new System.Drawing.Size(27, 14);
            this.lblRunOutDuration.TabIndex = 17;
            this.lblRunOutDuration.Text = "0.0";
            this.lblRunOutDuration.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblRunInDuration
            // 
            this.lblRunInDuration.AutoSize = true;
            this.lblRunInDuration.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunInDuration.ForeColor = System.Drawing.Color.White;
            this.lblRunInDuration.Location = new System.Drawing.Point(346, 51);
            this.lblRunInDuration.Name = "lblRunInDuration";
            this.lblRunInDuration.Size = new System.Drawing.Size(27, 14);
            this.lblRunInDuration.TabIndex = 16;
            this.lblRunInDuration.Text = "0.0";
            this.lblRunInDuration.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSetDownDuration
            // 
            this.lblSetDownDuration.AutoSize = true;
            this.lblSetDownDuration.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetDownDuration.ForeColor = System.Drawing.Color.White;
            this.lblSetDownDuration.Location = new System.Drawing.Point(346, 27);
            this.lblSetDownDuration.Name = "lblSetDownDuration";
            this.lblSetDownDuration.Size = new System.Drawing.Size(27, 14);
            this.lblSetDownDuration.TabIndex = 15;
            this.lblSetDownDuration.Text = "0.0";
            this.lblSetDownDuration.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSpaceRemaining
            // 
            this.lblSpaceRemaining.AutoSize = true;
            this.lblSpaceRemaining.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpaceRemaining.ForeColor = System.Drawing.Color.White;
            this.lblSpaceRemaining.Location = new System.Drawing.Point(240, 152);
            this.lblSpaceRemaining.Name = "lblSpaceRemaining";
            this.lblSpaceRemaining.Size = new System.Drawing.Size(27, 14);
            this.lblSpaceRemaining.TabIndex = 14;
            this.lblSpaceRemaining.Text = "0.0";
            this.lblSpaceRemaining.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblRunOutWidth
            // 
            this.lblRunOutWidth.AutoSize = true;
            this.lblRunOutWidth.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunOutWidth.ForeColor = System.Drawing.Color.White;
            this.lblRunOutWidth.Location = new System.Drawing.Point(240, 99);
            this.lblRunOutWidth.Name = "lblRunOutWidth";
            this.lblRunOutWidth.Size = new System.Drawing.Size(27, 14);
            this.lblRunOutWidth.TabIndex = 13;
            this.lblRunOutWidth.Text = "0.0";
            this.lblRunOutWidth.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // nudRunOutLPcm
            // 
            this.nudRunOutLPcm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudRunOutLPcm.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudRunOutLPcm.ForeColor = System.Drawing.Color.White;
            this.nudRunOutLPcm.Location = new System.Drawing.Point(149, 98);
            this.nudRunOutLPcm.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudRunOutLPcm.Name = "nudRunOutLPcm";
            this.nudRunOutLPcm.Size = new System.Drawing.Size(50, 18);
            this.nudRunOutLPcm.TabIndex = 12;
            this.nudRunOutLPcm.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nudRunInWidth
            // 
            this.nudRunInWidth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudRunInWidth.DecimalPlaces = 2;
            this.nudRunInWidth.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudRunInWidth.ForeColor = System.Drawing.Color.White;
            this.nudRunInWidth.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nudRunInWidth.Location = new System.Drawing.Point(240, 50);
            this.nudRunInWidth.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRunInWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudRunInWidth.Name = "nudRunInWidth";
            this.nudRunInWidth.Size = new System.Drawing.Size(55, 18);
            this.nudRunInWidth.TabIndex = 11;
            this.nudRunInWidth.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            // 
            // nudRunInLPcm
            // 
            this.nudRunInLPcm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudRunInLPcm.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudRunInLPcm.ForeColor = System.Drawing.Color.White;
            this.nudRunInLPcm.Location = new System.Drawing.Point(149, 50);
            this.nudRunInLPcm.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.nudRunInLPcm.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudRunInLPcm.Name = "nudRunInLPcm";
            this.nudRunInLPcm.Size = new System.Drawing.Size(50, 18);
            this.nudRunInLPcm.TabIndex = 10;
            this.nudRunInLPcm.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // nudSetDownWidth
            // 
            this.nudSetDownWidth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudSetDownWidth.DecimalPlaces = 2;
            this.nudSetDownWidth.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSetDownWidth.ForeColor = System.Drawing.Color.White;
            this.nudSetDownWidth.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nudSetDownWidth.Location = new System.Drawing.Point(240, 26);
            this.nudSetDownWidth.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSetDownWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudSetDownWidth.Name = "nudSetDownWidth";
            this.nudSetDownWidth.Size = new System.Drawing.Size(55, 18);
            this.nudSetDownWidth.TabIndex = 9;
            this.nudSetDownWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // nudSetDownLPcm
            // 
            this.nudSetDownLPcm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudSetDownLPcm.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSetDownLPcm.ForeColor = System.Drawing.Color.White;
            this.nudSetDownLPcm.Location = new System.Drawing.Point(149, 26);
            this.nudSetDownLPcm.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.nudSetDownLPcm.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudSetDownLPcm.Name = "nudSetDownLPcm";
            this.nudSetDownLPcm.Size = new System.Drawing.Size(50, 18);
            this.nudSetDownLPcm.TabIndex = 8;
            this.nudSetDownLPcm.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(333, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 14);
            this.label8.TabIndex = 7;
            this.label8.Text = "Duration";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(230, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 14);
            this.label7.TabIndex = 6;
            this.label7.Text = "Width (cm)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(138, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "Lines / cm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(32, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "Space remaining";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(32, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total duration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Run-out spiral";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Run-in spiral";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Set-down";
            // 
            // pnlTracks
            // 
            this.pnlTracks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTracks.AutoScroll = true;
            this.pnlTracks.BackColor = System.Drawing.Color.MediumOrchid;
            this.pnlTracks.Location = new System.Drawing.Point(10, 250);
            this.pnlTracks.Name = "pnlTracks";
            this.pnlTracks.Size = new System.Drawing.Size(966, 400);
            this.pnlTracks.TabIndex = 12;
            // 
            // SideDetailsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlTracks);
            this.Controls.Add(this.pnlSideSettings);
            this.Controls.Add(this.pnlSideSizes);
            this.Name = "SideDetailsControl";
            this.Size = new System.Drawing.Size(976, 720);
            this.Resize += new System.EventHandler(this.SideDetailsControl_Resize);
            this.pnlSideSizes.ResumeLayout(false);
            this.pnlSideSizes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLockRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartRadius)).EndInit();
            this.pnlSideSettings.ResumeLayout(false);
            this.pnlSideSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreProgWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreProgLPcm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRunOutLPcm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRunInWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRunInLPcm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSetDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSetDownLPcm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideSizes;
        private System.Windows.Forms.NumericUpDown nudLockRadius;
        private System.Windows.Forms.NumericUpDown nudStartRadius;
        private System.Windows.Forms.Label lblLastTrackRadius;
        private System.Windows.Forms.Label lblLockGrooveRadius;
        private System.Windows.Forms.Label lblStartRadius;
        private System.Windows.Forms.Panel pnlSideSettings;
        private System.Windows.Forms.Label lblTotalDuration;
        private System.Windows.Forms.Label lblRunOutDuration;
        private System.Windows.Forms.Label lblRunInDuration;
        private System.Windows.Forms.Label lblSetDownDuration;
        private System.Windows.Forms.Label lblSpaceRemaining;
        private System.Windows.Forms.Label lblRunOutWidth;
        private System.Windows.Forms.NumericUpDown nudRunOutLPcm;
        private System.Windows.Forms.NumericUpDown nudRunInWidth;
        private System.Windows.Forms.NumericUpDown nudRunInLPcm;
        private System.Windows.Forms.NumericUpDown nudSetDownWidth;
        private System.Windows.Forms.NumericUpDown nudSetDownLPcm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlTracks;
        private System.Windows.Forms.Label lblRunOutSteps;
        private System.Windows.Forms.Label lblRunInSteps;
        private System.Windows.Forms.Label lblSetDownSteps;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPreProgSteps;
        private System.Windows.Forms.Label lblPreProgDuration;
        private System.Windows.Forms.NumericUpDown nudPreProgWidth;
        private System.Windows.Forms.NumericUpDown nudPreProgLPcm;
        private System.Windows.Forms.Label label11;
    }
}
