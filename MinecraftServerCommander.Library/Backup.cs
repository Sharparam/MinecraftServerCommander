using System;
using System.Collections.Concurrent;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization;
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
		public string Date { get; private set; }
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
		public ConcurrentDictionary<string, string> Checksums { get; private set; }
		[DataMember]
		private string BackupDir { get { return BackupManager.BackupDir + Name; } }
		private string ArchiveFile { get { return BackupDir + "\\" + Name + ".zip"; } }

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

		public Backup(string date)
		{
			Date = date;
			World = BackupManager.WorldName;
			Name = string.Format(BackupManager.BackupName, Date, World);
			if (!Directory.Exists(BackupDir))
				Directory.CreateDirectory(BackupDir);

			//Finish implementing this
			//BackupWorld();
		}

		private void BackupWorld()
		{
			string[] worldFiles = Directory.GetFiles(BackupManager.WorldDir);
			OnBackupStart(new BackupStartEventArgs(worldFiles.Length));
		}

		/// <summary>
		/// Create an incremental backup.
		/// </summary>
		public void CreateIncremental()
		{
			string incName = string.Format(BackupManager.BackupIncName, DateTime.Now.ToString("d-M-yyyy"), (Incrementals.Count + 1), Name);
		}

		/// <summary>
		/// Restore this backup, doing this will overwrite the current world.
		/// </summary>
		public void Restore()
		{
			
		}
	}
}
