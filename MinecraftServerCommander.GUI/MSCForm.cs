using System;
using System.IO;
using System.Net;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;
using MinecraftServerCommander.Library;

namespace MinecraftServerCommander.GUI
{
	public partial class MscForm : Form
	{
		//Yep the code is really messy

		private MinecraftServer _mcServer;
		private readonly Dictionary<string, int> _items;
		private const string ItemsUrl = "http://www.f16gaming.com/files/items.txt";
		private readonly int _itemsVersion;
		private readonly int _currentVersion;
		private int _cmdCount;

		public MscForm()
		{
			InitializeComponent();
			mainGroup.Enabled = false;
			var client = new WebClient();
			try
			{
				// ReSharper disable AssignNullToNotNullAttribute
				// ReSharper disable PossibleNullReferenceException
				Stream remoteItemFile = client.OpenRead(ItemsUrl);
				var itemFile = new StreamReader(remoteItemFile);
				_currentVersion = int.Parse(itemFile.ReadLine().Split('=')[1]);
				remoteItemFile.Close();
				itemFile = new StreamReader("items.txt");
				_itemsVersion = int.Parse(itemFile.ReadLine().Split('=')[1]);
				itemFile.Close();
				// ReSharper restore PossibleNullReferenceException
				// ReSharper restore AssignNullToNotNullAttribute
			}
			catch (Exception ex)
			{
				MessageBox.Show(@"Failed to get latest version from the web. Application will still work but some items might be missing or have the wrong IDs."
								+ Environment.NewLine + Environment.NewLine + @"Details:" + Environment.NewLine + ex.Message,
								@"Failed to Connect",
								MessageBoxButtons.OK,
								MessageBoxIcon.Warning
				);
				_currentVersion = _itemsVersion;
			}
			if (_itemsVersion < _currentVersion)
			{
				if (MessageBox.Show(@"There is an update to the item.txt available, do you want to download it?", @"Update Available",
									MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
				{
					try
					{
						File.Delete("items.txt");
						client.DownloadFile(ItemsUrl, "items.txt");
						client.Dispose();
						_itemsVersion = _currentVersion;
						MessageBox.Show(@"Successfully updated the items.txt!", @"Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					catch (Exception)
					{
						MessageBox.Show(@"Failed to download the latest items.txt from apps.f16gaming.com. Application will still work but some items might be missing or have the wrong IDs.",
										@"Download Failed",
										MessageBoxButtons.OK,
										MessageBoxIcon.Warning
						);
					}
				}
			}
			_items = new Dictionary<string, int>();
			foreach (string line in File.ReadAllLines("items.txt"))
			{
				string[] aline = line.Split('=');
				if (aline[0] == "Version")
					_itemsVersion = int.Parse(aline[1]);
				else
					_items.Add(aline[1], int.Parse(aline[0]));
			}
			itemBox.DataSource = new List<string>(_items.Keys);
		}

		/// <summary>
		/// Refresh all the controls in the form.
		/// </summary>
		private void RefreshControls() //TODO: Could this be done better?
		{
			if (_mcServer.IsRunning)
			{
				startMCButton.Enabled = false;
				stopMCButton.Enabled = true;
				if (!string.IsNullOrEmpty(namesBox.Text))
					giveButton.Enabled = true;
			}
			else
			{
				startMCButton.Enabled = true;
				stopMCButton.Enabled = false;
				giveButton.Enabled = false;
			}

			if (_mcServer.IsAcsRunning)
			{
				startACSButton.Enabled = false;
				stopACSButton.Enabled = true;
			}
			else
			{
				if (_mcServer.IsRunning)
					startACSButton.Enabled = true;
				stopACSButton.Enabled = false;
			}

			execFileButton.Enabled = !string.IsNullOrEmpty(execFileBox.Text);
		}

		private void BrowseButtonClick(object sender, EventArgs e)
		{
			if (MinecraftSFileDialog.ShowDialog() == DialogResult.OK)
			{
				pathBox.Text = MinecraftSFileDialog.FileName;
				_mcServer = new MinecraftServer(pathBox.Text);
				_mcServer.FeStart += FileExecStart;
				_mcServer.FeUpdate += FileExecUpdate;
				_mcServer.FeStop += FileExecStop;
				mainGroup.Enabled = true;
				RefreshControls();
			}
		}

		private void StartMcButtonClick(object sender, EventArgs e)
		{
			_mcServer.Start();
			RefreshControls();
		}

		private void StopMcButtonClick(object sender, EventArgs e)
		{
			_mcServer.Stop();
			RefreshControls();
		}

		private void ExitButtonClick(object sender, EventArgs e)
		{
			if (_mcServer.IsRunning)
				_mcServer.Stop();
			Environment.Exit(0);
		}

		private void AddCmdButtonClick(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(commandBox.Text))
				commandList.Items.Add(commandBox.Text);
		}

		private void RemoveCmdButtonClick(object sender, EventArgs e)
		{
			commandList.Items.Remove(commandList.SelectedItem);
		}

		private void ClearListButtonClick(object sender, EventArgs e)
		{
			commandList.Items.Clear();
		}

		private void NamesBoxTextChanged(object sender, EventArgs e)
		{
			RefreshControls();
		}

		private void GiveButtonClick(object sender, EventArgs e)
		{
			string[] players = namesBox.Text.Split(';');
			foreach (string player in players)
			{
				_mcServer.Exec("give " + player + " " + _items[itemBox.SelectedItem.ToString()] + " " + quantityBox.Value);
			}
		}

		private void StartAcsButtonClick(object sender, EventArgs e)
		{
			if (commandList.Items.Count > 0 && _mcServer.IsRunning)
			{
				var tCmds = new List<string>();
				foreach (string item in commandList.Items)
				{
					tCmds.Add(item);
				}
				_mcServer.StartAutoExec(tCmds.ToArray(), (int)secondsBox.Value, creditCheckBox.Checked);
			}
			RefreshControls();
		}

		private void StopAcsButtonClick(object sender, EventArgs e)
		{
			_mcServer.StopAutoExec();
			RefreshControls();
		}

		private void MscFormHelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
		{
			Process.Start("notepad", "README.txt");
		}

		//
		// File execution
		//
		private void ExecFileBrowseClick(object sender, EventArgs e)
		{
			if (execFileDialog.ShowDialog() == DialogResult.OK)
			{
				execFileBox.Text = execFileDialog.FileName;
				RefreshControls();
			}
		}

		private void ExecFileButtonClick(object sender, EventArgs e)
		{
			if (!execFileButton.Enabled)
				return;
			if (_mcServer.IsRunning)
				execFileWorker.RunWorkerAsync();
		}

		private delegate void VoidDelegate();
		private void FileExecStart(object sender, FeStartEventArgs e)
		{
			if (InvokeRequired)
			{
				execFileButton.Invoke((VoidDelegate) (() => execFileButton.Enabled = false));
				execFileLog.Invoke((VoidDelegate) (() => execFileLog.Clear()));
				_cmdCount = e.CmdCount;
				string logText = Environment.NewLine + "Executing " + _cmdCount + " commands." + Environment.NewLine;
				execFileLog.Invoke((VoidDelegate) (() => execFileLog.AppendText(logText)));
				execFileLabel.Invoke((VoidDelegate) (() => execFileLabel.Text = @"Executing 0/" + _cmdCount));
				execFileProgress.Invoke((VoidDelegate) (() => execFileProgress.Maximum = e.CmdCount));
				execFileProgress.Invoke((VoidDelegate) (() => execFileProgress.Value = 0));
			}
		}

		private void FileExecUpdate(object sender, FeUpdateEventArgs e)
		{
			if (InvokeRequired)
			{
				execFileLog.Invoke((VoidDelegate) (() => execFileLog.AppendText("Executing \"" + e.CurrentCmd + "\"" + Environment.NewLine)));
				execFileLabel.Invoke((VoidDelegate) (() => execFileLabel.Text = @"Executing " + e.CurrentCmdNumber + @"/" + _cmdCount));
				execFileProgress.Invoke((VoidDelegate) (() => execFileProgress.PerformStep()));
			}
		}

		private void FileExecStop(object sender, FeStopEventArgs e)
		{
			if (InvokeRequired)
			{
				execFileLog.Invoke((VoidDelegate) (() => execFileLog.AppendText("Done executing!")));
				execFileLabel.Invoke((VoidDelegate) (() => execFileLabel.Text = @"Execution complete!"));
				execFileProgress.Invoke((VoidDelegate) (() => execFileProgress.Value = _cmdCount));
				execFileButton.Invoke((VoidDelegate) (() => execFileButton.Enabled = true));
			}
		}

		private void ExecFileWorkerDoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			if (_mcServer.IsRunning)
				_mcServer.FileExec(execFileBox.Text);
		}
	}
}
