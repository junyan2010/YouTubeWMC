using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouTubeWMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            InitializeComponent();

            InitializeBrowserCoreWebViewAsync();
        }
        private async void InitializeBrowserCoreWebViewAsync()
        {
            if (this.webView21.CoreWebView2 == null)
            {
                await this.webView21.EnsureCoreWebView2Async();
            }

            this.webView21.CoreWebView2.Settings.UserAgent = "Mozilla/5.0 (SMART-TV; Linux; Tizen 4.0.0.2) AppleWebkit/605.1.15 (KHTML, like Gecko) SamsungBrowser/9.2 TV Safari/605.1.15";
        }
    }
}
