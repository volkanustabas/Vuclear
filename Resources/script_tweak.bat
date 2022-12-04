@echo off

fltmc >nul 2>&1 || (
    echo Administrator privileges are required.
    PowerShell Start -Verb RunAs '%0' 2> nul || (
        echo Right-click on the script and select "Run as administrator".
        pause & exit 1
    )
    exit 0
)

:: Show file extensions in Explorer
powershell -Command "Write-Host ' [Setting] Show file extensions in Explorer ' -F blue -B black"
reg add "HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced" /v "HideFileExt" /t  REG_DWORD /d 0 /f >nul 2>nul

:: Disable Transparency in taskbar, menu start etc
powershell -Command "Write-Host ' [Setting] Disable Transparency in taskbar/menu start ' -F blue -B black"
reg add "HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\Themes\Personalize" /v "EnableTransparency" /t REG_DWORD /d 0 /f >nul 2>nul
reg add "HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize" /v "EnableTransparency" /t REG_DWORD /d 0 /f >nul 2>nul

::  Disable windows animations, menu Start animations.
powershell -Command "Write-Host ' [Disable] Windows animations, menu Start animations ' -F darkgray -B black"
REG ADD "HKCU\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\VisualEffects" /v VisualFXSetting  /t REG_DWORD /d 3 /f >nul 2>nul

REG ADD "HKCU\Control Panel\Desktop" /v UserPreferencesMask /t REG_BINARY /d 9012078010000000 /f >nul 2>nul
REG ADD "HKCU\Control Panel\Desktop\WindowMetrics" /v MinAnimate /t REG_SZ /d 0 /f >nul 2>nul

REG ADD "HKCU\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\VisualEffects\AnimateMinMax" /v DefaultApplied  /t REG_DWORD /d 0 /f >nul 2>nul
REG ADD "HKCU\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\VisualEffects\ComboBoxAnimation" /v DefaultApplied  /t REG_DWORD /d 0 /f >nul 2>nul
REG ADD "HKCU\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\VisualEffects\ControlAnimations" /v DefaultApplied  /t REG_DWORD /d 0 /f >nul 2>nul
REG ADD "HKCU\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\VisualEffects\MenuAnimation" /v DefaultApplied  /t REG_DWORD /d 0 /f >nul 2>nul
REG ADD "HKCU\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\VisualEffects\TaskbarAnimation" /v DefaultApplied  /t REG_DWORD /d 0 /f >nul 2>nul
REG ADD "HKCU\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\VisualEffects\TooltipAnimation" /v DefaultApplied  /t REG_DWORD /d 0 /f >nul 2>nul

:: Disable MRU lists (jump lists) of XAML apps in Start Menu
powershell -Command "Write-Host ' [Disable] MRU lists (jump lists) of XAML apps in Start Menu ' -F darkgray -B black"
reg add "HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced" /v "Start_TrackDocs" /t REG_DWORD /d 0 /f >nul 2>nul

::  Hide the search box from taskbar. You can still search by pressing the Win key and start typing what you're looking for 
:: 0 = hide completely, 1 = show only icon, 2 = show long search box
powershell -Command "Write-Host ' [Setting] Hide the search box from taskbar. ' -F blue -B black"
reg add "HKCU\SOFTWARE\Microsoft\Windows\CurrentVersion\Search" /v "SearchboxTaskbarMode" /t REG_DWORD /d 1 /f >nul 2>nul

:: Windows Explorer to start on This PC instead of Quick Access 
powershell -Command "Write-Host ' [Setting] Windows Explorer to start on This PC instead of Quick Access ' -F blue -B black" 
reg add "HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced" /v "LaunchTo" /t REG_DWORD /d 1 /f >nul 2>nul

::  Disable Edge WebWidget
powershell -Command "Write-Host ' [Disable] Edge WebWidget ' -F darkgray -B black"
REG ADD "HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Edge" /v WebWidgetAllowed /t REG_DWORD /d 0 /f >nul 2>nul

::  Setting power option to high for best performance
:: powershell -Command "Write-Host ' [Setting] Power option to high for best performance ' -F blue -B black"
:: powercfg -setactive scheme_min

::  Enable All (Logical) Cores (Boot Advanced Options)
:: powershell -Command "Write-Host ' [Setting] Enable All (Logical) Cores (Boot Advanced Options) ' -F blue -B black"
:: wmic cpu get NumberOfLogicalProcessors | findstr /r "[0-9]" > NumLogicalCores.txt
:: set /P NOLP=<NumLogicalCores.txt
:: bcdedit /set {current} numproc %NOLP% >nul 2>nul
:: if exist NumLogicalCores.txt del NumLogicalCores.txt

:: Dual boot timeout 3sec
powershell -Command "Write-Host ' [Setting] Dual boot timeout 3sec ' -F blue -B black"
bcdedit /set timeout 3 >nul 2>nul

:: Disable Hibernation/Fast startup in Windows to free RAM from "C:\hiberfil.sys"
powershell -Command "Write-Host ' [Disable] Hibernation/Fast startup in Windows ' -F darkgray -B black"
powercfg -hibernate off >nul 2>nul

:: Disable windows insider experiments
powershell -Command "Write-Host ' [Disable] Windows Insider experiments ' -F darkgray -B black"
reg add "HKLM\SOFTWARE\Microsoft\PolicyManager\current\device\System" /v "AllowExperimentation" /t REG_DWORD /d "0" /f >nul 2>nul
reg add "HKLM\SOFTWARE\Microsoft\PolicyManager\default\System\AllowExperimentation" /v "value" /t "REG_DWORD" /d "0" /f >nul 2>nul

:: Disable app launch tracking
powershell -Command "Write-Host ' [Disable] App launch tracking ' -F darkgray -B black"
reg add "HKCU\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced" /v "Start_TrackProgs" /d "0" /t REG_DWORD /f >nul 2>nul

:: Disable powerthrottling (Intel 6gen and higher)
powershell -Command "Write-Host ' [Disable] Powerthrottling (Intel 6gen and higher) ' -F darkgray -B black"
reg add "HKLM\SYSTEM\CurrentControlSet\Control\Power\PowerThrottling" /v "PowerThrottlingOff" /t REG_DWORD /d "1" /f >nul 2>nul

:: Turn Off Background Apps
powershell -Command "Write-Host ' [Setting] Turn Off Background Apps ' -F blue -B black"
REG ADD "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\BackgroundAccessApplications" /v GlobalUserDisabled  /t REG_DWORD /d 1 /f >nul 2>nul
REG ADD "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Search" /v BackgroundAppGlobalToggle /t REG_DWORD /d 0 /f >nul 2>nul

