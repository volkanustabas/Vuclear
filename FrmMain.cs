using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
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
            btn_clear.Enabled = false;
            clb_clear.Enabled = false;
            clb_installApplication.Enabled = false;
        }

        private void EnabledTrue()
        {
            btn_clear.Enabled = true;
            clb_clear.Enabled = true;
            clb_installApplication.Enabled = true;
        }

        private bool ControlCheckbox()
        {
            var tpClearCount = clb_clear.SelectedItems.Count;
            var tpInstallApplicationCount = clb_installApplication.SelectedItems.Count;


            if (tpInstallApplicationCount > 0 || tpClearCount > 0 || cb_tweak.Checked)
                return true;
            return false;
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

        #region Tweak

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
                Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads\\windowsTweaks.bat";

            using (var batFile = new StreamWriter(executeBatLocation))
            {
                batFile.WriteLine(scripts);
            }

            var processStartInfo = new ProcessStartInfo("cmd.exe", "/c " + executeBatLocation)
            {
                UseShellExecute = false,
                CreateNoWindow = true,
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

        #endregion

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
            public string Bios { get; set; }
        }

        #region INFO_FillData

        public void InfoFillData()
        {
            var computer = new Computer
            {
                InstallDate = GetOsInstallDate(),
                Os = GetOs("127.0.0.1"),
                Model = GetBrandAndModel("127.0.0.1"),
                Processor = GetProcessor("127.0.0.1"),
                Ram = GetRam("127.0.0.1"),
                Bios = GetBiosDetail()
            };

            rtb_info.AppendText("Computer Name: " + Environment.MachineName + Environment.NewLine);
            rtb_info.AppendText("Username: " + Environment.UserName + Environment.NewLine);
            rtb_info.AppendText("OS: " + computer.Os + Environment.NewLine);
            rtb_info.AppendText("OS Install Date: " + computer.InstallDate + Environment.NewLine);
            rtb_info.AppendText("Brand / Model: " + computer.Model + Environment.NewLine);
            rtb_info.AppendText("Processor: " + computer.Processor + Environment.NewLine);
            rtb_info.AppendText("Ram: " + computer.Ram + Environment.NewLine);
            rtb_info.AppendText("Bios: " + computer.Bios + Environment.NewLine);
        }

        #endregion

        public static string GetBiosDetail()
        {
            try
            {
                var mSearcher =
                    new ManagementObjectSearcher("SELECT SerialNumber, SMBIOSBIOSVersion, ReleaseDate FROM Win32_BIOS");
                var collection = mSearcher.Get();
                foreach (var o in collection)
                {
                    var obj = (ManagementObject) o;
                    var releaseDt = (string) obj["ReleaseDate"];
                    var dt = ManagementDateTimeConverter.ToDateTime(releaseDt);
                    var biosDateConvert = dt.ToString("yyyy.MM.dd");

                    var biosDetail = @"v" + (string) obj["SMBIOSBIOSVersion"] + @" - " + biosDateConvert;

                    return biosDetail;
                }
            }
            catch (Exception ex)
            {
                return "Exception: " + ex;
            }

            return null;
        }

        public static DateTime GetOsInstallDate()
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

        public static string GetOs(string ipAdressForOs)
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

        public static string GetBrandAndModel(string ipAdressForBrandAndModel)
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

        public static string GetProcessor(string ipAdressForProcessor)
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

        public static string GetRam(string ipAdressForRam)
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
                            totalMemory += (ulong) m["Capacity"];
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
            public static string ByteToString(ulong bytes)
            {
                string[] Suffix = {"bytes", "KB", "GB", "TB"};
                int i;
                double dblSByte = bytes;
                for (i = 0; i < Suffix.Length && bytes >= 1024; i++, bytes /= 1024) dblSByte = bytes / 1024.0;

                return $"{dblSByte:0.#} {Suffix[i]}";
            }

            public static string ByteToStringForInfo(ulong bytes)
            {
                string[] Suffix = {"bytes", "KB", "MB", "GB", "TB"};
                int i;
                double dblSByte = bytes;
                for (i = 0; i < Suffix.Length && bytes >= 1024; i++, bytes /= 1024) dblSByte = bytes / 1024.0;

                return $"{dblSByte:0.#} {Suffix[i]}";
            }
        }

        #endregion

        #region Install

        private void cb_install_selectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_install_selectAll.Checked)
            {
                for (var i = 0; i < clb_installApplication.Items.Count; i++) clb_installApplication.SetItemChecked(i, true);
            }
            else
            {
                for (var i = 0; i < clb_installApplication.Items.Count; i++) clb_installApplication.SetItemChecked(i, false);
            }
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
                else if (item.ToString() == "VLC Player")
                {
                    var installVlcPlayer = @"winget install --id=VideoLAN.VLC -e";
                    ExecuteCommand(installVlcPlayer, "VLC Player installed.", rtb_log);
                }
                else if (item.ToString() == "Notepad++")
                {
                    var installNotepadPlusPlus = @"winget install --id=Notepad++.Notepad++ -e";
                    ExecuteCommand(installNotepadPlusPlus, "Notepad++ installed.", rtb_log);
                }
                else if (item.ToString() == "Microsoft Visual C++ 2015-2022 Redistributable (x64)")
                {
                    var installMicrosoftVcRedistX64 = @"winget install --id=Microsoft.VCRedist.2015+.x64 -e";
                    ExecuteCommand(installMicrosoftVcRedistX64, "Microsoft VC++ 2015-2022 Redist-x64 installed.",
                        rtb_log);
                }

                else if (item.ToString() == "Microsoft Visual C++ 2015-2022 Redistributable (x86)")
                {
                    var installMicrosoftVcRedistX86 = @"winget install --id=Microsoft.VCRedist.2015+.x86 -e";
                    ExecuteCommand(installMicrosoftVcRedistX86, "Microsoft VC++ 2015-2022 Redist-x86 installed.",
                        rtb_log);
                }
                else if (item.ToString() == "Microsoft Edge")
                {
                    var installMicrosoftEdge = @"winget install -e --id Microsoft.Edge";
                    ExecuteCommand(installMicrosoftEdge, "Microsoft Edge installed.", rtb_log);
                }
                else if (item.ToString() == "Libre Office")
                {
                    var installLibreOffice = @"winget install -e --id TheDocumentFoundation.LibreOffice";
                    ExecuteCommand(installLibreOffice, "Libre Office installed.", rtb_log);
                }
                else if (item.ToString() == "ShareX")
                {
                    var installShareX = @"winget install -e --id ShareX.ShareX";
                    ExecuteCommand(installShareX, "ShareX installed.", rtb_log);
                }
                else if (item.ToString() == "ImageGlass")
                {
                    var installImageGlass = @"winget install -e --id DuongDieuPhap.ImageGlass";
                    ExecuteCommand(installImageGlass, "ImageGlass installed.", rtb_log);
                }
                else if (item.ToString() == "qBittorrent")
                {
                    var installQbittorrent = @"winget install -e --id qBittorrent.qBittorrent";
                    ExecuteCommand(installQbittorrent, "qBittorrent installed.", rtb_log);
                }
                else if (item.ToString() == "Discord")
                {
                    var installDiscord = @"winget install -e --id Discord.Discord";
                    ExecuteCommand(installDiscord, "Discord installed.", rtb_log);
                }
                else if (item.ToString() == "Steam")
                {
                    var installSteam = @"winget install -e --id Valve.Steam";
                    ExecuteCommand(installSteam, "Steam installed.", rtb_log);
                }
                else if (item.ToString() == "Microsoft Visual Studio Code")
                {
                    var installMicrosoftVisualStudioCode = @"winget install -e --id Microsoft.VisualStudioCode";
                    ExecuteCommand(installMicrosoftVisualStudioCode, "Microsoft Visual Studio Code installed.",
                        rtb_log);
                }
                else if (item.ToString() == "Spotify")
                {
                    var installSpotify = @"winget install -e --id Spotify.Spotify";
                    ExecuteCommand(installSpotify, "Spotify installed.", rtb_log);
                }
                else if (item.ToString() == "Java Runtime Environment")
                {
                    var installJavaRuntime = @"winget install -e --id Oracle.JavaRuntimeEnvironment";
                    ExecuteCommand(installJavaRuntime, "Java Runtime Environment installed.", rtb_log);
                }
        }

        #endregion

        #region Clear

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

        private void btn_clear_Click(object sender, EventArgs e)
        {
            if (ControlCheckbox())
            {
                bw_clear.RunWorkerAsync();
                EnabledFalse();
            }
            else
            {
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
            EnabledTrue();
        }

        #endregion
    }
}