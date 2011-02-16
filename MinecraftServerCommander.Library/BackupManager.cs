using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace MinecraftServerCommander.Library
{
	class BackupManager
	{
		public const string BackupDirectory = "backups";
		public const string BackupFile = "backups.json";
		public const string BackupName = "{0}_{1}_backup";
		public const string BackupIncName = "{0}_inc{1}_{2}_backup";
		private static readonly DataContractJsonSerializer Serializer = new DataContractJsonSerializer(typeof(List<Backup>));
		private static string _serverPath;

		public BackupManager(string serverPath)
		{
			_serverPath = serverPath;
		}

		public static void SerializeBackups(List<Backup> backups, string jsonFile)
		{
			using (var jsonWriter = new FileStream(jsonFile, FileMode.OpenOrCreate))
				Serializer.WriteObject(jsonWriter, backups);
		}

		public static List<Backup> GetBackups(string jsonFile)
		{
			using (var jsonReader = new FileStream(jsonFile, FileMode.Open))
			{
				return (List<Backup>)Serializer.ReadObject(jsonReader);
			}
		}
	}
}
