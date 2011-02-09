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
			AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(MscUnhandledException);
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

		static void MscUnhandledException(object sender, UnhandledExceptionEventArgs e)
		{
			try
			{
				var ex = (Exception) e.ExceptionObject;
				if (File.Exists("msc_fatal.log"))
					File.Delete("msc_fatal.log");
				using (File.Create("msc_fatal.log")) { }
				File.WriteAllText("msc_fatal.log", @"Unhandled exception occurred in " + ex.Source + "\n\nException: " + ex.GetType() + "\n" + ex.Message + "\n" + ex.StackTrace);
				string msg = string.Empty;
				msg += "FATAL: Unhandled exception occurred in: {0}\nProgram is unable to continue.\n\n";
				msg += "Please contact us with the following information:\n";
				msg += "What were you doing when this error occurred?\n\nPlease see msc_fatal.log for more detailed info.\n\nException: {1}\n{2}\n\n";
				msg += "Contact email: support@f16gaming.com, please include the log files.";
				MessageBox.Show(string.Format(msg, ex.Source, ex.GetType(), ex.Message), @"Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
			finally
			{
				Environment.Exit(2);
			}
		}
	}
}
