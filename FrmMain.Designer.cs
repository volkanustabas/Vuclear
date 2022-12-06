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
            this.tc_01 = new System.Windows.Forms.TabControl();
            this.tp_info = new System.Windows.Forms.TabPage();
            this.rtb_info = new System.Windows.Forms.RichTextBox();
            this.tp_tweak = new System.Windows.Forms.TabPage();
            this.tlp_tweak = new System.Windows.Forms.TableLayoutPanel();
            this.rtb_tweak_details = new System.Windows.Forms.RichTextBox();
            this.cb_tweak = new System.Windows.Forms.CheckBox();
            this.tp_installApplication = new System.Windows.Forms.TabPage();
            this.tlp_install = new System.Windows.Forms.TableLayoutPanel();
            this.clb_installApplication = new System.Windows.Forms.CheckedListBox();
            this.tlp_install_checkbox = new System.Windows.Forms.TableLayoutPanel();
            this.cb_install_selectAll = new System.Windows.Forms.CheckBox();
            this.tp_clear = new System.Windows.Forms.TabPage();
            this.clb_clear = new System.Windows.Forms.CheckedListBox();
            this.rtb_log = new System.Windows.Forms.RichTextBox();
            this.tlp_main = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_footer = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_loading = new System.Windows.Forms.TableLayoutPanel();
            this.pb_loading = new System.Windows.Forms.PictureBox();
            this.tc_01.SuspendLayout();
            this.tp_info.SuspendLayout();
            this.tp_tweak.SuspendLayout();
            this.tlp_tweak.SuspendLayout();
            this.tp_installApplication.SuspendLayout();
            this.tlp_install.SuspendLayout();
            this.tlp_install_checkbox.SuspendLayout();
            this.tp_clear.SuspendLayout();
            this.tlp_main.SuspendLayout();
            this.tlp_footer.SuspendLayout();
            this.tlp_loading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_loading)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Transparent;
            this.btn_clear.BackgroundImage = global::Vuclear.Properties.Resources.run;
            this.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.ForeColor = System.Drawing.Color.Transparent;
            this.btn_clear.Location = new System.Drawing.Point(561, 3);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(94, 88);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // bw_clear
            // 
            this.bw_clear.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_clear_DoWork);
            this.bw_clear.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_clear_RunWorkerCompleted);
            // 
            // tc_01
            // 
            this.tc_01.Controls.Add(this.tp_info);
            this.tc_01.Controls.Add(this.tp_tweak);
            this.tc_01.Controls.Add(this.tp_installApplication);
            this.tc_01.Controls.Add(this.tp_clear);
            this.tc_01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_01.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tc_01.Location = new System.Drawing.Point(3, 3);
            this.tc_01.Name = "tc_01";
            this.tc_01.SelectedIndex = 0;
            this.tc_01.Size = new System.Drawing.Size(658, 385);
            this.tc_01.TabIndex = 8;
            this.tc_01.SelectedIndexChanged += new System.EventHandler(this.tc_01_SelectedIndexChanged);
            // 
            // tp_info
            // 
            this.tp_info.Controls.Add(this.rtb_info);
            this.tp_info.Location = new System.Drawing.Point(4, 28);
            this.tp_info.Name = "tp_info";
            this.tp_info.Padding = new System.Windows.Forms.Padding(3);
            this.tp_info.Size = new System.Drawing.Size(650, 353);
            this.tp_info.TabIndex = 3;
            this.tp_info.Text = "Info";
            this.tp_info.UseVisualStyleBackColor = true;
            // 
            // rtb_info
            // 
            this.rtb_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.rtb_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_info.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtb_info.Location = new System.Drawing.Point(3, 3);
            this.rtb_info.Name = "rtb_info";
            this.rtb_info.ReadOnly = true;
            this.rtb_info.Size = new System.Drawing.Size(644, 347);
            this.rtb_info.TabIndex = 0;
            this.rtb_info.Text = "";
            // 
            // tp_tweak
            // 
            this.tp_tweak.Controls.Add(this.tlp_tweak);
            this.tp_tweak.Location = new System.Drawing.Point(4, 28);
            this.tp_tweak.Name = "tp_tweak";
            this.tp_tweak.Padding = new System.Windows.Forms.Padding(3);
            this.tp_tweak.Size = new System.Drawing.Size(650, 353);
            this.tp_tweak.TabIndex = 1;
            this.tp_tweak.Text = "Tweak";
            this.tp_tweak.UseVisualStyleBackColor = true;
            // 
            // tlp_tweak
            // 
            this.tlp_tweak.ColumnCount = 1;
            this.tlp_tweak.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_tweak.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_tweak.Controls.Add(this.rtb_tweak_details, 0, 1);
            this.tlp_tweak.Controls.Add(this.cb_tweak, 0, 0);
            this.tlp_tweak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_tweak.Location = new System.Drawing.Point(3, 3);
            this.tlp_tweak.Name = "tlp_tweak";
            this.tlp_tweak.RowCount = 2;
            this.tlp_tweak.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlp_tweak.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_tweak.Size = new System.Drawing.Size(644, 347);
            this.tlp_tweak.TabIndex = 0;
            // 
            // rtb_tweak_details
            // 
            this.rtb_tweak_details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.rtb_tweak_details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_tweak_details.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtb_tweak_details.Location = new System.Drawing.Point(3, 53);
            this.rtb_tweak_details.Name = "rtb_tweak_details";
            this.rtb_tweak_details.ReadOnly = true;
            this.rtb_tweak_details.Size = new System.Drawing.Size(638, 291);
            this.rtb_tweak_details.TabIndex = 2;
            this.rtb_tweak_details.Text = resources.GetString("rtb_tweak_details.Text");
            // 
            // cb_tweak
            // 
            this.cb_tweak.AutoSize = true;
            this.cb_tweak.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_tweak.Location = new System.Drawing.Point(3, 3);
            this.cb_tweak.Name = "cb_tweak";
            this.cb_tweak.Size = new System.Drawing.Size(262, 23);
            this.cb_tweak.TabIndex = 1;
            this.cb_tweak.Text = "All necessary tools after installation";
            this.cb_tweak.UseVisualStyleBackColor = true;
            // 
            // tp_installApplication
            // 
            this.tp_installApplication.Controls.Add(this.tlp_install);
            this.tp_installApplication.Location = new System.Drawing.Point(4, 28);
            this.tp_installApplication.Name = "tp_installApplication";
            this.tp_installApplication.Padding = new System.Windows.Forms.Padding(3);
            this.tp_installApplication.Size = new System.Drawing.Size(650, 353);
            this.tp_installApplication.TabIndex = 2;
            this.tp_installApplication.Text = "Install Application";
            this.tp_installApplication.UseVisualStyleBackColor = true;
            // 
            // tlp_install
            // 
            this.tlp_install.ColumnCount = 1;
            this.tlp_install.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_install.Controls.Add(this.clb_installApplication, 0, 1);
            this.tlp_install.Controls.Add(this.tlp_install_checkbox, 0, 0);
            this.tlp_install.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_install.Location = new System.Drawing.Point(3, 3);
            this.tlp_install.Name = "tlp_install";
            this.tlp_install.RowCount = 2;
            this.tlp_install.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp_install.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_install.Size = new System.Drawing.Size(644, 347);
            this.tlp_install.TabIndex = 0;
            // 
            // clb_installApplication
            // 
            this.clb_installApplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.clb_installApplication.CheckOnClick = true;
            this.clb_installApplication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clb_installApplication.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clb_installApplication.ForeColor = System.Drawing.Color.Black;
            this.clb_installApplication.FormattingEnabled = true;
            this.clb_installApplication.HorizontalScrollbar = true;
            this.clb_installApplication.Items.AddRange(new object[] {
            "7-zip",
            "Discord",
            "Google Chrome",
            "ImageGlass",
            "Java Runtime Environment",
            "Libre Office",
            "Microsoft Edge",
            "Microsoft Visual C++ 2015-2022 Redistributable (x64)",
            "Microsoft Visual C++ 2015-2022 Redistributable (x86)",
            "Mozilla Firefox",
            "Notepad++",
            "qBittorrent",
            "ShareX",
            "Spotify",
            "Steam",
            "VLC Player"});
            this.clb_installApplication.Location = new System.Drawing.Point(3, 43);
            this.clb_installApplication.Name = "clb_installApplication";
            this.clb_installApplication.ScrollAlwaysVisible = true;
            this.clb_installApplication.Size = new System.Drawing.Size(638, 301);
            this.clb_installApplication.Sorted = true;
            this.clb_installApplication.TabIndex = 0;
            // 
            // tlp_install_checkbox
            // 
            this.tlp_install_checkbox.ColumnCount = 4;
            this.tlp_install_checkbox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_install_checkbox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_install_checkbox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_install_checkbox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_install_checkbox.Controls.Add(this.cb_install_selectAll, 0, 0);
            this.tlp_install_checkbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_install_checkbox.Location = new System.Drawing.Point(3, 3);
            this.tlp_install_checkbox.Name = "tlp_install_checkbox";
            this.tlp_install_checkbox.RowCount = 1;
            this.tlp_install_checkbox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_install_checkbox.Size = new System.Drawing.Size(638, 34);
            this.tlp_install_checkbox.TabIndex = 1;
            // 
            // cb_install_selectAll
            // 
            this.cb_install_selectAll.AutoSize = true;
            this.cb_install_selectAll.Location = new System.Drawing.Point(3, 3);
            this.cb_install_selectAll.Name = "cb_install_selectAll";
            this.cb_install_selectAll.Size = new System.Drawing.Size(94, 23);
            this.cb_install_selectAll.TabIndex = 0;
            this.cb_install_selectAll.Text = "Select ALL";
            this.cb_install_selectAll.UseVisualStyleBackColor = true;
            this.cb_install_selectAll.CheckedChanged += new System.EventHandler(this.cb_install_selectAll_CheckedChanged);
            // 
            // tp_clear
            // 
            this.tp_clear.Controls.Add(this.clb_clear);
            this.tp_clear.Location = new System.Drawing.Point(4, 28);
            this.tp_clear.Name = "tp_clear";
            this.tp_clear.Padding = new System.Windows.Forms.Padding(3);
            this.tp_clear.Size = new System.Drawing.Size(650, 353);
            this.tp_clear.TabIndex = 0;
            this.tp_clear.Text = "Clear";
            this.tp_clear.UseVisualStyleBackColor = true;
            // 
            // clb_clear
            // 
            this.clb_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.clb_clear.CheckOnClick = true;
            this.clb_clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clb_clear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
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
            this.clb_clear.Size = new System.Drawing.Size(644, 347);
            this.clb_clear.Sorted = true;
            this.clb_clear.TabIndex = 0;
            // 
            // rtb_log
            // 
            this.rtb_log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_log.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtb_log.Location = new System.Drawing.Point(3, 3);
            this.rtb_log.Name = "rtb_log";
            this.rtb_log.ReadOnly = true;
            this.rtb_log.Size = new System.Drawing.Size(552, 88);
            this.rtb_log.TabIndex = 9;
            this.rtb_log.Text = "";
            // 
            // tlp_main
            // 
            this.tlp_main.ColumnCount = 1;
            this.tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_main.Controls.Add(this.tlp_footer, 0, 1);
            this.tlp_main.Controls.Add(this.tc_01, 0, 0);
            this.tlp_main.Controls.Add(this.tlp_loading, 0, 2);
            this.tlp_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_main.Location = new System.Drawing.Point(0, 0);
            this.tlp_main.Name = "tlp_main";
            this.tlp_main.RowCount = 3;
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlp_main.Size = new System.Drawing.Size(664, 541);
            this.tlp_main.TabIndex = 10;
            // 
            // tlp_footer
            // 
            this.tlp_footer.ColumnCount = 2;
            this.tlp_footer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_footer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp_footer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_footer.Controls.Add(this.rtb_log, 0, 0);
            this.tlp_footer.Controls.Add(this.btn_clear, 1, 0);
            this.tlp_footer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_footer.Location = new System.Drawing.Point(3, 394);
            this.tlp_footer.Name = "tlp_footer";
            this.tlp_footer.RowCount = 1;
            this.tlp_footer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_footer.Size = new System.Drawing.Size(658, 94);
            this.tlp_footer.TabIndex = 11;
            // 
            // tlp_loading
            // 
            this.tlp_loading.ColumnCount = 3;
            this.tlp_loading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_loading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlp_loading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_loading.Controls.Add(this.pb_loading, 1, 0);
            this.tlp_loading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_loading.Location = new System.Drawing.Point(3, 494);
            this.tlp_loading.Name = "tlp_loading";
            this.tlp_loading.RowCount = 1;
            this.tlp_loading.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_loading.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_loading.Size = new System.Drawing.Size(658, 44);
            this.tlp_loading.TabIndex = 12;
            // 
            // pb_loading
            // 
            this.pb_loading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_loading.Image = global::Vuclear.Properties.Resources.loading;
            this.pb_loading.Location = new System.Drawing.Point(232, 3);
            this.pb_loading.Name = "pb_loading";
            this.pb_loading.Size = new System.Drawing.Size(194, 38);
            this.pb_loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_loading.TabIndex = 0;
            this.pb_loading.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 541);
            this.Controls.Add(this.tlp_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(680, 540);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vuclear [v1.0.1.1]";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tc_01.ResumeLayout(false);
            this.tp_info.ResumeLayout(false);
            this.tp_tweak.ResumeLayout(false);
            this.tlp_tweak.ResumeLayout(false);
            this.tlp_tweak.PerformLayout();
            this.tp_installApplication.ResumeLayout(false);
            this.tlp_install.ResumeLayout(false);
            this.tlp_install_checkbox.ResumeLayout(false);
            this.tlp_install_checkbox.PerformLayout();
            this.tp_clear.ResumeLayout(false);
            this.tlp_main.ResumeLayout(false);
            this.tlp_footer.ResumeLayout(false);
            this.tlp_loading.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_loading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_clear;
        private System.ComponentModel.BackgroundWorker bw_clear;
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
        private System.Windows.Forms.TableLayoutPanel tlp_main;
        private System.Windows.Forms.TableLayoutPanel tlp_footer;
        private System.Windows.Forms.TableLayoutPanel tlp_tweak;
        private System.Windows.Forms.TableLayoutPanel tlp_loading;
        private System.Windows.Forms.PictureBox pb_loading;
        private System.Windows.Forms.TableLayoutPanel tlp_install;
        private System.Windows.Forms.TableLayoutPanel tlp_install_checkbox;
        private System.Windows.Forms.CheckBox cb_install_selectAll;
    }
}

