using System;
using System.Windows.Forms;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Corium.Client.Windows.Adapter.Client;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Corium.Client.Windows
{
    public static class Program
    {
       public static MainForm Form { get; set; }
        [STAThread]
        static void Main(string[] args)
        {
           
           
            
            System.Windows.Forms.Application.SetHighDpiMode(HighDpiMode.SystemAware);
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            Form = new MainForm();
            System.Windows.Forms.Application.Run(Form);
        }
    }
}