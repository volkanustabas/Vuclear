@echo off

fltmc >nul 2>&1 || (
    echo Administrator privileges are required.
    PowerShell Start -Verb RunAs '%0' 2> nul || (
        echo Right-click on the script and select "Run as administrator".
        pause & exit 1
    )
    exit 0
)


:: ----------------------------------------------------------
:: ---------------------Clear Temp----------------------
:: ----------------------------------------------------------
@echo --- Clear Temp
:: clearing windows temp folders
del /s /f /q %windir%\temp\*.*
rd /s /q %windir%\temp
md %windir%\temp

:: clearing driver cache
del /s /f /q %windir%\system32\dllcache\*.*
rd /s /q %windir%\system32\dllcache
md %windir%\system32\dllcache

:: clearing base system temp folders
del /s /f /q "%SystemDrive%\Temp"\*.*
rd /s /q "%SystemDrive%\Temp"
md "%SystemDrive%\Temp"

:: clearing system temp folder
del /s /f /q %temp%\*.*
rd /s /q %temp%
md %temp%

:: clearing appdata local temp folders
del /s /f /q "%APPDATA%\Local\History"\*.*
rd /s /q "%APPDATA%\Local\History"
md "%APPDATA%\Local\History"
del /s /f /q "%APPDATA%\Local\Temporary Internet Files"\*.*
rd /s /q "%APPDATA%\Local\Temporary Internet Files"
md "%APPDATA%\Local\Temporary Internet Files"
del /s /f /q "%APPDATA%\Local\Temp"\*.*
rd /s /q "%APPDATA%\Local\Temp"
md "%APPDATA%\Local\Temp"

:: clearing appdata roaming folders
set EX_DataDir=%APPDATA%\Roaming\Microsoft\Windows\Recent
del /q /s /f "%EX_DataDir%"
rd /s /q "%EX_DataDir%"
md "%EX_DataDir%"
set EX_DataDir_ad=%APPDATA%\Roaming\Microsoft\Windows\Recent\AutomaticDestinations\
del /q /s /f "%EX_DataDir_ad%"
rd /s /q "%EX_DataDir_ad%"
md "%EX_DataDir_ad%"
set EX_DataDir_cd=%APPDATA%\Roaming\Microsoft\Windows\Recent\CustomeDestinations\
del /q /s /f "%EX_DataDir_cd%"
rd /s /q "%EX_DataDir_cd%"
md "%EX_DataDir_cd%"

:: clearing user profile temp folders
del /s /f /q "%USERPROFILE%\Recent"\*.*
rd /s /q "%USERPROFILE%\Recent"
md "%USERPROFILE%\Recent"
del /s /f /q "%USERPROFILE%\Cookies"\*.*
rd /s /q "%USERPROFILE%\Cookies"
md "%USERPROFILE%\Cookies"

:: clearing and renewing network connection
ipconfig /release
ipconfig /renew
ipconfig /flushdns

:: ----------------------------------------------------------
:: ----------------------------------------------------------
:: ----------------------------------------------------------