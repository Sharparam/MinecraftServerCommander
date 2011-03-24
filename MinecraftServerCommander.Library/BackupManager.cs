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

		public static List<string> GetChecksums()
		{
			var checksums = new List<string>();
			var crc32 = new Crc32();

			foreach (string file in Directory.GetFiles(WorldDir))
			{
				checksums.Add(crc32.ComputeFile(file));
			}

			return checksums;
		}
	}
}
