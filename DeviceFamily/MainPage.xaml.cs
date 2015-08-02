using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System.Profile;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DeviceFamily
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private bool usePrimary = false;

        public MainPage()
        {
            if (AnalyticsInfo.VersionInfo.DeviceFamily == "Windows.Mobile")
            {
                if (usePrimary)
                {
                    InitializeComponent(new Uri("ms-appx:///PrimaryMainPage.xaml", UriKind.Absolute));
                }
                else
                {
                    InitializeComponent(new Uri("ms-appx:///SecondaryMainPage.xaml", UriKind.Absolute));
                }
            }
            else
            {
                InitializeComponent();
            }
        }
    }
}
