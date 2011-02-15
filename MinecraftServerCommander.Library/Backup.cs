using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace MinecraftServerCommander.Library
{
	[DataContract]
	public class Backup
	{
		private static readonly DataContractJsonSerializer Serializer = new DataContractJsonSerializer(typeof(List<Backup>));
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

		public static void SerializeBackups(List<Backup> backups, string jsonFile)
		{
			using (var jsonWriter = new FileStream(jsonFile, FileMode.OpenOrCreate))
				Serializer.WriteObject(jsonWriter, backups);
		}

		public static List<Backup> GetBackups(string jsonFile)
		{
			using (var jsonReader = new FileStream(jsonFile, FileMode.Open))
			{
				return (List<Backup>) Serializer.ReadObject(jsonReader);
			}
		}

		public Backup(string date, string name, List<string> incrementals)
		{
			Date = date;
			Name = name;
			Incrementals = incrementals;
		}

		/// <summary>
		/// Restore this backup, doing this will overwrite the current world.
		/// </summary>
		public void Restore()
		{
			
		}
	}
}
