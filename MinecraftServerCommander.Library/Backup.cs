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
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip;

namespace MinecraftServerCommander.Library
{
	[DataContract]
	public class Backup
	{
		/// <summary>
		/// The date (dd-MM-yyyy) this backup was created.
		/// </summary>
		[DataMember]
		public DateTime Date { get; private set; }
		/// <summary>
		/// Name of the backup (will be foldername).
		/// </summary>
		[DataMember]
		public string Name { get; private set; }
		/// <summary>
		/// The name of the world (folder) this backup is using.
		/// </summary>
		[DataMember]
		public string World { get; private set; }
		/// <summary>
		/// List of incremental backups associated with this backup.
		/// </summary>
		[DataMember]
		public List<string> Incrementals { get; private set; }
		/// <summary>
		/// Contains the checksums of every file in the minecraft world.
		/// </summary>
		[DataMember]
		public Dictionary<string, string> Checksums { get; private set; }
		[DataMember]
		private string BackupDir { get { return BackupManager.BackupDir + Name + "\\"; } }
		private string ArchiveFile { get { return BackupDir + Name + ".zip"; } }

		public event BackupStart BckupStart;
		protected virtual void OnBackupStart(BackupStartEventArgs e)
		{
			BckupStart(this, e);
		}
		public event BackupStop BckupStop;
		protected virtual void OnBackupStop(BackupStopEventArgs e)
		{
			BckupStop(this, e);
		}

		public Backup(DateTime date)
		{
			Date = date;
			World = BackupManager.WorldName;
			Name = string.Format(BackupManager.BackupName, Date.ToString("yyyy-MM-dd"), World);
			Logger.Notice("Backup dir: " + BackupDir);
			if (!Directory.Exists(BackupDir))
				Directory.CreateDirectory(BackupDir);
		}

		//TODO: Finish this.
		public void BackupWorld()
		{
			var worldFiles = new List<string>();
			DoFolder(BackupManager.WorldDir, worldFiles.Add);
			OnBackupStart(new BackupStartEventArgs(worldFiles.Count));
		}

		private static void DoFolder(string path, Action<string> callback)
		{
			Parallel.ForEach(Directory.GetDirectories(path), p => DoFolder(p, callback));
			Parallel.ForEach(Directory.GetFiles(path), callback);
		}

		/// <summary>
		/// Create an incremental backup.
		/// </summary>
		public void CreateIncremental()
		{
			string incName = string.Format(BackupManager.BackupIncName, Date.ToString("yyyy-MM-dd"), (Incrementals.Count + 1), Name);
		}

		/// <summary>
		/// Restore this backup, doing this will overwrite the current world.
		/// </summary>
		public void Restore()
		{
			
		}
	}
}
