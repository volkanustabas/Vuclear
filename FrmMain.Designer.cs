namespace Vuclear
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btn_clear = new System.Windows.Forms.Button();
            this.bw_clear = new System.ComponentModel.BackgroundWorker();
            this.pb_loading = new System.Windows.Forms.PictureBox();
            this.tc_01 = new System.Windows.Forms.TabControl();
            this.tp_clear = new System.Windows.Forms.TabPage();
            this.clb_clear = new System.Windows.Forms.CheckedListBox();
            this.tp_tweak = new System.Windows.Forms.TabPage();
            this.rtb_tweak_details = new System.Windows.Forms.RichTextBox();
            this.cb_tweak = new System.Windows.Forms.CheckBox();
            this.tp_installApplication = new System.Windows.Forms.TabPage();
            this.clb_installApplication = new System.Windows.Forms.CheckedListBox();
            this.rtb_log = new System.Windows.Forms.RichTextBox();
            this.tp_info = new System.Windows.Forms.TabPage();
            this.rtb_info = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_loading)).BeginInit();
            this.tc_01.SuspendLayout();
            this.tp_clear.SuspendLayout();
            this.tp_tweak.SuspendLayout();
            this.tp_installApplication.SuspendLayout();
            this.tp_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_clear
            // 
            this.btn_clear.BackgroundImage = global::Vuclear.Properties.Resources.image_clear;
            this.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_clear.Location = new System.Drawing.Point(305, 255);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(73, 69);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // bw_clear
            // 
            this.bw_clear.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_clear_DoWork);
            this.bw_clear.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_clear_RunWorkerCompleted);
            // 
            // pb_loading
            // 
            this.pb_loading.Image = global::Vuclear.Properties.Resources.image_loading;
            this.pb_loading.Location = new System.Drawing.Point(305, 255);
            this.pb_loading.Name = "pb_loading";
            this.pb_loading.Size = new System.Drawing.Size(73, 69);
            this.pb_loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_loading.TabIndex = 7;
            this.pb_loading.TabStop = false;
            // 
            // tc_01
            // 
            this.tc_01.Controls.Add(this.tp_info);
            this.tc_01.Controls.Add(this.tp_clear);
            this.tc_01.Controls.Add(this.tp_tweak);
            this.tc_01.Controls.Add(this.tp_installApplication);
            this.tc_01.Location = new System.Drawing.Point(12, 12);
            this.tc_01.Name = "tc_01";
            this.tc_01.SelectedIndex = 0;
            this.tc_01.Size = new System.Drawing.Size(370, 230);
            this.tc_01.TabIndex = 8;
            this.tc_01.SelectedIndexChanged += new System.EventHandler(this.tc_01_SelectedIndexChanged);
            // 
            // tp_clear
            // 
            this.tp_clear.Controls.Add(this.clb_clear);
            this.tp_clear.Location = new System.Drawing.Point(4, 22);
            this.tp_clear.Name = "tp_clear";
            this.tp_clear.Padding = new System.Windows.Forms.Padding(3);
            this.tp_clear.Size = new System.Drawing.Size(362, 204);
            this.tp_clear.TabIndex = 0;
            this.tp_clear.Text = "Clear";
            this.tp_clear.UseVisualStyleBackColor = true;
            // 
            // clb_clear
            // 
            this.clb_clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clb_clear.FormattingEnabled = true;
            this.clb_clear.Items.AddRange(new object[] {
            "Clear Application History",
            "Clear Browser History",
            "Clear Credential Cache",
            "Clear Temp",
            "Clear Windows Logs Caches",
            "Empty Trash Bin"});
            this.clb_clear.Location = new System.Drawing.Point(3, 3);
            this.clb_clear.Name = "clb_clear";
            this.clb_clear.Size = new System.Drawing.Size(356, 198);
            this.clb_clear.Sorted = true;
            this.clb_clear.TabIndex = 0;
            // 
            // tp_tweak
            // 
            this.tp_tweak.Controls.Add(this.rtb_tweak_details);
            this.tp_tweak.Controls.Add(this.cb_tweak);
            this.tp_tweak.Location = new System.Drawing.Point(4, 22);
            this.tp_tweak.Name = "tp_tweak";
            this.tp_tweak.Padding = new System.Windows.Forms.Padding(3);
            this.tp_tweak.Size = new System.Drawing.Size(362, 204);
            this.tp_tweak.TabIndex = 1;
            this.tp_tweak.Text = "Tweak";
            this.tp_tweak.UseVisualStyleBackColor = true;
            // 
            // rtb_tweak_details
            // 
            this.rtb_tweak_details.Location = new System.Drawing.Point(7, 30);
            this.rtb_tweak_details.Name = "rtb_tweak_details";
            this.rtb_tweak_details.ReadOnly = true;
            this.rtb_tweak_details.Size = new System.Drawing.Size(349, 168);
            this.rtb_tweak_details.TabIndex = 2;
            this.rtb_tweak_details.Text = resources.GetString("rtb_tweak_details.Text");
            // 
            // cb_tweak
            // 
            this.cb_tweak.AutoSize = true;
            this.cb_tweak.Location = new System.Drawing.Point(6, 6);
            this.cb_tweak.Name = "cb_tweak";
            this.cb_tweak.Size = new System.Drawing.Size(189, 17);
            this.cb_tweak.TabIndex = 1;
            this.cb_tweak.Text = "All necessary tools after installation";
            this.cb_tweak.UseVisualStyleBackColor = true;
            // 
            // tp_installApplication
            // 
            this.tp_installApplication.Controls.Add(this.clb_installApplication);
            this.tp_installApplication.Location = new System.Drawing.Point(4, 22);
            this.tp_installApplication.Name = "tp_installApplication";
            this.tp_installApplication.Padding = new System.Windows.Forms.Padding(3);
            this.tp_installApplication.Size = new System.Drawing.Size(362, 204);
            this.tp_installApplication.TabIndex = 2;
            this.tp_installApplication.Text = "Install Application";
            this.tp_installApplication.UseVisualStyleBackColor = true;
            // 
            // clb_installApplication
            // 
            this.clb_installApplication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clb_installApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clb_installApplication.FormattingEnabled = true;
            this.clb_installApplication.HorizontalScrollbar = true;
            this.clb_installApplication.Items.AddRange(new object[] {
            "7-zip",
            "Google Chrome",
            "Greenshot",
            "Mozilla Firefox",
            "Notepad++",
            "Vlc Player"});
            this.clb_installApplication.Location = new System.Drawing.Point(3, 3);
            this.clb_installApplication.Name = "clb_installApplication";
            this.clb_installApplication.ScrollAlwaysVisible = true;
            this.clb_installApplication.Size = new System.Drawing.Size(356, 198);
            this.clb_installApplication.Sorted = true;
            this.clb_installApplication.TabIndex = 0;
            // 
            // rtb_log
            // 
            this.rtb_log.Location = new System.Drawing.Point(16, 255);
            this.rtb_log.Name = "rtb_log";
            this.rtb_log.ReadOnly = true;
            this.rtb_log.Size = new System.Drawing.Size(283, 69);
            this.rtb_log.TabIndex = 9;
            this.rtb_log.Text = "";
            // 
            // tp_info
            // 
            this.tp_info.Controls.Add(this.rtb_info);
            this.tp_info.Location = new System.Drawing.Point(4, 22);
            this.tp_info.Name = "tp_info";
            this.tp_info.Padding = new System.Windows.Forms.Padding(3);
            this.tp_info.Size = new System.Drawing.Size(362, 204);
            this.tp_info.TabIndex = 3;
            this.tp_info.Text = "Info";
            this.tp_info.UseVisualStyleBackColor = true;
            // 
            // rtb_info
            // 
            this.rtb_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtb_info.Location = new System.Drawing.Point(3, 3);
            this.rtb_info.Name = "rtb_info";
            this.rtb_info.ReadOnly = true;
            this.rtb_info.Size = new System.Drawing.Size(356, 198);
            this.rtb_info.TabIndex = 0;
            this.rtb_info.Text = "";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 346);
            this.Controls.Add(this.rtb_log);
            this.Controls.Add(this.tc_01);
            this.Controls.Add(this.pb_loading);
            this.Controls.Add(this.btn_clear);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(410, 385);
            this.MinimumSize = new System.Drawing.Size(410, 385);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vuclear [v1.0.0.8]";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_loading)).EndInit();
            this.tc_01.ResumeLayout(false);
            this.tp_clear.ResumeLayout(false);
            this.tp_tweak.ResumeLayout(false);
            this.tp_tweak.PerformLayout();
            this.tp_installApplication.ResumeLayout(false);
            this.tp_info.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_clear;
        private System.ComponentModel.BackgroundWorker bw_clear;
        private System.Windows.Forms.PictureBox pb_loading;
        private System.Windows.Forms.TabControl tc_01;
        private System.Windows.Forms.TabPage tp_clear;
        private System.Windows.Forms.TabPage tp_tweak;
        private System.Windows.Forms.CheckBox cb_tweak;
        private System.Windows.Forms.RichTextBox rtb_tweak_details;
        private System.Windows.Forms.TabPage tp_installApplication;
        private System.Windows.Forms.CheckedListBox clb_installApplication;
        private System.Windows.Forms.RichTextBox rtb_log;
        private System.Windows.Forms.CheckedListBox clb_clear;
        private System.Windows.Forms.TabPage tp_info;
        private System.Windows.Forms.RichTextBox rtb_info;
    }
}