:: Disable Sticky Keys prompt
powershell -Command "Write-Host ' [Disable] Sticky Keys prompt ' -F darkgray -B black"
reg add "HKEY_CURRENT_USER\Control Panel\Accessibility\StickyKeys" /v "Flags" /t REG_SZ /d 506 /f >nul 2>nul

:: Disable Activity History
powershell -Command "Write-Host ' [Disable] Activity History ' -F darkgray -B black"
reg add "HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\System" /v "PublishUserActivities" /t REG_DWORD /d 0 /f >nul 2>nul

:: Disable Automatic Updates for Microsoft Store apps
powershell -Command "Write-Host ' [Disable] Automatic Updates for Microsoft Store apps ' -F darkgray -B black"
reg add "HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\WindowsStore" /v "AutoDownload" /t REG_DWORD /d 2 /f >nul 2>nul

::  SmartScreen Filter for Store Apps: Disable
powershell -Command "Write-Host ' [Disable] SmartScreen Filter for Store Apps ' -F darkgray -B black"
reg add "HKCU\SOFTWARE\Microsoft\Windows\CurrentVersion\AppHost" /v EnableWebContentEvaluation /t REG_DWORD /d 0 /f >nul 2>nul

::  Let websites provide locally...
powershell -Command "Write-Host ' [Setting] Let websites provide locally ' -F blue -B black"
reg add "HKCU\Control Panel\International\User Profile" /v HttpAcceptLanguageOptOut /t REG_DWORD /d 1 /f >nul 2>nul

::  Microsoft Edge settings
powershell -Command "Write-Host ' [Setting] Microsoft Edge settings for privacy ' -F blue -B black"
reg add "HKCU\SOFTWARE\Classes\Local Settings\Software\Microsoft\Windows\CurrentVersion\AppContainer\Storage\microsoft.microsoftedge_8wekyb3d8bbwe\MicrosoftEdge\Main" /v DoNotTrack /t REG_DWORD /d 1 /f >nul 2>nul
reg add "HKCU\SOFTWARE\Classes\Local Settings\Software\Microsoft\Windows\CurrentVersion\AppContainer\Storage\microsoft.microsoftedge_8wekyb3d8bbwe\MicrosoftEdge\User\Default\SearchScopes" /v ShowSearchSuggestionsGlobal /t REG_DWORD /d 0 /f >nul 2>nul
reg add "HKCU\SOFTWARE\Classes\Local Settings\Software\Microsoft\Windows\CurrentVersion\AppContainer\Storage\microsoft.microsoftedge_8wekyb3d8bbwe\MicrosoftEdge\FlipAhead" /v FPEnabled /t REG_DWORD /d 0 /f >nul 2>nul
reg add "HKCU\SOFTWARE\Classes\Local Settings\Software\Microsoft\Windows\CurrentVersion\AppContainer\Storage\microsoft.microsoftedge_8wekyb3d8bbwe\MicrosoftEdge\PhishingFilter" /v EnabledV9 /t REG_DWORD /d 0 /f >nul 2>nul

::  Disable location sensor
powershell -Command "Write-Host ' [Disable] Location sensor ' -F darkgray -B black"
reg add "HKCU\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Sensor\Permissions\{BFA794E4-F964-4FDB-90F6-51056BFE4B44}" /v SensorPermissionState /t REG_DWORD /d 0 /f >nul 2>nul

:: WiFi Sense: HotSpot Sharing: Disable
powershell -Command "Write-Host ' [Disable] WiFi Sense: HotSpot Sharing ' -F darkgray -B black"
reg add "HKLM\Software\Microsoft\PolicyManager\default\WiFi\AllowWiFiHotSpotReporting" /v value /t REG_DWORD /d 0 /f >nul 2>nul

:: WiFi Sense: Shared HotSpot Auto-Connect: Disable
powershell -Command "Write-Host ' [Disable] WiFi Sense: Shared HotSpot Auto-Connect ' -F darkgray -B black"
reg add "HKLM\Software\Microsoft\PolicyManager\default\WiFi\AllowAutoConnectToWiFiSenseHotspots" /v value /t REG_DWORD /d 0 /f >nul 2>nul

:: Change Windows Updates to "Notify to schedule restart"
powershell -Command "Write-Host ' [Setting] Windows Updates to Notify to schedule restart ' -F blue -B black"
reg add "HKLM\SOFTWARE\Microsoft\WindowsUpdate\UX\Settings" /v UxOption /t REG_DWORD /d 1 /f >nul 2>nul

:: Disable P2P Update downloads outside of local network
powershell -Command "Write-Host ' [Disable] P2P Update downloads outside of local network ' -F darkgray -B black"
reg add "HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\DeliveryOptimization\Config" /v DODownloadMode /t REG_DWORD /d 0 /f >nul 2>nul

:: Setting Lower Shutdown time
powershell -Command "Write-Host ' [Setting] Lower Shutdown time ' -F blue -B black"
reg add "HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control" /v "WaitToKillServiceTimeout" /t REG_SZ /d 2000 /f >nul 2>nul

:: Remove Old Device Drivers
powershell -Command "Write-Host ' [Remove] Old Device Drivers ' -F red -B black"
SET DEVMGR_SHOW_NONPRESENT_DEVICES=1

:: Disable Get Even More Out of Windows Screen /W10
powershell -Command "Write-Host ' [Disable] Get Even More Out of Windows Screen ' -F darkgray -B black"
reg add "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager" /v "SubscribedContent-310093Enabled" /t REG_DWORD /d 0 /f >nul 2>nul
reg add "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager" /v "SubscribedContent-314559Enabled" /t REG_DWORD /d 0 /f >nul 2>nul
reg add "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager" /v "SubscribedContent-314563Enabled" /t REG_DWORD /d 0 /f >nul 2>nul
reg add "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager" /v "SubscribedContent-338387Enabled" /t REG_DWORD /d 0 /f >nul 2>nul
reg add "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager" /v "SubscribedContent-338388Enabled" /t REG_DWORD /d 0 /f >nul 2>nul
reg add "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager" /v "SubscribedContent-338389Enabled" /t REG_DWORD /d 0 /f >nul 2>nul
reg add "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager" /v "SubscribedContent-338393Enabled" /t REG_DWORD /d 0 /f >nul 2>nul
reg add "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager" /v "SubscribedContent-353698Enabled" /t REG_DWORD /d 0 /f >nul 2>nul
reg add "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\UserProfileEngagement" /v "ScoobeSystemSettingEnabled" /t REG_DWORD /d 0 /f >nul 2>nul

