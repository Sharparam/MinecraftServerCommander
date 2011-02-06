using System;
using System.IO;
using System.Windows.Forms;
using MinecraftServerCommander.Library;

namespace MinecraftServerCommander.GUI
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			bool debug;
			if (!File.Exists("msclib.dll"))
			{
				MessageBox.Show(@"Error: msclib.dll not found, exiting.", @"Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				Environment.Exit(1);
			}
			if (!File.Exists("items.txt"))
			{
				MessageBox.Show(@"Error: items.txt not found, exiting.", @"Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				Logger.Error("items.txt not found, exiting.");
				Environment.Exit(1);
			}
			if (args.Length > 0)
				debug = args[0] == "-debug";
			else
				debug = false;
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MscForm(debug));
		}
	}
}
