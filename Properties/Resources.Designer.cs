﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vuclear.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Vuclear.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @echo off
        ///
        ///fltmc &gt;nul 2&gt;&amp;1 || (
        ///    echo Administrator privileges are required.
        ///    PowerShell Start -Verb RunAs &apos;%0&apos; 2&gt; nul || (
        ///        echo Right-click on the script and select &quot;Run as administrator&quot;.
        ///        pause &amp; exit 1
        ///    )
        ///    exit 0
        ///)
        ///
        ///
        ///:: ----------------------------------------------------------
        ///:: ------------------Clear Listary indexes-------------------
        ///:: ----------------------------------------------------------
        ///echo --- Clear Listary indexes
        ///del /f /s /q %appdata%\Listary\UserData &gt; nul
        ///: [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string clear_applicationHistory {
            get {
                return ResourceManager.GetString("clear_applicationHistory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @echo off
        ///
        ///fltmc &gt;nul 2&gt;&amp;1 || (
        ///    echo Administrator privileges are required.
        ///    PowerShell Start -Verb RunAs &apos;%0&apos; 2&gt; nul || (
        ///        echo Right-click on the script and select &quot;Run as administrator&quot;.
        ///        pause &amp; exit 1
        ///    )
        ///    exit 0
        ///)
        ///
        ///
        ///:: ----------------------------------------------------------
        ///:: -Clear all Opera data (user profiles, settings, and data)-
        ///:: ----------------------------------------------------------
        ///echo --- Clear all Opera data (user profiles, settings, and data)
        ///:: Windows X [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string clear_browserHistory {
            get {
                return ResourceManager.GetString("clear_browserHistory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @echo off
        ///
        ///fltmc &gt;nul 2&gt;&amp;1 || (
        ///    echo Administrator privileges are required.
        ///    PowerShell Start -Verb RunAs &apos;%0&apos; 2&gt; nul || (
        ///        echo Right-click on the script and select &quot;Run as administrator&quot;.
        ///        pause &amp; exit 1
        ///    )
        ///    exit 0
        ///)
        ///
        ///
        ///:: ----------------------------------------------------------
        ///:: ----Clear credentials from Windows Credential Manager-----
        ///:: ----------------------------------------------------------
        ///echo --- Clear credentials from Windows Credential Manager
        ///cmdkey.exe /list &gt;  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string clear_credentialCache {
            get {
                return ResourceManager.GetString("clear_credentialCache", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @echo off
        ///
        ///fltmc &gt;nul 2&gt;&amp;1 || (
        ///    echo Administrator privileges are required.
        ///    PowerShell Start -Verb RunAs &apos;%0&apos; 2&gt; nul || (
        ///        echo Right-click on the script and select &quot;Run as administrator&quot;.
        ///        pause &amp; exit 1
        ///    )
        ///    exit 0
        ///)
        ///
        ///
        ///:: ----------------------------------------------------------
        ///:: ---------------------Empty trash bin----------------------
        ///:: ----------------------------------------------------------
        ///echo --- Empty trash bin
        ///PowerShell -ExecutionPolicy Unrestricted -Command &quot;$b [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string clear_emptyTrashBin {
            get {
                return ResourceManager.GetString("clear_emptyTrashBin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @echo off
        ///
        ///fltmc &gt;nul 2&gt;&amp;1 || (
        ///    echo Administrator privileges are required.
        ///    PowerShell Start -Verb RunAs &apos;%0&apos; 2&gt; nul || (
        ///        echo Right-click on the script and select &quot;Run as administrator&quot;.
        ///        pause &amp; exit 1
        ///    )
        ///    exit 0
        ///)
        ///
        ///
        ///:: ----------------------------------------------------------
        ///:: ---------------------Clear Temp----------------------
        ///:: ----------------------------------------------------------
        ///@echo --- Clear Temp
        ///:: clearing windows temp folders
        ///del /s /f /q %windir%\temp\*. [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string clear_temp {
            get {
                return ResourceManager.GetString("clear_temp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @echo off
        ///
        ///fltmc &gt;nul 2&gt;&amp;1 || (
        ///    echo Administrator privileges are required.
        ///    PowerShell Start -Verb RunAs &apos;%0&apos; 2&gt; nul || (
        ///        echo Right-click on the script and select &quot;Run as administrator&quot;.
        ///        pause &amp; exit 1
        ///    )
        ///    exit 0
        ///)
        ///
        ///
        ///:: ----------------------------------------------------------
        ///:: ------------------Clear thumbnail cache-------------------
        ///:: ----------------------------------------------------------
        ///echo --- Clear thumbnail cache
        ///del /f /s /q /a %LocalAppData%\Microsoft\Window [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string clear_windowsLogsCaches {
            get {
                return ResourceManager.GetString("clear_windowsLogsCaches", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap image_clear {
            get {
                object obj = ResourceManager.GetObject("image_clear", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap image_loading {
            get {
                object obj = ResourceManager.GetObject("image_loading", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @echo off
        ///
        ///fltmc &gt;nul 2&gt;&amp;1 || (
        ///    echo Administrator privileges are required.
        ///    PowerShell Start -Verb RunAs &apos;%0&apos; 2&gt; nul || (
        ///        echo Right-click on the script and select &quot;Run as administrator&quot;.
        ///        pause &amp; exit 1
        ///    )
        ///    exit 0
        ///)
        ///
        ///:: Show file extensions in Explorer
        ///powershell -Command &quot;Write-Host &apos; [Setting] Show file extensions in Explorer &apos; -F blue -B black&quot;
        ///reg add &quot;HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced&quot; /v &quot;HideFileExt&quot; /t  REG_DWORD /d 0 /f &gt;nul  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string script_tweak {
            get {
                return ResourceManager.GetString("script_tweak", resourceCulture);
            }
        }
    }
}
