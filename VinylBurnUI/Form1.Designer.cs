namespace TrackHarness
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axWMP1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.pnlTracks = new System.Windows.Forms.Panel();
            this.pnlSpeed = new System.Windows.Forms.Panel();
            this.cmd45rpm = new System.Windows.Forms.Button();
            this.cmd39rpm = new System.Windows.Forms.Button();
            this.cmd33rpm = new System.Windows.Forms.Button();
            this.cmd22rpm = new System.Windows.Forms.Button();
            this.cmd16rpm = new System.Windows.Forms.Button();
            this.pnlLatheMoves = new System.Windows.Forms.Panel();
            this.cmdZero = new System.Windows.Forms.Button();
            this.cmdLatheForth = new System.Windows.Forms.Button();
            this.cmdStop = new System.Windows.Forms.Button();
            this.cmdLatheBack = new System.Windows.Forms.Button();
            this.cmdReturnLathe = new System.Windows.Forms.Button();
            this.cmdCutRecord = new System.Windows.Forms.Button();
            this.pnlTrackAdmin = new System.Windows.Forms.Panel();
            this.cmdRemoveTrack = new System.Windows.Forms.Button();
            this.cmdMoveDown = new System.Windows.Forms.Button();
            this.cmdMoveUp = new System.Windows.Forms.Button();
            this.cmdUseFile = new System.Windows.Forms.Button();
            this.cmdInsertTrack = new System.Windows.Forms.Button();
            this.cmdAppendTrack = new System.Windows.Forms.Button();
            this.pnlRecordSizes = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.nudStartRadius = new System.Windows.Forms.NumericUpDown();
            this.lblLastTrackGrooveRadius = new System.Windows.Forms.Label();
            this.lblLockGrooveRadius = new System.Windows.Forms.Label();
            this.lblStartRadius = new System.Windows.Forms.Label();
            this.pnlRecordSettings = new System.Windows.Forms.Panel();
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
            ((System.ComponentModel.ISupportInitialize)(this.axWMP1)).BeginInit();
            this.pnlSpeed.SuspendLayout();
            this.pnlLatheMoves.SuspendLayout();
            this.pnlTrackAdmin.SuspendLayout();
            this.pnlRecordSizes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartRadius)).BeginInit();
            this.pnlRecordSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRunOutLPcm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRunInWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRunInLPcm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSetDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSetDownLPcm)).BeginInit();
            this.SuspendLayout();
            // 
            // axWMP1
            // 
            this.axWMP1.Enabled = true;
            this.axWMP1.Location = new System.Drawing.Point(602, 10);
            this.axWMP1.Name = "axWMP1";
            this.axWMP1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWMP1.OcxState")));
            this.axWMP1.Size = new System.Drawing.Size(221, 63);
            this.axWMP1.TabIndex = 3;
            // 
            // pnlTracks
            // 
            this.pnlTracks.BackColor = System.Drawing.Color.Transparent;
            this.pnlTracks.Location = new System.Drawing.Point(10, 273);
            this.pnlTracks.Name = "pnlTracks";
            this.pnlTracks.Size = new System.Drawing.Size(813, 195);
            this.pnlTracks.TabIndex = 4;
            // 
            // pnlSpeed
            // 
            this.pnlSpeed.BackgroundImage = global::TrackHarness.Properties.Resources.disc_speed;
            this.pnlSpeed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlSpeed.Controls.Add(this.cmd45rpm);
            this.pnlSpeed.Controls.Add(this.cmd39rpm);
            this.pnlSpeed.Controls.Add(this.cmd33rpm);
            this.pnlSpeed.Controls.Add(this.cmd22rpm);
            this.pnlSpeed.Controls.Add(this.cmd16rpm);
            this.pnlSpeed.Location = new System.Drawing.Point(10, 22);
            this.pnlSpeed.Name = "pnlSpeed";
            this.pnlSpeed.Size = new System.Drawing.Size(167, 51);
            this.pnlSpeed.TabIndex = 6;
            // 
            // cmd45rpm
            // 
            this.cmd45rpm.BackColor = System.Drawing.Color.Transparent;
            this.cmd45rpm.Location = new System.Drawing.Point(131, 19);
            this.cmd45rpm.Name = "cmd45rpm";
            this.cmd45rpm.Size = new System.Drawing.Size(32, 32);
            this.cmd45rpm.TabIndex = 4;
            this.cmd45rpm.UseVisualStyleBackColor = false;
            this.cmd45rpm.Click += new System.EventHandler(this.cmdSpeed_Click);
            // 
            // cmd39rpm
            // 
            this.cmd39rpm.BackColor = System.Drawing.Color.Transparent;
            this.cmd39rpm.Location = new System.Drawing.Point(99, 19);
            this.cmd39rpm.Name = "cmd39rpm";
            this.cmd39rpm.Size = new System.Drawing.Size(32, 32);
            this.cmd39rpm.TabIndex = 3;
            this.cmd39rpm.UseVisualStyleBackColor = false;
            this.cmd39rpm.Click += new System.EventHandler(this.cmdSpeed_Click);
            // 
            // cmd33rpm
            // 
            this.cmd33rpm.BackColor = System.Drawing.Color.Transparent;
            this.cmd33rpm.Location = new System.Drawing.Point(67, 19);
            this.cmd33rpm.Name = "cmd33rpm";
            this.cmd33rpm.Size = new System.Drawing.Size(32, 32);
            this.cmd33rpm.TabIndex = 2;
            this.cmd33rpm.UseVisualStyleBackColor = false;
            this.cmd33rpm.Click += new System.EventHandler(this.cmdSpeed_Click);
            // 
            // cmd22rpm
            // 
            this.cmd22rpm.BackColor = System.Drawing.Color.Transparent;
            this.cmd22rpm.Location = new System.Drawing.Point(35, 19);
            this.cmd22rpm.Name = "cmd22rpm";
            this.cmd22rpm.Size = new System.Drawing.Size(32, 32);
            this.cmd22rpm.TabIndex = 1;
            this.cmd22rpm.UseVisualStyleBackColor = false;
            this.cmd22rpm.Click += new System.EventHandler(this.cmdSpeed_Click);
            // 
            // cmd16rpm
            // 
            this.cmd16rpm.BackColor = System.Drawing.Color.Transparent;
            this.cmd16rpm.Location = new System.Drawing.Point(3, 19);
            this.cmd16rpm.Name = "cmd16rpm";
            this.cmd16rpm.Size = new System.Drawing.Size(32, 32);
            this.cmd16rpm.TabIndex = 0;
            this.cmd16rpm.UseVisualStyleBackColor = false;
            this.cmd16rpm.Click += new System.EventHandler(this.cmdSpeed_Click);
            // 
            // pnlLatheMoves
            // 
            this.pnlLatheMoves.BackgroundImage = global::TrackHarness.Properties.Resources.lathecontrol;
            this.pnlLatheMoves.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlLatheMoves.Controls.Add(this.cmdZero);
            this.pnlLatheMoves.Controls.Add(this.cmdLatheForth);
            this.pnlLatheMoves.Controls.Add(this.cmdStop);
            this.pnlLatheMoves.Controls.Add(this.cmdLatheBack);
            this.pnlLatheMoves.Controls.Add(this.cmdReturnLathe);
            this.pnlLatheMoves.Controls.Add(this.cmdCutRecord);
            this.pnlLatheMoves.Location = new System.Drawing.Point(183, 22);
            this.pnlLatheMoves.Name = "pnlLatheMoves";
            this.pnlLatheMoves.Size = new System.Drawing.Size(200, 51);
            this.pnlLatheMoves.TabIndex = 7;
            // 
            // cmdZero
            // 
            this.cmdZero.BackColor = System.Drawing.Color.Transparent;
            this.cmdZero.Image = global::TrackHarness.Properties.Resources._24x24_zero_counter;
            this.cmdZero.Location = new System.Drawing.Point(163, 19);
            this.cmdZero.Name = "cmdZero";
            this.cmdZero.Size = new System.Drawing.Size(32, 32);
            this.cmdZero.TabIndex = 6;
            this.cmdZero.UseVisualStyleBackColor = false;
            // 
            // cmdLatheForth
            // 
            this.cmdLatheForth.BackColor = System.Drawing.Color.Transparent;
            this.cmdLatheForth.Image = global::TrackHarness.Properties.Resources._24x24_wind_forward;
            this.cmdLatheForth.Location = new System.Drawing.Point(131, 19);
            this.cmdLatheForth.Name = "cmdLatheForth";
            this.cmdLatheForth.Size = new System.Drawing.Size(32, 32);
            this.cmdLatheForth.TabIndex = 5;
            this.cmdLatheForth.UseVisualStyleBackColor = false;
            // 
            // cmdStop
            // 
            this.cmdStop.BackColor = System.Drawing.Color.Transparent;
            this.cmdStop.Image = global::TrackHarness.Properties.Resources._24x24_lathe_stop;
            this.cmdStop.Location = new System.Drawing.Point(99, 19);
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.Size = new System.Drawing.Size(32, 32);
            this.cmdStop.TabIndex = 4;
            this.cmdStop.UseVisualStyleBackColor = false;
            // 
            // cmdLatheBack
            // 
            this.cmdLatheBack.BackColor = System.Drawing.Color.Transparent;
            this.cmdLatheBack.Image = global::TrackHarness.Properties.Resources._24x24_wind_backward;
            this.cmdLatheBack.Location = new System.Drawing.Point(67, 19);
            this.cmdLatheBack.Name = "cmdLatheBack";
            this.cmdLatheBack.Size = new System.Drawing.Size(32, 32);
            this.cmdLatheBack.TabIndex = 3;
            this.cmdLatheBack.UseVisualStyleBackColor = false;
            // 
            // cmdReturnLathe
            // 
            this.cmdReturnLathe.BackColor = System.Drawing.Color.Transparent;
            this.cmdReturnLathe.Image = global::TrackHarness.Properties.Resources._24x24_return_lathe;
            this.cmdReturnLathe.Location = new System.Drawing.Point(35, 19);
            this.cmdReturnLathe.Name = "cmdReturnLathe";
            this.cmdReturnLathe.Size = new System.Drawing.Size(32, 32);
            this.cmdReturnLathe.TabIndex = 2;
            this.cmdReturnLathe.UseVisualStyleBackColor = false;
            // 
            // cmdCutRecord
            // 
            this.cmdCutRecord.BackColor = System.Drawing.Color.Transparent;
            this.cmdCutRecord.Image = global::TrackHarness.Properties.Resources._24x24_start_cut;
            this.cmdCutRecord.Location = new System.Drawing.Point(3, 19);
            this.cmdCutRecord.Name = "cmdCutRecord";
            this.cmdCutRecord.Size = new System.Drawing.Size(32, 32);
            this.cmdCutRecord.TabIndex = 1;
            this.cmdCutRecord.UseVisualStyleBackColor = false;
            // 
            // pnlTrackAdmin
            // 
            this.pnlTrackAdmin.BackgroundImage = global::TrackHarness.Properties.Resources.trackorder;
            this.pnlTrackAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlTrackAdmin.Controls.Add(this.cmdRemoveTrack);
            this.pnlTrackAdmin.Controls.Add(this.cmdMoveDown);
            this.pnlTrackAdmin.Controls.Add(this.cmdMoveUp);
            this.pnlTrackAdmin.Controls.Add(this.cmdUseFile);
            this.pnlTrackAdmin.Controls.Add(this.cmdInsertTrack);
            this.pnlTrackAdmin.Controls.Add(this.cmdAppendTrack);
            this.pnlTrackAdmin.Location = new System.Drawing.Point(389, 22);
            this.pnlTrackAdmin.Name = "pnlTrackAdmin";
            this.pnlTrackAdmin.Size = new System.Drawing.Size(200, 51);
            this.pnlTrackAdmin.TabIndex = 8;
            // 
            // cmdRemoveTrack
            // 
            this.cmdRemoveTrack.BackColor = System.Drawing.Color.Transparent;
            this.cmdRemoveTrack.Image = global::TrackHarness.Properties.Resources._24x24_delete;
            this.cmdRemoveTrack.Location = new System.Drawing.Point(163, 19);
            this.cmdRemoveTrack.Name = "cmdRemoveTrack";
            this.cmdRemoveTrack.Size = new System.Drawing.Size(32, 32);
            this.cmdRemoveTrack.TabIndex = 7;
            this.cmdRemoveTrack.UseVisualStyleBackColor = false;
            // 
            // cmdMoveDown
            // 
            this.cmdMoveDown.BackColor = System.Drawing.Color.Transparent;
            this.cmdMoveDown.Image = global::TrackHarness.Properties.Resources._24x24_arrow_down;
            this.cmdMoveDown.Location = new System.Drawing.Point(131, 19);
            this.cmdMoveDown.Name = "cmdMoveDown";
            this.cmdMoveDown.Size = new System.Drawing.Size(32, 32);
            this.cmdMoveDown.TabIndex = 6;
            this.cmdMoveDown.UseVisualStyleBackColor = false;
            this.cmdMoveDown.Click += new System.EventHandler(this.cmdMoveDown_Click);
            // 
            // cmdMoveUp
            // 
            this.cmdMoveUp.BackColor = System.Drawing.Color.Transparent;
            this.cmdMoveUp.Image = global::TrackHarness.Properties.Resources._24x24_arrow_up;
            this.cmdMoveUp.Location = new System.Drawing.Point(99, 19);
            this.cmdMoveUp.Name = "cmdMoveUp";
            this.cmdMoveUp.Size = new System.Drawing.Size(32, 32);
            this.cmdMoveUp.TabIndex = 5;
            this.cmdMoveUp.UseVisualStyleBackColor = false;
            this.cmdMoveUp.Click += new System.EventHandler(this.cmdMoveUp_Click);
            // 
            // cmdUseFile
            // 
            this.cmdUseFile.BackColor = System.Drawing.Color.Transparent;
            this.cmdUseFile.Image = global::TrackHarness.Properties.Resources._24x24_use_file;
            this.cmdUseFile.Location = new System.Drawing.Point(3, 19);
            this.cmdUseFile.Name = "cmdUseFile";
            this.cmdUseFile.Size = new System.Drawing.Size(32, 32);
            this.cmdUseFile.TabIndex = 4;
            this.cmdUseFile.UseVisualStyleBackColor = false;
            this.cmdUseFile.Click += new System.EventHandler(this.cmdUseFile_Click);
            // 
            // cmdInsertTrack
            // 
            this.cmdInsertTrack.BackColor = System.Drawing.Color.Transparent;
            this.cmdInsertTrack.Image = global::TrackHarness.Properties.Resources._24x24_insert;
            this.cmdInsertTrack.Location = new System.Drawing.Point(35, 19);
            this.cmdInsertTrack.Name = "cmdInsertTrack";
            this.cmdInsertTrack.Size = new System.Drawing.Size(32, 32);
            this.cmdInsertTrack.TabIndex = 3;
            this.cmdInsertTrack.UseVisualStyleBackColor = false;
            this.cmdInsertTrack.Click += new System.EventHandler(this.cmdInsertTrack_Click);
            // 
            // cmdAppendTrack
            // 
            this.cmdAppendTrack.BackColor = System.Drawing.Color.Transparent;
            this.cmdAppendTrack.Image = global::TrackHarness.Properties.Resources._24x24_append;
            this.cmdAppendTrack.Location = new System.Drawing.Point(67, 19);
            this.cmdAppendTrack.Name = "cmdAppendTrack";
            this.cmdAppendTrack.Size = new System.Drawing.Size(32, 32);
            this.cmdAppendTrack.TabIndex = 2;
            this.cmdAppendTrack.UseVisualStyleBackColor = false;
            this.cmdAppendTrack.Click += new System.EventHandler(this.cmdAppendTrack_Click);
            // 
            // pnlRecordSizes
            // 
            this.pnlRecordSizes.Controls.Add(this.numericUpDown1);
            this.pnlRecordSizes.Controls.Add(this.nudStartRadius);
            this.pnlRecordSizes.Controls.Add(this.lblLastTrackGrooveRadius);
            this.pnlRecordSizes.Controls.Add(this.lblLockGrooveRadius);
            this.pnlRecordSizes.Controls.Add(this.lblStartRadius);
            this.pnlRecordSizes.Location = new System.Drawing.Point(10, 79);
            this.pnlRecordSizes.Name = "pnlRecordSizes";
            this.pnlRecordSizes.Size = new System.Drawing.Size(813, 27);
            this.pnlRecordSizes.TabIndex = 9;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.ForeColor = System.Drawing.Color.White;
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown1.Location = new System.Drawing.Point(360, 4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(51, 18);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
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
            // lblLastTrackGrooveRadius
            // 
            this.lblLastTrackGrooveRadius.AutoSize = true;
            this.lblLastTrackGrooveRadius.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastTrackGrooveRadius.ForeColor = System.Drawing.Color.White;
            this.lblLastTrackGrooveRadius.Location = new System.Drawing.Point(451, 4);
            this.lblLastTrackGrooveRadius.Name = "lblLastTrackGrooveRadius";
            this.lblLastTrackGrooveRadius.Size = new System.Drawing.Size(200, 14);
            this.lblLastTrackGrooveRadius.TabIndex = 2;
            this.lblLastTrackGrooveRadius.Text = "Last track groove radius (cm): ";
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
            // pnlRecordSettings
            // 
            this.pnlRecordSettings.Controls.Add(this.lblTotalDuration);
            this.pnlRecordSettings.Controls.Add(this.lblRunOutDuration);
            this.pnlRecordSettings.Controls.Add(this.lblRunInDuration);
            this.pnlRecordSettings.Controls.Add(this.lblSetDownDuration);
            this.pnlRecordSettings.Controls.Add(this.lblSpaceRemaining);
            this.pnlRecordSettings.Controls.Add(this.lblRunOutWidth);
            this.pnlRecordSettings.Controls.Add(this.nudRunOutLPcm);
            this.pnlRecordSettings.Controls.Add(this.nudRunInWidth);
            this.pnlRecordSettings.Controls.Add(this.nudRunInLPcm);
            this.pnlRecordSettings.Controls.Add(this.nudSetDownWidth);
            this.pnlRecordSettings.Controls.Add(this.nudSetDownLPcm);
            this.pnlRecordSettings.Controls.Add(this.label8);
            this.pnlRecordSettings.Controls.Add(this.label7);
            this.pnlRecordSettings.Controls.Add(this.label6);
            this.pnlRecordSettings.Controls.Add(this.label5);
            this.pnlRecordSettings.Controls.Add(this.label4);
            this.pnlRecordSettings.Controls.Add(this.label3);
            this.pnlRecordSettings.Controls.Add(this.label2);
            this.pnlRecordSettings.Controls.Add(this.label1);
            this.pnlRecordSettings.Location = new System.Drawing.Point(10, 112);
            this.pnlRecordSettings.Name = "pnlRecordSettings";
            this.pnlRecordSettings.Size = new System.Drawing.Size(813, 155);
            this.pnlRecordSettings.TabIndex = 10;
            // 
            // lblTotalDuration
            // 
            this.lblTotalDuration.AutoSize = true;
            this.lblTotalDuration.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDuration.ForeColor = System.Drawing.Color.White;
            this.lblTotalDuration.Location = new System.Drawing.Point(346, 100);
            this.lblTotalDuration.Name = "lblTotalDuration";
            this.lblTotalDuration.Size = new System.Drawing.Size(27, 14);
            this.lblTotalDuration.TabIndex = 18;
            this.lblTotalDuration.Text = "0.0";
            // 
            // lblRunOutDuration
            // 
            this.lblRunOutDuration.AutoSize = true;
            this.lblRunOutDuration.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunOutDuration.ForeColor = System.Drawing.Color.White;
            this.lblRunOutDuration.Location = new System.Drawing.Point(346, 73);
            this.lblRunOutDuration.Name = "lblRunOutDuration";
            this.lblRunOutDuration.Size = new System.Drawing.Size(27, 14);
            this.lblRunOutDuration.TabIndex = 17;
            this.lblRunOutDuration.Text = "0.0";
            // 
            // lblRunInDuration
            // 
            this.lblRunInDuration.AutoSize = true;
            this.lblRunInDuration.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunInDuration.ForeColor = System.Drawing.Color.White;
            this.lblRunInDuration.Location = new System.Drawing.Point(346, 50);
            this.lblRunInDuration.Name = "lblRunInDuration";
            this.lblRunInDuration.Size = new System.Drawing.Size(27, 14);
            this.lblRunInDuration.TabIndex = 16;
            this.lblRunInDuration.Text = "0.0";
            // 
            // lblSetDownDuration
            // 
            this.lblSetDownDuration.AutoSize = true;
            this.lblSetDownDuration.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetDownDuration.ForeColor = System.Drawing.Color.White;
            this.lblSetDownDuration.Location = new System.Drawing.Point(346, 25);
            this.lblSetDownDuration.Name = "lblSetDownDuration";
            this.lblSetDownDuration.Size = new System.Drawing.Size(27, 14);
            this.lblSetDownDuration.TabIndex = 15;
            this.lblSetDownDuration.Text = "0.0";
            // 
            // lblSpaceRemaining
            // 
            this.lblSpaceRemaining.AutoSize = true;
            this.lblSpaceRemaining.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpaceRemaining.ForeColor = System.Drawing.Color.White;
            this.lblSpaceRemaining.Location = new System.Drawing.Point(237, 128);
            this.lblSpaceRemaining.Name = "lblSpaceRemaining";
            this.lblSpaceRemaining.Size = new System.Drawing.Size(27, 14);
            this.lblSpaceRemaining.TabIndex = 14;
            this.lblSpaceRemaining.Text = "0.0";
            // 
            // lblRunOutWidth
            // 
            this.lblRunOutWidth.AutoSize = true;
            this.lblRunOutWidth.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunOutWidth.ForeColor = System.Drawing.Color.White;
            this.lblRunOutWidth.Location = new System.Drawing.Point(237, 74);
            this.lblRunOutWidth.Name = "lblRunOutWidth";
            this.lblRunOutWidth.Size = new System.Drawing.Size(27, 14);
            this.lblRunOutWidth.TabIndex = 13;
            this.lblRunOutWidth.Text = "0.0";
            // 
            // nudRunOutLPcm
            // 
            this.nudRunOutLPcm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudRunOutLPcm.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudRunOutLPcm.ForeColor = System.Drawing.Color.White;
            this.nudRunOutLPcm.Location = new System.Drawing.Point(149, 74);
            this.nudRunOutLPcm.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudRunOutLPcm.Name = "nudRunOutLPcm";
            this.nudRunOutLPcm.Size = new System.Drawing.Size(50, 18);
            this.nudRunOutLPcm.TabIndex = 12;
            this.nudRunOutLPcm.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // nudRunInWidth
            // 
            this.nudRunInWidth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudRunInWidth.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudRunInWidth.ForeColor = System.Drawing.Color.White;
            this.nudRunInWidth.Location = new System.Drawing.Point(240, 50);
            this.nudRunInWidth.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudRunInWidth.Name = "nudRunInWidth";
            this.nudRunInWidth.Size = new System.Drawing.Size(50, 18);
            this.nudRunInWidth.TabIndex = 11;
            this.nudRunInWidth.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // nudRunInLPcm
            // 
            this.nudRunInLPcm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudRunInLPcm.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudRunInLPcm.ForeColor = System.Drawing.Color.White;
            this.nudRunInLPcm.Location = new System.Drawing.Point(149, 50);
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
            this.nudSetDownWidth.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSetDownWidth.ForeColor = System.Drawing.Color.White;
            this.nudSetDownWidth.Location = new System.Drawing.Point(240, 26);
            this.nudSetDownWidth.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudSetDownWidth.Name = "nudSetDownWidth";
            this.nudSetDownWidth.Size = new System.Drawing.Size(50, 18);
            this.nudSetDownWidth.TabIndex = 9;
            this.nudSetDownWidth.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // nudSetDownLPcm
            // 
            this.nudSetDownLPcm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudSetDownLPcm.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSetDownLPcm.ForeColor = System.Drawing.Color.White;
            this.nudSetDownLPcm.Location = new System.Drawing.Point(149, 26);
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
            this.label5.Location = new System.Drawing.Point(32, 128);
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
            this.label4.Location = new System.Drawing.Point(32, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total duration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 74);
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
            this.label1.Location = new System.Drawing.Point(32, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Set-down";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(842, 480);
            this.Controls.Add(this.pnlRecordSettings);
            this.Controls.Add(this.pnlRecordSizes);
            this.Controls.Add(this.pnlTrackAdmin);
            this.Controls.Add(this.pnlLatheMoves);
            this.Controls.Add(this.pnlSpeed);
            this.Controls.Add(this.pnlTracks);
            this.Controls.Add(this.axWMP1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axWMP1)).EndInit();
            this.pnlSpeed.ResumeLayout(false);
            this.pnlLatheMoves.ResumeLayout(false);
            this.pnlTrackAdmin.ResumeLayout(false);
            this.pnlRecordSizes.ResumeLayout(false);
            this.pnlRecordSizes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartRadius)).EndInit();
            this.pnlRecordSettings.ResumeLayout(false);
            this.pnlRecordSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRunOutLPcm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRunInWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRunInLPcm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSetDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSetDownLPcm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AxWMPLib.AxWindowsMediaPlayer axWMP1;
        private System.Windows.Forms.Panel pnlTracks;
        private System.Windows.Forms.Panel pnlSpeed;
        private System.Windows.Forms.Button cmd45rpm;
        private System.Windows.Forms.Button cmd39rpm;
        private System.Windows.Forms.Button cmd33rpm;
        private System.Windows.Forms.Button cmd22rpm;
        private System.Windows.Forms.Button cmd16rpm;
        private System.Windows.Forms.Panel pnlLatheMoves;
        private System.Windows.Forms.Button cmdZero;
        private System.Windows.Forms.Button cmdLatheForth;
        private System.Windows.Forms.Button cmdStop;
        private System.Windows.Forms.Button cmdLatheBack;
        private System.Windows.Forms.Button cmdReturnLathe;
        private System.Windows.Forms.Button cmdCutRecord;
        private System.Windows.Forms.Panel pnlTrackAdmin;
        private System.Windows.Forms.Button cmdRemoveTrack;
        private System.Windows.Forms.Button cmdMoveDown;
        private System.Windows.Forms.Button cmdMoveUp;
        private System.Windows.Forms.Button cmdUseFile;
        private System.Windows.Forms.Button cmdInsertTrack;
        private System.Windows.Forms.Button cmdAppendTrack;
        private System.Windows.Forms.Panel pnlRecordSizes;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown nudStartRadius;
        private System.Windows.Forms.Label lblLastTrackGrooveRadius;
        private System.Windows.Forms.Label lblLockGrooveRadius;
        private System.Windows.Forms.Label lblStartRadius;
        private System.Windows.Forms.Panel pnlRecordSettings;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
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
    }
}

