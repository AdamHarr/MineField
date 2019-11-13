namespace MineFieldNew
{
    partial class FormMineField
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMineField));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCat = new System.Windows.Forms.Button();
            this.BtnDog = new System.Windows.Forms.Button();
            this.btnRabbit = new System.Windows.Forms.Button();
            this.lblCHamp = new System.Windows.Forms.Label();
            this.btnPerson = new System.Windows.Forms.Button();
            this.BtnRight = new System.Windows.Forms.Button();
            this.BtnLeft = new System.Windows.Forms.Button();
            this.BtnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.lblbomb = new System.Windows.Forms.Label();
            this.RBEasy = new System.Windows.Forms.RadioButton();
            this.RBMedium = new System.Windows.Forms.RadioButton();
            this.RBHard = new System.Windows.Forms.RadioButton();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.BtnRestart = new System.Windows.Forms.Button();
            this.timerUp = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnStart = new System.Windows.Forms.Button();
            this.timerDown = new System.Windows.Forms.Timer(this.components);
            this.lblHello = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnLeaderboard = new System.Windows.Forms.Button();
            this.tbLeaderboard = new System.Windows.Forms.TextBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.btnMute = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.timerbomb = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // BtnCat
            // 
            resources.ApplyResources(this.BtnCat, "BtnCat");
            this.BtnCat.Name = "BtnCat";
            this.BtnCat.UseVisualStyleBackColor = true;
            this.BtnCat.Click += new System.EventHandler(this.BtnCat_Click);
            // 
            // BtnDog
            // 
            resources.ApplyResources(this.BtnDog, "BtnDog");
            this.BtnDog.Name = "BtnDog";
            this.BtnDog.UseVisualStyleBackColor = true;
            this.BtnDog.Click += new System.EventHandler(this.BtnDog_Click);
            // 
            // btnRabbit
            // 
            resources.ApplyResources(this.btnRabbit, "btnRabbit");
            this.btnRabbit.Name = "btnRabbit";
            this.btnRabbit.UseVisualStyleBackColor = true;
            this.btnRabbit.Click += new System.EventHandler(this.BtnRabbit_Click);
            // 
            // lblCHamp
            // 
            resources.ApplyResources(this.lblCHamp, "lblCHamp");
            this.lblCHamp.Name = "lblCHamp";
            // 
            // btnPerson
            // 
            resources.ApplyResources(this.btnPerson, "btnPerson");
            this.btnPerson.Name = "btnPerson";
            this.btnPerson.UseVisualStyleBackColor = true;
            this.btnPerson.Click += new System.EventHandler(this.BtnPerson_Click);
            // 
            // BtnRight
            // 
            resources.ApplyResources(this.BtnRight, "BtnRight");
            this.BtnRight.Name = "BtnRight";
            this.BtnRight.UseVisualStyleBackColor = true;
            this.BtnRight.Click += new System.EventHandler(this.BtnRight_Click);
            // 
            // BtnLeft
            // 
            resources.ApplyResources(this.BtnLeft, "BtnLeft");
            this.BtnLeft.Name = "BtnLeft";
            this.BtnLeft.UseVisualStyleBackColor = true;
            this.BtnLeft.Click += new System.EventHandler(this.BtnLeft_Click);
            // 
            // BtnDown
            // 
            resources.ApplyResources(this.BtnDown, "BtnDown");
            this.BtnDown.Name = "BtnDown";
            this.BtnDown.UseVisualStyleBackColor = true;
            this.BtnDown.Click += new System.EventHandler(this.BtnDown_Click);
            // 
            // btnUp
            // 
            resources.ApplyResources(this.btnUp, "btnUp");
            this.btnUp.Name = "btnUp";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.BtnUp_Click);
            // 
            // lblbomb
            // 
            resources.ApplyResources(this.lblbomb, "lblbomb");
            this.lblbomb.Name = "lblbomb";
            // 
            // RBEasy
            // 
            resources.ApplyResources(this.RBEasy, "RBEasy");
            this.RBEasy.Name = "RBEasy";
            this.RBEasy.UseVisualStyleBackColor = true;
            this.RBEasy.CheckedChanged += new System.EventHandler(this.RBEasy_CheckedChanged);
            // 
            // RBMedium
            // 
            resources.ApplyResources(this.RBMedium, "RBMedium");
            this.RBMedium.Name = "RBMedium";
            this.RBMedium.UseVisualStyleBackColor = true;
            this.RBMedium.CheckedChanged += new System.EventHandler(this.RBMedium_CheckedChanged);
            // 
            // RBHard
            // 
            resources.ApplyResources(this.RBHard, "RBHard");
            this.RBHard.Name = "RBHard";
            this.RBHard.UseVisualStyleBackColor = true;
            this.RBHard.CheckedChanged += new System.EventHandler(this.RBHard_CheckedChanged);
            // 
            // lblDifficulty
            // 
            resources.ApplyResources(this.lblDifficulty, "lblDifficulty");
            this.lblDifficulty.Name = "lblDifficulty";
            // 
            // BtnRestart
            // 
            resources.ApplyResources(this.BtnRestart, "BtnRestart");
            this.BtnRestart.Name = "BtnRestart";
            this.BtnRestart.UseVisualStyleBackColor = true;
            this.BtnRestart.Click += new System.EventHandler(this.BtnRestart_Click);
            // 
            // timerUp
            // 
            this.timerUp.Enabled = true;
            this.timerUp.Interval = 1000;
            this.timerUp.Tick += new System.EventHandler(this.TimerUp_Tick);
            // 
            // lblTime
            // 
            resources.ApplyResources(this.lblTime, "lblTime");
            this.lblTime.Name = "lblTime";
            // 
            // BtnExit
            // 
            resources.ApplyResources(this.BtnExit, "BtnExit");
            this.BtnExit.BackgroundImage = global::MineFieldNew.Properties.Resources.X;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnStart
            // 
            resources.ApplyResources(this.BtnStart, "BtnStart");
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // timerDown
            // 
            this.timerDown.Enabled = true;
            this.timerDown.Interval = 1000;
            this.timerDown.Tick += new System.EventHandler(this.TimerDown_Tick);
            // 
            // lblHello
            // 
            resources.ApplyResources(this.lblHello, "lblHello");
            this.lblHello.Name = "lblHello";
            // 
            // lblUserName
            // 
            resources.ApplyResources(this.lblUserName, "lblUserName");
            this.lblUserName.Name = "lblUserName";
            // 
            // btnLeaderboard
            // 
            resources.ApplyResources(this.btnLeaderboard, "btnLeaderboard");
            this.btnLeaderboard.Name = "btnLeaderboard";
            this.btnLeaderboard.UseVisualStyleBackColor = true;
            this.btnLeaderboard.Click += new System.EventHandler(this.BtnLeadaboard_Click);
            // 
            // tbLeaderboard
            // 
            resources.ApplyResources(this.tbLeaderboard, "tbLeaderboard");
            this.tbLeaderboard.BackColor = System.Drawing.Color.Gray;
            this.tbLeaderboard.ForeColor = System.Drawing.Color.White;
            this.tbLeaderboard.Name = "tbLeaderboard";
            this.tbLeaderboard.ReadOnly = true;
            // 
            // lblLevel
            // 
            resources.ApplyResources(this.lblLevel, "lblLevel");
            this.lblLevel.Name = "lblLevel";
            // 
            // btnMute
            // 
            resources.ApplyResources(this.btnMute, "btnMute");
            this.btnMute.BackColor = System.Drawing.Color.Transparent;
            this.btnMute.BackgroundImage = global::MineFieldNew.Properties.Resources.mute;
            this.btnMute.FlatAppearance.BorderSize = 0;
            this.btnMute.Name = "btnMute";
            this.btnMute.UseVisualStyleBackColor = false;
            this.btnMute.Click += new System.EventHandler(this.BtnMute_Click);
            // 
            // btnHelp
            // 
            resources.ApplyResources(this.btnHelp, "btnHelp");
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            // 
            // timerbomb
            // 
            this.timerbomb.Interval = 2000;
            this.timerbomb.Tick += new System.EventHandler(this.timerbomb_Tick);
            // 
            // FormMineField
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnMute);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.tbLeaderboard);
            this.Controls.Add(this.btnLeaderboard);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.BtnRestart);
            this.Controls.Add(this.lblDifficulty);
            this.Controls.Add(this.RBHard);
            this.Controls.Add(this.RBMedium);
            this.Controls.Add(this.RBEasy);
            this.Controls.Add(this.lblbomb);
            this.Controls.Add(this.BtnCat);
            this.Controls.Add(this.BtnDog);
            this.Controls.Add(this.btnRabbit);
            this.Controls.Add(this.lblCHamp);
            this.Controls.Add(this.btnPerson);
            this.Controls.Add(this.BtnRight);
            this.Controls.Add(this.BtnLeft);
            this.Controls.Add(this.BtnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormMineField";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnCat;
        private System.Windows.Forms.Button BtnDog;
        private System.Windows.Forms.Button btnRabbit;
        private System.Windows.Forms.Label lblCHamp;
        private System.Windows.Forms.Button btnPerson;
        private System.Windows.Forms.Button BtnRight;
        private System.Windows.Forms.Button BtnLeft;
        private System.Windows.Forms.Button BtnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Label lblbomb;
        private System.Windows.Forms.RadioButton RBEasy;
        private System.Windows.Forms.RadioButton RBMedium;
        private System.Windows.Forms.RadioButton RBHard;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.Button BtnRestart;
        private System.Windows.Forms.Timer timerUp;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Timer timerDown;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnLeaderboard;
        private System.Windows.Forms.TextBox tbLeaderboard;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Button btnMute;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Timer timerbomb;
    }
}

