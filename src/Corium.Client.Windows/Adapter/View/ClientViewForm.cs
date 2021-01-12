using System;
using System.Drawing;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using Corium.Domain.View;

namespace Corium.Client.Windows.Adapter.View
{
    public sealed partial class ClientViewForm : Form, IClientViewer
    {
        private ChromiumWebBrowser _browser;
        private bool _mouseDown;
        private Point _lastLocation;

        public ClientViewForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);
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


        private void OnIsBrowserInitializedChanged(object sender, EventArgs e)
        {
            var b = ((ChromiumWebBrowser) sender);

            this.InvokeOnUiThreadIfRequired(() => b.Focus());
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
            _browser?.Dispose();
            Close();
        }


        private void lblTitle_DoubleClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }


        private void MaximizeButton_Click(object sender, EventArgs e) => WindowState = FormWindowState.Maximized;

        private void MinimizeButton_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;


        public void OpenViewer(ClientViewContext context)
        {
            _browser = new ChromiumWebBrowser(context.StartUrl);
            _browser.Dock = DockStyle.None;

            _browser.IsBrowserInitializedChanged += OnIsBrowserInitializedChanged;
            _browser.LoadingStateChanged += OnLoadingStateChanged;
            _browser.TitleChanged += OnBrowserTitleChanged;
            _browser.AddressChanged += OnBrowserAddressChanged;

            _browser.Top = 24;
            _browser.Left = 2;
            _browser.Width = ClientSize.Width - 4;
            _browser.Height = ClientSize.Height - 26;
            _browser.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;

            Controls.Add(_browser);
            BackColor = ColorTranslator.FromHtml(context.ClientAppearance.WindowBorderColor);
            lblTitle.BackColor = ColorTranslator.FromHtml(context.ClientAppearance.TitleBarBackground);
            MinimizeButton.BackColor = ColorTranslator.FromHtml(context.ClientAppearance.TitleBarBackground);
            MinimizeButton.IconColor = ColorTranslator.FromHtml(context.ClientAppearance.TitleBarIconColor);
            MaximizeButton.BackColor = ColorTranslator.FromHtml(context.ClientAppearance.TitleBarBackground);
            MaximizeButton.IconColor = ColorTranslator.FromHtml(context.ClientAppearance.TitleBarIconColor);
            ExitButton.BackColor = ColorTranslator.FromHtml(context.ClientAppearance.TitleBarBackground);
            ExitButton.IconColor = ColorTranslator.FromHtml(context.ClientAppearance.TitleBarIconColor);
            BackButton.BackColor = ColorTranslator.FromHtml(context.ClientAppearance.TitleBarBackground);
            BackButton.IconColor = ColorTranslator.FromHtml(context.ClientAppearance.TitleBarIconColor);
            ForwardButton.BackColor = ColorTranslator.FromHtml(context.ClientAppearance.TitleBarBackground);
            ForwardButton.IconColor = ColorTranslator.FromHtml(context.ClientAppearance.TitleBarIconColor);
            this.Show();
        }
    }
}