using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Stremio
{
    /// <summary>
    /// Core Display Page for Stremio Content.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public static string DeviceForm { get; } // Get Device Info
        public MainPage()
        {
            this.InitializeComponent();
            Environment.SetEnvironmentVariable("WEBVIEW2_DEFAULT_BACKGROUND_COLOR", "151330"); // Control WebView2 default background colour
        }

    }
}