:: Disable automatically installing suggested apps /W10
powershell -Command "Write-Host ' [Disable] Automatically installing suggested apps ' -F darkgray -B black"
reg add "HKLM\SOFTWARE\Policies\Microsoft\Windows\CloudContent" /v "DisableWindowsConsumerFeatures" /t REG_DWORD /d 1 /f >nul 2>nul
reg add "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager" /v "ContentDeliveryAllowed" /t REG_DWORD /d 0 /f >nul 2>nul
reg add "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager" /v "OemPreInstalledAppsEnabled" /t REG_DWORD /d 0 /f >nul 2>nul
reg add "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager" /v "PreInstalledAppsEnabled" /t REG_DWORD /d 0 /f >nul 2>nul
reg add "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager" /v "PreInstalledAppsEverEnabled" /t REG_DWORD /d 0 /f >nul 2>nul
reg add "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager" /v "SilentInstalledAppsEnabled" /t REG_DWORD /d 0 /f >nul 2>nul
reg add "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager" /v "FeatureManagementEnabled" /t REG_DWORD /d 0 /f >nul 2>nul
reg add "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager" /v "SoftLandingEnabled" /t REG_DWORD /d 0 /f >nul 2>nul
reg add "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager" /v "RemediationRequired" /t REG_DWORD /d 0 /f >nul 2>nul
reg add "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager" /v "SubscribedContentEnabled" /t REG_DWORD /d 0 /f >nul 2>nul

:: Disable Start Menu Ads/Suggestions /W10
powershell -Command "Write-Host ' [Disable] Start Menu Ads/Suggestions ' -F darkgray -B black"
reg add "HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\ContentDeliveryManager" /v "SystemPaneSuggestionsEnabled" /t REG_DWORD /d 0 /f >nul 2>nul
reg add "HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced" /v "ShowSyncProviderNotifications" /t REG_DWORD /d 0 /f >nul 2>nul
reg add "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager" /v "RotatingLockScreenEnabled" /t REG_DWORD /d 0 /f >nul 2>nul
reg add "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager" /v "RotatingLockScreenOverlayEnabled" /t REG_DWORD /d 0 /f >nul 2>nul
reg add "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager" /v "SubscribedContent-338387Enabled" /t REG_DWORD /d 0 /f >nul 2>nul

:: Disable Allowing Suggested Apps In WindowsInk Workspace
powershell -Command "Write-Host ' [Disable] Allowing Suggested Apps In WindowsInk Workspace ' -F darkgray -B black"
reg add "HKLM\SOFTWARE\Microsoft\PolicyManager\default\WindowsInkWorkspace\AllowSuggestedAppsInWindowsInkWorkspace" /v "value" /t REG_DWORD /d 0 /f >nul 2>nul

:: Disables several unnecessary components
powershell -Command "Write-Host ' [Disable] Unnecessary components ' -F darkgray -B black"
set components=Printing-PrintToPDFServices-Features Printing-XPSServices-Features Xps-Foundation-Xps-Viewer
(for %%a in (%components%) do ( 
   PowerShell -Command " disable-windowsoptionalfeature -online -featureName %%a -NoRestart " >nul 2>nul
))

:: Setting Windows Defender Scheduled Scan from highest to normal privileges (CPU % high usage)
powershell -Command "Write-Host ' [Setting] Windows Defender Scheduled Scan from highest to normal privileges ' -F blue -B black"
schtasks /Change /TN "Microsoft\Windows\Windows Defender\Windows Defender Scheduled Scan" /RL LIMITED >nul 2>nul

::  Disabling Process Mitigation
:: Audit exploit mitigations for increased process security or for converting existing Enhanced Mitigation Experience Toolkit
powershell -Command "Write-Host ' [Disable] Process Mitigation ' -F darkgray -B black"
powershell.exe -command "Set-ProcessMitigation -System -Disable CFG"
for /f "tokens=3 skip=2" %%i in ('reg query "HKLM\System\CurrentControlSet\Control\Session Manager\kernel" /v "MitigationAuditOptions"') do set mitigation_mask=%%i
for /l %%i in (0,1,9) do set mitigation_mask=!mitigation_mask:%%i=2!
reg add "HKLM\System\CurrentControlSet\Control\Session Manager\kernel" /v "MitigationOptions" /t REG_BINARY /d "!mitigation_mask!" /f >nul 2>&1
reg add "HKLM\System\CurrentControlSet\Control\Session Manager\kernel" /v "MitigationAuditOptions" /t REG_BINARY /d "!mitigation_mask!" /f >nul 2>&1

:: Defragmenting the File Indexing Service database file
powershell -Command "Write-Host ' [Setting] Defragment Database Indexing Service File ' -F blue -B black" 
net stop wsearch /y >nul 2>nul
esentutl /d C:\ProgramData\Microsoft\Search\Data\Applications\Windows\Windows.edb >nul 2>nul
net start wsearch >nul 2>nul

