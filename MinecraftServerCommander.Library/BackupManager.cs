using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace MinecraftServerCommander.Library
{
	class BackupManager
	{
		public const string BackupName = "{0}_{1}_backup";
		public const string BackupIncName = "{0}_inc{1}_{2}_backup";
		public static string BackupDir { get { return _serverPath + "backups"; } }
		public static string BackupFile { get { return _serverPath + BackupDir + "backups.json"; } }
		public static string WorldName { get; private set; }
		public static string WorldDir { get { return _serverPath + WorldName; } }
		private static string _serverPath;
		private static readonly DataContractJsonSerializer Serializer = new DataContractJsonSerializer(typeof(List<Backup>));

		public BackupManager(string serverPath, string world)
		{
			_serverPath = serverPath;
			WorldName = world;

			if (!Directory.Exists(_serverPath + BackupDir))
				Directory.CreateDirectory(_serverPath + BackupDir);

			if (!File.Exists(_serverPath + BackupDir + BackupFile))
				File.Create(_serverPath + BackupDir + BackupFile);
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
