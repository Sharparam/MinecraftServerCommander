using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization;

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
		/// List of incremental backups associated with this backup.
		/// </summary>
		[DataMember]
		public List<string> Incrementals { get; private set; }

		public Backup(string date, string name)
		{
			Date = date;
			Name = name;
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
