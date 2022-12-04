using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Windows.Forms;
using Microsoft.Win32;
using Vuclear.Properties;

namespace Vuclear
{
    public partial class FrmMain : Form
    {
        private bool _tpClear;
        private bool _tpInstallApplication;
        private bool _tpWindowsTweaks;

        public string ScriptTweak;

        public FrmMain()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            pb_loading.Visible = false;
            _tpClear = true;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            InfoFillData();
        }

        private void EnabledFalse()
        {
            tc_01.Enabled = false;
            btn_clear.Enabled = false;
        }

        private void EnabledTrue()
        {
            tc_01.Enabled = true;
            btn_clear.Enabled = true;
        }

        private bool ControlCheckbox()
        {
            var tpClearCount = clb_clear.SelectedItems.Count;
            var tpTweakCount = tp_tweak.Controls.OfType<CheckBox>().Count(c => c.Checked);
            var tpInstallApplicationCount = clb_installApplication.SelectedItems.Count;


            if (tpInstallApplicationCount > 0 || tpClearCount > 0 || tpTweakCount > 0)
                return true;
            return false;
        }

        private void ClearOptions()
        {
            foreach (var item in clb_clear.CheckedItems)

                if (item.ToString() == "Clear Application History")
                {
                    var clearApplicationHistory =
                        Resources.ResourceManager.GetString(@"clear_applicationHistory");
                    var executeBatLocation =
                        Environment.GetEnvironmentVariable("USERPROFILE") + @"\" +
                        "Downloads\\clearApplicationHistory.bat";

                    using (var batFile = new StreamWriter(executeBatLocation))
                    {
                        batFile.WriteLine(clearApplicationHistory);
                    }

                    ExecuteCommand(executeBatLocation, "Clear Application History", rtb_log);

                    File.Delete(executeBatLocation);
                }

                else if (item.ToString() == "Clear Browser History")
                {
                    var clearBrowserHistory =
                        Resources.ResourceManager.GetString(@"clear_browserHistory");
                    var executeBatLocation =
                        Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads\\clearBrowserHistory.bat";

                    using (var batFile = new StreamWriter(executeBatLocation))
                    {
                        batFile.WriteLine(clearBrowserHistory);
                    }

                    ExecuteCommand(executeBatLocation, "Browser History cleared.", rtb_log);

                    File.Delete(executeBatLocation);
                }

                else if (item.ToString() == "Clear Credential Cache")
                {
                    var clearCredentialCache =
                        Resources.ResourceManager.GetString(@"clear_credentialCache");
                    var executeBatLocation =
                        Environment.GetEnvironmentVariable("USERPROFILE") + @"\" +
                        "Downloads\\clearCredentialCache.bat";

                    using (var batFile = new StreamWriter(executeBatLocation))
                    {
                        batFile.WriteLine(clearCredentialCache);
                    }

                    ExecuteCommand(executeBatLocation, "Credential cache cleared", rtb_log);

                    File.Delete(executeBatLocation);
                }

                else if (item.ToString() == "Clear Temp")
                {
                    var clearTemp =
                        Resources.ResourceManager.GetString(@"clear_temp");
                    var executeBatLocation =
                        Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads\\clearTemp.bat";

                    using (var batFile = new StreamWriter(executeBatLocation))
                    {
                        batFile.WriteLine(clearTemp);
                    }

                    ExecuteCommand(executeBatLocation, "Temp cleared.", rtb_log);

                    File.Delete(executeBatLocation);
                }

                else if (item.ToString() == "Clear Windows Logs Caches")
                {
                    var clearWindowsLogsCaches =
                        Resources.ResourceManager.GetString(@"clear_windowsLogsCaches");
                    var executeBatLocation =
                        Environment.GetEnvironmentVariable("USERPROFILE") + @"\" +
                        "Downloads\\clearWindowsLogsCaches.bat";

                    using (var batFile = new StreamWriter(executeBatLocation))
                    {
                        batFile.WriteLine(clearWindowsLogsCaches);
                    }

                    ExecuteCommand(executeBatLocation, "Windows Logs Caches cleared.", rtb_log);

                    File.Delete(executeBatLocation);
                }

                else
                {
                    var emptyTrashBin =
                        Resources.ResourceManager.GetString(@"clear_emptyTrashBin");
                    var executeBatLocation =
                        Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads\\emptyTrashBin.bat";

                    using (var batFile = new StreamWriter(executeBatLocation))
                    {
                        batFile.WriteLine(emptyTrashBin);
                    }

                    ExecuteCommand(executeBatLocation, "Trash bin cleared.", rtb_log);

                    File.Delete(executeBatLocation);
                }
        }

