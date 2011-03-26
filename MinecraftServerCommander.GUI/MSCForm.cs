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
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Collections.Generic;
using MinecraftServerCommander.Library;

namespace MinecraftServerCommander.GUI
{
	public partial class MscForm : Form
	{
		//Yep the code is really messy
		//TODO-List:
		//In order of importance.
		// * Finish backup functionality
		// * Reduce number of possible unhandled exceptions.
		// * Make the UAC prompt show up to run as admin
		//   if the server exe requires elevation.
		// * Support for saving the server exe location.
		// * Support for saving the ACS command list.


		private MinecraftServer _mcServer;
		private Backup _currBackup;
		private delegate void VoidDelegate();
		private int _itemsVersion;
		private int _currentVersion;
		private Dictionary<string, int> _items;
		private const string ItemsUrl = "http://apps.f16gaming.com/msc/items.txt";
		private string _serverFile;
		private string _serverPath;
		private string _worldPath;
		private int _cmdCount;
		
		public MscForm()
		{
			InitializeComponent();
			mainGroup.Enabled = false;
			MscUpdate();
		}

		public MscForm(string servPath)
		{
			InitializeComponent();
			mainGroup.Enabled = false;
			MscUpdate();
			SetServer(servPath);
		}

		private void MscUpdate()
		{
			var client = new WebClient();
			try
			{
				// ReSharper disable AssignNullToNotNullAttribute
				// ReSharper disable PossibleNullReferenceException
				Logger.Notice("Opening remote items.txt for reading.");
				//Read the items.txt on the apps server.
				Stream remoteItemFile = client.OpenRead(ItemsUrl);
				var itemFile = new StreamReader(remoteItemFile);
				Logger.Notice("Getting current version.");
				//Get the version number.
				_currentVersion = int.Parse(itemFile.ReadLine().Split('=')[1]);
				Logger.Notice("Closing remote file.");
				//Close the remote items.txt
				remoteItemFile.Close();
				Logger.Notice("Opening local items.txt for reading.");
				//Now open the local items.txt
				itemFile = new StreamReader("items.txt");
				Logger.Notice("Getting local version.");
				//Get the version of the local items.txt
				_itemsVersion = int.Parse(itemFile.ReadLine().Split('=')[1]);
				Logger.Notice("Closing local file.");
				//Close the local items.txt
				itemFile.Close();
				// ReSharper restore PossibleNullReferenceException
				// ReSharper restore AssignNullToNotNullAttribute
			}
			catch (Exception ex)
			{
				//Currently, this will be shown even if the problem had nothing to do with the remote file
				// (such as being unable to write a log file)
				//TODO: Make the catch better?
				MessageBox.Show(@"Failed to get latest version from the web. Application will still work but some items might be missing or have the wrong IDs."
								+ Environment.NewLine + Environment.NewLine + @"Details:" + Environment.NewLine + ex.Message,
								@"Failed to Connect",
								MessageBoxButtons.OK,
								MessageBoxIcon.Warning
				);

				//TODO: Remove the risk of unhandled exceptions here.
				Logger.Warning("Failed to get latest version from the web: " + ex.Message);
				Logger.Notice("Setting current version to local version.");
				_currentVersion = _itemsVersion;
			}
			if (_itemsVersion < _currentVersion)
			{
				if (MessageBox.Show(@"There is an update to the item.txt available, do you want to download it?", @"Update Available",
									MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
				{
					try
					{
						Logger.Notice("Deleting old items.txt");
						File.Delete("items.txt");
						Logger.Notice("Downloading new items.txt");
						client.DownloadFile(ItemsUrl, "items.txt");
						client.Dispose();
						Logger.Notice("Updating version variable.");
						_itemsVersion = _currentVersion;
						MessageBox.Show(@"Successfully updated the items.txt!", @"Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					catch (Exception ex)
					{
						//Again, this will be shown even if the problem was not with the remote items.txt
						// (such as being unable to delete the local version)
						//TODO: Make this catch better?
						MessageBox.Show(@"Failed to download the latest items.txt from apps.f16gaming.com. Application will still work but some items might be missing or have the wrong IDs.",
										@"Download Failed",
										MessageBoxButtons.OK,
										MessageBoxIcon.Warning
						);
						Logger.Warning("Failed to download items.txt: " + ex.Message);
					}
				}
			}
			//Perhaps you can use XML to make this nicer?
			_items = new Dictionary<string, int>();
			Logger.Notice("Loading items from items.txt");
			foreach (string line in File.ReadAllLines("items.txt"))
			{
				string[] aline = line.Split('=');
				if (aline[0] == "Version")
				{
					_itemsVersion = int.Parse(aline[1]);
				}
				else
				{
					Logger.Debug("Adding item: " + aline[1] + " with id " + aline[0]);
					_items.Add(aline[1], int.Parse(aline[0]));
				}
			}
			itemBox.DataSource = new List<string>(_items.Keys);
		}

		private void SetServer(string serverPath)
		{
			_serverFile = serverPath;
			_serverPath = Path.GetDirectoryName(_serverFile);
			pathBox.Text = _serverFile;
			_mcServer = new MinecraftServer(_serverFile);
			_mcServer.FeStart += FileExecStart;
			_mcServer.FeUpdate += FileExecUpdate;
			_mcServer.FeStop += FileExecStop;
			MscTabControl.Enabled = true;
			mainGroup.Enabled = true;
			RefreshControls();
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

		#region Main Program

		private void LicenseMenuItemClick(object sender, EventArgs e)
		{
			var licenseBox = new LicenseBox();
			licenseBox.ShowDialog(this);
		}

		private void AboutMenuItemClick(object sender, EventArgs e)
		{
			var aboutMsc = new AboutMsc();
			aboutMsc.ShowDialog(this);
		}

		private void BrowseButtonClick(object sender, EventArgs e)
		{
			//This does not validate if the exe chosen is really the
			// minecraft server exe. Is it possible to do?
			//TODO: Find out if it is.
			if (MinecraftSFileDialog.ShowDialog() == DialogResult.OK)
				SetServer(MinecraftSFileDialog.FileName);
		}

		private void StartMcButtonClick(object sender, EventArgs e)
		{
			//Temporary fix to avoid unhandled exception being thrown when
			//the server exe requires elevation.
			//TODO: Make the UAC prompt show up to run as admin if the exe requires elevation.
			try
			{
				_mcServer.Start();
				RefreshControls();
			}
			catch (Exception ex)
			{
				MessageBox.Show(@"Failed to start minecraft server, reason: " + ex.Message, @"Error starting server", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				Logger.Error("Failed to start minecraft server, reason: " + ex.Message + "(" + ex.GetType() + ")");
			}
			
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

		#endregion

		#region Backup Section

		private void WorldBrowseButtonClick(object sender, EventArgs e)
		{
			worldFolderDialog.SelectedPath = _serverPath;
			if (worldFolderDialog.ShowDialog() == DialogResult.OK)
			{
				if (!File.Exists(worldFolderDialog.SelectedPath + "\\level.dat"))
				{
					MessageBox.Show(@"The folder selected is not a valid world folder.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				_worldPath = worldFolderDialog.SelectedPath + "\\";
				WorldFolderBox.Text = _worldPath;
				backupPanel.Enabled = true;
				BackupManager.Init(_serverPath + "\\", _worldPath);
			}
		}

		#endregion
	}
}
