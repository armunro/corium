using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using Autofac;
using Corium.Destinations;
using Corium.Domain;
using Corium.Sources;
using Corium.Sources.File;

namespace Corium.Client.Windows.Forms
{
    public partial class MainForm : Form
    {
        private readonly IContainer _container;

        
        public MainForm(IContainer container)
        {
            
            string defaultInitialsPath = "default.initials.json";
            string defaultToolSetPath = "default.toolset.json";
            
            _container = container;
            InitializeComponent();
            Initials initials;
            var initialsParam = new NamedParameter("filePath", defaultInitialsPath);
          
            try
            {
                 initials = _container.Resolve<IInitialsSource>(initialsParam).GetInitials();
            }
            catch (SourceNotFoundException)
            {
                initials = new Initials() {ToolSetSources = new List<string>() {defaultToolSetPath}};
                _container.Resolve<IInitialsDestination>(initialsParam).SetInitials(initials);
            }

            InitialsFilePath.Text = defaultInitialsPath;
            Sources.DataSource = initials.ToolSetSources;

            ToolsetsList.DisplayMember = "Name";
            foreach (string source in initials.ToolSetSources)
            {
                var toolsetParam = new NamedParameter("filePath", source);
                ToolSet toolSet;
                try
                {
                    toolSet = _container.Resolve<IToolsetSource>(toolsetParam).LoadToolset();
                    
                }
                catch (SourceNotFoundException)
                {
                    toolSet = Examples.Toolset.ExampleBasicGoogleToolset.ProvideToolset;
                   _container.Resolve<IToolsetDestination>(toolsetParam).SetToolSet(toolSet);
                }

                ToolsetsList.Items.Add(toolSet);
               


            }
        }

      


        private void InitialsFilePath_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = "notepad.exe";
            process.StartInfo.Arguments = InitialsFilePath.Text;
            process.Start();
        }


        private void ToolsetsList_DoubleClick(object sender, EventArgs e)
        {
            var list = sender as ListBox;
            var toolset = list.SelectedItem as ToolSet;
            foreach (Tool tool in toolset.Tools)
            {
                foreach (ToolWindow toolWindow in tool.Windows)
                {
                    CoriumWindowForm form = new CoriumWindowForm(toolWindow);
                    form.Show();
                }
            }
            
           
        }
    }
}