        private void WindowsTweaks()
        {
            ScriptTweak = @"";

            if (cb_tweak.Checked)
                ScriptTweak =
                    Resources.ResourceManager.GetString(@"script_tweak") + Environment.NewLine +
                    Environment.NewLine;


            var scripts = ScriptTweak + Environment.NewLine +
                          @"exit /b 0";

            var executeBatLocation =
                Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads\\Vuclear.bat";

            using (var batFile = new StreamWriter(executeBatLocation))
            {
                batFile.WriteLine(scripts);
            }

            var processStartInfo = new ProcessStartInfo("cmd.exe", "/c " + executeBatLocation)
            {
                UseShellExecute = true,
                CreateNoWindow = false,
                WindowStyle = ProcessWindowStyle.Hidden,
                RedirectStandardOutput = true,
                Verb = "runas"
            };

            var p = new Process {StartInfo = processStartInfo};
            p.Start();
            var result = p.StandardOutput.ReadToEnd();
            rtb_log.AppendText(result + Environment.NewLine);
            p.WaitForExit();

            File.Delete(executeBatLocation);
        }

        private void InstallApplication()
        {
            foreach (var item in clb_installApplication.CheckedItems)
                if (item.ToString() == "7-zip")
                {
                    var install7Zip = @"winget install --id=7zip.7zip -e";
                    ExecuteCommand(install7Zip, "7zip installed.", rtb_log);
                }
                else if (item.ToString() == "Mozilla Firefox")
                {
                    var installFirefox = @"winget install --id=Mozilla.Firefox -e";
                    ExecuteCommand(installFirefox, "Mozilla Firefox installed.", rtb_log);
                }

                else if (item.ToString() == "Google Chrome")
                {
                    var installGoogleChrome = @"winget install --id=Google.Chrome -e";
                    ExecuteCommand(installGoogleChrome, "Google Chrome installed.", rtb_log);
                }
                else if (item.ToString() == "Greenshot")
                {
                    var installGreenshot = @"winget install --id=Greenshot.Greenshot -e";
                    ExecuteCommand(installGreenshot, "Greenshot installed.", rtb_log);
                }
                else if (item.ToString() == "Vlc Player")
                {
                    var installVlcPlayer = @"winget install --id=VideoLAN.VLC -e";
                    ExecuteCommand(installVlcPlayer, "Vlc Player installed.", rtb_log);
                }
                else if (item.ToString() == "Notepad++")
                {
                    var installNotepadPlusPlus = @"winget install --id=Notepad++.Notepad++ -e";
                    ExecuteCommand(installNotepadPlusPlus, "Notepad++ installed.", rtb_log);
                }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            if (ControlCheckbox())
            {
                bw_clear.RunWorkerAsync();
                EnabledFalse();
            }
            else
            {
                MessageBoxHelper.PrepToCenterMessageBoxOnForm(this);

                MessageBox.Show(@"You must choose at least one option!", @"Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void bw_clear_DoWork(object sender, DoWorkEventArgs e)
        {
            BeginInvoke((MethodInvoker) delegate { pb_loading.Visible = true; });

            if (_tpClear)
                ClearOptions();
            else if (_tpWindowsTweaks)
                WindowsTweaks();
            else
                InstallApplication();
        }

        private void bw_clear_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pb_loading.Visible = false;

            MessageBoxHelper.PrepToCenterMessageBoxOnForm(this);

            var result = MessageBox.Show(@"The selections have been deleted. Do you want to close?", @"Info",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
                EnabledTrue();
            else
                Application.Exit();
        }

        private void tc_01_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tc_01.SelectedTab == tp_clear)
            {
                _tpClear = true;
                _tpWindowsTweaks = false;
                _tpInstallApplication = false;
            }
            else if (tc_01.SelectedTab == tp_tweak)
            {
                _tpClear = false;
                _tpWindowsTweaks = true;
                _tpInstallApplication = false;
            }
            else
            {
                _tpClear = false;
                _tpWindowsTweaks = false;
                _tpInstallApplication = true;
            }
        }

        public static void ExecuteCommand(object command, string applicationNameForLog, RichTextBox rtbLog)
        {
            try
            {
                var procStartInfo =
                    new ProcessStartInfo("cmd", "/c " + command)
                    {
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        Verb = "runas",
                        WindowStyle = ProcessWindowStyle.Hidden
                    };

                var proc = new Process();
                proc.StartInfo = procStartInfo;
                proc.Start();
                proc.WaitForExit();
                //rtbLog.AppendText(result + Environment.NewLine);
                rtbLog.AppendText(applicationNameForLog + Environment.NewLine);
            }
            catch (Exception objException)
            {
                rtbLog.AppendText(objException + Environment.NewLine);
            }
        }

        

        #region INFO

        public class Computer
        {
            public string Name { get; set; }
            public string Username { get; set; }
            public DateTime InstallDate { get; set; }
            public string Os { get; set; }
            public string Model { get; set; }
            public string Processor { get; set; }
            public string Ram { get; set; }
        }

        #region INFO_FillData

        public void InfoFillData()
        {
            var computer = new Computer
            {
                InstallDate = OsInstallDate(),
                Os = Os("127.0.0.1"),
                Model = BrandAndModel("127.0.0.1"),
                Processor = Processor("127.0.0.1"),
                Ram = Ram("127.0.0.1")
            };

            rtb_info.AppendText("Computer Name: " + Environment.MachineName + Environment.NewLine);
            rtb_info.AppendText("Username: " + Environment.UserName + Environment.NewLine);
            rtb_info.AppendText("OS: " + computer.Os + Environment.NewLine);
            rtb_info.AppendText("OS Install Date: " + computer.InstallDate + Environment.NewLine);
            rtb_info.AppendText("Brand / Model: " + computer.Model + Environment.NewLine);
            rtb_info.AppendText("Processor: " + computer.Processor + Environment.NewLine);
            rtb_info.AppendText("Ram: " + computer.Ram + Environment.NewLine);
        }

        #endregion

        public static DateTime OsInstallDate()
        {
            var key = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);

            key = key.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion", false);
            if (key != null)
            {
                var startDate = new DateTime(1970, 1, 1, 0, 0, 0);
                var objValue = key.GetValue("InstallDate");
                var stringValue = objValue.ToString();
                var regVal = Convert.ToInt64(stringValue);

                var installDate = startDate.AddSeconds(regVal);

                return installDate;
            }

            return DateTime.Today;
        }

