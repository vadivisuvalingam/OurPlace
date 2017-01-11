using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace OUR_PLACE
{
	/// <summary>
	/// Summary description for frmLogin.
	/// </summary>
	public class frmLogin : System.Windows.Forms.Form
	{
		bool mb_Login = false;
		private System.Windows.Forms.Label lblUserID;
		private System.Windows.Forms.TextBox txtUserID;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Button btnCancel;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmLogin()
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
			this.lblUserID = new System.Windows.Forms.Label();
			this.txtUserID = new System.Windows.Forms.TextBox();
			this.lblPassword = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblUserID
			// 
			this.lblUserID.Location = new System.Drawing.Point(16, 16);
			this.lblUserID.Name = "lblUserID";
			this.lblUserID.TabIndex = 0;
			this.lblUserID.Text = "User ID";
			// 
			// txtUserID
			// 
			this.txtUserID.Location = new System.Drawing.Point(88, 16);
			this.txtUserID.Name = "txtUserID";
			this.txtUserID.Size = new System.Drawing.Size(184, 20);
			this.txtUserID.TabIndex = 1;
			this.txtUserID.Text = "";
			// 
			// lblPassword
			// 
			this.lblPassword.Location = new System.Drawing.Point(16, 40);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.TabIndex = 2;
			this.lblPassword.Text = "Password";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(88, 40);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(184, 20);
			this.txtPassword.TabIndex = 3;
			this.txtPassword.Text = "";
			// 
			// btnLogin
			// 
			this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.btnLogin.Location = new System.Drawing.Point(104, 72);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.TabIndex = 4;
			this.btnLogin.Text = "Login";
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(192, 72);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// frmLogin
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 102);
			this.ControlBox = false;
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.txtUserID);
			this.Controls.Add(this.lblUserID);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.ResumeLayout(false);

		}
		#endregion

		#region Properties

		public bool Login
		{
			get
			{
				return mb_Login;
			}
		}

		#endregion

		#region Event Handlers

		private void btnLogin_Click(object sender, System.EventArgs e)
		{
			mb_Login = true;
			this.Close();
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		#endregion

	}
}
