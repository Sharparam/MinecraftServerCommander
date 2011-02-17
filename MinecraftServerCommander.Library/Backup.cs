using System;
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
		[DataMember]
		private string BackupDir { get { return BackupManager.BackupDir + Name; } }
		private string ArchiveFile { get { return BackupDir + "\\" + Name + ".zip"; } }

		public event BackupZipStart ZippingStart;
		protected virtual void OnZippingStart(BackupZipStartEventArgs e)
		{
			ZippingStart(this, e);
		}
		public event BackupZipProgress ZippingProgress;
		protected virtual void OnZippingProgress(BackupZipProgressEventArgs e)
		{
			ZippingProgress(this, e);
		}
		public event BackupZipStop ZippingStop;
		protected virtual void OnZippingStop(BackupZipStopEventArgs e)
		{
			ZippingStop(this, e);
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
			OnZippingStart(new BackupZipStartEventArgs(worldFiles.Length));
		}

		/// <summary>
		/// Create an incremental backup.
		/// </summary>
		public void CreateIncremental()
		{
			
		}

		/// <summary>
		/// Restore this backup, doing this will overwrite the current world.
		/// </summary>
		public void Restore()
		{
			
		}
	}
}