:: SCHEDULED TASKS tweaks (Updates, Telemetry etc)
powershell -Command "Write-Host ' [Disable] SCHEDULED TASKS tweaks (Updates, Telemetry etc) ' -F darkgray -B black"
schtasks /Change /TN "Microsoft\Windows\AppID\SmartScreenSpecific" /Disable >nul 2>nul
schtasks /Change /TN "Microsoft\Windows\Application Experience\Microsoft Compatibility Appraiser" /Disable >nul 2>nul
schtasks /Change /TN "Microsoft\Windows\Application Experience\ProgramDataUpdater" /Disable >nul 2>nul
schtasks /Change /TN "Microsoft\Windows\Application Experience\StartupAppTask" /Disable >nul 2>nul
schtasks /Change /TN "Microsoft\Windows\Customer Experience Improvement Program\Consolidator" /Disable >nul 2>nul
schtasks /Change /TN "Microsoft\Windows\Customer Experience Improvement Program\KernelCeipTask" /Disable >nul 2>nul
schtasks /Change /TN "Microsoft\Windows\Customer Experience Improvement Program\UsbCeip" /Disable >nul 2>nul
schtasks /Change /TN "Microsoft\Windows\DiskDiagnostic\Microsoft-Windows-DiskDiagnosticDataCollector" /Disable >nul 2>nul
schtasks /Change /TN "Microsoft\Windows\MemoryDiagnostic\ProcessMemoryDiagnosticEvent" /Disable >nul 2>nul
schtasks /Change /TN "Microsoft\Windows\Power Efficiency Diagnostics\AnalyzeSystem" /Disable >nul 2>nul
schtasks /Change /TN "Microsoft\Windows\Customer Experience Improvement Program\Uploader" /Disable >nul 2>nul
schtasks /Change /TN "Microsoft\Windows\Shell\FamilySafetyUpload" /Disable >nul 2>nul
schtasks /Change /TN "Microsoft\Office\OfficeTelemetryAgentLogOn" /Disable >nul 2>nul
schtasks /Change /TN "Microsoft\Office\OfficeTelemetryAgentFallBack" /Disable >nul 2>nul
schtasks /Change /TN "\Microsoft\Office\OfficeTelemetryAgentFallBack2016" /Disable >nul 2>nul
schtasks /Change /TN "\Microsoft\Office\OfficeTelemetryAgentLogOn2016" /Disable >nul 2>nul
schtasks /Change /TN "Microsoft\Office\Office 15 Subscription Heartbeat" /Disable >nul 2>nul
schtasks /Change /TN "Microsoft\Windows\Windows Error Reporting\QueueReporting" /Disable >nul 2>nul
schtasks /Change /TN "Microsoft\Windows\WindowsUpdate\Automatic App Update" /Disable >nul 2>nul
schtasks /Change /TN "NIUpdateServiceStartupTask" /Disable >nul 2>nul
schtasks /Change /TN "CCleaner Update" /Disable >nul 2>nul
schtasks /Change /TN "CCleanerSkipUAC - %username%" /Disable >nul 2>nul
schtasks /Change /TN "Adobe Acrobat Update Task" /Disable >nul 2>nul
schtasks /Change /TN "AMDLinkUpdate" /Disable >nul 2>nul
schtasks /Change /TN "Microsoft\Office\Office Automatic Updates 2.0" /Disable >nul 2>nul
schtasks /Change /TN "Microsoft\Office\Office Feature Updates" /Disable >nul 2>nul
schtasks /Change /TN "Microsoft\Office\Office Feature Updates Logon" /Disable >nul 2>nul
schtasks /Change /TN "GoogleUpdateTaskMachineCore" /Disable >nul 2>nul
schtasks /Change /TN "GoogleUpdateTaskMachineUA" /Disable >nul 2>nul

:: Remove Telemetry & Data Collection 
powershell -Command "Write-Host ' [Disable] Telemetry/Data Collection ' -F darkgray -B black" 
reg add "HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Device Metadata" /v PreventDeviceMetadataFromNetwork /t REG_DWORD /d 1 /f >nul 2>nul
reg add "HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\DataCollection" /v "AllowTelemetry" /t REG_DWORD /d 0 /f >nul 2>nul
reg add "HKLM\Software\Policies\Microsoft\Windows\DataCollection" /v "AllowTelemetry" /t REG_DWORD /d 0 /f >nul 2>nul
reg add "HKLM\SOFTWARE\Policies\Microsoft\MRT" /v DontOfferThroughWUAU /t REG_DWORD /d 1 /f >nul 2>nul
reg add "HKLM\SOFTWARE\Policies\Microsoft\SQMClient\Windows" /v "CEIPEnable" /t REG_DWORD /d 0 /f >nul 2>nul
reg add "HKLM\SOFTWARE\Policies\Microsoft\Windows\AppCompat" /v "AITEnable" /t REG_DWORD /d 0 /f >nul 2>nul
reg add "HKLM\SOFTWARE\Policies\Microsoft\Windows\AppCompat" /v "DisableUAR" /t REG_DWORD /d 1 /f >nul 2>nul
reg add "HKLM\SOFTWARE\Policies\Microsoft\Windows\DataCollection" /v "AllowTelemetry" /t REG_DWORD /d 0 /f >nul 2>nul
reg add "HKLM\SYSTEM\CurrentControlSet\Control\WMI\AutoLogger\AutoLogger-Diagtrack-Listener" /v "Start" /t REG_DWORD /d 0 /f >nul 2>nul
reg add "HKLM\SYSTEM\CurrentControlSet\Control\WMI\AutoLogger\SQMLogger" /v "Start" /t REG_DWORD /d 0 /f >nul 2>nul
reg add "HKLM\Software\Microsoft\Windows\CurrentVersion\Privacy" /v "TailoredExperiencesWithDiagnosticDataEnabled" /t REG_DWORD /d 0 /f >nul 2>nul
reg add "HKLM\SYSTEM\ControlSet001\Control\WMI\Autologger\AutoLogger-Diagtrack-Listener" /v "Start" /t REG_DWORD /d 0 /f >nul 2>nul
reg add "HKLM\SYSTEM\ControlSet001\Services\dmwappushservice" /v "Start" /t REG_DWORD /d 4 /f >nul 2>nul
reg add "HKLM\SYSTEM\ControlSet001\Services\DiagTrack" /v "Start" /t REG_DWORD /d 4 /f >nul 2>nul

:: Disable PowerShell Telemetry
powershell -Command "Write-Host ' [Disable] PowerShell Telemetry ' -F darkgray -B black"
setx POWERSHELL_TELEMETRY_OPTOUT 1 >nul 2>nul

:: Disable Skype Telemetry
powershell -Command "Write-Host ' [Disable] Skype Telemetry ' -F darkgray -B black"
reg add "HKCU\SOFTWARE\Microsoft\Tracing\WPPMediaPerApp\Skype\ETW" /v "TraceLevelThreshold" /t REG_DWORD /d "0" /f >nul 2>nul
reg add "HKCU\SOFTWARE\Microsoft\Tracing\WPPMediaPerApp\Skype" /v "EnableTracing" /t REG_DWORD /d "0" /f >nul 2>nul
reg add "HKCU\SOFTWARE\Microsoft\Tracing\WPPMediaPerApp\Skype\ETW" /v "EnableTracing" /t REG_DWORD /d "0" /f >nul 2>nul
reg add "HKCU\SOFTWARE\Microsoft\Tracing\WPPMediaPerApp\Skype" /v "WPPFilePath" /t REG_SZ /d "%%SYSTEMDRIVE%%\TEMP\Tracing\WPPMedia" /f >nul 2>nul
reg add "HKCU\SOFTWARE\Microsoft\Tracing\WPPMediaPerApp\Skype\ETW" /v "WPPFilePath" /t REG_SZ /d "%%SYSTEMDRIVE%%\TEMP\WPPMedia" /f >nul 2>nul

:: Disable windows media player usage reports
powershell -Command "Write-Host ' [Disable] Windows media player usage reports ' -F darkgray -B black"
reg add "HKCU\SOFTWARE\Microsoft\MediaPlayer\Preferences" /v "UsageTracking" /t REG_DWORD /d "0" /f >nul 2>nul

