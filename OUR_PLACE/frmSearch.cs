using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace OUR_PLACE
{
	/// <summary>
	/// Summary description for frmSearch.
	/// </summary>
	public class frmSearch : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lblLastName;
		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.Label lblFirstName;
		private System.Windows.Forms.DateTimePicker dtmBirthDate;
		private System.Windows.Forms.Label lblBirthDate;
		private System.Windows.Forms.ListView lstResults;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Label lblResults;
		private System.Windows.Forms.ColumnHeader FileNumber;
		private System.Windows.Forms.ColumnHeader LastName;
		private System.Windows.Forms.ColumnHeader FirstName;
		private System.Windows.Forms.ColumnHeader BirthDate;
		private System.Windows.Forms.ColumnHeader CurrentAge;
		private System.Windows.Forms.ColumnHeader Gender;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmSearch()
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
			this.lblLastName = new System.Windows.Forms.Label();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.lblFirstName = new System.Windows.Forms.Label();
			this.dtmBirthDate = new System.Windows.Forms.DateTimePicker();
			this.lblBirthDate = new System.Windows.Forms.Label();
			this.lstResults = new System.Windows.Forms.ListView();
			this.btnSearch = new System.Windows.Forms.Button();
			this.lblResults = new System.Windows.Forms.Label();
			this.FileNumber = new System.Windows.Forms.ColumnHeader();
			this.LastName = new System.Windows.Forms.ColumnHeader();
			this.FirstName = new System.Windows.Forms.ColumnHeader();
			this.BirthDate = new System.Windows.Forms.ColumnHeader();
			this.CurrentAge = new System.Windows.Forms.ColumnHeader();
			this.Gender = new System.Windows.Forms.ColumnHeader();
			this.SuspendLayout();
			// 
			// lblLastName
			// 
			this.lblLastName.Location = new System.Drawing.Point(16, 16);
			this.lblLastName.Name = "lblLastName";
			this.lblLastName.TabIndex = 0;
			this.lblLastName.Text = "Last Name";
			// 
			// txtLastName
			// 
			this.txtLastName.Location = new System.Drawing.Point(96, 16);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(168, 20);
			this.txtLastName.TabIndex = 1;
			this.txtLastName.Text = "";
			// 
			// txtFirstName
			// 
			this.txtFirstName.Location = new System.Drawing.Point(96, 40);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(168, 20);
			this.txtFirstName.TabIndex = 3;
			this.txtFirstName.Text = "";
			// 
			// lblFirstName
			// 
			this.lblFirstName.Location = new System.Drawing.Point(16, 40);
			this.lblFirstName.Name = "lblFirstName";
			this.lblFirstName.TabIndex = 2;
			this.lblFirstName.Text = "First Name";
			// 
			// dtmBirthDate
			// 
			this.dtmBirthDate.Location = new System.Drawing.Point(96, 64);
			this.dtmBirthDate.Name = "dtmBirthDate";
			this.dtmBirthDate.TabIndex = 4;
			// 
			// lblBirthDate
			// 
			this.lblBirthDate.Location = new System.Drawing.Point(16, 64);
			this.lblBirthDate.Name = "lblBirthDate";
			this.lblBirthDate.TabIndex = 5;
			this.lblBirthDate.Text = "Date of Birth";
			// 
			// lstResults
			// 
			this.lstResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						 this.FileNumber,
																						 this.LastName,
																						 this.FirstName,
																						 this.BirthDate,
																						 this.CurrentAge,
																						 this.Gender});
			this.lstResults.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lstResults.Location = new System.Drawing.Point(0, 110);
			this.lstResults.Name = "lstResults";
			this.lstResults.Size = new System.Drawing.Size(632, 152);
			this.lstResults.TabIndex = 6;
			this.lstResults.View = System.Windows.Forms.View.Details;
			// 
			// btnSearch
			// 
			this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSearch.Location = new System.Drawing.Point(520, 8);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.TabIndex = 7;
			this.btnSearch.Text = "Search";
			// 
			// lblResults
			// 
			this.lblResults.Location = new System.Drawing.Point(8, 88);
			this.lblResults.Name = "lblResults";
			this.lblResults.Size = new System.Drawing.Size(304, 23);
			this.lblResults.TabIndex = 8;
			this.lblResults.Text = "Results";
			// 
			// FileNumber
			// 
			this.FileNumber.Text = "File Number";
			this.FileNumber.Width = 104;
			// 
			// LastName
			// 
			this.LastName.Text = "Last Name";
			this.LastName.Width = 111;
			// 
			// FirstName
			// 
			this.FirstName.Text = "First Name";
			this.FirstName.Width = 110;
			// 
			// BirthDate
			// 
			this.BirthDate.Text = "Date of Birth";
			this.BirthDate.Width = 85;
			// 
			// CurrentAge
			// 
			this.CurrentAge.Text = "Current Age";
			this.CurrentAge.Width = 87;
			// 
			// Gender
			// 
			this.Gender.Text = "Gender";
			// 
			// frmSearch
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(632, 262);
			this.Controls.Add(this.lstResults);
			this.Controls.Add(this.lblResults);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.dtmBirthDate);
			this.Controls.Add(this.lblBirthDate);
			this.Controls.Add(this.txtFirstName);
			this.Controls.Add(this.lblFirstName);
			this.Controls.Add(this.txtLastName);
			this.Controls.Add(this.lblLastName);
			this.Name = "frmSearch";
			this.Text = "Search";
			this.ResumeLayout(false);

		}
		#endregion
	}
}