        public static string Os(string ipAdressForOs)
        {
            try
            {
                var connection = new ConnectionOptions();

                var scope = new ManagementScope("\\\\" + ipAdressForOs + "\\root\\CIMV2", connection);
                scope.Connect();

                var query = new ObjectQuery(
                    "SELECT * FROM Win32_OperatingSystem");

                var searcher =
                    new ManagementObjectSearcher(scope, query);

                foreach (var o in searcher.Get())
                {
                    var queryObj = (ManagementObject) o;
                    var osInstallDateConvert =
                        ManagementDateTimeConverter.ToDateTime(queryObj["InstallDate"].ToString());

                    var os = queryObj["Caption"] + @" " + queryObj["BuildNumber"];
                    return os;
                }
            }
            catch (ManagementException)
            {
                return "Error: Connection issue";
            }
            catch (UnauthorizedAccessException)
            {
                return "Error: UnauthorizedAccess";
            }

            return "null";
        }

        public static string BrandAndModel(string ipAdressForBrandAndModel)
        {
            try
            {
                var connection = new ConnectionOptions();

                var scope = new ManagementScope("\\\\" + ipAdressForBrandAndModel + "\\root\\CIMV2", connection);
                scope.Connect();

                var query = new ObjectQuery(
                    "SELECT * FROM Win32_ComputerSystem");

                var searcher =
                    new ManagementObjectSearcher(scope, query);

                foreach (var o in searcher.Get())
                {
                    var queryObj = (ManagementObject) o;
                    var brandModelName = queryObj["Manufacturer"] + @" / " + queryObj["Model"];


                    return brandModelName;
                }
            }
            catch (ManagementException)
            {
                return "Error: Connection issue";
            }
            catch (UnauthorizedAccessException)
            {
                return "Error: UnauthorizedAccess";
            }

            return "null";
        }

