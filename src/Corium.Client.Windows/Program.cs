using System;
using System.Windows.Forms;
using Corium.Client.Windows.Adapter.Client;

namespace Corium.Client.Windows
{
    public static class Program
    {
       public static MainForm Form { get; private set; }
        [STAThread]
        static void Main()
        {
           
            System.Windows.Forms.Application.SetHighDpiMode(HighDpiMode.SystemAware);
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            Form = new MainForm();
            System.Windows.Forms.Application.Run(Form);
        }
    }
}