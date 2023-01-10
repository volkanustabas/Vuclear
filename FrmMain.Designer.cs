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
            this.clb_tweak_all = new System.Windows.Forms.CheckedListBox();
            this.tlp_tweak_top = new System.Windows.Forms.TableLayoutPanel();
            this.cb_tweak_selectAll = new System.Windows.Forms.CheckBox();
            this.lbl_tweak_count = new System.Windows.Forms.Label();
            this.tp_installApplication = new System.Windows.Forms.TabPage();
            this.tlp_install = new System.Windows.Forms.TableLayoutPanel();
            this.clb_installApplication = new System.Windows.Forms.CheckedListBox();
            this.tlp_install_top = new System.Windows.Forms.TableLayoutPanel();
            this.cb_install_selectAll = new System.Windows.Forms.CheckBox();
            this.lbl_install_count = new System.Windows.Forms.Label();
            this.tp_clear = new System.Windows.Forms.TabPage();
            this.tlp_clear = new System.Windows.Forms.TableLayoutPanel();
            this.clb_clear = new System.Windows.Forms.CheckedListBox();
            this.tlp_clear_top = new System.Windows.Forms.TableLayoutPanel();
            this.cb_clear_selectAll = new System.Windows.Forms.CheckBox();
            this.lbl_clear_count = new System.Windows.Forms.Label();
            this.rtb_log = new System.Windows.Forms.RichTextBox();
            this.tlp_main = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_footer = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_loading = new System.Windows.Forms.TableLayoutPanel();
            this.pb_loading = new System.Windows.Forms.PictureBox();
            this.tc_01.SuspendLayout();
            this.tp_info.SuspendLayout();
            this.tp_tweak.SuspendLayout();
            this.tlp_tweak.SuspendLayout();
            this.tlp_tweak_top.SuspendLayout();
            this.tp_installApplication.SuspendLayout();
            this.tlp_install.SuspendLayout();
            this.tlp_install_top.SuspendLayout();
            this.tp_clear.SuspendLayout();
            this.tlp_clear.SuspendLayout();
            this.tlp_clear_top.SuspendLayout();
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
            this.btn_clear.Location = new System.Drawing.Point(551, 3);
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
            this.tc_01.Location = new System.Drawing.Point(8, 8);
            this.tc_01.Name = "tc_01";
            this.tc_01.SelectedIndex = 0;
            this.tc_01.Size = new System.Drawing.Size(648, 375);
            this.tc_01.TabIndex = 8;
            this.tc_01.SelectedIndexChanged += new System.EventHandler(this.tc_01_SelectedIndexChanged);
            // 
            // tp_info
            // 
            this.tp_info.Controls.Add(this.rtb_info);
            this.tp_info.Location = new System.Drawing.Point(4, 28);
            this.tp_info.Name = "tp_info";
            this.tp_info.Padding = new System.Windows.Forms.Padding(3);
            this.tp_info.Size = new System.Drawing.Size(640, 343);
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
            this.rtb_info.Size = new System.Drawing.Size(634, 337);
            this.rtb_info.TabIndex = 0;
            this.rtb_info.Text = "";
            // 
            // tp_tweak
            // 
            this.tp_tweak.Controls.Add(this.tlp_tweak);
            this.tp_tweak.Location = new System.Drawing.Point(4, 28);
            this.tp_tweak.Name = "tp_tweak";
            this.tp_tweak.Padding = new System.Windows.Forms.Padding(3);
            this.tp_tweak.Size = new System.Drawing.Size(640, 343);
            this.tp_tweak.TabIndex = 1;
            this.tp_tweak.Text = "Tweak";
            this.tp_tweak.UseVisualStyleBackColor = true;
            // 
            // tlp_tweak
            // 
            this.tlp_tweak.ColumnCount = 1;
            this.tlp_tweak.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_tweak.Controls.Add(this.clb_tweak_all, 0, 1);
            this.tlp_tweak.Controls.Add(this.tlp_tweak_top, 0, 0);
            this.tlp_tweak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_tweak.Location = new System.Drawing.Point(3, 3);
            this.tlp_tweak.Name = "tlp_tweak";
            this.tlp_tweak.Padding = new System.Windows.Forms.Padding(5);
            this.tlp_tweak.RowCount = 2;
            this.tlp_tweak.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlp_tweak.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_tweak.Size = new System.Drawing.Size(634, 337);
            this.tlp_tweak.TabIndex = 0;
            // 
            // clb_tweak_all
            // 
            this.clb_tweak_all.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.clb_tweak_all.CheckOnClick = true;
            this.clb_tweak_all.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clb_tweak_all.FormattingEnabled = true;
            this.clb_tweak_all.Items.AddRange(new object[] {
            "[Disable] Activity History",
            "[Disable] Allowing Suggested Apps In WindowsInk Workspace",
            "[Disable] App launch tracking",
            "[Disable] Automatic Updates for Microsoft Store apps",
            "[Disable] Automatically installing suggested apps",
            "[Disable] Cortana",
            "[Disable] Edge WebWidget",
            "[Disable] Get Even More Out of Windows Screen",
            "[Disable] Handwriting recognition personalization",
            "[Disable] Hibernation/Fast startup in Windows",
            "[Disable] Let apps use my advertising ID",
            "[Disable] Location sensor",
            "[Disable] Malware diagnostic data",
            "[Disable] Mozilla telemetry",
            "[Disable] MRU lists (jump lists) of XAML apps in Start Menu",
            "[Disable] Network Diagnostic Usage Service",
            "[Disable] P2P Update downloads outside of local network",
            "[Disable] PowerShell Telemetry",
            "[Disable] Powerthrottling (Intel 6gen and higher)",
            "[Disable] Process Mitigation",
            "[Disable] SCHEDULED TASKS tweaks (Updates, Telemetry etc)",
            "[Disable] Send Microsoft info about how I write",
            "[Disable] Sending contacts to MS",
            "[Disable] Sending speech, inking and typing samples to MS",
            "[Disable] Setting override for reporting to Microsoft MAPS",
            "[Disable] Skype Telemetry",
            "[Disable] Sleep Mode Timeouts",
            "[Disable] SmartScreen Filter for Store Apps",
            "[Disable] Spectre/Meltdown Protection",
            "[Disable] Spynet Defender reporting",
            "[Disable] Start Menu Ads/Suggestions",
            "[Disable] Sticky Keys prompt",
            "[Disable] Telemetry/Data Collection",
            "[Disable] Unnecessary components",
            "[Disable] Watson malware reports",
            "[Disable] WiFi Sense: HotSpot Sharing",
            "[Disable] WiFi Sense: Shared HotSpot Auto-Connect",
            "[Disable] Windows animations, menu Start animations",
            "[Disable] Windows Insider experiments",
            "[Disable] Windows media player usage reports",
            "[Remove] Bloatware Apps",
            "[Remove] News and Interests/Widgets",
            "[Remove] Old Device Drivers",
            "[Remove] Windows Game Bar",
            "[Setting] Defragment Database Indexing Service File",
            "[Setting] Disable Transparency in taskbar/menu start",
            "[Setting] Do not send malware samples for further analysis",
            "[Setting] Dual boot timeout 3sec",
            "[Setting] Enable All (Logical) Cores (Boot Advanced Options)",
            "[Setting] Hide the search box from taskbar",
            "[Setting] Let websites provide locally",
            "[Setting] Lower Shutdown time",
            "[Setting] Microsoft Edge settings for privacy",
            "[Setting] Power option to ultimate performance",
            "[Setting] Services to: Disable Mode",
            "[Setting] Services to: Manuall Mode",
            "[Setting] Show file extensions in Explorer",
            "[Setting] Turn Off Background Apps",
            "[Setting] Windows Defender Scheduled Scan from highest to normal privileges",
            "[Setting] Windows Explorer to start on This PC instead of Quick Access",
            "[Setting] Windows Updates to Notify to schedule restart"});
            this.clb_tweak_all.Location = new System.Drawing.Point(8, 68);
            this.clb_tweak_all.Name = "clb_tweak_all";
            this.clb_tweak_all.Size = new System.Drawing.Size(618, 261);
            this.clb_tweak_all.Sorted = true;
            this.clb_tweak_all.TabIndex = 0;
            this.clb_tweak_all.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clb_tweak_all_ItemCheck);
            // 
            // tlp_tweak_top
            // 
            this.tlp_tweak_top.BackColor = System.Drawing.Color.PeachPuff;
            this.tlp_tweak_top.ColumnCount = 2;
            this.tlp_tweak_top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_tweak_top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_tweak_top.Controls.Add(this.cb_tweak_selectAll, 0, 0);
            this.tlp_tweak_top.Controls.Add(this.lbl_tweak_count, 1, 0);
            this.tlp_tweak_top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_tweak_top.Location = new System.Drawing.Point(8, 8);
            this.tlp_tweak_top.Name = "tlp_tweak_top";
            this.tlp_tweak_top.Padding = new System.Windows.Forms.Padding(5);
            this.tlp_tweak_top.RowCount = 1;
            this.tlp_tweak_top.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_tweak_top.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlp_tweak_top.Size = new System.Drawing.Size(618, 54);
            this.tlp_tweak_top.TabIndex = 1;
            // 
            // cb_tweak_selectAll
            // 
            this.cb_tweak_selectAll.AutoSize = true;
            this.cb_tweak_selectAll.Location = new System.Drawing.Point(8, 8);
            this.cb_tweak_selectAll.Name = "cb_tweak_selectAll";
            this.cb_tweak_selectAll.Size = new System.Drawing.Size(88, 23);
            this.cb_tweak_selectAll.TabIndex = 1;
            this.cb_tweak_selectAll.Text = "Select All";
            this.cb_tweak_selectAll.UseVisualStyleBackColor = true;
            this.cb_tweak_selectAll.CheckedChanged += new System.EventHandler(this.cb_tweak_selectAll_CheckedChanged);
            // 
            // lbl_tweak_count
            // 
            this.lbl_tweak_count.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_tweak_count.AutoSize = true;
            this.lbl_tweak_count.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tweak_count.ForeColor = System.Drawing.Color.Red;
            this.lbl_tweak_count.Location = new System.Drawing.Point(581, 5);
            this.lbl_tweak_count.Name = "lbl_tweak_count";
            this.lbl_tweak_count.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_tweak_count.Size = new System.Drawing.Size(29, 29);
            this.lbl_tweak_count.TabIndex = 2;
            this.lbl_tweak_count.Text = "--";
            // 
            // tp_installApplication
            // 
            this.tp_installApplication.Controls.Add(this.tlp_install);
            this.tp_installApplication.Location = new System.Drawing.Point(4, 28);
            this.tp_installApplication.Name = "tp_installApplication";
            this.tp_installApplication.Padding = new System.Windows.Forms.Padding(3);
            this.tp_installApplication.Size = new System.Drawing.Size(640, 343);
            this.tp_installApplication.TabIndex = 2;
            this.tp_installApplication.Text = "Install Application";
            this.tp_installApplication.UseVisualStyleBackColor = true;
            // 
            // tlp_install
            // 
            this.tlp_install.ColumnCount = 1;
            this.tlp_install.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_install.Controls.Add(this.clb_installApplication, 0, 1);
            this.tlp_install.Controls.Add(this.tlp_install_top, 0, 0);
            this.tlp_install.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_install.Location = new System.Drawing.Point(3, 3);
            this.tlp_install.Name = "tlp_install";
            this.tlp_install.Padding = new System.Windows.Forms.Padding(5);
            this.tlp_install.RowCount = 2;
            this.tlp_install.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlp_install.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_install.Size = new System.Drawing.Size(634, 337);
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
            this.clb_installApplication.Location = new System.Drawing.Point(8, 68);
            this.clb_installApplication.Name = "clb_installApplication";
            this.clb_installApplication.ScrollAlwaysVisible = true;
            this.clb_installApplication.Size = new System.Drawing.Size(618, 261);
            this.clb_installApplication.Sorted = true;
            this.clb_installApplication.TabIndex = 0;
            this.clb_installApplication.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clb_installApplication_ItemCheck);
            // 
            // tlp_install_top
            // 
            this.tlp_install_top.BackColor = System.Drawing.Color.PeachPuff;
            this.tlp_install_top.ColumnCount = 2;
            this.tlp_install_top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_install_top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_install_top.Controls.Add(this.cb_install_selectAll, 0, 0);
            this.tlp_install_top.Controls.Add(this.lbl_install_count, 1, 0);
            this.tlp_install_top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_install_top.Location = new System.Drawing.Point(8, 8);
            this.tlp_install_top.Name = "tlp_install_top";
            this.tlp_install_top.Padding = new System.Windows.Forms.Padding(5);
            this.tlp_install_top.RowCount = 1;
            this.tlp_install_top.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_install_top.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlp_install_top.Size = new System.Drawing.Size(618, 54);
            this.tlp_install_top.TabIndex = 1;
            // 
            // cb_install_selectAll
            // 
            this.cb_install_selectAll.AutoSize = true;
            this.cb_install_selectAll.Location = new System.Drawing.Point(8, 8);
            this.cb_install_selectAll.Name = "cb_install_selectAll";
            this.cb_install_selectAll.Size = new System.Drawing.Size(88, 23);
            this.cb_install_selectAll.TabIndex = 1;
            this.cb_install_selectAll.Text = "Select All";
            this.cb_install_selectAll.UseVisualStyleBackColor = true;
            this.cb_install_selectAll.CheckedChanged += new System.EventHandler(this.cb_install_selectAll_CheckedChanged);
            // 
            // lbl_install_count
            // 
            this.lbl_install_count.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_install_count.AutoSize = true;
            this.lbl_install_count.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_install_count.ForeColor = System.Drawing.Color.Red;
            this.lbl_install_count.Location = new System.Drawing.Point(581, 5);
            this.lbl_install_count.Name = "lbl_install_count";
            this.lbl_install_count.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_install_count.Size = new System.Drawing.Size(29, 29);
            this.lbl_install_count.TabIndex = 2;
            this.lbl_install_count.Text = "--";
            // 
            // tp_clear
            // 
            this.tp_clear.Controls.Add(this.tlp_clear);
            this.tp_clear.Location = new System.Drawing.Point(4, 28);
            this.tp_clear.Name = "tp_clear";
            this.tp_clear.Padding = new System.Windows.Forms.Padding(3);
            this.tp_clear.Size = new System.Drawing.Size(640, 343);
            this.tp_clear.TabIndex = 0;
            this.tp_clear.Text = "Clear";
            this.tp_clear.UseVisualStyleBackColor = true;
            // 
            // tlp_clear
            // 
            this.tlp_clear.ColumnCount = 1;
            this.tlp_clear.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_clear.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_clear.Controls.Add(this.clb_clear, 0, 1);
            this.tlp_clear.Controls.Add(this.tlp_clear_top, 0, 0);
            this.tlp_clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_clear.Location = new System.Drawing.Point(3, 3);
            this.tlp_clear.Name = "tlp_clear";
            this.tlp_clear.Padding = new System.Windows.Forms.Padding(5);
            this.tlp_clear.RowCount = 2;
            this.tlp_clear.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlp_clear.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_clear.Size = new System.Drawing.Size(634, 337);
            this.tlp_clear.TabIndex = 1;
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
            this.clb_clear.Location = new System.Drawing.Point(8, 68);
            this.clb_clear.Name = "clb_clear";
            this.clb_clear.Size = new System.Drawing.Size(618, 261);
            this.clb_clear.Sorted = true;
            this.clb_clear.TabIndex = 0;
            this.clb_clear.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clb_clear_ItemCheck);
            // 
            // tlp_clear_top
            // 
            this.tlp_clear_top.BackColor = System.Drawing.Color.PeachPuff;
            this.tlp_clear_top.ColumnCount = 2;
            this.tlp_clear_top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_clear_top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_clear_top.Controls.Add(this.cb_clear_selectAll, 0, 0);
            this.tlp_clear_top.Controls.Add(this.lbl_clear_count, 1, 0);
            this.tlp_clear_top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_clear_top.Location = new System.Drawing.Point(8, 8);
            this.tlp_clear_top.Name = "tlp_clear_top";
            this.tlp_clear_top.Padding = new System.Windows.Forms.Padding(5);
            this.tlp_clear_top.RowCount = 1;
            this.tlp_clear_top.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_clear_top.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlp_clear_top.Size = new System.Drawing.Size(618, 54);
            this.tlp_clear_top.TabIndex = 1;
            // 
            // cb_clear_selectAll
            // 
            this.cb_clear_selectAll.AutoSize = true;
            this.cb_clear_selectAll.Location = new System.Drawing.Point(8, 8);
            this.cb_clear_selectAll.Name = "cb_clear_selectAll";
            this.cb_clear_selectAll.Size = new System.Drawing.Size(88, 23);
            this.cb_clear_selectAll.TabIndex = 0;
            this.cb_clear_selectAll.Text = "Select All";
            this.cb_clear_selectAll.UseVisualStyleBackColor = true;
            this.cb_clear_selectAll.CheckedChanged += new System.EventHandler(this.cb_clear_selectAll_CheckedChanged);
            // 
            // lbl_clear_count
            // 
            this.lbl_clear_count.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_clear_count.AutoSize = true;
            this.lbl_clear_count.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_clear_count.ForeColor = System.Drawing.Color.Red;
            this.lbl_clear_count.Location = new System.Drawing.Point(581, 5);
            this.lbl_clear_count.Name = "lbl_clear_count";
            this.lbl_clear_count.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_clear_count.Size = new System.Drawing.Size(29, 29);
            this.lbl_clear_count.TabIndex = 1;
            this.lbl_clear_count.Text = "--";
            // 
            // rtb_log
            // 
            this.rtb_log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_log.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtb_log.Location = new System.Drawing.Point(3, 3);
            this.rtb_log.Name = "rtb_log";
            this.rtb_log.ReadOnly = true;
            this.rtb_log.Size = new System.Drawing.Size(542, 88);
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
            this.tlp_main.Padding = new System.Windows.Forms.Padding(5);
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
            this.tlp_footer.Location = new System.Drawing.Point(8, 389);
            this.tlp_footer.Name = "tlp_footer";
            this.tlp_footer.RowCount = 1;
            this.tlp_footer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_footer.Size = new System.Drawing.Size(648, 94);
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
            this.tlp_loading.Location = new System.Drawing.Point(8, 489);
            this.tlp_loading.Name = "tlp_loading";
            this.tlp_loading.RowCount = 1;
            this.tlp_loading.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_loading.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_loading.Size = new System.Drawing.Size(648, 44);
            this.tlp_loading.TabIndex = 12;
            // 
            // pb_loading
            // 
            this.pb_loading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_loading.Image = global::Vuclear.Properties.Resources.loading;
            this.pb_loading.Location = new System.Drawing.Point(227, 3);
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
            this.Text = "Vuclear [v1.0.1.2]";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tc_01.ResumeLayout(false);
            this.tp_info.ResumeLayout(false);
            this.tp_tweak.ResumeLayout(false);
            this.tlp_tweak.ResumeLayout(false);
            this.tlp_tweak_top.ResumeLayout(false);
            this.tlp_tweak_top.PerformLayout();
            this.tp_installApplication.ResumeLayout(false);
            this.tlp_install.ResumeLayout(false);
            this.tlp_install_top.ResumeLayout(false);
            this.tlp_install_top.PerformLayout();
            this.tp_clear.ResumeLayout(false);
            this.tlp_clear.ResumeLayout(false);
            this.tlp_clear_top.ResumeLayout(false);
            this.tlp_clear_top.PerformLayout();
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
        private System.Windows.Forms.CheckedListBox clb_tweak_all;
        private System.Windows.Forms.CheckBox cb_tweak_selectAll;
        private System.Windows.Forms.CheckBox cb_install_selectAll;
        private System.Windows.Forms.TableLayoutPanel tlp_tweak_top;
        private System.Windows.Forms.TableLayoutPanel tlp_install_top;
        private System.Windows.Forms.Label lbl_tweak_count;
        private System.Windows.Forms.Label lbl_install_count;
        private System.Windows.Forms.TableLayoutPanel tlp_clear;
        private System.Windows.Forms.TableLayoutPanel tlp_clear_top;
        private System.Windows.Forms.CheckBox cb_clear_selectAll;
        private System.Windows.Forms.Label lbl_clear_count;
    }
}

