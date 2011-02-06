using System;
using System.IO;

namespace MinecraftServerCommander.Library
{
	public static class Logger
	{
		private static void CheckFile()
		{
			if (!File.Exists(string.Format("msc_{0}.log", DateTime.Now.ToString("d-M-yyyy"))))
				File.Create(string.Format("msc_{0}.log", DateTime.Now.ToString("d-M-yyyy")));
		}

		private static void FileWrite(string message)
		{
			var logFile = new StreamWriter(string.Format("msc_{0}.log", DateTime.Now.ToString("d-M-yyyy")), true);
			logFile.WriteLine(string.Format("[{0}] {1}", DateTime.Now.ToString("HH:mm:ss"), message));
			logFile.Close();
		}

		public static void Debug(string message, bool debug)
		{
			if (debug)
			{
				CheckFile();
				FileWrite(string.Format("[Debug] {0}", message));
			}
		}

		public static void Notice(string message)
		{
			CheckFile();
			FileWrite(string.Format("[Notice] {0}", message));
		}

		public static void Warning(string message)
		{
			CheckFile();
			FileWrite(string.Format("[Warning] {0}", message));
		}

		public static void Error(string message)
		{
			CheckFile();
			FileWrite(string.Format("[Error] {0}", message));
		}
	}
}
