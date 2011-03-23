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

namespace MinecraftServerCommander.GUI
{
	partial class LicenseBox
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.licenseText = new System.Windows.Forms.TextBox();
			this.closeButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// licenseText
			// 
			this.licenseText.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.licenseText.Location = new System.Drawing.Point(12, 12);
			this.licenseText.Multiline = true;
			this.licenseText.Name = "licenseText";
			this.licenseText.ReadOnly = true;
			this.licenseText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.licenseText.Size = new System.Drawing.Size(606, 517);
			this.licenseText.TabIndex = 0;
			// 
			// closeButton
			// 
			this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.closeButton.Location = new System.Drawing.Point(285, 535);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(60, 23);
			this.closeButton.TabIndex = 1;
			this.closeButton.Text = "Close";
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.CloseButtonClick);
			// 
			// LicenseBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(630, 562);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.licenseText);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LicenseBox";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "License";
			this.Load += new System.EventHandler(this.LicenseBoxLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox licenseText;
		private System.Windows.Forms.Button closeButton;
	}
}