        public static string Processor(string ipAdressForProcessor)
        {
            try
            {
                var connection = new ConnectionOptions();

                var scope = new ManagementScope("\\\\" + ipAdressForProcessor + "\\root\\CIMV2", connection);
                scope.Connect();

                var query = new ObjectQuery(
                    "SELECT * FROM Win32_Processor");

                var searcher =
                    new ManagementObjectSearcher(scope, query);

                foreach (var o in searcher.Get())
                {
                    var queryObj = (ManagementObject) o;
                    var processorModel = queryObj["Name"].ToString();

                    return processorModel;
                }
            }
            catch (ManagementException)
            {
                return "Error: Connection issue";
            }
            catch (UnauthorizedAccessException)
            {
                return "Error: UnauthorizedAccess";
            }

            return "null";
        }

        public static string Ram(string ipAdressForRam)
        {
            try
            {
                var connection = new ConnectionOptions();

                var scope = new ManagementScope("\\\\" + ipAdressForRam + "\\root\\CIMV2", connection);
                scope.Connect();

                var query = new ObjectQuery(
                    "SELECT Capacity,PartNumber FROM Win32_PhysicalMemory");

                var searcher =
                    new ManagementObjectSearcher(scope, query);

                foreach (var o in searcher.Get())
                {
                    var queryObj = (ManagementObject) o;
                    ulong totalMemory = 0;
                    foreach (var managementBaseObject in searcher.Get())
                    {
                        var m = (ManagementObject) managementBaseObject;
                        if (m["Capacity"] != null)
                            totalMemory += (ulong)m["Capacity"];
                    }

                    var ramInfo = KbMbGbTbConvert.ByteToStringForInfo(totalMemory) + @" (" +
                                  queryObj["PartNumber"].ToString().Trim() + @")";

                    return ramInfo;
                }
            }
            catch (ManagementException)
            {
                return "Error: Connection issue";
            }
            catch (UnauthorizedAccessException)
            {
                return "Error: UnauthorizedAccess";
            }

            return "null";
        }
        public class KbMbGbTbConvert
        {
            public static string ByteToString(UInt64 bytes)
            {
                string[] Suffix = { "bytes", "KB", "GB", "TB" };
                int i;
                double dblSByte = bytes;
                for (i = 0; i < Suffix.Length && bytes >= 1024; i++, bytes /= 1024)
                {
                    dblSByte = bytes / 1024.0;
                }

                return $"{dblSByte:0.#} {Suffix[i]}";
            }

            public static string ByteToStringForInfo(UInt64 bytes)
            {
                string[] Suffix = { "bytes", "KB", "MB", "GB", "TB" };
                int i;
                double dblSByte = bytes;
                for (i = 0; i < Suffix.Length && bytes >= 1024; i++, bytes /= 1024)
                {
                    dblSByte = bytes / 1024.0;
                }

                return $"{dblSByte:0.#} {Suffix[i]}";
            }
        }

        #endregion
    }
}