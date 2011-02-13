using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinecraftServerCommander.Library
{
	public class Backup
	{
		public string Date { get; private set; }
		public string File { get; private set; }

		public Backup(string date, string file)
		{
			Date = date;
			File = file;
		}

		public void Restore()
		{
			
		}
	}
}
