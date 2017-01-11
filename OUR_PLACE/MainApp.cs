using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace OUR_PLACE
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class MainApp : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem mnuFile;
		private System.Windows.Forms.MenuItem mnuAction;
		private System.Windows.Forms.MenuItem mnuFileSearch;
		private System.Windows.Forms.MenuItem mnuActionNew;
		private System.Windows.Forms.MenuItem mnuActionEdit;
		private System.Windows.Forms.MenuItem mnuActionSubmit;
		private System.Windows.Forms.MenuItem mnuFileExit;
		private System.Windows.Forms.MenuItem mnuAdmin;
		private System.Windows.Forms.MenuItem mnuAdminAddUsers;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public MainApp()
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
				if (components != null) 
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
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.mnuFile = new System.Windows.Forms.MenuItem();
			this.mnuFileSearch = new System.Windows.Forms.MenuItem();
			this.mnuFileExit = new System.Windows.Forms.MenuItem();
			this.mnuAction = new System.Windows.Forms.MenuItem();
			this.mnuActionNew = new System.Windows.Forms.MenuItem();
			this.mnuActionEdit = new System.Windows.Forms.MenuItem();
			this.mnuActionSubmit = new System.Windows.Forms.MenuItem();
			this.mnuAdmin = new System.Windows.Forms.MenuItem();
			this.mnuAdminAddUsers = new System.Windows.Forms.MenuItem();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.mnuFile,
																					  this.mnuAction,
																					  this.mnuAdmin});
			// 
			// mnuFile
			// 
			this.mnuFile.Index = 0;
			this.mnuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					this.mnuFileSearch,
																					this.mnuFileExit});
			this.mnuFile.Text = "File";
			// 
			// mnuFileSearch
			// 
			this.mnuFileSearch.Index = 0;
			this.mnuFileSearch.Text = "Search";
			this.mnuFileSearch.Click += new System.EventHandler(this.mnuFileSearch_Click);
			// 
			// mnuFileExit
			// 
			this.mnuFileExit.Index = 1;
			this.mnuFileExit.Text = "Exit";
			this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
			// 
			// mnuAction
			// 
			this.mnuAction.Index = 1;
			this.mnuAction.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.mnuActionNew,
																					  this.mnuActionEdit,
																					  this.mnuActionSubmit});
			this.mnuAction.Text = "Action";
			// 
			// mnuActionNew
			// 
			this.mnuActionNew.Index = 0;
			this.mnuActionNew.Text = "New";
			this.mnuActionNew.Click += new System.EventHandler(this.mnuActionNew_Click);
			// 
			// mnuActionEdit
			// 
			this.mnuActionEdit.Index = 1;
			this.mnuActionEdit.Text = "Edit";
			this.mnuActionEdit.Click += new System.EventHandler(this.mnuActionEdit_Click);
			// 
			// mnuActionSubmit
			// 
			this.mnuActionSubmit.Index = 2;
			this.mnuActionSubmit.Text = "Submit";
			this.mnuActionSubmit.Click += new System.EventHandler(this.mnuActionSubmit_Click);
			// 
			// mnuAdmin
			// 
			this.mnuAdmin.Index = 2;
			this.mnuAdmin.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.mnuAdminAddUsers});
			this.mnuAdmin.Text = "Admin";
			// 
			// mnuAdminAddUsers
			// 
			this.mnuAdminAddUsers.Index = 0;
			this.mnuAdminAddUsers.Text = "Add Users";
			this.mnuAdminAddUsers.Click += new System.EventHandler(this.mnuAdminAddUsers_Click);
			// 
			// MainApp
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(792, 545);
			this.IsMdiContainer = true;
			this.Menu = this.mainMenu1;
			this.Name = "MainApp";
			this.Text = "Our Place";

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			frmSplash lo_frmSplash = new frmSplash();
			frmLogin lo_frmLogin = new frmLogin();
			StaticVariables.mo_DBLayer = new DBLayer();
			lo_frmSplash.Show();
			System.Threading.Thread.Sleep(1000);
			lo_frmLogin.ShowDialog();
			lo_frmSplash.Close();
			if (lo_frmLogin.Login)
			{
				Application.Run(new MainApp());
			}
		}

		private void mnuFileSearch_Click(object sender, System.EventArgs e)
		{
			if (StaticVariables.mo_frmSearch != null)
			{
				StaticVariables.mo_frmSearch.Show();
			}
			else
			{
				StaticVariables.mo_frmSearch = new frmSearch();
				StaticVariables.mo_frmSearch.MdiParent = this;
				StaticVariables.mo_frmSearch.Show();
			}		
		}

		private void mnuFileExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void mnuActionNew_Click(object sender, System.EventArgs e)
		{
			if (StaticVariables.mo_frmDataEntry != null)
			{
				StaticVariables.mo_frmDataEntry.Show();
			}
			else
			{
				StaticVariables.mo_frmDataEntry = new frmDataEntry();
				StaticVariables.mo_frmDataEntry.MdiParent = this;
				StaticVariables.mo_frmDataEntry.Show();
			}
		}

		private void mnuActionEdit_Click(object sender, System.EventArgs e)
		{
			if (StaticVariables.mo_frmDataEntry != null)
			{
				StaticVariables.mo_frmDataEntry.Show();
			}
			else
			{
				StaticVariables.mo_frmDataEntry = new frmDataEntry();
				StaticVariables.mo_frmDataEntry.MdiParent = this;
				StaticVariables.mo_frmDataEntry.Show();
			}		
		}

		private void mnuActionSubmit_Click(object sender, System.EventArgs e)
		{
		
		}

		private void mnuAdminAddUsers_Click(object sender, System.EventArgs e)
		{
			frmUsers lo_frmUsers = new frmUsers();
			lo_frmUsers.ShowDialog(this);			
		}
	}
}
