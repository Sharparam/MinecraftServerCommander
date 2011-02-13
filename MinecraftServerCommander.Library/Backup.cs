using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinecraftServerCommander.Library
{
	public class Backup
	{
		/// <summary>
		/// The date (dd-MM-yyyy) this backup was created.
		/// </summary>
		public string Date { get; private set; }
		/// <summary>
		/// Name of the backup (will be foldername).
		/// </summary>
		public string Name { get; private set; }

		public Backup(string date, string name)
		{
			Date = date;
			Name = name;
		}

		/// <summary>
		/// Restore this backup, doing this will overwrite the current world.
		/// </summary>
		public void Restore()
		{
			
		}
	}
}
