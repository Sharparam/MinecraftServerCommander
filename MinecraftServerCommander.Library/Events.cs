using System;

namespace MinecraftServerCommander.Library
{
	public class FeStartEventArgs : EventArgs
	{
		public int CmdCount { get; private set; }

		public FeStartEventArgs(int cmdCount)
		{
			CmdCount = cmdCount;
		}
	}

	public class FeUpdateEventArgs : EventArgs
	{
		public int CurrentCmdNumber { get; private set; }
		public string CurrentCmd { get; private set; }

		public FeUpdateEventArgs(int currentCmdNumber, string currentCmd)
		{
			CurrentCmdNumber = currentCmdNumber;
			CurrentCmd = currentCmd;
		}
	}

	public class FeStopEventArgs : EventArgs
	{
	}

	public class BackupStartEventArgs : EventArgs
	{
		public int FilesCount { get; private set; }

		public BackupStartEventArgs(int filesCount)
		{
			FilesCount = filesCount;
		}
	}

	public class BackupStopEventArgs : EventArgs
	{
	}

	public delegate void FileExecStart(object sender, FeStartEventArgs e);
	public delegate void FileExecUpdate(object sender, FeUpdateEventArgs e);
	public delegate void FileExecStop(object sender, FeStopEventArgs e);
	public delegate void BackupStart(object sender, BackupStartEventArgs e);
	public delegate void BackupStop(object sender, BackupStopEventArgs e);
}
