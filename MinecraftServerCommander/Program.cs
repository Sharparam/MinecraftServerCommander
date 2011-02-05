using System;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Collections.Generic;

namespace MinecraftServerCommander
{
	class Program
	{
		private static StreamWriter mcWriter;
		private static string serverPath;
		private static List<string> commands = new List<string>();
		private static int seconds;

		static void Main(string[] args)
		{
			Console.Title = "MSC - Minecraft Server Commander";
			Console.WriteLine("MSC - Minecraft Server Commander by F16Gaming\n");

			if (args.Length > 0)
			{
				serverPath = args[0];
				if (args.Length > 1)
				{
					string[] pCommands = args[1].Split(';');
					foreach (string pCommand in pCommands)
					{
						commands.Add(pCommand);
					}
					if (args.Length > 2)
					{
						seconds = int.Parse(args[2]);
					}
				}
			}
			if (string.IsNullOrEmpty(serverPath))
			{
				Console.WriteLine("Input the FULL PATH to your minecraft server EXE.");
				Console.Write(">");
				serverPath = Console.ReadLine();
				if (!File.Exists(serverPath))
				{
					Console.WriteLine("[{0}] ERROR: File not found.", DateTime.Now.ToString("HH:mm:ss"));
					Environment.Exit(1);
				}
			}
			if (commands.Count <= 0)
			{
				Console.WriteLine("Please input the commands you want the server to execute (Press enter when you are done).");
				string inputText;
				do
				{
					Console.Write(">");
					inputText = Console.ReadLine();
					if (inputText.Length > 0)
					{
						commands.Add(inputText);
					}
				} while (inputText.Length != 0); 
			}
			if (seconds == 0)
			{
				Console.WriteLine("Input how many seconds it should wait before executing commands.");
				Console.WriteLine("Hint: 60 = 1 minute, 300 = 5 minutes, 600 = 10 minutes, 900 = 15 minutes.");
				Console.Write(">");
				seconds = int.Parse(Console.ReadLine()); 
			}

			Console.Title = "MSC: " + Path.GetFileName(serverPath);

			Process mcServer = new Process();

			try
			{
				Console.WriteLine("[{0}] Creating server process...", DateTime.Now.ToString("HH:mm:ss"));
				mcServer.StartInfo.WorkingDirectory = Path.GetDirectoryName(serverPath);
				mcServer.StartInfo.FileName = serverPath;
				mcServer.StartInfo.UseShellExecute = false;
				mcServer.StartInfo.RedirectStandardInput = true;
			}
			catch (Exception ex)
			{
				Console.WriteLine("[{0}] ERROR: Failed to create process.\n{1}", DateTime.Now.ToString("HH:mm:ss"), ex.Message);
			}

			try
			{
				Console.WriteLine("[{0}] Starting minecraft server...", DateTime.Now.ToString("HH:mm:ss"));
				mcServer.Start();
			}
			catch (Exception ex)
			{
				Console.WriteLine("[{0}] ERROR: Failed to start process.\n{1}", DateTime.Now.ToString("HH:mm:ss"), ex.Message);
			}

			Console.WriteLine("[{0}] Creating streamwriter for input...", DateTime.Now.ToString("HH:mm:ss"));
			mcWriter = mcServer.StandardInput;

			Console.WriteLine("[{0}] Initializing auto-command system with {1} seconds delay...", DateTime.Now.ToString("HH:mm:ss"), seconds);

			Timer mcTimer = new Timer(ExecCommand, 5, 0, (seconds * 1000));

			Console.WriteLine("Press any key to exit this app AND the server.");

			Console.ReadLine();

			mcTimer.Dispose();
			mcWriter.WriteLine("stop");
			mcWriter.Close();
			mcServer.WaitForExit();
			mcServer.Close();
			Environment.Exit(0);
		}

		private static void ExecCommand(Object state)
		{
			Console.WriteLine("[{0}] Executing commands", DateTime.Now.ToString("HH:mm:ss"));
			foreach (string command in commands)
			{
				Console.WriteLine("[{0}] Executing command: \"{1}\"", DateTime.Now.ToString("HH:mm:ss"), command);
				mcWriter.WriteLine(command);
			}
		}
	}
}
