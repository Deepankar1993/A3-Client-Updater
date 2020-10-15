namespace A3Downloader
{
    partial class Updater2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Updater2));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.StopButton = new System.Windows.Forms.Button();
            this.FullCkeckButton = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.linkLabel8 = new System.Windows.Forms.LinkLabel();
            this.StatusLable = new System.Windows.Forms.Label();
            this.CurrentProgBar = new System.Windows.Forms.PictureBox();
            this.SpeedLable = new System.Windows.Forms.Label();
            this.TotalProgBar = new System.Windows.Forms.PictureBox();
            this.percentLable = new System.Windows.Forms.Label();
            this.TotalLable = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentProgBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalProgBar)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.Color.Transparent;
            this.StopButton.Location = new System.Drawing.Point(635, 498);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(77, 27);
            this.StopButton.TabIndex = 6;
            this.StopButton.Text = "Stop";
            this.toolTip1.SetToolTip(this.StopButton, "Stop Downloading");
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // FullCkeckButton
            // 
            this.FullCkeckButton.BackColor = System.Drawing.Color.Transparent;
            this.FullCkeckButton.Enabled = false;
            this.FullCkeckButton.Location = new System.Drawing.Point(635, 532);
            this.FullCkeckButton.Name = "FullCkeckButton";
            this.FullCkeckButton.Size = new System.Drawing.Size(77, 27);
            this.FullCkeckButton.TabIndex = 7;
            this.FullCkeckButton.Text = "FullCheck";
            this.toolTip1.SetToolTip(this.FullCkeckButton, "Perform Full Check");
            this.FullCkeckButton.UseVisualStyleBackColor = false;
            this.FullCkeckButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Transparent;
            this.Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start.Enabled = false;
            this.Start.Location = new System.Drawing.Point(736, 473);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(96, 90);
            this.Start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Start.TabIndex = 14;
            this.Start.TabStop = false;
            this.toolTip1.SetToolTip(this.Start, "Start Client");
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(49, 120);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(51, 19);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Home";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.linkLabel1, "TownWars Home Page");
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.White;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.White;
            this.linkLabel2.Location = new System.Drawing.Point(731, 120);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(39, 19);
            this.linkLabel2.TabIndex = 16;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "ACP";
            this.linkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.linkLabel2, "Manage Your Account");
            this.linkLabel2.VisitedLinkColor = System.Drawing.Color.White;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel7
            // 
            this.linkLabel7.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel7.AutoSize = true;
            this.linkLabel7.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel7.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel7.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel7.LinkColor = System.Drawing.Color.White;
            this.linkLabel7.Location = new System.Drawing.Point(617, 120);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Size = new System.Drawing.Size(89, 19);
            this.linkLabel7.TabIndex = 21;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "Downloads";
            this.linkLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.linkLabel7, "Download Client and Patch");
            this.linkLabel7.VisitedLinkColor = System.Drawing.Color.White;
            this.linkLabel7.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel7_LinkClicked);
            // 
            // linkLabel8
            // 
            this.linkLabel8.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel8.AutoSize = true;
            this.linkLabel8.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel8.DisabledLinkColor = System.Drawing.Color.White;
            this.linkLabel8.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel8.ForeColor = System.Drawing.Color.White;
            this.linkLabel8.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel8.LinkColor = System.Drawing.Color.White;
            this.linkLabel8.Location = new System.Drawing.Point(779, 120);
            this.linkLabel8.Name = "linkLabel8";
            this.linkLabel8.Size = new System.Drawing.Size(66, 19);
            this.linkLabel8.TabIndex = 22;
            this.linkLabel8.TabStop = true;
            this.linkLabel8.Text = "Register";
            this.linkLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.linkLabel8, "Register Your Self");
            this.linkLabel8.VisitedLinkColor = System.Drawing.Color.White;
            this.linkLabel8.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel8_LinkClicked);
            // 
            // StatusLable
            // 
            this.StatusLable.AutoSize = true;
            this.StatusLable.BackColor = System.Drawing.Color.Transparent;
            this.StatusLable.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StatusLable.Location = new System.Drawing.Point(49, 458);
            this.StatusLable.Name = "StatusLable";
            this.StatusLable.Size = new System.Drawing.Size(51, 15);
            this.StatusLable.TabIndex = 3;
            this.StatusLable.Text = "Starting";
            this.StatusLable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StatusLable.Click += new System.EventHandler(this.StatusLable_Click);
            // 
            // CurrentProgBar
            // 
            this.CurrentProgBar.BackColor = System.Drawing.Color.Transparent;
            this.CurrentProgBar.Image = global::A3Downloader.Properties.Resources.File;
            this.CurrentProgBar.Location = new System.Drawing.Point(42, 504);
            this.CurrentProgBar.Name = "CurrentProgBar";
            this.CurrentProgBar.Size = new System.Drawing.Size(436, 23);
            this.CurrentProgBar.TabIndex = 9;
            this.CurrentProgBar.TabStop = false;
            // 
            // SpeedLable
            // 
            this.SpeedLable.AutoSize = true;
            this.SpeedLable.BackColor = System.Drawing.Color.Transparent;
            this.SpeedLable.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SpeedLable.Location = new System.Drawing.Point(649, 443);
            this.SpeedLable.Name = "SpeedLable";
            this.SpeedLable.Size = new System.Drawing.Size(0, 15);
            this.SpeedLable.TabIndex = 10;
            this.SpeedLable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TotalProgBar
            // 
            this.TotalProgBar.BackColor = System.Drawing.Color.Transparent;
            this.TotalProgBar.Image = global::A3Downloader.Properties.Resources.Total;
            this.TotalProgBar.Location = new System.Drawing.Point(42, 547);
            this.TotalProgBar.Name = "TotalProgBar";
            this.TotalProgBar.Size = new System.Drawing.Size(436, 23);
            this.TotalProgBar.TabIndex = 11;
            this.TotalProgBar.TabStop = false;
            // 
            // percentLable
            // 
            this.percentLable.AutoSize = true;
            this.percentLable.BackColor = System.Drawing.Color.Transparent;
            this.percentLable.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentLable.ForeColor = System.Drawing.Color.Gold;
            this.percentLable.Location = new System.Drawing.Point(510, 504);
            this.percentLable.Name = "percentLable";
            this.percentLable.Size = new System.Drawing.Size(0, 18);
            this.percentLable.TabIndex = 5;
            this.percentLable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TotalLable
            // 
            this.TotalLable.AutoSize = true;
            this.TotalLable.BackColor = System.Drawing.Color.Transparent;
            this.TotalLable.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLable.ForeColor = System.Drawing.SystemColors.Control;
            this.TotalLable.Location = new System.Drawing.Point(510, 548);
            this.TotalLable.Name = "TotalLable";
            this.TotalLable.Size = new System.Drawing.Size(0, 18);
            this.TotalLable.TabIndex = 23;
            this.TotalLable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::A3Downloader.Properties.Resources.cancel;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(822, 73);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(27, 27);
            this.btnClose.TabIndex = 24;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.BackgroundImage = global::A3Downloader.Properties.Resources.minimize;
            this.btn_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.ForeColor = System.Drawing.Color.Transparent;
            this.btn_minimize.Location = new System.Drawing.Point(793, 73);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(27, 27);
            this.btn_minimize.TabIndex = 25;
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // linkLabel3
            // 
            this.linkLabel3.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel3.LinkColor = System.Drawing.Color.White;
            this.linkLabel3.Location = new System.Drawing.Point(785, 148);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(47, 19);
            this.linkLabel3.TabIndex = 26;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Home";
            this.linkLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.linkLabel3, "A3 Ultimate Home Page");
            this.linkLabel3.VisitedLinkColor = System.Drawing.Color.White;
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.BackColor = System.Drawing.Color.Black;
            this.linkLabel4.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel4.ForeColor = System.Drawing.Color.White;
            this.linkLabel4.LinkColor = System.Drawing.Color.White;
            this.linkLabel4.Location = new System.Drawing.Point(635, 209);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(103, 21);
            this.linkLabel4.TabIndex = 27;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "linkLabel4";
            // 
            // Updater2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::A3Downloader.Properties.Resources.mainformbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(874, 601);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.btn_minimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.TotalLable);
            this.Controls.Add(this.percentLable);
            this.Controls.Add(this.linkLabel8);
            this.Controls.Add(this.linkLabel7);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.TotalProgBar);
            this.Controls.Add(this.SpeedLable);
            this.Controls.Add(this.CurrentProgBar);
            this.Controls.Add(this.StatusLable);
            this.Controls.Add(this.FullCkeckButton);
            this.Controls.Add(this.StopButton);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Updater2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A3TW Updater";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Updater_FormClosing);
            this.Load += new System.EventHandler(this.Updater_Load);
            this.Shown += new System.EventHandler(this.Updater_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Updater_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Updater_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Updater_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.Start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentProgBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalProgBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button FullCkeckButton;
        private System.Windows.Forms.Label StatusLable;
        private System.Windows.Forms.PictureBox CurrentProgBar;
        private System.Windows.Forms.Label SpeedLable;
        private System.Windows.Forms.PictureBox TotalProgBar;
        private System.Windows.Forms.PictureBox Start;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel7;
        private System.Windows.Forms.LinkLabel linkLabel8;
        private System.Windows.Forms.Label percentLable;
        private System.Windows.Forms.Label TotalLable;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel4;
    }
}

