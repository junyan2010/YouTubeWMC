using Microsoft.Web.WebView2.Core;
using System;
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
        }
        private void webView21_CoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            this.webView21.CoreWebView2.Settings.UserAgent = "Mozilla/5.0 (SMART-TV) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/131.0.6778.200 Mobile Safari/537.36";
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
            System.Drawing.Point leftTop = new System.Drawing.Point(this.Width, this.Height);
            Cursor.Position = leftTop;
        }
    }
}
