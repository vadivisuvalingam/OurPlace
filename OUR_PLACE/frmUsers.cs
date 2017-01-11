using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient; 
using System.Configuration;


namespace OUR_PLACE
{
	/// <summary>
	/// Summary description for frmUsers.
	/// </summary>
	public class frmUsers : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lblFirstName;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.Label lblLastName;
		private System.Windows.Forms.TextBox txtUserID;
		private System.Windows.Forms.Label lblUserID;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.Label lblRole;
		private System.Windows.Forms.ComboBox cboRole;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmUsers()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			LoadCombos();			
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
			this.lblFirstName = new System.Windows.Forms.Label();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.lblLastName = new System.Windows.Forms.Label();
			this.txtUserID = new System.Windows.Forms.TextBox();
			this.lblUserID = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.lblPassword = new System.Windows.Forms.Label();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.lblDescription = new System.Windows.Forms.Label();
			this.lblRole = new System.Windows.Forms.Label();
			this.cboRole = new System.Windows.Forms.ComboBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblFirstName
			// 
			this.lblFirstName.Location = new System.Drawing.Point(16, 88);
			this.lblFirstName.Name = "lblFirstName";
			this.lblFirstName.TabIndex = 6;
			this.lblFirstName.Text = "First Name";
			// 
			// txtFirstName
			// 
			this.txtFirstName.Location = new System.Drawing.Point(128, 88);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(208, 20);
			this.txtFirstName.TabIndex = 7;
			this.txtFirstName.Text = "";
			// 
			// txtLastName
			// 
			this.txtLastName.Location = new System.Drawing.Point(128, 112);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(208, 20);
			this.txtLastName.TabIndex = 9;
			this.txtLastName.Text = "";
			// 
			// lblLastName
			// 
			this.lblLastName.Location = new System.Drawing.Point(16, 112);
			this.lblLastName.Name = "lblLastName";
			this.lblLastName.TabIndex = 8;
			this.lblLastName.Text = "Last Name";
			// 
			// txtUserID
			// 
			this.txtUserID.Location = new System.Drawing.Point(128, 16);
			this.txtUserID.Name = "txtUserID";
			this.txtUserID.Size = new System.Drawing.Size(208, 20);
			this.txtUserID.TabIndex = 1;
			this.txtUserID.Text = "";
			// 
			// lblUserID
			// 
			this.lblUserID.Location = new System.Drawing.Point(16, 16);
			this.lblUserID.Name = "lblUserID";
			this.lblUserID.TabIndex = 0;
			this.lblUserID.Text = "User ID";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(128, 40);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(208, 20);
			this.txtPassword.TabIndex = 3;
			this.txtPassword.Text = "";
			// 
			// lblPassword
			// 
			this.lblPassword.Location = new System.Drawing.Point(16, 40);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.TabIndex = 2;
			this.lblPassword.Text = "Password";
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(128, 136);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(208, 40);
			this.txtDescription.TabIndex = 11;
			this.txtDescription.Text = "";
			// 
			// lblDescription
			// 
			this.lblDescription.Location = new System.Drawing.Point(16, 136);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.TabIndex = 10;
			this.lblDescription.Text = "Description";
			// 
			// lblRole
			// 
			this.lblRole.Location = new System.Drawing.Point(16, 64);
			this.lblRole.Name = "lblRole";
			this.lblRole.TabIndex = 4;
			this.lblRole.Text = "Role";
			// 
			// cboRole
			// 
			this.cboRole.Location = new System.Drawing.Point(128, 64);
			this.cboRole.Name = "cboRole";
			this.cboRole.Size = new System.Drawing.Size(208, 21);
			this.cboRole.TabIndex = 5;
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(176, 184);
			this.btnOK.Name = "btnOK";
			this.btnOK.TabIndex = 12;
			this.btnOK.Text = "OK";
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(264, 184);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 13;
			this.btnCancel.Text = "Cancel";
			// 
			// frmUsers
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(360, 222);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.cboRole);
			this.Controls.Add(this.lblRole);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUserID);
			this.Controls.Add(this.txtLastName);
			this.Controls.Add(this.txtFirstName);
			this.Controls.Add(this.lblDescription);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.lblUserID);
			this.Controls.Add(this.lblLastName);
			this.Controls.Add(this.lblFirstName);
			this.Name = "frmUsers";
			this.ShowInTaskbar = false;
			this.Text = "Add Users";
			this.ResumeLayout(false);

		}
		#endregion

		#region Private Methods

		private void LoadCombos()
		{
			StaticMethods.LoadCombos(cboRole, "SYSTEM_ROLE");
		}

		#endregion
	}
}