:: Disable mozilla telemetry
powershell -Command "Write-Host ' [Disable] Mozilla telemetry ' -F darkgray -B black"
reg add HKLM\SOFTWARE\Policies\Mozilla\Firefox /v "DisableTelemetry" /t REG_DWORD /d "2" /f >nul 2>nul

:: Settings -> Privacy -> General -> Let apps use my advertising ID...
powershell -Command "Write-Host ' [Disable] Let apps use my advertising ID ' -F darkgray -B black"
reg add "HKCU\SOFTWARE\Microsoft\Windows\CurrentVersion\AdvertisingInfo" /v Enabled /t REG_DWORD /d 0 /f >nul 2>nul

::  Send Microsoft info about how I write to help us improve typing and writing in the future
powershell -Command "Write-Host ' [Disable] Send Microsoft info about how I write ' -F darkgray -B black"
reg add "HKCU\SOFTWARE\Microsoft\Input\TIPC" /v Enabled /t REG_DWORD /d 0 /f >nul 2>nul

::  Handwriting recognition personalization
powershell -Command "Write-Host ' [Disable] Handwriting recognition personalization ' -F darkgray -B black"
reg add "HKCU\SOFTWARE\Microsoft\InputPersonalization" /v RestrictImplicitInkCollection /t REG_DWORD /d 1 /f >nul 2>nul
reg add "HKCU\SOFTWARE\Microsoft\InputPersonalization" /v RestrictImplicitTextCollection /t REG_DWORD /d 1 /f >nul 2>nul

:: Disable watson malware reports
powershell -Command "Write-Host ' [Disable] Watson malware reports ' -F darkgray -B black"
reg add "HKLM\SOFTWARE\Policies\Microsoft\Windows Defender\Reporting" /v "DisableGenericReports" /t REG_DWORD /d "2" /f >nul 2>nul

:: Disable malware diagnostic data 
powershell -Command "Write-Host ' [Disable] Malware diagnostic data ' -F darkgray -B black" 
reg add "HKLM\SOFTWARE\Policies\Microsoft\MRT" /v "DontReportInfectionInformation" /t REG_DWORD /d "2" /f >nul 2>nul

:: Disable  setting override for reporting to Microsoft MAPS
powershell -Command "Write-Host ' [Disable] Setting override for reporting to Microsoft MAPS ' -F darkgray -B black"
reg add "HKLM\SOFTWARE\Policies\Microsoft\Windows Defender\Spynet" /v "LocalSettingOverrideSpynetReporting" /t REG_DWORD /d 0 /f >nul 2>nul

:: Disable spynet Defender reporting
powershell -Command "Write-Host ' [Disable] Spynet Defender reporting ' -F darkgray -B black"
reg add "HKLM\SOFTWARE\Policies\Microsoft\Windows Defender\Spynet" /v "SpynetReporting" /t REG_DWORD /d 0 /f >nul 2>nul

:: Do not send malware samples for further analysis
powershell -Command "Write-Host ' [Setting] Do not send malware samples for further analysis ' -F blue -B black"
reg add "HKLM\SOFTWARE\Policies\Microsoft\Windows Defender\Spynet" /v "SubmitSamplesConsent" /t REG_DWORD /d "2" /f >nul 2>nul

::  Prevents sending speech, inking and typing samples to MS (so Cortana can learn to recognise you)
powershell -Command "Write-Host ' [Disable] Sending speech, inking and typing samples to MS ' -F darkgray -B black"
reg add "HKCU\SOFTWARE\Microsoft\Personalization\Settings" /v AcceptedPrivacyPolicy /t REG_DWORD /d 0 /f >nul 2>nul

::  Prevents sending contacts to MS (so Cortana can compare speech etc samples)
powershell -Command "Write-Host ' [Disable] Sending contacts to MS ' -F darkgray -B black"
reg add "HKCU\SOFTWARE\Microsoft\InputPersonalization\TrainedDataStore" /v HarvestContacts /t REG_DWORD /d 0 /f >nul 2>nul

::  Immobilise Cortana 
powershell -Command "Write-Host ' [Disable] Cortana ' -F darkgray -B black"
reg add "HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\Windows Search" /v "AllowCortana" /t REG_DWORD /d 0 /f >nul 2>nul

:: Removing Windows Game Bar 
reg add "HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\GameDVR" /v "AppCaptureEnabled" /t REG_DWORD /d 0 /f >nul 2>nul
reg add "HKEY_CURRENT_USER\System\GameConfigStore" /v "GameDVR_Enabled" /t REG_DWORD /d 0 /f >nul 2>nul
powershell -Command "Write-Host ' [Remove] Windows Game Bar ' -F red -B black"
PowerShell -Command "Get-AppxPackage *XboxGamingOverlay* | Remove-AppxPackage"
PowerShell -Command "Get-AppxPackage *XboxGameOverlay* | Remove-AppxPackage"
PowerShell -Command "Get-AppxPackage *XboxSpeechToTextOverlay* | Remove-AppxPackage"

:: Remove News and Interests/Widgets from Win 11 (even if not shown on taskbar, that takes RAM/CPU running in background)
powershell -Command "Write-Host ' [Remove] News and Interests/Widgets' -F red -B black"
reg add "HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\Windows Feeds" /v EnableFeeds /t REG_DWORD /d 0 /f >nul 2>nul
reg add "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced" /v TaskbarDa /t REG_DWORD /d 0 /f >nul 2>nul
winget uninstall "windows web experience pack" --accept-source-agreements >nul 2>nul

:: Disable Services
powershell -Command "Write-Host ' [Setting] Services to: Disable Mode ' -F blue -B black"
set toDisable=DiagTrack diagnosticshub.standardcollector.service dmwappushservice RemoteRegistry RemoteAccess SCardSvr SCPolicySvc fax WerSvc NvTelemetryContainer gadjservice AdobeARMservice PSI_SVC_2 lfsvc WalletService RetailDemo SEMgrSvc diagsvc AJRouter
(for %%a in (%toDisable%) do ( 
   sc stop %%a >nul 2>nul
   sc config %%a start= disabled  >nul 2>nul
))

::Disable Network Diagnostic Usage Service
reg add "HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Services\Ndu" /v "Start" /t REG_DWORD /d 4 /f >nul 2>nul

