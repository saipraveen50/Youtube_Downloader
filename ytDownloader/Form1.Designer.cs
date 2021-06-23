
namespace ytDownloader
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDownload = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.Dataprogress = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.grbVideoDetails = new System.Windows.Forms.GroupBox();
            this.btnDownload = new Guna.UI2.WinForms.Guna2Button();
            this.chkAudioOnly = new System.Windows.Forms.CheckBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFilePath = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.lblAudio = new System.Windows.Forms.Label();
            this.cmbAudioQuality = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblVideo = new System.Windows.Forms.Label();
            this.cmbQuality = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnStart = new Guna.UI2.WinForms.Guna2Button();
            this.txtUrl = new Guna.UI2.WinForms.Guna2TextBox();
            this.tabHelp = new System.Windows.Forms.TabPage();
            this.bgWorkerGetVideo = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Downloader_BackProcess = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabDownload.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.grbVideoDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDownload);
            this.tabControl1.Controls.Add(this.tabHelp);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 461);
            this.tabControl1.TabIndex = 0;
            // 
            // tabDownload
            // 
            this.tabDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tabDownload.Controls.Add(this.statusStrip1);
            this.tabDownload.Controls.Add(this.progressBar1);
            this.tabDownload.Controls.Add(this.grbVideoDetails);
            this.tabDownload.Controls.Add(this.btnStart);
            this.tabDownload.Controls.Add(this.txtUrl);
            this.tabDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDownload.Location = new System.Drawing.Point(4, 22);
            this.tabDownload.Name = "tabDownload";
            this.tabDownload.Padding = new System.Windows.Forms.Padding(3);
            this.tabDownload.Size = new System.Drawing.Size(776, 435);
            this.tabDownload.TabIndex = 0;
            this.tabDownload.Text = "Download";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.Status,
            this.Dataprogress});
            this.statusStrip1.Location = new System.Drawing.Point(3, 410);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(770, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // Status
            // 
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(0, 17);
            // 
            // Dataprogress
            // 
            this.Dataprogress.Name = "Dataprogress";
            this.Dataprogress.Size = new System.Drawing.Size(0, 17);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(4, 364);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(768, 28);
            this.progressBar1.TabIndex = 3;
            // 
            // grbVideoDetails
            // 
            this.grbVideoDetails.Controls.Add(this.btnDownload);
            this.grbVideoDetails.Controls.Add(this.chkAudioOnly);
            this.grbVideoDetails.Controls.Add(this.btnBrowse);
            this.grbVideoDetails.Controls.Add(this.txtFilePath);
            this.grbVideoDetails.Controls.Add(this.lblPath);
            this.grbVideoDetails.Controls.Add(this.lblAudio);
            this.grbVideoDetails.Controls.Add(this.cmbAudioQuality);
            this.grbVideoDetails.Controls.Add(this.lblVideo);
            this.grbVideoDetails.Controls.Add(this.cmbQuality);
            this.grbVideoDetails.Controls.Add(this.txtTitle);
            this.grbVideoDetails.Controls.Add(this.lblTitle);
            this.grbVideoDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.grbVideoDetails.Location = new System.Drawing.Point(0, 109);
            this.grbVideoDetails.Name = "grbVideoDetails";
            this.grbVideoDetails.Size = new System.Drawing.Size(780, 249);
            this.grbVideoDetails.TabIndex = 2;
            this.grbVideoDetails.TabStop = false;
            this.grbVideoDetails.Text = "Video Details";
            // 
            // btnDownload
            // 
            this.btnDownload.BorderRadius = 20;
            this.btnDownload.CheckedState.Parent = this.btnDownload;
            this.btnDownload.CustomImages.Parent = this.btnDownload;
            this.btnDownload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDownload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDownload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDownload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDownload.DisabledState.Parent = this.btnDownload;
            this.btnDownload.FillColor = System.Drawing.Color.Firebrick;
            this.btnDownload.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.ForeColor = System.Drawing.Color.White;
            this.btnDownload.HoverState.Parent = this.btnDownload;
            this.btnDownload.Location = new System.Drawing.Point(630, 187);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.PressedColor = System.Drawing.Color.IndianRed;
            this.btnDownload.ShadowDecoration.Parent = this.btnDownload;
            this.btnDownload.Size = new System.Drawing.Size(138, 45);
            this.btnDownload.TabIndex = 10;
            this.btnDownload.Text = "Download";
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // chkAudioOnly
            // 
            this.chkAudioOnly.AutoSize = true;
            this.chkAudioOnly.Location = new System.Drawing.Point(519, 204);
            this.chkAudioOnly.Name = "chkAudioOnly";
            this.chkAudioOnly.Size = new System.Drawing.Size(94, 19);
            this.chkAudioOnly.TabIndex = 9;
            this.chkAudioOnly.Text = "Audio Only";
            this.chkAudioOnly.UseVisualStyleBackColor = true;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBrowse.BackgroundImage")));
            this.btnBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBrowse.ForeColor = System.Drawing.Color.Transparent;
            this.btnBrowse.Location = new System.Drawing.Point(703, 145);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(34, 34);
            this.btnBrowse.TabIndex = 8;
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.BorderRadius = 15;
            this.txtFilePath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilePath.DefaultText = "";
            this.txtFilePath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFilePath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFilePath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilePath.DisabledState.Parent = this.txtFilePath;
            this.txtFilePath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilePath.FillColor = System.Drawing.Color.LightSteelBlue;
            this.txtFilePath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilePath.FocusedState.Parent = this.txtFilePath;
            this.txtFilePath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFilePath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilePath.HoverState.Parent = this.txtFilePath;
            this.txtFilePath.Location = new System.Drawing.Point(87, 145);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.PasswordChar = '\0';
            this.txtFilePath.PlaceholderText = "";
            this.txtFilePath.SelectedText = "";
            this.txtFilePath.ShadowDecoration.Parent = this.txtFilePath;
            this.txtFilePath.Size = new System.Drawing.Size(610, 36);
            this.txtFilePath.TabIndex = 7;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath.Location = new System.Drawing.Point(20, 155);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(61, 16);
            this.lblPath.TabIndex = 6;
            this.lblPath.Text = "Save to";
            // 
            // lblAudio
            // 
            this.lblAudio.AutoSize = true;
            this.lblAudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAudio.Location = new System.Drawing.Point(295, 95);
            this.lblAudio.Name = "lblAudio";
            this.lblAudio.Size = new System.Drawing.Size(100, 16);
            this.lblAudio.TabIndex = 5;
            this.lblAudio.Text = "Audio Quality";
            // 
            // cmbAudioQuality
            // 
            this.cmbAudioQuality.BackColor = System.Drawing.Color.Transparent;
            this.cmbAudioQuality.BorderRadius = 15;
            this.cmbAudioQuality.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAudioQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAudioQuality.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmbAudioQuality.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbAudioQuality.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbAudioQuality.FocusedState.Parent = this.cmbAudioQuality;
            this.cmbAudioQuality.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbAudioQuality.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbAudioQuality.HoverState.Parent = this.cmbAudioQuality;
            this.cmbAudioQuality.ItemHeight = 30;
            this.cmbAudioQuality.ItemsAppearance.Parent = this.cmbAudioQuality;
            this.cmbAudioQuality.Location = new System.Drawing.Point(404, 86);
            this.cmbAudioQuality.Name = "cmbAudioQuality";
            this.cmbAudioQuality.ShadowDecoration.Parent = this.cmbAudioQuality;
            this.cmbAudioQuality.Size = new System.Drawing.Size(140, 36);
            this.cmbAudioQuality.TabIndex = 4;
            this.cmbAudioQuality.SelectedIndexChanged += new System.EventHandler(this.cmbAudioQuality_SelectedIndexChanged);
            // 
            // lblVideo
            // 
            this.lblVideo.AutoSize = true;
            this.lblVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVideo.Location = new System.Drawing.Point(8, 95);
            this.lblVideo.Name = "lblVideo";
            this.lblVideo.Size = new System.Drawing.Size(101, 16);
            this.lblVideo.TabIndex = 3;
            this.lblVideo.Text = "Video Quality";
            // 
            // cmbQuality
            // 
            this.cmbQuality.BackColor = System.Drawing.Color.Transparent;
            this.cmbQuality.BorderRadius = 15;
            this.cmbQuality.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuality.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmbQuality.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbQuality.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbQuality.FocusedState.Parent = this.cmbQuality;
            this.cmbQuality.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbQuality.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbQuality.HoverState.Parent = this.cmbQuality;
            this.cmbQuality.ItemHeight = 30;
            this.cmbQuality.ItemsAppearance.Parent = this.cmbQuality;
            this.cmbQuality.Location = new System.Drawing.Point(117, 86);
            this.cmbQuality.Name = "cmbQuality";
            this.cmbQuality.ShadowDecoration.Parent = this.cmbQuality;
            this.cmbQuality.Size = new System.Drawing.Size(140, 36);
            this.cmbQuality.TabIndex = 2;
            this.cmbQuality.SelectedIndexChanged += new System.EventHandler(this.cmbQuality_SelectedIndexChanged);
            // 
            // txtTitle
            // 
            this.txtTitle.BorderRadius = 15;
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitle.DefaultText = "";
            this.txtTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitle.DisabledState.Parent = this.txtTitle;
            this.txtTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitle.FillColor = System.Drawing.Color.LightSteelBlue;
            this.txtTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTitle.FocusedState.Parent = this.txtTitle;
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTitle.HoverState.Parent = this.txtTitle;
            this.txtTitle.Location = new System.Drawing.Point(61, 20);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PasswordChar = '\0';
            this.txtTitle.PlaceholderText = "";
            this.txtTitle.SelectedText = "";
            this.txtTitle.ShadowDecoration.Parent = this.txtTitle;
            this.txtTitle.Size = new System.Drawing.Size(661, 36);
            this.txtTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(8, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(39, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // btnStart
            // 
            this.btnStart.BorderRadius = 20;
            this.btnStart.CheckedState.Parent = this.btnStart;
            this.btnStart.CustomImages.Parent = this.btnStart;
            this.btnStart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStart.DisabledState.Parent = this.btnStart;
            this.btnStart.FillColor = System.Drawing.Color.Firebrick;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.HoverState.Parent = this.btnStart;
            this.btnStart.Location = new System.Drawing.Point(652, 58);
            this.btnStart.Name = "btnStart";
            this.btnStart.PressedColor = System.Drawing.Color.IndianRed;
            this.btnStart.ShadowDecoration.Parent = this.btnStart;
            this.btnStart.Size = new System.Drawing.Size(116, 45);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.BorderRadius = 15;
            this.txtUrl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUrl.DefaultText = "Enter video link";
            this.txtUrl.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUrl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUrl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUrl.DisabledState.Parent = this.txtUrl;
            this.txtUrl.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUrl.FillColor = System.Drawing.Color.LightSteelBlue;
            this.txtUrl.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUrl.FocusedState.Parent = this.txtUrl;
            this.txtUrl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrl.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUrl.HoverState.Parent = this.txtUrl;
            this.txtUrl.Location = new System.Drawing.Point(8, 6);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.PasswordChar = '\0';
            this.txtUrl.PlaceholderText = "";
            this.txtUrl.SelectedText = "";
            this.txtUrl.SelectionStart = 16;
            this.txtUrl.ShadowDecoration.Parent = this.txtUrl;
            this.txtUrl.Size = new System.Drawing.Size(726, 36);
            this.txtUrl.TabIndex = 0;
            this.txtUrl.TextChanged += new System.EventHandler(this.txtUrl_TextChanged);
            this.txtUrl.Enter += new System.EventHandler(this.txtUrl_Enter);
            this.txtUrl.Leave += new System.EventHandler(this.txtUrl_Leave);
            // 
            // tabHelp
            // 
            this.tabHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tabHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabHelp.Location = new System.Drawing.Point(4, 22);
            this.tabHelp.Name = "tabHelp";
            this.tabHelp.Padding = new System.Windows.Forms.Padding(3);
            this.tabHelp.Size = new System.Drawing.Size(776, 435);
            this.tabHelp.TabIndex = 1;
            this.tabHelp.Text = "Help";
            // 
            // bgWorkerGetVideo
            // 
            this.bgWorkerGetVideo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerGetVideo_DoWork);
            // 
            // Downloader_BackProcess
            // 
            this.Downloader_BackProcess.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Downloader_BackProcess_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Youtube Video Downloader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabDownload.ResumeLayout(false);
            this.tabDownload.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grbVideoDetails.ResumeLayout(false);
            this.grbVideoDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDownload;
        private System.Windows.Forms.GroupBox grbVideoDetails;
        private Guna.UI2.WinForms.Guna2Button btnDownload;
        private System.Windows.Forms.CheckBox chkAudioOnly;
        private System.Windows.Forms.Button btnBrowse;
        private Guna.UI2.WinForms.Guna2TextBox txtFilePath;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblAudio;
        private Guna.UI2.WinForms.Guna2ComboBox cmbAudioQuality;
        private System.Windows.Forms.Label lblVideo;
        private Guna.UI2.WinForms.Guna2ComboBox cmbQuality;
        private Guna.UI2.WinForms.Guna2TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnStart;
        private Guna.UI2.WinForms.Guna2TextBox txtUrl;
        private System.Windows.Forms.TabPage tabHelp;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel Status;
        private System.Windows.Forms.ToolStripStatusLabel Dataprogress;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker bgWorkerGetVideo;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.ComponentModel.BackgroundWorker Downloader_BackProcess;
    }
}

