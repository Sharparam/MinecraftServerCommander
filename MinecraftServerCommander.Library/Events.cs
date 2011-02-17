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

	public class BackupZipStartEventArgs : EventArgs
	{
		public int FilesCount { get; private set; }

		public BackupZipStartEventArgs(int filesCount)
		{
			FilesCount = filesCount;
		}
	}

	public class BackupZipProgressEventArgs : EventArgs
	{
		public string CurrentFile { get; private set; }
		public int FileNumber { get; private set; }

		public BackupZipProgressEventArgs(string currentFile, int fileNumber)
		{
			CurrentFile = currentFile;
			FileNumber = fileNumber;
		}
	}

	public class BackupZipStopEventArgs : EventArgs
	{
	}

	public delegate void FileExecStart(object sender, FeStartEventArgs e);
	public delegate void FileExecUpdate(object sender, FeUpdateEventArgs e);
	public delegate void FileExecStop(object sender, FeStopEventArgs e);
	public delegate void BackupZipStart(object sender, BackupZipStartEventArgs e);
	public delegate void BackupZipProgress(object sender, BackupZipProgressEventArgs e);
	public delegate void BackupZipStop(object sender, BackupZipStopEventArgs e);
}