:: Manuall
powershell -Command "Write-Host ' [Setting] Services to: Manuall Mode ' -F blue -B black"
set toManuall=BITS SamSs TapiSrv seclogon wuauserv PhoneSvc lmhosts iphlpsvc gupdate gupdatem edgeupdate edgeupdatem MapsBroker PnkBstrA brave bravem asus asusm adobeupdateservice adobeflashplayerupdatesvc WSearch
(for %%a in (%toManuall%) do ( 
   sc config %%a start= demand >nul 2>nul
))

:: Remove Bloatware Apps (Preinstalled) 69 apps
powershell -Command "Write-Host ' [Remove] Bloatware Apps ' -F red -B black"

set listofbloatware=3DBuilder Automate Appconnector Microsoft3DViewer MicrosoftPowerBIForWindows MicrosoftPowerBIForWindows Print3D XboxApp GetHelp WindowsFeedbackHub BingFoodAndDrink BingHealthAndFitness BingTravel WindowsReadingList MixedReality.Portal ScreenSketch YourPhone PicsArt-PhotoStudio EclipseManager PolarrPhotoEditorAcademicEdition Wunderlist LinkedInforWindows AutodeskSketchBook Twitter DisneyMagicKingdoms MarchofEmpires ActiproSoftwareLLC Plex iHeartRadio FarmVille2CountryEscape Duolingo CyberLinkMediaSuiteEssentials DolbyAccess DrawboardPDF FitbitCoach Flipboard Asphalt8Airborne Keeper BingNews COOKINGFEVER PandoraMediaInc CaesarsSlotsFreeCasino Shazam PhototasticCollage TuneInRadio WinZipUniversal XING RoyalRevolt2 CandyCrushSodaSaga BubbleWitch3Saga CandyCrushSaga Getstarted bing MicrosoftOfficeHub OneNote WindowsPhone SkypeApp windowscommunicationsapps WindowsMaps Sway CommsPhone ConnectivityStore Hotspot Sketchable Clipchamp Prime TikTok ToDo Family NewVoiceNote SamsungNotes SamsungFlux StudioPlus SamsungWelcome SamsungQuickSearch SamsungPCCleaner SamsungCloudBluetoothSync PCGallery OnlineSupportSService 
(for %%a in (%listofbloatware%) do ( 
	set /a insidecount+=1 >nul 2>nul
	title %version% [%counter%/%alltodo%] [!insidecount!/79]
   PowerShell -Command "Get-AppxPackage -allusers *%%a* | Remove-AppxPackage"
))

set /a counter+=1 >nul 2>nul

:: Disabling unnecessary applications at startup
powershell -Command "Write-Host ' [Disable] Unnecessary applications at startup ' -F darkgray -B black"

:: Java Update Checker x64
reg delete "HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Run" /v "SunJavaUpdateSched" /f >nul 2>nul

:: Mini Partition Tool Wizard Updater
reg delete "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Run" /v "MTPW" /f >nul 2>nul

:: Teams Machine Installer
reg delete "HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Run" /v "TeamsMachineInstaller" /f >nul 2>nul

:: Cisco Meeting Daemon
reg delete "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run" /v "CiscoMeetingDaemon" /f >nul 2>nul

:: Adobe Reader Speed Launcher
reg delete "HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Run" /v "Adobe Reader Speed Launcher" /f >nul 2>nul

:: CCleaner Smart Cleaning/Monitor
reg delete "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run" /v "CCleaner Smart Cleaning" /f >nul 2>nul
reg delete "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run" /v "CCleaner Monitor" /f >nul 2>nul

:: Spotify Web Helper
reg delete "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run" /v "Spotify Web Helper" /f >nul 2>nul

:: Gaijin.Net Updater
reg delete "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run" /v "Gaijin.Net Updater" /f >nul 2>nul

:: Microsoft Teams Update
reg delete "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run" /v "com.squirrel.Teams.Teams" /f >nul 2>nul

:: Google Update
reg delete "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run" /v "Google Update" /f >nul 2>nul

:: Microsoft Edge Update
reg delete "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run" /v "Microsoft Edge Update" /f >nul 2>nul

:: BitTorrent Bleep
reg delete "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run" /v "BitTorrent Bleep" /f >nul 2>nul

:: Skype
reg delete "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run" /v "Skype" /f >nul 2>nul

:: Adobe Update Startup Utility
reg delete "HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Run" /v "adobeAAMUpdater-1.0" /f >nul 2>nul
reg delete "HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Run" /v "AdobeAAMUpdater" /f >nul 2>nul

:: iTunes Helper
reg delete "HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Run" /v "iTunesHelper" /f >nul 2>nul

:: CyberLink Update Utility
reg delete "HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Run" /v "UpdatePPShortCut" /f >nul 2>nul

:: MSI Live Update
reg delete "HKEY_LOCAL_MACHINE\Software\Wow6432Node\Microsoft\Windows\CurrentVersion\Run" /v "Live Update" /f >nul 2>nul

:: Wondershare Helper Compact
reg delete "HKEY_LOCAL_MACHINE\Software\Wow6432Node\Microsoft\Windows\CurrentVersion\Run" /v "Wondershare Helper Compact" /f >nul 2>nul

:: Cisco AnyConnect Secure Mobility Agent
reg delete "HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Run" /v "Cisco AnyConnect Secure Mobility Agent for Windows" /f >nul 2>nul

:: Opera Browser Assistant (Update/Tray)
reg delete "HKCU\SOFTWARE\Microsoft\Windows\CurrentVersion\Run" /v "Opera Browser Assistant" /f >nul 2>nul

:: Steam Autorun
reg delete "HKCU\SOFTWARE\Microsoft\Windows\CurrentVersion\Run" /v "Steam" /f >nul 2>nul

:: Origin Autorun
reg delete "HKCU\SOFTWARE\Microsoft\Windows\CurrentVersion\Run" /v "EADM" /f >nul 2>nul

:: Epic Games Launcher Autorun
reg delete "HKCU\SOFTWARE\Microsoft\Windows\CurrentVersion\Run" /v "EpicGamesLauncher" /f >nul 2>nul

:: Gog Galaxy Autorun
reg delete "HKCU\SOFTWARE\Microsoft\Windows\CurrentVersion\Run" /v "GogGalaxy" /f >nul 2>nul

:: Skype for Desktop Autorun
reg delete "HKCU\SOFTWARE\Microsoft\Windows\CurrentVersion\Run" /v "Skype for Desktop" /f >nul 2>nul

:: Wargaming.net Game Center
reg delete "HKCU\SOFTWARE\Microsoft\Windows\CurrentVersion\Run" /v "Wargaming.net Game Center" /f >nul 2>nul

:: uTorrent Autorun
reg delete "HKCU\SOFTWARE\Microsoft\Windows\CurrentVersion\Run" /v "ut" /f >nul 2>nul

