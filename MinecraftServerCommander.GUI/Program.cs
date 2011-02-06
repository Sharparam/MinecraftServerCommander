using System;
using System.IO;
using System.Windows.Forms;

namespace MinecraftServerCommander.GUI
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			if (!File.Exists("msclib.dll"))
			{
				MessageBox.Show(@"Error: msclib.dll not found, exiting.", @"Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				Environment.Exit(1);
			}
			if (!File.Exists("items.txt"))
			{
				MessageBox.Show(@"Error: items.txt not found, exiting.", @"Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				Environment.Exit(1);
			}
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MSCForm());
		}
	}
}
