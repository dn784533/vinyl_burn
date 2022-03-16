namespace VinylBurnUI
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.stripStatus = new System.Windows.Forms.StatusStrip();
            this.tslPort = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslMotorSteps = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslMotorStepsRequired = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslEndPhaseAtStep = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslLimitLo = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslLimitHi = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.serArduino = new System.IO.Ports.SerialPort(this.components);
            this.tmrSegment = new System.Windows.Forms.Timer(this.components);
            this.axWMP1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTrackAdmin = new System.Windows.Forms.Panel();
            this.cmdRemoveTrack = new System.Windows.Forms.Button();
            this.cmdMoveDown = new System.Windows.Forms.Button();
            this.cmdMoveUp = new System.Windows.Forms.Button();
            this.cmdUseFile = new System.Windows.Forms.Button();
            this.cmdInsertTrack = new System.Windows.Forms.Button();
            this.cmdAppendTrack = new System.Windows.Forms.Button();
            this.pnlLatheMoves = new System.Windows.Forms.Panel();
            this.cmdTestCut = new System.Windows.Forms.Button();
            this.cmdZero = new System.Windows.Forms.Button();
            this.cmdLatheForth = new System.Windows.Forms.Button();
            this.cmdStop = new System.Windows.Forms.Button();
            this.cmdLatheBack = new System.Windows.Forms.Button();
            this.cmdReturnLathe = new System.Windows.Forms.Button();
            this.cmdCutRecord = new System.Windows.Forms.Button();
            this.pnlSpeed = new System.Windows.Forms.Panel();
            this.dbn45rpm = new VinylBurnUI.DataButton();
            this.dbn39rpm = new VinylBurnUI.DataButton();
            this.dbn33rpm = new VinylBurnUI.DataButton();
            this.dbn22rpm = new VinylBurnUI.DataButton();
            this.dbn16rpm = new VinylBurnUI.DataButton();
            this.dbn08rpm = new VinylBurnUI.DataButton();
            this.stripStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWMP1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.pnlTrackAdmin.SuspendLayout();
            this.pnlLatheMoves.SuspendLayout();
            this.pnlSpeed.SuspendLayout();
            this.SuspendLayout();
            // 
            // stripStatus
            // 
            this.stripStatus.BackColor = System.Drawing.Color.Transparent;
            this.stripStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslPort,
            this.tslStatus,
            this.tslMotorSteps,
            this.tslMotorStepsRequired,
            this.tslEndPhaseAtStep,
            this.tslLimitLo,
            this.tslLimitHi,
            this.tslMessage});
            this.stripStatus.Location = new System.Drawing.Point(0, 707);
            this.stripStatus.MaximumSize = new System.Drawing.Size(1200, 22);
            this.stripStatus.Name = "stripStatus";
            this.stripStatus.Size = new System.Drawing.Size(1008, 22);
            this.stripStatus.SizingGrip = false;
            this.stripStatus.Stretch = false;
            this.stripStatus.TabIndex = 11;
            // 
            // tslPort
            // 
            this.tslPort.AutoSize = false;
            this.tslPort.Name = "tslPort";
            this.tslPort.Size = new System.Drawing.Size(240, 17);
            this.tslPort.Text = "(No device found)";
            this.tslPort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tslStatus
            // 
            this.tslStatus.AutoSize = false;
            this.tslStatus.Name = "tslStatus";
            this.tslStatus.Size = new System.Drawing.Size(75, 17);
            this.tslStatus.Text = "Idle";
            this.tslStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tslMotorSteps
            // 
            this.tslMotorSteps.AutoSize = false;
            this.tslMotorSteps.Name = "tslMotorSteps";
            this.tslMotorSteps.Size = new System.Drawing.Size(150, 17);
            this.tslMotorSteps.Text = "Motor: ";
            this.tslMotorSteps.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tslMotorStepsRequired
            // 
            this.tslMotorStepsRequired.AutoSize = false;
            this.tslMotorStepsRequired.Name = "tslMotorStepsRequired";
            this.tslMotorStepsRequired.Size = new System.Drawing.Size(150, 17);
            this.tslMotorStepsRequired.Text = "Steps required:";
            this.tslMotorStepsRequired.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tslEndPhaseAtStep
            // 
            this.tslEndPhaseAtStep.AutoSize = false;
            this.tslEndPhaseAtStep.Name = "tslEndPhaseAtStep";
            this.tslEndPhaseAtStep.Size = new System.Drawing.Size(150, 17);
            this.tslEndPhaseAtStep.Text = "End phase at step: ";
            this.tslEndPhaseAtStep.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // tslLimitLo
            // 
            this.tslLimitLo.Name = "tslLimitLo";
            this.tslLimitLo.Size = new System.Drawing.Size(13, 17);
            this.tslLimitLo.Text = "L";
            // 
            // tslLimitHi
            // 
            this.tslLimitHi.Name = "tslLimitHi";
            this.tslLimitHi.Size = new System.Drawing.Size(16, 17);
            this.tslLimitHi.Text = "H";
            // 
            // tslMessage
            // 
            this.tslMessage.Name = "tslMessage";
            this.tslMessage.Size = new System.Drawing.Size(40, 17);
            this.tslMessage.Text = "           ";
            // 
            // tmrSegment
            // 
            this.tmrSegment.Tick += new System.EventHandler(this.tmrSegment_Tick);
            // 
            // axWMP1
            // 
            this.axWMP1.Enabled = true;
            this.axWMP1.Location = new System.Drawing.Point(696, 17);
            this.axWMP1.Name = "axWMP1";
            this.axWMP1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWMP1.OcxState")));
            this.axWMP1.Size = new System.Drawing.Size(221, 63);
            this.axWMP1.TabIndex = 3;
            this.axWMP1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWMP1_PlayStateChange);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // pnlTrackAdmin
            // 
            this.pnlTrackAdmin.BackgroundImage = global::VinylBurnUI.Properties.Resources.trackorder;
            this.pnlTrackAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlTrackAdmin.Controls.Add(this.cmdRemoveTrack);
            this.pnlTrackAdmin.Controls.Add(this.cmdMoveDown);
            this.pnlTrackAdmin.Controls.Add(this.cmdMoveUp);
            this.pnlTrackAdmin.Controls.Add(this.cmdUseFile);
            this.pnlTrackAdmin.Controls.Add(this.cmdInsertTrack);
            this.pnlTrackAdmin.Controls.Add(this.cmdAppendTrack);
            this.pnlTrackAdmin.Location = new System.Drawing.Point(476, 29);
            this.pnlTrackAdmin.Name = "pnlTrackAdmin";
            this.pnlTrackAdmin.Size = new System.Drawing.Size(200, 51);
            this.pnlTrackAdmin.TabIndex = 8;
            // 
            // cmdRemoveTrack
            // 
            this.cmdRemoveTrack.BackColor = System.Drawing.Color.Transparent;
            this.cmdRemoveTrack.Image = global::VinylBurnUI.Properties.Resources._24x24_delete;
            this.cmdRemoveTrack.Location = new System.Drawing.Point(168, 19);
            this.cmdRemoveTrack.Name = "cmdRemoveTrack";
            this.cmdRemoveTrack.Size = new System.Drawing.Size(32, 32);
            this.cmdRemoveTrack.TabIndex = 7;
            this.cmdRemoveTrack.UseVisualStyleBackColor = false;
            this.cmdRemoveTrack.Click += new System.EventHandler(this.cmdRemoveTrack_Click);
            // 
            // cmdMoveDown
            // 
            this.cmdMoveDown.BackColor = System.Drawing.Color.Transparent;
            this.cmdMoveDown.Image = global::VinylBurnUI.Properties.Resources._24x24_arrow_down;
            this.cmdMoveDown.Location = new System.Drawing.Point(136, 19);
            this.cmdMoveDown.Name = "cmdMoveDown";
            this.cmdMoveDown.Size = new System.Drawing.Size(32, 32);
            this.cmdMoveDown.TabIndex = 6;
            this.cmdMoveDown.UseVisualStyleBackColor = false;
            this.cmdMoveDown.Click += new System.EventHandler(this.cmdMoveDown_Click);
            // 
            // cmdMoveUp
            // 
            this.cmdMoveUp.BackColor = System.Drawing.Color.Transparent;
            this.cmdMoveUp.Image = global::VinylBurnUI.Properties.Resources._24x24_arrow_up;
            this.cmdMoveUp.Location = new System.Drawing.Point(104, 19);
            this.cmdMoveUp.Name = "cmdMoveUp";
            this.cmdMoveUp.Size = new System.Drawing.Size(32, 32);
            this.cmdMoveUp.TabIndex = 5;
            this.cmdMoveUp.UseVisualStyleBackColor = false;
            this.cmdMoveUp.Click += new System.EventHandler(this.cmdMoveUp_Click);
            // 
            // cmdUseFile
            // 
            this.cmdUseFile.BackColor = System.Drawing.Color.Transparent;
            this.cmdUseFile.Image = global::VinylBurnUI.Properties.Resources._24x24_use_file;
            this.cmdUseFile.Location = new System.Drawing.Point(8, 19);
            this.cmdUseFile.Name = "cmdUseFile";
            this.cmdUseFile.Size = new System.Drawing.Size(32, 32);
            this.cmdUseFile.TabIndex = 4;
            this.cmdUseFile.UseVisualStyleBackColor = false;
            this.cmdUseFile.Click += new System.EventHandler(this.cmdUseFile_Click);
            // 
            // cmdInsertTrack
            // 
            this.cmdInsertTrack.BackColor = System.Drawing.Color.Transparent;
            this.cmdInsertTrack.Image = global::VinylBurnUI.Properties.Resources._24x24_insert;
            this.cmdInsertTrack.Location = new System.Drawing.Point(40, 19);
            this.cmdInsertTrack.Name = "cmdInsertTrack";
            this.cmdInsertTrack.Size = new System.Drawing.Size(32, 32);
            this.cmdInsertTrack.TabIndex = 3;
            this.cmdInsertTrack.UseVisualStyleBackColor = false;
            this.cmdInsertTrack.Click += new System.EventHandler(this.cmdInsertTrack_Click);
            // 
            // cmdAppendTrack
            // 
            this.cmdAppendTrack.BackColor = System.Drawing.Color.Transparent;
            this.cmdAppendTrack.Image = global::VinylBurnUI.Properties.Resources._24x24_append;
            this.cmdAppendTrack.Location = new System.Drawing.Point(72, 19);
            this.cmdAppendTrack.Name = "cmdAppendTrack";
            this.cmdAppendTrack.Size = new System.Drawing.Size(32, 32);
            this.cmdAppendTrack.TabIndex = 2;
            this.cmdAppendTrack.UseVisualStyleBackColor = false;
            this.cmdAppendTrack.Click += new System.EventHandler(this.cmdAppendTrack_Click);
            // 
            // pnlLatheMoves
            // 
            this.pnlLatheMoves.BackgroundImage = global::VinylBurnUI.Properties.Resources.lathecontrol;
            this.pnlLatheMoves.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlLatheMoves.Controls.Add(this.cmdTestCut);
            this.pnlLatheMoves.Controls.Add(this.cmdZero);
            this.pnlLatheMoves.Controls.Add(this.cmdLatheForth);
            this.pnlLatheMoves.Controls.Add(this.cmdStop);
            this.pnlLatheMoves.Controls.Add(this.cmdLatheBack);
            this.pnlLatheMoves.Controls.Add(this.cmdReturnLathe);
            this.pnlLatheMoves.Controls.Add(this.cmdCutRecord);
            this.pnlLatheMoves.Location = new System.Drawing.Point(232, 29);
            this.pnlLatheMoves.Name = "pnlLatheMoves";
            this.pnlLatheMoves.Size = new System.Drawing.Size(236, 51);
            this.pnlLatheMoves.TabIndex = 7;
            // 
            // cmdTestCut
            // 
            this.cmdTestCut.BackColor = System.Drawing.Color.Transparent;
            this.cmdTestCut.Image = global::VinylBurnUI.Properties.Resources._24x24_test_cut;
            this.cmdTestCut.Location = new System.Drawing.Point(200, 19);
            this.cmdTestCut.Name = "cmdTestCut";
            this.cmdTestCut.Size = new System.Drawing.Size(32, 32);
            this.cmdTestCut.TabIndex = 7;
            this.cmdTestCut.UseVisualStyleBackColor = false;
            this.cmdTestCut.Click += new System.EventHandler(this.cmdTestCut_Click);
            // 
            // cmdZero
            // 
            this.cmdZero.BackColor = System.Drawing.Color.Transparent;
            this.cmdZero.Image = global::VinylBurnUI.Properties.Resources._24x24_zero_counter;
            this.cmdZero.Location = new System.Drawing.Point(168, 19);
            this.cmdZero.Name = "cmdZero";
            this.cmdZero.Size = new System.Drawing.Size(32, 32);
            this.cmdZero.TabIndex = 6;
            this.cmdZero.UseVisualStyleBackColor = false;
            this.cmdZero.Click += new System.EventHandler(this.cmdZero_Click);
            // 
            // cmdLatheForth
            // 
            this.cmdLatheForth.BackColor = System.Drawing.Color.Transparent;
            this.cmdLatheForth.Image = global::VinylBurnUI.Properties.Resources._24x24_wind_forward;
            this.cmdLatheForth.Location = new System.Drawing.Point(136, 19);
            this.cmdLatheForth.Name = "cmdLatheForth";
            this.cmdLatheForth.Size = new System.Drawing.Size(32, 32);
            this.cmdLatheForth.TabIndex = 5;
            this.cmdLatheForth.UseVisualStyleBackColor = false;
            this.cmdLatheForth.Click += new System.EventHandler(this.cmdLatheForth_Click);
            // 
            // cmdStop
            // 
            this.cmdStop.BackColor = System.Drawing.Color.Transparent;
            this.cmdStop.Image = global::VinylBurnUI.Properties.Resources._24x24_lathe_stop;
            this.cmdStop.Location = new System.Drawing.Point(104, 19);
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.Size = new System.Drawing.Size(32, 32);
            this.cmdStop.TabIndex = 4;
            this.cmdStop.UseVisualStyleBackColor = false;
            this.cmdStop.Click += new System.EventHandler(this.cmdStop_Click);
            // 
            // cmdLatheBack
            // 
            this.cmdLatheBack.BackColor = System.Drawing.Color.Transparent;
            this.cmdLatheBack.Image = global::VinylBurnUI.Properties.Resources._24x24_wind_backward;
            this.cmdLatheBack.Location = new System.Drawing.Point(72, 19);
            this.cmdLatheBack.Name = "cmdLatheBack";
            this.cmdLatheBack.Size = new System.Drawing.Size(32, 32);
            this.cmdLatheBack.TabIndex = 3;
            this.cmdLatheBack.UseVisualStyleBackColor = false;
            this.cmdLatheBack.Click += new System.EventHandler(this.cmdLatheBack_Click);
            // 
            // cmdReturnLathe
            // 
            this.cmdReturnLathe.BackColor = System.Drawing.Color.Transparent;
            this.cmdReturnLathe.Image = global::VinylBurnUI.Properties.Resources._24x24_return_lathe;
            this.cmdReturnLathe.Location = new System.Drawing.Point(40, 19);
            this.cmdReturnLathe.Name = "cmdReturnLathe";
            this.cmdReturnLathe.Size = new System.Drawing.Size(32, 32);
            this.cmdReturnLathe.TabIndex = 2;
            this.cmdReturnLathe.UseVisualStyleBackColor = false;
            this.cmdReturnLathe.Click += new System.EventHandler(this.cmdReturnLathe_Click);
            // 
            // cmdCutRecord
            // 
            this.cmdCutRecord.BackColor = System.Drawing.Color.Transparent;
            this.cmdCutRecord.Image = global::VinylBurnUI.Properties.Resources._24x24_start_cut;
            this.cmdCutRecord.Location = new System.Drawing.Point(8, 19);
            this.cmdCutRecord.Name = "cmdCutRecord";
            this.cmdCutRecord.Size = new System.Drawing.Size(32, 32);
            this.cmdCutRecord.TabIndex = 1;
            this.cmdCutRecord.UseVisualStyleBackColor = false;
            this.cmdCutRecord.Click += new System.EventHandler(this.cmdCutRecord_Click);
            // 
            // pnlSpeed
            // 
            this.pnlSpeed.BackgroundImage = global::VinylBurnUI.Properties.Resources.turntablecontrol;
            this.pnlSpeed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlSpeed.Controls.Add(this.dbn45rpm);
            this.pnlSpeed.Controls.Add(this.dbn39rpm);
            this.pnlSpeed.Controls.Add(this.dbn33rpm);
            this.pnlSpeed.Controls.Add(this.dbn22rpm);
            this.pnlSpeed.Controls.Add(this.dbn16rpm);
            this.pnlSpeed.Controls.Add(this.dbn08rpm);
            this.pnlSpeed.Location = new System.Drawing.Point(10, 29);
            this.pnlSpeed.Name = "pnlSpeed";
            this.pnlSpeed.Size = new System.Drawing.Size(212, 51);
            this.pnlSpeed.TabIndex = 6;
            // 
            // dbn45rpm
            // 
            this.dbn45rpm.BackColor = System.Drawing.Color.Transparent;
            this.dbn45rpm.Location = new System.Drawing.Point(170, 19);
            this.dbn45rpm.Name = "dbn45rpm";
            this.dbn45rpm.Size = new System.Drawing.Size(32, 32);
            this.dbn45rpm.Speedx1 = new decimal(new int[] {
            4500,
            0,
            0,
            131072});
            this.dbn45rpm.Speedx100 = 4500;
            this.dbn45rpm.TabIndex = 6;
            this.dbn45rpm.UseVisualStyleBackColor = true;
            this.dbn45rpm.Click += new System.EventHandler(this.dbnSpeed_Click);
            // 
            // dbn39rpm
            // 
            this.dbn39rpm.BackColor = System.Drawing.Color.Transparent;
            this.dbn39rpm.Location = new System.Drawing.Point(138, 19);
            this.dbn39rpm.Name = "dbn39rpm";
            this.dbn39rpm.Size = new System.Drawing.Size(32, 32);
            this.dbn39rpm.Speedx1 = new decimal(new int[] {
            3900,
            0,
            0,
            131072});
            this.dbn39rpm.Speedx100 = 3900;
            this.dbn39rpm.TabIndex = 5;
            this.dbn39rpm.UseVisualStyleBackColor = false;
            this.dbn39rpm.Click += new System.EventHandler(this.dbnSpeed_Click);
            // 
            // dbn33rpm
            // 
            this.dbn33rpm.BackColor = System.Drawing.Color.Transparent;
            this.dbn33rpm.Location = new System.Drawing.Point(106, 19);
            this.dbn33rpm.Name = "dbn33rpm";
            this.dbn33rpm.Size = new System.Drawing.Size(32, 32);
            this.dbn33rpm.Speedx1 = new decimal(new int[] {
            3333,
            0,
            0,
            131072});
            this.dbn33rpm.Speedx100 = 3333;
            this.dbn33rpm.TabIndex = 4;
            this.dbn33rpm.UseVisualStyleBackColor = false;
            this.dbn33rpm.Click += new System.EventHandler(this.dbnSpeed_Click);
            // 
            // dbn22rpm
            // 
            this.dbn22rpm.BackColor = System.Drawing.Color.Transparent;
            this.dbn22rpm.Location = new System.Drawing.Point(74, 19);
            this.dbn22rpm.Name = "dbn22rpm";
            this.dbn22rpm.Size = new System.Drawing.Size(32, 32);
            this.dbn22rpm.Speedx1 = new decimal(new int[] {
            2250,
            0,
            0,
            131072});
            this.dbn22rpm.Speedx100 = 2250;
            this.dbn22rpm.TabIndex = 3;
            this.dbn22rpm.UseVisualStyleBackColor = false;
            this.dbn22rpm.Click += new System.EventHandler(this.dbnSpeed_Click);
            // 
            // dbn16rpm
            // 
            this.dbn16rpm.BackColor = System.Drawing.Color.Transparent;
            this.dbn16rpm.Location = new System.Drawing.Point(42, 19);
            this.dbn16rpm.Name = "dbn16rpm";
            this.dbn16rpm.Size = new System.Drawing.Size(32, 32);
            this.dbn16rpm.Speedx1 = new decimal(new int[] {
            1666,
            0,
            0,
            131072});
            this.dbn16rpm.Speedx100 = 1666;
            this.dbn16rpm.TabIndex = 2;
            this.dbn16rpm.UseVisualStyleBackColor = false;
            this.dbn16rpm.Click += new System.EventHandler(this.dbnSpeed_Click);
            // 
            // dbn08rpm
            // 
            this.dbn08rpm.BackColor = System.Drawing.Color.Transparent;
            this.dbn08rpm.Location = new System.Drawing.Point(10, 19);
            this.dbn08rpm.Name = "dbn08rpm";
            this.dbn08rpm.Size = new System.Drawing.Size(32, 32);
            this.dbn08rpm.Speedx1 = new decimal(new int[] {
            833,
            0,
            0,
            131072});
            this.dbn08rpm.Speedx100 = 833;
            this.dbn08rpm.TabIndex = 1;
            this.dbn08rpm.UseVisualStyleBackColor = false;
            this.dbn08rpm.Click += new System.EventHandler(this.dbnSpeed_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.stripStatus);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlTrackAdmin);
            this.Controls.Add(this.pnlLatheMoves);
            this.Controls.Add(this.pnlSpeed);
            this.Controls.Add(this.axWMP1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.stripStatus.ResumeLayout(false);
            this.stripStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWMP1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlTrackAdmin.ResumeLayout(false);
            this.pnlLatheMoves.ResumeLayout(false);
            this.pnlSpeed.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AxWMPLib.AxWindowsMediaPlayer axWMP1;
        private System.Windows.Forms.Panel pnlSpeed;
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
        private System.Windows.Forms.StatusStrip stripStatus;
        private System.Windows.Forms.ToolStripStatusLabel tslPort;
        private System.Windows.Forms.ToolStripStatusLabel tslStatus;
        private System.Windows.Forms.ToolStripStatusLabel tslMotorSteps;
        private System.Windows.Forms.ToolStripStatusLabel tslMotorStepsRequired;
        private System.Windows.Forms.ToolStripStatusLabel tslMessage;
        private System.IO.Ports.SerialPort serArduino;
        private System.Windows.Forms.Timer tmrSegment;
        private System.Windows.Forms.ToolStripStatusLabel tslLimitLo;
        private System.Windows.Forms.ToolStripStatusLabel tslLimitHi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private DataButton dbn08rpm;
        private DataButton dbn45rpm;
        private DataButton dbn39rpm;
        private DataButton dbn33rpm;
        private DataButton dbn22rpm;
        private DataButton dbn16rpm;
        private System.Windows.Forms.ToolStripStatusLabel tslEndPhaseAtStep;
        private System.Windows.Forms.Button cmdTestCut;
    }
}

