using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace OUR_PLACE
{
	/// <summary>
	/// Summary description for ctlYesNo.
	/// </summary>
	public class ctlYesNo : System.Windows.Forms.UserControl
	{

		private bool mb_Checked;

		private System.Windows.Forms.CheckBox chkNo;
		private System.Windows.Forms.CheckBox chkYes;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ctlYesNo()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call

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

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.chkNo = new System.Windows.Forms.CheckBox();
			this.chkYes = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// chkNo
			// 
			this.chkNo.Location = new System.Drawing.Point(47, 0);
			this.chkNo.Name = "chkNo";
			this.chkNo.TabIndex = 74;
			this.chkNo.Text = "No";
			this.chkNo.CheckedChanged += new System.EventHandler(this.chkNo_CheckedChanged);
			// 
			// chkYes
			// 
			this.chkYes.Location = new System.Drawing.Point(-1, 0);
			this.chkYes.Name = "chkYes";
			this.chkYes.TabIndex = 73;
			this.chkYes.Text = "Yes";
			this.chkYes.CheckedChanged += new System.EventHandler(this.chkYes_CheckedChanged);
			// 
			// ctlYesNo
			// 
			this.Controls.Add(this.chkNo);
			this.Controls.Add(this.chkYes);
			this.Name = "ctlYesNo";
			this.Size = new System.Drawing.Size(150, 24);
			this.ResumeLayout(false);

		}
		#endregion

		#region Properties

		public bool Checked
		{
			get
			{
				return mb_Checked;
			}
			set
			{
				mb_Checked = value;
				if (mb_Checked)
				{
					chkYes.Checked = true;
					chkNo.Checked = false;
				}
				else
				{
					chkYes.Checked = false;
					chkNo.Checked = true;
				}
			}
		}

		#endregion

		#region Event Handlers

		private void chkYes_CheckedChanged(object sender, System.EventArgs e)
		{
			chkNo.Checked = !chkYes.Checked;
			mb_Checked = true;			
		}

		private void chkNo_CheckedChanged(object sender, System.EventArgs e)
		{
			chkYes.Checked = !chkNo.Checked;
			mb_Checked = false;
		}

		#endregion
	}
}
