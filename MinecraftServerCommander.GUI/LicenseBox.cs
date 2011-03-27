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
using System.Windows.Forms;

namespace MinecraftServerCommander.GUI
{
	public partial class LicenseBox : Form
	{
		public LicenseBox()
		{
			InitializeComponent();
		}

		private void LicenseBoxLoad(object sender, EventArgs e)
		{
			try
			{
				licenseText.Text = File.ReadAllText("COPYING");
				licenseText.DeselectAll();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Failed to load license text: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void CloseButtonClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
