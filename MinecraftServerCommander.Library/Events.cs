/*
 * Copyright (C) 2011 by Adam Hellberg
 * 
 * This file is part of Minecraft Server Commander.
 *
 * Minecraft Server Commander is free software: you can redistribute it
 * and/or modify it under the terms of the GNU General Public License as
 * published by the Free Software Foundation, either version 3 of the
 * License, or (at your option) any later version.
 * 
 * Minecraft Server Commander is distributed in the hope that it
 * will be useful, but WITHOUT ANY WARRANTY; without even the implied
 * warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
 * See the GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License along
 * with Minecraft Server Commander.  If not, see <http://www.gnu.org/licenses/>.
 * 
 */

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
