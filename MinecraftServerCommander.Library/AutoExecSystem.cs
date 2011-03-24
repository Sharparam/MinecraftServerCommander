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

using System.IO;
using System.Threading;

namespace MinecraftServerCommander.Library
{
	public class AutoExecSystem
	{
		private readonly StreamWriter _mscInput;
		private readonly string[] _commands;
		private readonly int _delay;
		private readonly bool _credit;
		public bool IsRunning { get; private set; }
		private Timer _mscTimer;

		public AutoExecSystem(StreamWriter mscInput, string[] commands, int delay, bool credit)
		{
			_mscInput = mscInput;
			_commands = commands;
			_delay = delay;
			_credit = credit;
		}

		public void Start()
		{
			if (IsRunning)
				return;

			_mscTimer = new Timer(Exec, 5, 0, (_delay * 1000));
			IsRunning = true;
		}

		public void Stop()
		{
			if (!IsRunning)
				return;

			_mscTimer.Dispose();
			IsRunning = false;
		}

		private void Exec(object state)
		{
			if (_credit)
				_mscInput.WriteLine("say [MSC] Auto Command System provided by F16Gaming");
			foreach (string command in _commands)
			{
				_mscInput.WriteLine(command);
			}
		}
	}
}