:: Lync - Skype for Business Autorun
reg delete "HKCU\SOFTWARE\Microsoft\Windows\CurrentVersion\Run" /v "Lync" /f >nul 2>nul

:: Google Chrome Installer (Update)
reg delete "HKLM\SOFTWARE\Microsoft\Active Setup\Installed Components" /v "Google Chrome" /f >nul 2>nul

:: Microsoft Edge Installer (Update)
reg delete "HKLM\SOFTWARE\Microsoft\Active Setup\Installed Components" /v "Microsoft Edge" /f >nul 2>nul
reg delete "HKCU\SOFTWARE\Microsoft\Windows\CurrentVersion\Run" /v "MicrosoftEdgeAutoLaunch_E9C49D8E9BDC4095F482C844743B9E82" /f >nul 2>nul
reg delete "HKCU\SOFTWARE\Microsoft\Windows\CurrentVersion\Run" /v "MicrosoftEdgeAutoLaunch" /f >nul 2>nul

:: Discord Update
reg delete "HKCU\SOFTWARE\Microsoft\Windows\CurrentVersion\Run" /v "Discord" /f >nul 2>nul

:: Ubisoft Game Launcher
reg delete "HKCU\SOFTWARE\Microsoft\Windows\CurrentVersion\Run" /v "Ubisoft Game Launcher" /f >nul 2>nul

::  TEMP/Logs/Cache/Prefetch/Updates Cleaning
powershell -Command "Write-Host ' [Clean] Temp ' -F yellow -B black"
powershell -Command "Get-ChildItem -Path $env:TEMP -Include *.* -Exclude *.bat, *.lbool -File -Recurse | foreach { $_.Delete()}" >nul 2>nul
Del /S /F /Q %Windir%\Temp >nul 2>nul

powershell -Command "Write-Host ' [Clean] Windows Prefetch/Cache/Logs ' -F yellow -B black"
Del /S /F /Q %windir%\Prefetch >nul 2>nul

del %AppData%\vstelemetry >nul 2>nul
del %LocalAppData%\Microsoft\VSApplicationInsights /F /Q /S >nul 2>nul
del %ProgramData%\Microsoft\VSApplicationInsights  /F /Q /S >nul 2>nul
del %Temp%\Microsoft\VSApplicationInsights  /F /Q /S >nul 2>nul
del %Temp%\VSFaultInfo  /F /Q /S >nul 2>nul
del %Temp%\VSFeedbackPerfWatsonData  /F /Q /S >nul 2>nul
del %Temp%\VSFeedbackVSRTCLogs  /F /Q /S >nul 2>nul
del %Temp%\VSRemoteControl  /F /Q /S >nul 2>nul
del %Temp%\VSTelem /F /Q /S >nul 2>nul
del %Temp%\VSTelem.Out /F /Q /S >nul 2>nul

del %localappdata%\Yarn\Cache /F /Q /S >nul 2>nul

del %appdata%\Microsoft\Teams\Cache /F /Q /S >nul 2>nul

del %programdata%\GOG.com\Galaxy\webcache /F /Q /S >nul 2>nul
del %programdata%\GOG.com\Galaxy\logs /F /Q /S >nul 2>nul

del %localappdata%\Microsoft\Windows\WebCache /F /Q /S >nul 2>nul

del "%SystemDrive%\*.log" /F /Q >nul 2>nul
del "%WinDir%\Directx.log" /F /Q >nul 2>nul
del "%WinDir%\SchedLgU.txt" /F /Q >nul 2>nul
del "%WinDir%\*.log" /F /Q >nul 2>nul
del "%WinDir%\security\logs\*.old" /F /Q >nul 2>nul
del "%WinDir%\security\logs\*.log" /F /Q >nul 2>nul
del "%WinDir%\Debug\*.log" /F /Q >nul 2>nul
del "%WinDir%\Debug\UserMode\*.bak" /F /Q >nul 2>nul
del "%WinDir%\Debug\UserMode\*.log" /F /Q >nul 2>nul
del "%WinDir%\*.bak" /F /Q >nul 2>nul
del "%WinDir%\system32\wbem\Logs\*.log" /F /Q >nul 2>nul
del "%WinDir%\OEWABLog.txt" /F /Q >nul 2>nul
del "%WinDir%\setuplog.txt" /F /Q >nul 2>nul
del "%WinDir%\Logs\DISM\*.log" /F /Q >nul 2>nul
del "%WinDir%\*.log.txt" /F /Q >nul 2>nul
del "%WinDir%\APPLOG\*.*" /F /Q >nul 2>nul
del "%WinDir%\system32\wbem\Logs\*.log" /F /Q >nul 2>nul
del "%WinDir%\system32\wbem\Logs\*.lo_" /F /Q >nul 2>nul
del "%WinDir%\Logs\DPX\*.log" /F /Q >nul 2>nul
del "%WinDir%\ServiceProfiles\NetworkService\AppData\Local\Temp\*.log" /F /Q >nul 2>nul
del "%WinDir%\Logs\*.log" /F /Q >nul 2>nul
del "%LocalAppData%\Microsoft\Windows\WindowsUpdate.log" /F /Q >nul 2>nul
del "%LocalAppData%\Microsoft\Windows\WebCache\*.log" /F /Q >nul 2>nul
del "%WinDir%\Panther\cbs.log" /F /Q >nul 2>nul
del "%WinDir%\Panther\DDACLSys.log" /F /Q >nul 2>nul
del "%WinDir%\repair\setup.log" /F /Q >nul 2>nul
del "%WinDir%\Panther\UnattendGC\diagerr.xml" /F /Q >nul 2>nul
del "%WinDir%\Panther\UnattendGC\diagwrn.xml" /F /Q >nul 2>nul
del "%WinDir%\inf\setupapi.offline.log" /F /Q >nul 2>nul
del "%WinDir%\inf\setupapi.app.log" /F /Q >nul 2>nul
del "%WinDir%\debug\WIA\*.log" /F /Q >nul 2>nul
del "%SystemDrive%\PerfLogs\System\Diagnostics\*.*" /F /Q >nul 2>nul
del "%WinDir%\Logs\CBS\*.cab" /F /Q >nul 2>nul
del "%WinDir%\Logs\CBS\*.cab" /F /Q >nul 2>nul
del "%WinDir%\Logs\WindowsBackup\*.etl" /F /Q >nul 2>nul
del "%WinDir%\System32\LogFiles\HTTPERR\*.*" /F /Q >nul 2>nul
del "%WinDir%\SysNative\SleepStudy\*.etl" /F /Q >nul 2>nul
del "%WinDir%\SysNative\SleepStudy\ScreenOn\*.etl" /F /Q >nul 2>nul
del "%WinDir%\System32\SleepStudy\*.etl" /F /Q >nul 2>nul
del "%WinDir%\System32\SleepStudy\ScreenOn\*.etl" /F /Q >nul 2>nul
del "%WinDir%\Logs" /F /Q >nul 2>nul
del "%WinDir%\DISM" /F /Q >nul 2>nul
del "%WinDir%\System32\catroot2\*.chk" /F /Q >nul 2>nul
del "%WinDir%\System32\catroot2\*.log" /F /Q >nul 2>nul
del "%WinDir%\System32\catroot2\.jrs" /F /Q >nul 2>nul
del "%WinDir%\System32\catroot2\*.txt" /F /Q >nul 2>nul

