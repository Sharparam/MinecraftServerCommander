using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace MinecraftServerCommander.Library
{
	public static class BackupManager
	{
		public const string BackupName = "{0}_{1}_backup";
		public const string BackupIncName = "{0}_inc{1}_{2}_backup";
		public static string BackupDir { get { return _serverPath + "backups\\"; } }
		public static string BackupFile { get { return BackupDir + "backups.json"; } }
		public static string WorldName { get; private set; }
		public static string WorldDir { get { return _serverPath + WorldName; } }
		private static string _serverPath;
		private static readonly DataContractJsonSerializer Serializer = new DataContractJsonSerializer(typeof(List<Backup>));

		public static void Init(string serverPath, string world)
		{
			_serverPath = serverPath;
			WorldName = world;

			if (!Directory.Exists(BackupDir))
				Directory.CreateDirectory(BackupDir);

			if (!File.Exists(BackupFile))
				File.Create(BackupFile);
		}

		public static void SerializeBackups(List<Backup> backups)
		{
			using (var jsonWriter = new FileStream(BackupFile, FileMode.OpenOrCreate))
				Serializer.WriteObject(jsonWriter, backups);
		}

		public static List<Backup> GetBackups()
		{
			using (var jsonReader = new FileStream(BackupFile, FileMode.Open))
			{
				return (List<Backup>)Serializer.ReadObject(jsonReader);
			}
		}
	}
}
