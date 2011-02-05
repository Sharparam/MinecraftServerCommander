using System.IO;
using System.Threading;

namespace MinecraftServerCommander.Library
{
	public class AutoExecSystem
	{
		private readonly StreamWriter _mscInput;
		private readonly string[] _commands;
		private readonly int _delay;
		private bool _credit;
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
				_mscInput.WriteLine("[MCS] Auto Command System provided by F16Gaming");
			foreach (string command in _commands)
			{
				_mscInput.WriteLine(command);
			}
		}
	}
}
