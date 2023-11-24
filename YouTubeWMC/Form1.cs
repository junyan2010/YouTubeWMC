using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace YouTubeWMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            InitializeComponent();
        }
        private void webView21_CoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            this.webView21.CoreWebView2.Settings.UserAgent = "Mozilla/5.0 (SMART-TV; Linux; Tizen 4.0.0.2) AppleWebkit/605.1.15 (KHTML, like Gecko) SamsungBrowser/9.2 TV Safari/605.1.15";
            this.webView21.Source = new System.Uri("https://youtube.com/tv", System.UriKind.Absolute);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.webView21.Left = this.Left;
            this.webView21.Top = this.Top;
            this.webView21.Width = this.Width;
            this.webView21.Height = this.Height;
        }

        private void webView21_KeyDown(object sender, KeyEventArgs e)
        {
            Console.Out.WriteLine(e.KeyCode);
            switch (e.KeyCode)
            {
                case Keys.BrowserBack:
                    e.Handled = true;
                    SendKeys.Send("{BACKSPACE}");
                    break;
            }
        }

        private void webView21_SourceChanged(object sender, CoreWebView2SourceChangedEventArgs e)
        {
            System.Drawing.Point leftTop = new System.Drawing.Point(0, 0);
            Cursor.Position = leftTop;
        }
    }
}
