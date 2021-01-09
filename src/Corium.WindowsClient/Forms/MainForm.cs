using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Autofac;
using Corium.Sources;

namespace Corium.WindowsClient.Forms
{
    public partial class MainForm : Form
    {
        private readonly IContainer _container;

        public MainForm(IContainer container)
        {
            _container = container;
            InitializeComponent();
            Initials initials = _container
                .Resolve<IInitialsSource>(new NamedParameter("filePath", "Corium.WindowsClient.tinitials.json")).GetInitials();

            InitialsFilePath.Text = ComputeInitialsFilePath();
            Sources.DataSource = initials.ToolSetSources;


            foreach (string source in initials.ToolSetSources)
            {
                ToolSet ts = _container.Resolve<IToolsetSource>(new NamedParameter("filePath", source)).LoadToolset();
                foreach (Tool tool in ts.Tools)
                {
                    foreach (ToolWindow window in tool.Windows)
                    {
                        CoriumWindowForm form = new CoriumWindowForm(window);
                        form.Show();
                    }
                }
            }
        }

        private static string ComputeInitialsFilePath()
        {
            string thisAssemblyPath = System.Reflection.Assembly.GetEntryAssembly()?.Location;
            string initialsFilePath = Path.GetFileNameWithoutExtension(thisAssemblyPath) + ".tinitials.json";
            return initialsFilePath;
        }


        private void InitialsFilePath_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = "notepad.exe";
            process.StartInfo.Arguments = InitialsFilePath.Text;
            process.Start();
        }


        private void StartButton_Click(object sender, EventArgs e)
        {
        }
    }
}