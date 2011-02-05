using System;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Collections.Generic;

namespace MinecraftServerCommander.Library
{
	public class MinecraftServer
	{
		/// <summary>
		/// The server directory.
		/// </summary>
		private readonly string _serverPath;
		/// <summary>
		/// The full path to the server executable.
		/// </summary>
		private readonly string _serverFile;
		private Process _mcServer;
		private StreamWriter _mcWriter;
		private AutoExecSystem _autoExecSys;
		/// <summary>
		/// True if the server is currently running.
		/// </summary>
		public bool IsRunning { get; private set; }
		/// <summary>
		/// True if the auto command system is currently running.
		/// </summary>
		public bool IsAcsRunning { get { return _autoExecSys != null ? _autoExecSys.IsRunning : false; } }

		public MinecraftServer(string path)
		{
			if (File.Exists(path) && !string.IsNullOrEmpty(path))
			{
				_serverPath = Path.GetDirectoryName(path);
				_serverFile = path;
				IsRunning = false;
			}
			else
			{
				Environment.Exit(1);
			}
		}

		public event FileExecStart FeStart;
		protected virtual void OnFeStart(FeStartEventArgs e)
		{
			FeStart(this, e);
		}
		public event FileExecUpdate FeUpdate;
		protected virtual void OnFeUpdate(FeUpdateEventArgs e)
		{
			FeUpdate(this, e);
		}
		public event FileExecStop FeStop;
		protected virtual void OnFeStop(FeStopEventArgs e)
		{
			FeStop(this, e);
		}

		/// <summary>
		/// Start the minecraft server.
		/// </summary>
		public void Start()
		{
			_mcServer = new Process();
			_mcServer.StartInfo.FileName = _serverFile;
			_mcServer.StartInfo.WorkingDirectory = _serverPath;
			_mcServer.StartInfo.UseShellExecute = false;
			_mcServer.StartInfo.RedirectStandardInput = true;
			_mcServer.Start();
			_mcWriter = _mcServer.StandardInput;
			IsRunning = true;
		}

		/// <summary>
		/// Stop the minecraft server and the auto command system if it's currently running.
		/// </summary>
		public void Stop()
		{
			if (_autoExecSys != null)
				_autoExecSys.Stop();
			Exec("stop");
			_mcWriter.Close();
			_mcServer.WaitForExit();
			_mcServer.Close();
			IsRunning = false;
		}

		/// <summary>
		/// Execute a command on the server.
		/// </summary>
		/// <param name="command">The command to be executed.</param>
		public void Exec(string command)
		{
			_mcWriter.WriteLine(command);
		}

		//NYI: Option to execute a file with a command on each line.
		public void FileExec(string file)
		{
			string[] lines = File.ReadAllLines(file);
			var commands = new List<string>();
			foreach (var line in lines)
			{
				if (!line.StartsWith("#") && !string.IsNullOrEmpty(line))
					commands.Add(line);
			}
			int count = commands.Count;
			int number = 1;
			string current;
			OnFeStart(new FeStartEventArgs(count));
			foreach (var command in commands)
			{
				//Debug to test the label:
				//Thread.Sleep(5);
				current = command;
				OnFeUpdate(new FeUpdateEventArgs(number, current));
				Exec(command);
				number++;
			}
			OnFeStop(new FeStopEventArgs());
		}

		/// <summary>
		/// Start the auto command system.
		/// </summary>
		/// <param name="commands">Array with commands to be executed.</param>
		/// <param name="delay">Delay between each execution (in seconds).</param>
		/// <param name="credit">Whether to send a message with credits to the author on each execution.</param>
		public void StartAutoExec(string[] commands, int delay, bool credit)
		{
			if (!IsAcsRunning)
			{
				_autoExecSys = new AutoExecSystem(_mcWriter, commands, delay, credit);
				_autoExecSys.Start();
			}
		}

		/// <summary>
		/// Stop the auto command system.
		/// </summary>
		public void StopAutoExec()
		{
			if (IsAcsRunning)
				_autoExecSys.Stop();
		}
	}
}