:: Cleaning Disk - cleanmgr
start cleanmgr.exe /autoclean


:: Clean
powershell -Command "Write-Host ' [Clean] Games Platforms Cache/Logs ' -F yellow -B black"

del %localappdata%\EpicGamesLauncher\Saved\Logs /F /Q /S >nul 2>nul
del %localappdata%\CrashReportClient\Saved\Logs /F /Q /S >nul 2>nul

del "%localappdata%\Steam\htmlcache\Code Cache" /F /Q /S >nul 2>nul
del %localappdata%\Steam\htmlcache\GPUCache /F /Q /S >nul 2>nul
del %localappdata%\Steam\htmlcache\Cache /F /Q /S >nul 2>nul

del %AppData%\Origin\Telemetry /F /Q /S >nul 2>nul
del %AppData%\Origin\Logs /F /Q /S >nul 2>nul
del %AppData%\Origin\NucleusCache /F /Q /S >nul 2>nul
del %AppData%\Origin\ConsolidatedCache /F /Q /S >nul 2>nul
del %AppData%\Origin\CatalogCache /F /Q /S >nul 2>nul
del %localAppData%\Origin\ThinSetup /F /Q /S >nul 2>nul
del %AppData%\Origin\Telemetry /F /Q /S >nul 2>nul
del %localAppData%\Origin\Logs /F /Q /S >nul 2>nul

del %localAppData%\Battle.net\Cache /F /Q /S >nul 2>nul
del %AppData%\Battle.net\Logs /F /Q /S >nul 2>nul
del %AppData%\Battle.net\Errors /F /Q /S >nul 2>nul

powershell -Command "Write-Host ' [Clean] Windows Defender Cache/Logs ' -F yellow -B black"

del "%ProgramData%\Microsoft\Windows Defender\Network Inspection System\Support\*.log" /F /Q /S >nul 2>nul
del "%ProgramData%\Microsoft\Windows Defender\Scans\History\CacheManager" /F /Q /S >nul 2>nul
del "%ProgramData%\Microsoft\Windows Defender\Scans\History\ReportLatency\Latency" /F /Q /S >nul 2>nul
del "%ProgramData%\Microsoft\Windows Defender\Scans\History\Service\*.log" /F /Q /S >nul 2>nul
del "%ProgramData%\Microsoft\Windows Defender\Scans\MetaStore" /F /Q /S >nul 2>nul
del "%ProgramData%\Microsoft\Windows Defender\Support" /F /Q /S >nul 2>nul
del "%ProgramData%\Microsoft\Windows Defender\Scans\History\Results\Quick" /F /Q /S >nul 2>nul
del "%ProgramData%\Microsoft\Windows Defender\Scans\History\Results\Resource" /F /Q /S >nul 2>nul

powershell -Command "Write-Host ' [Clean] Windows Font Cache ' -F yellow -B black"

net stop FontCache >nul 2>nul
net stop FontCache3.0.0.0 >nul 2>nul
del "%WinDir%\ServiceProfiles\LocalService\AppData\Local\FontCache\*.dat" /F /Q /S >nul 2>nul
del "%WinDir%\SysNative\FNTCACHE.DAT" /F /Q /S >nul 2>nul
del "%WinDir%\System32\FNTCACHE.DAT" /F /Q /S >nul 2>nul
net start FontCache >nul 2>nul
net start FontCache3.0.0.0 >nul 2>nul

powershell -Command "Write-Host ' [Clean] Windows Icon Cache ' -F yellow -B black"

%WinDir%\SysNative\ie4uinit.exe -show >nul 2>nul
%WinDir%\System32\ie4uinit.exe -show >nul 2>nul
del %LocalAppData%\IconCache.db /F /Q /S >nul 2>nul
del "%LocalAppData%\Microsoft\Windows\Explorer\iconcache_*.db" /F /Q /S >nul 2>nul


:: Onedrive
powershell -Command "Write-Host ' [Remove] Microsoft OneDrive ' -F red -B black"
taskkill /F /IM "OneDrive.exe" >nul 2>nul
%systemroot\SysWOW64\OneDriveSetup.exe /uninstall >nul 2>nul
%systemroot\System32\OneDriveSetup.exe /uninstall >nul 2>nul

PowerShell -Command "Get-AppxPackage -allusers *Microsoft.OneDriveSync* | Remove-AppxPackage"

rd "%UserProfile%\OneDrive" /Q /S 1>NUL 2>NUL
rd "%LocalAppData%\Microsoft\OneDrive" /Q /S 1>NUL 2>NUL
rd "%ProgramData%\Microsoft OneDrive" /Q /S 1>NUL 2>NUL
rd "%systemdrive%\OneDriveTemp" /Q /S 1>NUL 2>NUL

::Remove OneDrive leftovers in explorer left side panel
reg add "HKEY_CLASSES_ROOT\CLSID\{018D5C66-4533-4307-9B53-224DE2ED1FE6}" /v "System.IsPinnedToNameSpaceTree" /t REG_DWORD /d 0 /f >nul 2>nul
reg add "HKEY_CLASSES_ROOT\Wow6432Node\CLSID\{018D5C66-4533-4307-9B53-224DE2ED1FE6}" /v "System.IsPinnedToNameSpaceTree" /t REG_DWORD /d 0 /f >nul 2>nul
reg delete "HKCU\SOFTWARE\Microsoft\Windows\CurrentVersion\Run" /v "OneDrive" /f >nul 2>nul

:: Xbox service
powershell -Command "Write-Host ' [Disable] Xbox Services ' -F darkgray -B black"
sc config XblAuthManager start= disabled >nul 2>nul
sc config XboxNetApiSvc start= disabled >nul 2>nul
sc config XblGameSave start= disabled >nul 2>nul