using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace OUR_PLACE
{
	/// <summary>
	/// Summary description for frmDataEntry.
	/// </summary>
	public class frmDataEntry : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox grpProgram;
		private System.Windows.Forms.CheckBox chkOurPlaceIShelter;
		private System.Windows.Forms.CheckBox chkOurPlaceIResourceRoom;
		private System.Windows.Forms.CheckBox chkOurPlaceIIShelter;
		private System.Windows.Forms.CheckBox chkOurPlaceIIResourceRoom;
		private System.Windows.Forms.TabControl tabDataEntry;
		private System.Windows.Forms.TabPage tabShelterPage;
		private System.Windows.Forms.TabPage tabResourceRoomPage;
		private System.Windows.Forms.TabControl tabResourceRoom;
		private System.Windows.Forms.TabPage tabResourceRoomPage1;
		private System.Windows.Forms.TabPage tabResourceRoomPage2;
		private System.Windows.Forms.TabPage tabShelterPage1;
		private System.Windows.Forms.TabPage tabShelterPage2;
		private System.Windows.Forms.TabPage tabShelterPage3;
		private System.Windows.Forms.TabPage tabShelterPage4;
		private OUR_PLACE.ctlPage1 dtlShelterPage1;
		private OUR_PLACE.ctlPage2 dtlShelterPage2;
		private OUR_PLACE.ctlPage3 dtlShelterPage3;
		private OUR_PLACE.ctlPage4 dtlShelterPage4;
		private OUR_PLACE.ctlResourcePage1 dtlResourcePage1;
		private OUR_PLACE.ctlResourcePage2 dtlResourcePage2;
		private System.Windows.Forms.TabControl tabShelter;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmDataEntry()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.grpProgram = new System.Windows.Forms.GroupBox();
			this.chkOurPlaceIIShelter = new System.Windows.Forms.CheckBox();
			this.chkOurPlaceIIResourceRoom = new System.Windows.Forms.CheckBox();
			this.chkOurPlaceIShelter = new System.Windows.Forms.CheckBox();
			this.chkOurPlaceIResourceRoom = new System.Windows.Forms.CheckBox();
			this.tabDataEntry = new System.Windows.Forms.TabControl();
			this.tabShelterPage = new System.Windows.Forms.TabPage();
			this.tabShelter = new System.Windows.Forms.TabControl();
			this.tabShelterPage1 = new System.Windows.Forms.TabPage();
			this.dtlShelterPage1 = new OUR_PLACE.ctlPage1();
			this.tabShelterPage2 = new System.Windows.Forms.TabPage();
			this.dtlShelterPage2 = new OUR_PLACE.ctlPage2();
			this.tabShelterPage3 = new System.Windows.Forms.TabPage();
			this.dtlShelterPage3 = new OUR_PLACE.ctlPage3();
			this.tabShelterPage4 = new System.Windows.Forms.TabPage();
			this.dtlShelterPage4 = new OUR_PLACE.ctlPage4();
			this.tabResourceRoomPage = new System.Windows.Forms.TabPage();
			this.tabResourceRoom = new System.Windows.Forms.TabControl();
			this.tabResourceRoomPage1 = new System.Windows.Forms.TabPage();
			this.dtlResourcePage1 = new OUR_PLACE.ctlResourcePage1();
			this.tabResourceRoomPage2 = new System.Windows.Forms.TabPage();
			this.dtlResourcePage2 = new OUR_PLACE.ctlResourcePage2();
			this.grpProgram.SuspendLayout();
			this.tabDataEntry.SuspendLayout();
			this.tabShelterPage.SuspendLayout();
			this.tabShelter.SuspendLayout();
			this.tabShelterPage1.SuspendLayout();
			this.tabShelterPage2.SuspendLayout();
			this.tabShelterPage3.SuspendLayout();
			this.tabShelterPage4.SuspendLayout();
			this.tabResourceRoomPage.SuspendLayout();
			this.tabResourceRoom.SuspendLayout();
			this.tabResourceRoomPage1.SuspendLayout();
			this.tabResourceRoomPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpProgram
			// 
			this.grpProgram.Controls.Add(this.chkOurPlaceIIShelter);
			this.grpProgram.Controls.Add(this.chkOurPlaceIIResourceRoom);
			this.grpProgram.Controls.Add(this.chkOurPlaceIShelter);
			this.grpProgram.Controls.Add(this.chkOurPlaceIResourceRoom);
			this.grpProgram.Location = new System.Drawing.Point(8, 8);
			this.grpProgram.Name = "grpProgram";
			this.grpProgram.Size = new System.Drawing.Size(624, 48);
			this.grpProgram.TabIndex = 0;
			this.grpProgram.TabStop = false;
			this.grpProgram.Text = "Program";
			// 
			// chkOurPlaceIIShelter
			// 
			this.chkOurPlaceIIShelter.Location = new System.Drawing.Point(304, 16);
			this.chkOurPlaceIIShelter.Name = "chkOurPlaceIIShelter";
			this.chkOurPlaceIIShelter.Size = new System.Drawing.Size(128, 24);
			this.chkOurPlaceIIShelter.TabIndex = 2;
			this.chkOurPlaceIIShelter.Text = "Our Place II Shelter";
			// 
			// chkOurPlaceIIResourceRoom
			// 
			this.chkOurPlaceIIResourceRoom.Location = new System.Drawing.Point(440, 16);
			this.chkOurPlaceIIResourceRoom.Name = "chkOurPlaceIIResourceRoom";
			this.chkOurPlaceIIResourceRoom.Size = new System.Drawing.Size(168, 24);
			this.chkOurPlaceIIResourceRoom.TabIndex = 3;
			this.chkOurPlaceIIResourceRoom.Text = "Our Place II Resource Room";
			// 
			// chkOurPlaceIShelter
			// 
			this.chkOurPlaceIShelter.Location = new System.Drawing.Point(8, 16);
			this.chkOurPlaceIShelter.Name = "chkOurPlaceIShelter";
			this.chkOurPlaceIShelter.Size = new System.Drawing.Size(128, 24);
			this.chkOurPlaceIShelter.TabIndex = 0;
			this.chkOurPlaceIShelter.Text = "Our Place I Shelter";
			// 
			// chkOurPlaceIResourceRoom
			// 
			this.chkOurPlaceIResourceRoom.Location = new System.Drawing.Point(144, 16);
			this.chkOurPlaceIResourceRoom.Name = "chkOurPlaceIResourceRoom";
			this.chkOurPlaceIResourceRoom.Size = new System.Drawing.Size(168, 24);
			this.chkOurPlaceIResourceRoom.TabIndex = 1;
			this.chkOurPlaceIResourceRoom.Text = "Our Place I Resource Room";
			// 
			// tabDataEntry
			// 
			this.tabDataEntry.Controls.Add(this.tabShelterPage);
			this.tabDataEntry.Controls.Add(this.tabResourceRoomPage);
			this.tabDataEntry.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tabDataEntry.Location = new System.Drawing.Point(0, 56);
			this.tabDataEntry.Name = "tabDataEntry";
			this.tabDataEntry.SelectedIndex = 0;
			this.tabDataEntry.Size = new System.Drawing.Size(775, 1100);
			this.tabDataEntry.TabIndex = 1;
			// 
			// tabShelterPage
			// 
			this.tabShelterPage.Controls.Add(this.tabShelter);
			this.tabShelterPage.Location = new System.Drawing.Point(4, 22);
			this.tabShelterPage.Name = "tabShelterPage";
			this.tabShelterPage.Size = new System.Drawing.Size(767, 1074);
			this.tabShelterPage.TabIndex = 0;
			this.tabShelterPage.Text = "Shelter";
			// 
			// tabShelter
			// 
			this.tabShelter.Controls.Add(this.tabShelterPage1);
			this.tabShelter.Controls.Add(this.tabShelterPage2);
			this.tabShelter.Controls.Add(this.tabShelterPage3);
			this.tabShelter.Controls.Add(this.tabShelterPage4);
			this.tabShelter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabShelter.Location = new System.Drawing.Point(0, 0);
			this.tabShelter.Name = "tabShelter";
			this.tabShelter.SelectedIndex = 0;
			this.tabShelter.Size = new System.Drawing.Size(767, 1074);
			this.tabShelter.TabIndex = 0;
			// 
			// tabShelterPage1
			// 
			this.tabShelterPage1.Controls.Add(this.dtlShelterPage1);
			this.tabShelterPage1.Location = new System.Drawing.Point(4, 22);
			this.tabShelterPage1.Name = "tabShelterPage1";
			this.tabShelterPage1.Size = new System.Drawing.Size(759, 1048);
			this.tabShelterPage1.TabIndex = 0;
			this.tabShelterPage1.Text = "Page 1";
			// 
			// dtlShelterPage1
			// 
			this.dtlShelterPage1.AutoScroll = true;
			this.dtlShelterPage1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dtlShelterPage1.Location = new System.Drawing.Point(0, 0);
			this.dtlShelterPage1.Name = "dtlShelterPage1";
			this.dtlShelterPage1.Size = new System.Drawing.Size(759, 1048);
			this.dtlShelterPage1.TabIndex = 0;
			// 
			// tabShelterPage2
			// 
			this.tabShelterPage2.Controls.Add(this.dtlShelterPage2);
			this.tabShelterPage2.Location = new System.Drawing.Point(4, 22);
			this.tabShelterPage2.Name = "tabShelterPage2";
			this.tabShelterPage2.Size = new System.Drawing.Size(776, 1048);
			this.tabShelterPage2.TabIndex = 1;
			this.tabShelterPage2.Text = "Page 2";
			// 
			// dtlShelterPage2
			// 
			this.dtlShelterPage2.AutoScroll = true;
			this.dtlShelterPage2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dtlShelterPage2.Location = new System.Drawing.Point(0, 0);
			this.dtlShelterPage2.Name = "dtlShelterPage2";
			this.dtlShelterPage2.Size = new System.Drawing.Size(776, 1048);
			this.dtlShelterPage2.TabIndex = 0;
			// 
			// tabShelterPage3
			// 
			this.tabShelterPage3.Controls.Add(this.dtlShelterPage3);
			this.tabShelterPage3.Location = new System.Drawing.Point(4, 22);
			this.tabShelterPage3.Name = "tabShelterPage3";
			this.tabShelterPage3.Size = new System.Drawing.Size(776, 1048);
			this.tabShelterPage3.TabIndex = 2;
			this.tabShelterPage3.Text = "Page 3";
			// 
			// dtlShelterPage3
			// 
			this.dtlShelterPage3.AutoScroll = true;
			this.dtlShelterPage3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dtlShelterPage3.Location = new System.Drawing.Point(0, 0);
			this.dtlShelterPage3.Name = "dtlShelterPage3";
			this.dtlShelterPage3.Size = new System.Drawing.Size(776, 1048);
			this.dtlShelterPage3.TabIndex = 0;
			// 
			// tabShelterPage4
			// 
			this.tabShelterPage4.Controls.Add(this.dtlShelterPage4);
			this.tabShelterPage4.Location = new System.Drawing.Point(4, 22);
			this.tabShelterPage4.Name = "tabShelterPage4";
			this.tabShelterPage4.Size = new System.Drawing.Size(776, 1048);
			this.tabShelterPage4.TabIndex = 3;
			this.tabShelterPage4.Text = "Page 4";
			// 
			// dtlShelterPage4
			// 
			this.dtlShelterPage4.AutoScroll = true;
			this.dtlShelterPage4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dtlShelterPage4.Location = new System.Drawing.Point(0, 0);
			this.dtlShelterPage4.Name = "dtlShelterPage4";
			this.dtlShelterPage4.Size = new System.Drawing.Size(776, 1048);
			this.dtlShelterPage4.TabIndex = 0;
			// 
			// tabResourceRoomPage
			// 
			this.tabResourceRoomPage.Controls.Add(this.tabResourceRoom);
			this.tabResourceRoomPage.Location = new System.Drawing.Point(4, 22);
			this.tabResourceRoomPage.Name = "tabResourceRoomPage";
			this.tabResourceRoomPage.Size = new System.Drawing.Size(784, 1074);
			this.tabResourceRoomPage.TabIndex = 1;
			this.tabResourceRoomPage.Text = "Resource Room";
			// 
			// tabResourceRoom
			// 
			this.tabResourceRoom.Controls.Add(this.tabResourceRoomPage1);
			this.tabResourceRoom.Controls.Add(this.tabResourceRoomPage2);
			this.tabResourceRoom.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabResourceRoom.Location = new System.Drawing.Point(0, 0);
			this.tabResourceRoom.Name = "tabResourceRoom";
			this.tabResourceRoom.SelectedIndex = 0;
			this.tabResourceRoom.Size = new System.Drawing.Size(784, 1074);
			this.tabResourceRoom.TabIndex = 0;
			// 
			// tabResourceRoomPage1
			// 
			this.tabResourceRoomPage1.Controls.Add(this.dtlResourcePage1);
			this.tabResourceRoomPage1.Location = new System.Drawing.Point(4, 22);
			this.tabResourceRoomPage1.Name = "tabResourceRoomPage1";
			this.tabResourceRoomPage1.Size = new System.Drawing.Size(655, 1048);
			this.tabResourceRoomPage1.TabIndex = 0;
			this.tabResourceRoomPage1.Text = "Page 1";
			// 
			// dtlResourcePage1
			// 
			this.dtlResourcePage1.AutoScroll = true;
			this.dtlResourcePage1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dtlResourcePage1.Location = new System.Drawing.Point(0, 0);
			this.dtlResourcePage1.Name = "dtlResourcePage1";
			this.dtlResourcePage1.Size = new System.Drawing.Size(655, 1048);
			this.dtlResourcePage1.TabIndex = 0;
			// 
			// tabResourceRoomPage2
			// 
			this.tabResourceRoomPage2.Controls.Add(this.dtlResourcePage2);
			this.tabResourceRoomPage2.Location = new System.Drawing.Point(4, 22);
			this.tabResourceRoomPage2.Name = "tabResourceRoomPage2";
			this.tabResourceRoomPage2.Size = new System.Drawing.Size(655, 1048);
			this.tabResourceRoomPage2.TabIndex = 1;
			this.tabResourceRoomPage2.Text = "Page 2";
			// 
			// dtlResourcePage2
			// 
			this.dtlResourcePage2.AutoScroll = true;
			this.dtlResourcePage2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dtlResourcePage2.Location = new System.Drawing.Point(0, 0);
			this.dtlResourcePage2.Name = "dtlResourcePage2";
			this.dtlResourcePage2.Size = new System.Drawing.Size(655, 1048);
			this.dtlResourcePage2.TabIndex = 0;
			// 
			// frmDataEntry
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(775, 1028);
			this.Controls.Add(this.tabDataEntry);
			this.Controls.Add(this.grpProgram);
			this.Name = "frmDataEntry";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text = "Data Entry";
			this.grpProgram.ResumeLayout(false);
			this.tabDataEntry.ResumeLayout(false);
			this.tabShelterPage.ResumeLayout(false);
			this.tabShelter.ResumeLayout(false);
			this.tabShelterPage1.ResumeLayout(false);
			this.tabShelterPage2.ResumeLayout(false);
			this.tabShelterPage3.ResumeLayout(false);
			this.tabShelterPage4.ResumeLayout(false);
			this.tabResourceRoomPage.ResumeLayout(false);
			this.tabResourceRoom.ResumeLayout(false);
			this.tabResourceRoomPage1.ResumeLayout(false);
			this.tabResourceRoomPage2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

	}
}
