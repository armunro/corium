using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using Corium.WindowsClient.Controls;

namespace Corium.WindowsClient.Forms
{
    public sealed partial class CoriumWindowForm : Form
    {
        private readonly ChromiumWebBrowser _browser;
        private bool _mouseDown;
        private Point _lastLocation;

        public CoriumWindowForm(ToolWindow toolWindow)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);


            _browser = new ChromiumWebBrowser(toolWindow.StartUrl);
            _browser.Dock = DockStyle.None;

            _browser.IsBrowserInitializedChanged += OnIsBrowserInitializedChanged;
            _browser.LoadingStateChanged += OnLoadingStateChanged;
            _browser.ConsoleMessage += OnBrowserConsoleMessage;
            _browser.TitleChanged += OnBrowserTitleChanged;
            _browser.AddressChanged += OnBrowserAddressChanged;

            PlaceBrowser(toolWindow);
            Controls.Add(_browser);
            BackColor = ColorTranslator.FromHtml(toolWindow.Appearance.WindowBorderColor);
            lblTitle.BackColor = ColorTranslator.FromHtml(toolWindow.Appearance.TitleBarBackground);
            MinimizeButton.BackColor = ColorTranslator.FromHtml(toolWindow.Appearance.TitleBarBackground);
            MinimizeButton.IconColor = ColorTranslator.FromHtml(toolWindow.Appearance.TitleBarIconColor);
            MaximizeButton.BackColor = ColorTranslator.FromHtml(toolWindow.Appearance.TitleBarBackground);
            MaximizeButton.IconColor = ColorTranslator.FromHtml(toolWindow.Appearance.TitleBarIconColor);
            ExitButton.BackColor = ColorTranslator.FromHtml(toolWindow.Appearance.TitleBarBackground);
            ExitButton.IconColor = ColorTranslator.FromHtml(toolWindow.Appearance.TitleBarIconColor);
            BackButton.BackColor = ColorTranslator.FromHtml(toolWindow.Appearance.TitleBarBackground);
            BackButton.IconColor = ColorTranslator.FromHtml(toolWindow.Appearance.TitleBarIconColor);
            ForwardButton.BackColor = ColorTranslator.FromHtml(toolWindow.Appearance.TitleBarBackground);
            ForwardButton.IconColor = ColorTranslator.FromHtml(toolWindow.Appearance.TitleBarIconColor);


            var version = string.Format("Chromium: {0}, CEF: {1}, CefSharp: {2}",
                Cef.ChromiumVersion, Cef.CefVersion, Cef.CefSharpVersion);

            var bitness = Environment.Is64BitProcess ? "x64" : "x86";
            var environment = String.Format("Environment: {0}", bitness);
            DisplayOutput(string.Format("{0}, {1}", version, environment));
        }

        protected override void WndProc(ref Message m)
        {
            const UInt32 wmNchittest = 0x0084;
            const UInt32 htbottomright = 17;
            const int resizeHandleSize = 120;
            bool handled = false;
            if (m.Msg == wmNchittest)
            {
                Size formSize = Size;
                Point screenPoint = new Point(m.LParam.ToInt32());
                Point clientPoint = PointToClient(screenPoint);
                Rectangle hitBox = new Rectangle(formSize.Width - resizeHandleSize, formSize.Height - resizeHandleSize,
                    resizeHandleSize, resizeHandleSize);
                if (hitBox.Contains(clientPoint))
                {
                    m.Result = (IntPtr) htbottomright;
                    handled = true;
                }
            }

            if (!handled)
                base.WndProc(ref m);
        }

        void PlaceBrowser(ToolWindow coriumWindow)
        {
            _browser.Top = 24;
            _browser.Left = 2;
            _browser.Width = ClientSize.Width - 4;
            _browser.Height = ClientSize.Height - 26;
            _browser.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
        }


        private void OnIsBrowserInitializedChanged(object sender, EventArgs e)
        {
            var b = ((ChromiumWebBrowser) sender);

            this.InvokeOnUiThreadIfRequired(() => b.Focus());
        }

        private void OnBrowserConsoleMessage(object sender, ConsoleMessageEventArgs args)
        {
            DisplayOutput(string.Format("Line: {0}, Source: {1}, Message: {2}", args.Line, args.Source, args.Message));
        }


        private void OnLoadingStateChanged(object sender, LoadingStateChangedEventArgs args)
        {
            SetCanGoBack(args.CanGoBack);
            SetCanGoForward(args.CanGoForward);

            //this.InvokeOnUiThreadIfRequired(() => SetIsLoading(!args.CanReload));
        }

        private void OnBrowserTitleChanged(object sender, TitleChangedEventArgs args)
        {
            this.InvokeOnUiThreadIfRequired(() => Text = args.Title);
            this.InvokeOnUiThreadIfRequired(() => lblTitle.Text = args.Title);
        }

        private void OnBrowserAddressChanged(object sender, AddressChangedEventArgs args)
        {
        }

        private void SetCanGoBack(bool canGoBack) =>
            this.InvokeOnUiThreadIfRequired(() => BackButton.Enabled = canGoBack);

        private void SetCanGoForward(bool canGoForward) =>
            this.InvokeOnUiThreadIfRequired(() => ForwardButton.Enabled = canGoForward);

        private void BackButton_Click(object sender, EventArgs e) => _browser.Back();

        private void ForwardButton_Click(object sender, EventArgs e) => _browser.Forward();

        private void DevToolsButton_Click(object sender, EventArgs e) => _browser.ShowDevTools();

        private void LogButton_Click(object sender, EventArgs e) => LogPanel.Visible = !LogPanel.Visible;


        public void DisplayOutput(string output) =>
            this.InvokeOnUiThreadIfRequired(() => txtOutput.Text += output + Environment.NewLine);


        private void ShowDevToolsMenuItemClick(object sender, EventArgs e) => _browser.ShowDevTools();


        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;
            _lastLocation = e.Location;
        }

        private void label1_MouseUp(object sender, MouseEventArgs e) => _mouseDown = false;

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
            {
                Location = new Point(
                    (Location.X - _lastLocation.X) + e.X, (Location.Y - _lastLocation.Y) + e.Y);

                Update();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            _browser.Dispose();
           
            Close();
        }


        private void lblTitle_DoubleClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }


        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        
    }
}